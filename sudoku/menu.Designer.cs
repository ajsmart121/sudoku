namespace sudoku
{
    partial class menu
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
            this.easyBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.leadBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyBtn
            // 
            this.easyBtn.Location = new System.Drawing.Point(125, 100);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(75, 23);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(125, 129);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(75, 23);
            this.regBtn.TabIndex = 1;
            this.regBtn.Text = "Regular";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // hardBtn
            // 
            this.hardBtn.Location = new System.Drawing.Point(125, 158);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(75, 23);
            this.hardBtn.TabIndex = 2;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            this.hardBtn.Click += new System.EventHandler(this.HardBtn_Click);
            // 
            // leadBtn
            // 
            this.leadBtn.Location = new System.Drawing.Point(125, 217);
            this.leadBtn.Name = "leadBtn";
            this.leadBtn.Size = new System.Drawing.Size(75, 23);
            this.leadBtn.TabIndex = 3;
            this.leadBtn.Text = "Leaderboard";
            this.leadBtn.UseVisualStyleBackColor = true;
            this.leadBtn.Click += new System.EventHandler(this.LeadBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(125, 247);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sudoku";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.leadBtn);
            this.Controls.Add(this.hardBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.easyBtn);
            this.Name = "menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Button leadBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
    }
}