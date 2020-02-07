using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    public partial class frmgame : Form
    {

        public int[,] grid = new int[9, 9];
        public Button[,] btns = new Button[9, 9];


        public frmgame(int Difficulty)
        {
            InitializeComponent();
            FillGrid(GenerateSolution(), Difficulty);                   // Create the grid with roughly 30 numbers
            for (int x = 0; x < btns.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < btns.GetLength(1); y++)     // Loop for y
                {
                    btns[x, y] = new Button();
                    btns[x, y].SetBounds(55 * x, 55 * y, 45, 45);
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
        }

        public void checkUp()
        {

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

        }
    }
}
