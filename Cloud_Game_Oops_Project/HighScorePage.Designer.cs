namespace Cloud_Game_Oops_Project
{
    partial class HighScorePage
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
            this.label2 = new System.Windows.Forms.Label();
            this.HsOne = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Hstwo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HsThree = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "HighScore 1";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HsOne
            // 
            this.HsOne.AutoSize = true;
            this.HsOne.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HsOne.Location = new System.Drawing.Point(632, 194);
            this.HsOne.Name = "HsOne";
            this.HsOne.Size = new System.Drawing.Size(41, 28);
            this.HsOne.TabIndex = 2;
            this.HsOne.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "HighScore 2";
            // 
            // Hstwo
            // 
            this.Hstwo.AutoSize = true;
            this.Hstwo.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hstwo.Location = new System.Drawing.Point(632, 284);
            this.Hstwo.Name = "Hstwo";
            this.Hstwo.Size = new System.Drawing.Size(41, 28);
            this.Hstwo.TabIndex = 4;
            this.Hstwo.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "HighScore 3";
            // 
            // HsThree
            // 
            this.HsThree.AutoSize = true;
            this.HsThree.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HsThree.Location = new System.Drawing.Point(632, 385);
            this.HsThree.Name = "HsThree";
            this.HsThree.Size = new System.Drawing.Size(41, 28);
            this.HsThree.TabIndex = 6;
            this.HsThree.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(232, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "High Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cloud_Game_Oops_Project.Properties.Resources.arrow_pointing_left_24px;
            this.pictureBox1.Location = new System.Drawing.Point(126, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HighScorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1021, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HsThree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Hstwo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HsOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "HighScorePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScorePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HsOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Hstwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label HsThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}