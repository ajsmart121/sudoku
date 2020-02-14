namespace sudoku
{
    partial class scores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.goldName = new System.Windows.Forms.Label();
            this.silverName = new System.Windows.Forms.Label();
            this.bronzeName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.goldScore = new System.Windows.Forms.Label();
            this.silverScore = new System.Windows.Forms.Label();
            this.bronzeScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(208, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(377, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightCyan;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(49, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(408, 234);
            this.listBox1.TabIndex = 3;
            // 
            // goldName
            // 
            this.goldName.AutoSize = true;
            this.goldName.Location = new System.Drawing.Point(235, 184);
            this.goldName.Name = "goldName";
            this.goldName.Size = new System.Drawing.Size(0, 13);
            this.goldName.TabIndex = 4;
            // 
            // silverName
            // 
            this.silverName.AutoSize = true;
            this.silverName.Location = new System.Drawing.Point(72, 244);
            this.silverName.Name = "silverName";
            this.silverName.Size = new System.Drawing.Size(0, 13);
            this.silverName.TabIndex = 5;
            // 
            // bronzeName
            // 
            this.bronzeName.AutoSize = true;
            this.bronzeName.Location = new System.Drawing.Point(401, 246);
            this.bronzeName.Name = "bronzeName";
            this.bronzeName.Size = new System.Drawing.Size(0, 13);
            this.bronzeName.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(49, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // goldScore
            // 
            this.goldScore.AutoSize = true;
            this.goldScore.Location = new System.Drawing.Point(235, 206);
            this.goldScore.Name = "goldScore";
            this.goldScore.Size = new System.Drawing.Size(0, 13);
            this.goldScore.TabIndex = 8;
            // 
            // silverScore
            // 
            this.silverScore.AutoSize = true;
            this.silverScore.Location = new System.Drawing.Point(72, 266);
            this.silverScore.Name = "silverScore";
            this.silverScore.Size = new System.Drawing.Size(0, 13);
            this.silverScore.TabIndex = 9;
            // 
            // bronzeScore
            // 
            this.bronzeScore.AutoSize = true;
            this.bronzeScore.Location = new System.Drawing.Point(401, 266);
            this.bronzeScore.Name = "bronzeScore";
            this.bronzeScore.Size = new System.Drawing.Size(0, 13);
            this.bronzeScore.TabIndex = 10;
            // 
            // scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(510, 596);
            this.Controls.Add(this.bronzeScore);
            this.Controls.Add(this.silverScore);
            this.Controls.Add(this.goldScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bronzeName);
            this.Controls.Add(this.silverName);
            this.Controls.Add(this.goldName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "scores";
            this.Text = "scores";
            this.Load += new System.EventHandler(this.Scores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label goldName;
        private System.Windows.Forms.Label silverName;
        private System.Windows.Forms.Label bronzeName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label goldScore;
        private System.Windows.Forms.Label silverScore;
        private System.Windows.Forms.Label bronzeScore;
    }
}