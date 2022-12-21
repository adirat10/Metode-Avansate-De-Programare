using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;
using System.Reflection.Emit;

namespace Flappy_Bird
{
    public class Engine
    {
        public static Form1 form1;
        public static Menu menu;
        public static Random random = new Random();
        public const int Gap = 200, delta = 50;
        public static PictureBox Ground;
        public static SoundPlayer hitSound = new SoundPlayer("../../Sounds/hit.wav");
        public static void Initialize(Form1 f)
        {
            form1 = f;
            Ground = new PictureBox();
            Ground.Parent = form1;
            Ground.Location = new Point(0, 370);
            Ground.Size = new Size(form1.Width, form1.Height);
            Ground.BackColor = Color.Transparent;
            Ground.Image = Image.FromFile("../../Images/ground.png");
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public static void CheckIfYouLose()
        {
            foreach (var control in form1.Controls)
            {
                if (control is PictureBox && !control.Equals(form1.player.image))
                {
                    if (form1.player.image.Bounds.IntersectsWith((control as PictureBox).Bounds))
                    {
                        hitSound.Play();
                        form1.timer1.Enabled = false;

                        string fileName = @"../../Score.txt";
                        using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.WriteLine(form1.score);
                        }

                        var response = MessageBox.Show("Do you want to restart?", "You Lost!", MessageBoxButtons.YesNo);
                        if (response == DialogResult.Yes)
                        {
                            form1.score = 0;
                            form1.label1.Text = "0";
                            form1.player.image.Parent = null;
                            foreach (Pipes p in form1.pipes)
                            {
                                p.UpPipe.Parent = null;
                                p.DownPipe.Parent = null;
                            }
                            form1.pipes.Clear();
                            form1.player = new Player();
                            form1.Count = 0;
                            form1.timer1.Enabled = true;
                        }
                        else Application.Exit();
                    }
                }
            }
        }
        public static bool IsPixelTransparent(Player player)
        {
            return true;
        }
    }
}
