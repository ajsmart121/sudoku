using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace sudoku
{
    public partial class frmgame : Form
    {

        public int[,] grid = new int[9, 9];
        public Button[,] btns = new Button[9, 9];
        public Button[] numbers = new Button[9];
        menu mnu;
        bool closing = false;
        public int passedtime = 0;
        public int diff;

        //create a win condition ?? also let the game work somehow ??
        //when the game is won then ask the user for their name and save their name and time (in seconds) to the scores file.

        public frmgame(int Difficulty)
        {
            diff = Difficulty;
            InitializeComponent();
            Pen drawer = new Pen(Color.Navy, 3);
            FillGrid(GenerateSolution(), Difficulty);                   // Create the grid with a desired number of locations filled in
            GridSwapper();
            for (int x = 0; x < btns.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < btns.GetLength(1); y++)     // Loop for y
                {
                    btns[x, y] = new Button();
                    btns[x, y].SetBounds((55 * x)+20, (55 * y)+40, 45, 45);
                    btns[x, y].BackColor = Color.PowderBlue;
                    if(grid[x,y] != 0)          // If the grid location isn't empty
                    {
                        btns[x, y].Text = Convert.ToString(grid[x, y]);     // Make the buttons text its value
                        btns[x, y].Enabled = false;                         // Disable the button
                    }
                    else
                    {
                        btns[x, y].Text = "";                               // Otherwise make the text empty
                    }
                    
                    btns[x, y].Click += new EventHandler(this.btnsEvent_Click);
                    Controls.Add(btns[x, y]);
                }
            }

            for (int i = 0; i< numbers.Length; i++)
            {
                numbers[i] = new Button();
                numbers[i].SetBounds((55 * i) + 20, 530 + 40, 45, 45);
                numbers[i].BackColor = Color.CornflowerBlue;
                numbers[i].Text = Convert.ToString(i + 1);
                numbers[i].Click += new EventHandler(this.numbersEvent_Click);
                Controls.Add(numbers[i]);
            }
            
        }

        // Method to be called when the game is completed
        // Asks the player for their name and then asks if they would like to play again
        public void OnWin()
        {
            timer1.Stop();
            string name;
            do
            {
                name = Interaction.InputBox("Please enter your name", "You have successfully completed the board!", "", -1, -1);
            } while (name == "");

            string filePath = Path.GetFullPath("scores.txt");
            FileInfo f = new FileInfo(filePath);
            StreamWriter w;
            if (File.Exists(filePath))
            {
                w = File.AppendText(filePath);
            }
            else
            {
                w = f.CreateText();
            }
            w.WriteLine(passedtime.ToString());
            w.WriteLine(name);
            w.Close();
            scores temp = new scores();
            temp.Close();

            DialogResult dialogResult = MessageBox.Show("Would you like to play again?", "Game Completed!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                mnu.NewGame(diff);
            }
            else if (dialogResult == DialogResult.No)
            {
                mnu.Show(); 
            }
            closing = true;
            this.Close();
            closing = false;

        }

        private void numbersEvent_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            
        }

        //whenevr a number is pressed then check around (square, up, side) and see if its valid

        public void checkValid()
        {
            //check if full then check sides and square
            //take in position of the chosen square and its value

            //temp variables until real ones exist
            int x = 0;
            int y = 0;
            int value = 0;
            //

            bool valid = false;
            
            //take in x coord and value 
            valid = checkUp(x,value);

            valid = false;

            //take in y coord and value
            valid = checkSide(y,value);

            valid = false;

            //calculates which square the selected thingy is in

            //take in x and y coords and value
            valid = checkSquare(x,y,value);

        }

        //take in the value selected and the x coord and check the entire row vertically, if it exists already then make red and hidden value = 11
        public bool checkUp(int x, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[x,i] == value)
                {
                    return false;
                }
            }
            return true;
        }

        //
        public bool checkSquare(int n, int m, int value)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if(grid[(n/3)*3  + x, (m/3)* 3 + y] == value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        void btnsEvent_Click(object sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).Text);    // SAME handler as before
        }


        // Find out how many times a value appears in the grid
        // Parameters:
        //      value - The value that is being searched for
        int CheckValue(int value)
        {
            int count = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == value)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        // Method to create a complete Sudoku solution
        int[,] GenerateSolution()
        {
            Random rand = new Random();
            int[,] tmpGrid = new int[9, 9];     // Create a temporary grid
            int[] tmpRow = new int[9];            // Create a temporary row
            
            for (int i = 0; i < 9; i++)         // For each item in a row
            {
                int val = rand.Next(1, 10);     // Select a random number
                while (!checkSide(0, val))      // While that number already exists in the row
                {
                    val = rand.Next(1, 10);     // Choose a different number
                }
                grid[i, 0] = val;               // Let the first row in the real grid have this value
                tmpRow[i] = val;                  // Give this value to the temporary row
            }

            int desRow = rand.Next(0, 3);       // Choose a random row to start on
            for (int i = 0; i < 9; i++)
            {
                tmpGrid[i, desRow * 3] = grid[i, 0];    // Give the random row in tmpGrid the correct value
                grid[i, 0] = 0;                         // Make the real grid empty again
            }

            for(int j = 1; j < 3; j++)
            {
                ShiftRow(tmpRow, 3);              // Shift the temporary row along by 3
                for (int i = 0; i < 9; i++)
                {
                    tmpGrid[i, desRow * 3 + j] = tmpRow[i];   // Set the next row to the shifted row
                }
            }

            int nextRow;
            do
            {
                nextRow = rand.Next(0, 3);      // Choose the next row to start on
            } while (nextRow == desRow);        // Change the next selected row if it has already been used

            for(int k = 0; k < 2; k++)
            {
                ShiftRow(tmpRow, 1);              // Shift the temporary row along by 1
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        tmpGrid[i, nextRow * 3 + j] = tmpRow[i];  // Set the next row to the shifted row
                    }
                    if (j < 2)
                    {
                        ShiftRow(tmpRow, 3);
                    }
                }
                nextRow = 3 - nextRow - desRow;     // Change the nextRow to the only row section that hasn't been used
            }
            return tmpGrid;
        }

        // Method to randomly swap columns and rows
        void GridSwapper()
        {
            int temp = 0;
            for(int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    temp = grid[3+j, i];
                    grid[3+j, i] = grid[0+j, i];
                    grid[0+j, i] = temp;
                }
            }

            Random rand = new Random();
            for(int i = 0; i <3; i++)
            {
                for(int k = 0; k < 2; k++)
                {
                    int col = rand.Next(0, 3) + (3 * i);
                    int col2;
                    do
                    {
                        col2 = rand.Next(0, 3) + (3 * i);
                    } while (col2 == col);

                    for (int j = 0; j < 9; j++)
                    {
                        temp = grid[col, j];
                        grid[col, j] = grid[col2, j];
                        grid[col2, j] = temp;
                    }
                }

            }

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    int row = rand.Next(0, 3) + (3 * i);
                    int row2;
                    do
                    {
                        row2 = rand.Next(0, 3) + (3 * i);
                    } while (row2 == row);

                    for (int j = 0; j < 9; j++)
                    {
                        temp = grid[j, row];
                        grid[j, row] = grid[j, row2];
                        grid[j, row2] = temp;
                    }
                }

            }

        }

        // Method to fill in the grid
        // Parameters:
        //      sol - a 2D array with a complete solution
        //      amount - the amount of numbers that should be displayed on the grid
        void FillGrid(int[,] sol, int amount)
        {
            Random rand = new Random();
            for (int i = 0; i <(amount+4)/2; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(0, 9);        // Choose a random x co-ordinate
                    y = rand.Next(0, 9);        // Choose a random y co-ordinate
                } while (grid[x, y] != 0);      // Loop while this position already has an assigned value
                grid[x, y] = sol[x, y];         // Set the real grid value to the value in the solution
                int choice = rand.Next(0, 2);   // Give a 50/50 chance
                if(choice == 0)
                {
                    grid[8 - y, 8 - x] = sol[8 - y, 8 - x];     // Select the value diagonally mirrored
                }
                else
                {
                    grid[y, x] = sol[y, x];     // Select the value mirrored in the other diagonal
                }  
            }
        }

        // Method to shift an array along
        // Parameters:
        //      row - the desired array to be shifted
        //      amount - how much the array should be shifted
        void ShiftRow(int[] row, int amount)
        {
            for(int i = 0; i < amount; i++)     // Loop as many times as specified
            {
                int start = row[0];             // Create a copy of the first value
                for(int j = 0; j < row.Length - 1; j++)
                {
                    row[j] = row[j + 1];        // Set the current value to the next one in the array
                }
                row[row.Length-1] = start;      // Set the last value to the first one ine the array
            }
        }

        public void SetMenu(menu menu1)
        {
            mnu = menu1;
        }


        //take in the value selected, and the y coord and check the entire row horizontally, if it exists already then make red and hidden value = 11
        public bool checkSide(int y, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[i, y] == value)
                {
                    return false;
                }
            }
            return true;
        }

        private void Frmgame_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Closing += Window_Closing;
            this.CenterToScreen();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnu.Show();
            closing = true;
            this.Close();
        }

        private void HelpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Rules: \n 1. Each row must contain all numbers from 1 to 9 \n 2. Each column must contain all numbers from 1 to 9 \n 3. Each 3x3 box must contain all numbers from 1 to 9\n\nHow to play: \n 1. Select a grid tile\n 2. Select a value to place it within the grid", "Help");
        }

        // Occurs when the form closes
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!closing)   // If the form isn't closing to go to the menu
            {
                Application.Exit();     // Close the program
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            passedtime++;
            timerlabel.Text = passedtime.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
