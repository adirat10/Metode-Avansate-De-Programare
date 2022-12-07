using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public class Engine
    {
        public static Form1 form;
        public static Random random = new Random();
        public const int Gap = 200, delta = 50;
        public static PictureBox Ground;
        public static void Initialize(Form1 f)
        {
            form = f;
            Ground = new PictureBox();
            Ground.Parent = form;
            Ground.Location = new Point(0,370);
            Ground.Size = new Size(form.Width,form.Height);
            Ground.BackColor = Color.Transparent;
            Ground.Image = Image.FromFile("../../Images/ground.png");
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public static void CheckIfYouLose()
        {
            foreach (var control in form.Controls)
            {
                if (control is PictureBox && !control.Equals(form.player.image))
                {
                    if (form.player.image.Bounds.IntersectsWith((control as PictureBox).Bounds))
                    {
                        form.timer1.Enabled = false;

                        var response = MessageBox.Show("Do you want to restart?", "You Lost!", MessageBoxButtons.YesNo);
                        if (response == DialogResult.Yes)
                        {
                            form.score = 0;
                            form.label1.Text = "0";
                            form.player.image.Parent = null;
                            foreach (Pipes p in form.pipes)
                            {
                                p.UpPipe.Parent = null;
                                p.DownPipe.Parent = null;
                            }
                            form.pipes.Clear();
                            form.player = new Player();
                            form.Count = 0;
                            form.timer1.Enabled = true;
                        }
                        else Application.Exit();
                    }
                }
            }
        }
    }
}
