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

        // Set the difficulty to easy when the player clicks on easy
        private void easyBtn_Click(object sender, EventArgs e)
        {
            game = new frmgame(38);
            OnStartGame();
        }

        // Set the difficulty to regular when the player clicks on regular
        private void RegBtn_Click(object sender, EventArgs e)
        {
            game = new frmgame(30);
            OnStartGame();
        }

        // Set the difficulty to hard when the player clicks on hard
        private void HardBtn_Click(object sender, EventArgs e)
        {
            game = new frmgame(22);
            OnStartGame();
        }

        // Show the game and hide the menu when the game starts
        private void OnStartGame()
        {
            game.Show();
            game.SetMenu(this);
            this.Hide();
        }

        // Display the leader board
        private void LeadBtn_Click(object sender, EventArgs e)
        {
            scores leader = new scores();
            leader.Show();
        }

        // Close the application
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Create a new game with the desired difficulty
        public void NewGame(int difficulty)
        {
            game = new frmgame(difficulty);
            OnStartGame();
        }
    }
}

