﻿namespace MAP_Shooter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timelabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.WaveLabel = new System.Windows.Forms.Label();
            this.Gun = new System.Windows.Forms.PictureBox();
            this.MenuScreen = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.HighscoreButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.PictureBox();
            this.HealthBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.BackColor = System.Drawing.Color.Transparent;
            this.Timelabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.ForeColor = System.Drawing.Color.Red;
            this.Timelabel.Location = new System.Drawing.Point(992, 523);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(34, 39);
            this.Timelabel.TabIndex = 1;
            this.Timelabel.Text = "0";
            // 
            // HealthLabel
            // 
            this.HealthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.ForeColor = System.Drawing.Color.Red;
            this.HealthLabel.Location = new System.Drawing.Point(47, 526);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(133, 39);
            this.HealthLabel.TabIndex = 2;
            this.HealthLabel.Text = "100/100";
            // 
            // WaveLabel
            // 
            this.WaveLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WaveLabel.AutoSize = true;
            this.WaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.WaveLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WaveLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaveLabel.ForeColor = System.Drawing.Color.Red;
            this.WaveLabel.Location = new System.Drawing.Point(632, 523);
            this.WaveLabel.Name = "WaveLabel";
            this.WaveLabel.Size = new System.Drawing.Size(121, 39);
            this.WaveLabel.TabIndex = 3;
            this.WaveLabel.Text = "Wave 1";
            // 
            // Gun
            // 
            this.Gun.BackColor = System.Drawing.Color.Transparent;
            this.Gun.Image = ((System.Drawing.Image)(resources.GetObject("Gun.Image")));
            this.Gun.Location = new System.Drawing.Point(397, 347);
            this.Gun.Name = "Gun";
            this.Gun.Size = new System.Drawing.Size(200, 200);
            this.Gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gun.TabIndex = 4;
            this.Gun.TabStop = false;
            // 
            // MenuScreen
            // 
            this.MenuScreen.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuScreen.BackgroundImage")));
            this.MenuScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuScreen.Location = new System.Drawing.Point(0, 0);
            this.MenuScreen.Name = "MenuScreen";
            this.MenuScreen.Size = new System.Drawing.Size(850, 323);
            this.MenuScreen.TabIndex = 5;
            this.MenuScreen.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartButton.BackColor = System.Drawing.Color.LightGray;
            this.StartButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(387, 182);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(180, 120);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "PLAY";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.BackColor = System.Drawing.Color.Crimson;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(9, 182);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 120);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionsButton.BackColor = System.Drawing.Color.PeachPuff;
            this.OptionsButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.Location = new System.Drawing.Point(573, 182);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(180, 120);
            this.OptionsButton.TabIndex = 8;
            this.OptionsButton.Text = "OPTIONS";
            this.OptionsButton.UseVisualStyleBackColor = false;
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HelpButton.BackColor = System.Drawing.Color.Orange;
            this.HelpButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(772, 182);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(180, 120);
            this.HelpButton.TabIndex = 9;
            this.HelpButton.Text = "HELP";
            this.HelpButton.UseVisualStyleBackColor = false;
            // 
            // HighscoreButton
            // 
            this.HighscoreButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HighscoreButton.BackColor = System.Drawing.Color.SkyBlue;
            this.HighscoreButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighscoreButton.Location = new System.Drawing.Point(201, 182);
            this.HighscoreButton.Name = "HighscoreButton";
            this.HighscoreButton.Size = new System.Drawing.Size(180, 120);
            this.HighscoreButton.TabIndex = 10;
            this.HighscoreButton.Text = "SCORE";
            this.HighscoreButton.UseVisualStyleBackColor = false;
            // 
            // StatusBar
            // 
            this.StatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StatusBar.Location = new System.Drawing.Point(0, 526);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1057, 49);
            this.StatusBar.TabIndex = 11;
            this.StatusBar.TabStop = false;
            // 
            // HealthBar
            // 
            this.HealthBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HealthBar.Location = new System.Drawing.Point(0, 526);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(304, 43);
            this.HealthBar.TabIndex = 12;
            this.HealthBar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 589);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.WaveLabel);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.HighscoreButton);
            this.Controls.Add(this.MenuScreen);
            this.Controls.Add(this.Gun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label Timelabel;
        public System.Windows.Forms.Label HealthLabel;
        public System.Windows.Forms.Label WaveLabel;
        private System.Windows.Forms.PictureBox Gun;
        private System.Windows.Forms.PictureBox MenuScreen;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button HighscoreButton;
        private System.Windows.Forms.PictureBox StatusBar;
        public System.Windows.Forms.PictureBox HealthBar;
    }
}

