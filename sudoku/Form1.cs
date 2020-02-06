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


        public frmgame()
        {
            InitializeComponent();
            FillGrid(GenerateSolution(), 30);
            for (int x = 0; x < btns.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < btns.GetLength(1); y++)     // Loop for y
                {
                    btns[x, y] = new Button();
                    btns[x, y].SetBounds(55 * x, 55 * y, 45, 45);
                    btns[x, y].BackColor = Color.PowderBlue;
                    if(grid[x,y] != 0)
                    {
                        btns[x, y].Text = Convert.ToString(grid[x, y]);
                        btns[x, y].Enabled = false;
                    }
                    else
                    {
                        btns[x, y].Text = "";
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


        int[,] GenerateSolution()
        {
            Random rand = new Random();
            int[,] tmp = new int[9, 9];
            int[] tmp2 = new int[9];
            
            for (int i = 0; i < 9; i++)
            {
                int val = rand.Next(1, 10);
                while (!checkSide(0, val))
                {
                    val = rand.Next(1, 10);
                }
                grid[i, 0] = val;
                tmp2[i] = val;
            }

            int desRow = rand.Next(0, 3);
            for (int i = 0; i < 9; i++)
            {
                tmp[i, desRow * 3] = grid[i, 0];
                grid[i, 0] = 0;
            }

            for(int j = 1; j < 3; j++)
            {
                ShiftRow(tmp2, 3);
                for (int i = 0; i < 9; i++)
                {
                    tmp[i, desRow * 3 + j] = tmp2[i];
                }
            }

            int tmpRow;
            do
            {
                tmpRow = rand.Next(0, 3);
            } while (tmpRow == desRow);

            for(int k = 0; k < 2; k++)
            {
                ShiftRow(tmp2, 1);
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        tmp[i, tmpRow * 3 + j] = tmp2[i];
                    }
                    if (j < 2)
                    {
                        ShiftRow(tmp2, 3);
                    }
                }
                tmpRow = 3 - tmpRow - desRow;
            }
            return tmp;
        }

        void FillGrid(int[,] sol, int amount)
        {
            Random rand = new Random();
            for (int i = 0; i <(amount+4)/2; i++)
            {
                int x, y = 0;
                do
                {
                    x = rand.Next(0, 9);
                    y = rand.Next(0, 9);
                } while (grid[x, y] != 0);
                grid[x, y] = sol[x, y];
                int choice = rand.Next(0, 2);
                if(choice == 0)
                {
                    grid[8 - y, 8 - x] = sol[8 - y, 8 - x];
                }
                else
                {
                    grid[y, x] = sol[y, x];
                }  
            }
        }

        void ShiftRow(int[] row, int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                int start = row[0];
                for(int j = 0; j < row.Length - 1; j++)
                {
                    row[j] = row[j + 1];
                }
                row[row.Length-1] = start;
            }
        }


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
