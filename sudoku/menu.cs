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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            frmgame game = new frmgame(38);
            game.Show();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            frmgame game = new frmgame(30);
            game.Show();
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {
            frmgame game = new frmgame(22);
            game.Show();
        }

        private void LeadBtn_Click(object sender, EventArgs e)
        {
            scores leader = new scores();
            leader.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
