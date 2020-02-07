using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sudoku
{
    public partial class scores : Form
    {
        public scores()
        {
            InitializeComponent();

            //take in the scores file
            //sort the file into highest to lowest
            //display the sorted thingy with the 1'st, 2nd and 3rd in labels, the rest in text boxes
            //overwrite the already existing file with the new sorted list
        }

        private void Scores_Load(object sender, EventArgs e)
        {

        }
    }
}
