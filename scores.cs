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
            string filePath = Directory.GetCurrentDirectory() + @"\..\..\Resources\";
            pictureBox1.Image = Image.FromFile(filePath + "gold.jpg");
            pictureBox2.Image = Image.FromFile(filePath + "silver.png");
            pictureBox3.Image = Image.FromFile(filePath + "bronze.png");
        }

        public void displayLeaderboard()
        {
            int[] scores = new int[10];
            string[] scoreNames = new string[10];
 

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
                    /*
                     * scores = ToInt(read); 
                     * 
                     * scoresName = read;
                     *
                     */
                    fileInfo[counter] = read;
                    counter++;
                 }
                 s.Close();
            }
            else {
                listBox1.Items.Add("Congrats You're The First!");
                //create the file
                FileInfo fi = new FileInfo(filePath); // Set file name
                StreamWriter wr = fi.CreateText();
            }


            //go through fileInfo and separate into names and scores and put into array "scores" and "scoreNames"


            //sort the scores
            bool sorted = false;
            int i = 0;
            int scorescounter = 0;

            while (sorted == false)
            {
                if (scores[i] < scores[i + 1])
                {
                    string tempString = scoreNames[i];
                    int tempInt = scores[i];

                    scores[i] = scores[i + 1];
                    scoreNames[i] = scoreNames[i+1];

                    scores[i + 1] = tempInt;
                    scoreNames[i + 1] = tempString;

                }
                else
                {
                    scorescounter++;
                }

                if (scorescounter >= scores.Length)
                {
                    sorted = true;
                }

            }

            //replace the scores.txt file with the new sorted file
            string scoresFilePath = Path.GetFullPath("scores.txt");
            FileInfo f = new FileInfo(scoresFilePath);
            StreamWriter w = f.CreateText();

            for(int q = 0; q<scores.Length; q++)
            {
                w.WriteLine(scores[q].ToString());
                w.WriteLine(scoreNames[q]);
            }

            //display the file, putting 1st, 2nd and 3rd in the labels at the top and the rest in the listbox

            //display 1st
            goldName.Text = scoreNames[0];
            goldScore.Text = scores[0].ToString();

            //display 2nd
            silverName.Text = scoreNames[1];
            silverScore.Text = scores[1].ToString();

            //display 3rd
            bronzeName.Text = scoreNames[2];
            bronzeScore.Text = scores[2].ToString();

            //display the rest
            for (int d = 3; d<scores.Length; d++)
            {
                //display in the listbox
                listBox1.Items.Add(scores[d].ToString() + " " + scoreNames[d]);
            }

        }
    }
}
