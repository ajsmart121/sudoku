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
        frmgame game;

        public menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            game = new frmgame(38);
            OnStartGame();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            game = new frmgame(30);
            OnStartGame();
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {
            game = new frmgame(22);
            OnStartGame();
        }

        private void OnStartGame()
        {
            game.Show();
            game.SetMenu(this);
            this.Hide();
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

        public void NewGame(int difficulty)
        {
            game = new frmgame(difficulty);
            OnStartGame();
        }
    }
}
