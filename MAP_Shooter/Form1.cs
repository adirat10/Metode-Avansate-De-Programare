using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MAP_Shooter
{
    public partial class Form1 : Form
    {
        public Image background = Image.FromFile("../../Images/background.jpg");
        public Image pistol = Image.FromFile("../../Images/Pistol2.png");
        public SoundPlayer backgroundSound = new SoundPlayer("../../Sounds/sound2.wav");

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = MenuScreen.Width = StatusBar.Width = this.Width;
            pictureBox1.Height = this.Height - StatusBar.Height;
            MenuScreen.Height = this.Height;

            Timelabel.Parent = WaveLabel.Parent = HealthLabel.Parent = HealthBar.Parent = StatusBar;
            Gun.Parent = pictureBox1;
            StartButton.Parent = ExitButton.Parent = MenuScreen;

            StartButton.Left = this.Width - StartButton.Width - 25;
            ExitButton.Left = this.Width - ExitButton.Width - 25;
            StartButton.Top = this.Height - StartButton.Height - 690;
            ExitButton.Top = this.Height - ExitButton.Height - 105;
            OptionsButton.Top = this.Height - OptionsButton.Height - 260;
            OptionsButton.Left = this.Width - OptionsButton.Width - 25;
            HelpButton.Top = this.Height - HelpButton.Height - 400;
            HelpButton.Left = this.Width - HelpButton.Width - 25;
            HighscoreButton.Top = this.Height - HighscoreButton.Height - 550;
            HighscoreButton.Left = this.Width - HighscoreButton.Width - 25;

            Engine.Init(this);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            backgroundSound.Stop();
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Enabled = false;
                Engine.BlurBackground();

                backgroundSound.Stop();
                var option = MessageBox.Show("Are you sure you want to exit this game? Your progress will not be saved!",
                    "Exit game", MessageBoxButtons.OKCancel);
                if (option == DialogResult.OK)
                    Close();
                timer1.Enabled = true;
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Engine.Shoot(e.Location);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Engine.Tick();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Gun.Location = new Point(e.Location.X, e.Location.Y + 20);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            MenuScreen.Visible = false;
            MenuScreen.Enabled = false;
            OptionsButton.Visible = false;
            HelpButton.Visible = false;
            HighscoreButton.Visible = false;
            OptionsButton.Visible = false;
            HelpButton.Visible = false;
            HighscoreButton.Enabled = false;
            backgroundSound.PlayLooping();
        }
    }
}
