namespace Cloud_Game_Oops_Project
{
    partial class StartPage
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
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.Scoretimer = new System.Windows.Forms.Timer(this.components);
            this.Restart = new System.Windows.Forms.Timer(this.components);
            this.Counter = new System.Windows.Forms.Label();
            this.txtcounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartingPosition = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StormCloud2_obstacle = new System.Windows.Forms.PictureBox();
            this.Bird1_obstacle = new System.Windows.Forms.PictureBox();
            this.StormCloud_obstacle = new System.Windows.Forms.PictureBox();
            this.Cloud = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartingPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StormCloud2_obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird1_obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StormCloud_obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Interval = 40;
            this.gametimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtScore.Location = new System.Drawing.Point(581, 29);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(114, 45);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score";
            // 
            // Scoretimer
            // 
            this.Scoretimer.Enabled = true;
            this.Scoretimer.Interval = 300;
            this.Scoretimer.Tick += new System.EventHandler(this.ScoreCounter);
            // 
            // Restart
            // 
            this.Restart.Interval = 300;
            this.Restart.Tick += new System.EventHandler(this.Gameovertimer);
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(825, 50);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(0, 16);
            this.Counter.TabIndex = 16;
            this.Counter.Visible = false;
            // 
            // txtcounter
            // 
            this.txtcounter.AutoSize = true;
            this.txtcounter.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcounter.Location = new System.Drawing.Point(129, -15);
            this.txtcounter.Name = "txtcounter";
            this.txtcounter.Size = new System.Drawing.Size(70, 18);
            this.txtcounter.TabIndex = 17;
            this.txtcounter.Text = "Counter :";
            this.txtcounter.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // StartingPosition
            // 
            this.StartingPosition.Image = global::Cloud_Game_Oops_Project.Properties.Resources.Screenshot_2022_06_17_222816_removebg_preview;
            this.StartingPosition.Location = new System.Drawing.Point(-4, 455);
            this.StartingPosition.Name = "StartingPosition";
            this.StartingPosition.Size = new System.Drawing.Size(256, 252);
            this.StartingPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StartingPosition.TabIndex = 2;
            this.StartingPosition.TabStop = false;
            this.StartingPosition.Tag = "StartingPosition";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Cloud_Game_Oops_Project.Properties.Resources._23_PM_unscreen;
            this.pictureBox2.Location = new System.Drawing.Point(1413, 611);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Bird1_obstacle";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Cloud_Game_Oops_Project.Properties.Resources.Screenshot_2022_07_03_150952_prev_ui;
            this.pictureBox7.Location = new System.Drawing.Point(1485, 419);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(126, 68);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "StormCloud2_obstacle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Cloud_Game_Oops_Project.Properties.Resources.Screenshot_2022_06_21_114345_prev_ui;
            this.pictureBox4.Location = new System.Drawing.Point(1572, 539);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 98);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "StormCloud_obstacle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Cloud_Game_Oops_Project.Properties.Resources._23_PM_unscreen;
            this.pictureBox1.Location = new System.Drawing.Point(1714, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Bird1_obstacle";
            // 
            // StormCloud2_obstacle
            // 
            this.StormCloud2_obstacle.Image = global::Cloud_Game_Oops_Project.Properties.Resources.Screenshot_2022_07_03_150952_prev_ui;
            this.StormCloud2_obstacle.Location = new System.Drawing.Point(1485, 169);
            this.StormCloud2_obstacle.Name = "StormCloud2_obstacle";
            this.StormCloud2_obstacle.Size = new System.Drawing.Size(126, 71);
            this.StormCloud2_obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StormCloud2_obstacle.TabIndex = 6;
            this.StormCloud2_obstacle.TabStop = false;
            this.StormCloud2_obstacle.Tag = "StormCloud2_obstacle";
            // 
            // Bird1_obstacle
            // 
            this.Bird1_obstacle.BackColor = System.Drawing.Color.Transparent;
            this.Bird1_obstacle.Image = global::Cloud_Game_Oops_Project.Properties.Resources._23_PM_unscreen;
            this.Bird1_obstacle.Location = new System.Drawing.Point(1676, 85);
            this.Bird1_obstacle.Name = "Bird1_obstacle";
            this.Bird1_obstacle.Size = new System.Drawing.Size(108, 86);
            this.Bird1_obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bird1_obstacle.TabIndex = 4;
            this.Bird1_obstacle.TabStop = false;
            this.Bird1_obstacle.Tag = "Bird1_obstacle";
            // 
            // StormCloud_obstacle
            // 
            this.StormCloud_obstacle.Image = global::Cloud_Game_Oops_Project.Properties.Resources.Screenshot_2022_06_21_114345_prev_ui;
            this.StormCloud_obstacle.Location = new System.Drawing.Point(1649, 233);
            this.StormCloud_obstacle.Name = "StormCloud_obstacle";
            this.StormCloud_obstacle.Size = new System.Drawing.Size(111, 105);
            this.StormCloud_obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StormCloud_obstacle.TabIndex = 3;
            this.StormCloud_obstacle.TabStop = false;
            this.StormCloud_obstacle.Tag = "StormCloud_obstacle";
            // 
            // Cloud
            // 
            this.Cloud.Image = global::Cloud_Game_Oops_Project.Properties.Resources.Screenshot_2022_06_21_114246_prev_ui;
            this.Cloud.Location = new System.Drawing.Point(116, 306);
            this.Cloud.Name = "Cloud";
            this.Cloud.Size = new System.Drawing.Size(109, 154);
            this.Cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cloud.TabIndex = 0;
            this.Cloud.TabStop = false;
            this.Cloud.Tag = "Cloud";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1409, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartingPosition);
            this.Controls.Add(this.txtcounter);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StormCloud2_obstacle);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.Bird1_obstacle);
            this.Controls.Add(this.StormCloud_obstacle);
            this.Controls.Add(this.Cloud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpKey);
            ((System.ComponentModel.ISupportInitialize)(this.StartingPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StormCloud2_obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird1_obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StormCloud_obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Cloud;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox StartingPosition;
        private System.Windows.Forms.PictureBox StormCloud_obstacle;
        private System.Windows.Forms.PictureBox Bird1_obstacle;
        private System.Windows.Forms.Timer Scoretimer;
        private System.Windows.Forms.PictureBox StormCloud2_obstacle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer RestartTimer;
        private System.Windows.Forms.Timer Restart;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label txtcounter;
        private System.Windows.Forms.Label label1;
    }
}

