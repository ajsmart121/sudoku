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
        }

        public void checkUp()
        {

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
