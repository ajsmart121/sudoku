namespace sudoku
{
    partial class frmgame
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
            this.components = new System.ComponentModel.Container();
            this.Line1 = new System.Windows.Forms.PictureBox();
            this.Line2 = new System.Windows.Forms.PictureBox();
            this.Line3 = new System.Windows.Forms.PictureBox();
            this.Line4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerlabel = new System.Windows.Forms.Label();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.Teal;
            this.Line1.Location = new System.Drawing.Point(177, 41);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(6, 483);
            this.Line1.TabIndex = 1;
            this.Line1.TabStop = false;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.Teal;
            this.Line2.Location = new System.Drawing.Point(342, 41);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(6, 483);
            this.Line2.TabIndex = 2;
            this.Line2.TabStop = false;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.Teal;
            this.Line3.Location = new System.Drawing.Point(21, 197);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(483, 6);
            this.Line3.TabIndex = 3;
            this.Line3.TabStop = false;
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.Color.Teal;
            this.Line4.Location = new System.Drawing.Point(21, 362);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(483, 6);
            this.Line4.TabIndex = 4;
            this.Line4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerlabel
            // 
            this.timerlabel.AutoSize = true;
            this.timerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlabel.Location = new System.Drawing.Point(252, 545);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(15, 16);
            this.timerlabel.TabIndex = 5;
            this.timerlabel.Text = "0";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click_1);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.MenuToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 651);
            this.Controls.Add(this.timerlabel);
            this.Controls.Add(this.Line4);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmgame";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Frmgame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Line1;
        private System.Windows.Forms.PictureBox Line2;
        private System.Windows.Forms.PictureBox Line3;
        private System.Windows.Forms.PictureBox Line4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerlabel;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}