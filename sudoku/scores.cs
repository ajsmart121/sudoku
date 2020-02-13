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

            displayLeaderboard();
        }

        private void Scores_Load(object sender, EventArgs e)
        {
         //put the photos in the boxes   
        }

        public void displayLeaderboard()
        {
            int[,] scores = new int[2, 10];
            string[] fileInfo = new string[11];
            string filePath = Path.GetFullPath("scores.txt");
            //FileInfo scoresFile = new FileInfo (filePath);
            Console.WriteLine(filePath);

            //load the file (scores.txt)
            if (File.Exists(filePath))
            {
                Console.WriteLine("file exists owo");
                 StreamReader s = File.OpenText(filePath);
                 string read = null;

                 int counter = 0;

                 while ((read = s.ReadLine()) != null)
                 {
                    Console.WriteLine(read);
                    listBox1.Items.Add(read);
                    fileInfo[counter] = read;
                    counter++;
                 }
                 s.Close();
            }
            else {
                listBox1.Items.Add("Congrats You're The First!");
                //create the file
                FileInfo f = new FileInfo(filePath); // Set file name
                StreamWriter w = f.CreateText();
            }
            
            
            //go through fileInfo and separate into names and scores and put into 2D array "scores"
            //remember to ToInt() the score

            
            //sort the scores

            //replace the scores.txt file with the new sorted file


            //display the file

        }
    }
}
