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
        public Button[] numbers = new Button[9];


        public frmgame()
        {
            InitializeComponent();
            for (int x = 0; x < btns.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < btns.GetLength(1); y++)     // Loop for y
                {
                    btns[x, y] = new Button();
                    btns[x, y].SetBounds(55 * x, 55 * y, 45, 45);
                    btns[x, y].BackColor = Color.PowderBlue;
                    btns[x, y].Text = Convert.ToString((x + 1) + "," + (y + 1));
                    btns[x, y].Click += new EventHandler(this.btnsEvent_Click);
                    Controls.Add(btns[x, y]);

                }
            }

            for (int i = 0; i< numbers.Length; i++)
            {
                numbers[i] = new Button();
                numbers[i].SetBounds(55 * i, 500, 45, 45);
                numbers[i].BackColor = Color.CornflowerBlue;
                numbers[i].Text = Convert.ToString(i + 1);
                numbers[i].Click += new EventHandler(this.numbersEvent_Click);
                Controls.Add(numbers[i]);
            }
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

            bool valid = false;

            valid = checkUp();

            valid = false;

            valid = checkSide();

            valid = false;

            //calculate which square the selected thingy is in

            valid = checkSquare();

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

        private void Frmgame_Load(object sender, EventArgs e)
        {

        }
    }
}
