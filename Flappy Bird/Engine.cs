using System;
using System.Collections.Generic;
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
        public static void Initialize(Form1 f)
        {
            form = f;
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
