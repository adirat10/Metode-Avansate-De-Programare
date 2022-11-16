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
            pictureBox1.Width = MenuScreen.Width = this.Width;
            pictureBox1.Height = MenuScreen.Height = this.Height;
            Timelabel.Parent = WaveLabel.Parent = HealthLabel.Parent = pictureBox1;
            Gun.Parent = pictureBox1;
            StartButton.Parent = ExitButton.Parent = MenuScreen;
            StartButton.Left = this.Width / 2 - StartButton.Width / 2;
            ExitButton.Left = this.Width / 2 - ExitButton.Width / 2;
            StartButton.Top = this.Height / 2 - StartButton.Height;
            ExitButton.Top = this.Height / 2 + 10;

            Engine.Init(this);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Enabled = false;
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
            backgroundSound.PlayLooping();
        }
    }
}
