using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Player player;
        public List<Pipes> pipes;
        public int Count = 0;
        public int score = 0;
        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
            timer1.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.Initialize(this);
            player = new Player();
            pipes = new List<Pipes>();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Space)
            {
                player.Jump();
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            player.Fall();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            button1.Visible = false;
            this.Focus();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            player.Fall();
            Count++;
            if (Count % 100 == 0)
                pipes.Add(new Pipes());
            foreach (Pipes p in pipes)
            {
                p.Move();
                if (player.image.Left >= p.DownPipe.Left && !p.isPassed)
                {
                    p.isPassed = true;
                    score++;
                    label1.Text = Convert.ToString(score);
                }
            }
            Engine.CheckIfYouLose();
        }
    }
}
