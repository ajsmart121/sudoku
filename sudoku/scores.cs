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
            List<int> scores = new List<int>();
            List<string> scoreNames = new List<string>();


            string[] fileInfo = new string[50];
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
                    //listBox1.Items.Add(read);


                    if (counter % 2 == 0)
                    {
                        scores.Add(System.Convert.ToInt32(read));

                    }
                    else
                    {
                        scoreNames.Add(read);
                    }

                    //fileInfo[counter] = read;
                    counter++;
                }
                s.Close();
            }
            else {
                listBox1.Items.Add("Congrats You're The First!");
                //create the file
               // FileInfo fi = new FileInfo(filePath); // Set file name
                //StreamWriter wr = fi.CreateText();
            }
            Console.WriteLine("Sort");

            //go through fileInfo and separate into names and scores and put into array "scores" and "scoreNames"


            //sort the scores

            for (int i = 0; i < scores.Count; i++) { 
                for (int j = 0; j < scores.Count - i - 1; j++) { 
                    if (scores[j] > scores[j + 1])
                    {
                        string tempString = scoreNames[j];
                        int tempInt = scores[j];

                        scores[j] = scores[j + 1];
                        scoreNames[j] = scoreNames[j + 1];

                        scores[j + 1] = tempInt;
                        scoreNames[j + 1] = tempString;
                    }
                }
            }


            //replace the scores.txt file with the new sorted file
            string scoresFilePath = Path.GetFullPath("scores.txt");
            FileInfo f = new FileInfo(scoresFilePath);
            StreamWriter w = f.CreateText();

            for(int q = 0; q<scores.Count; q++)
            {
                w.WriteLine(scores[q].ToString());
                w.WriteLine(scoreNames[q]);
            }

            w.Close();

            //display the file, putting 1st, 2nd and 3rd in the labels at the top and the rest in the listbox

            //display 1st
            if(scores.Count > 0)
            {
                goldName.Text = scoreNames[0];
                goldScore.Text = scores[0].ToString();
            }


            //display 2nd
            if(scores.Count > 1)
            {
                silverName.Text = scoreNames[1];
                silverScore.Text = scores[1].ToString();
            }


            //display 3rd
            if(scores.Count > 2)
            {
                bronzeName.Text = scoreNames[2];
                bronzeScore.Text = scores[2].ToString();
            }


            //display the rest
            for (int d = 3; d<scores.Count; d++)
            {
                //display in the listbox
                listBox1.Items.Add(scores[d].ToString() + " " + scoreNames[d]);
            }

        }
    }
}
