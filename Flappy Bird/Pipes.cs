using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public class Pipes
    {
        public PictureBox UpPipe;
        public PictureBox DownPipe;
        public Pipes()
        {
            int y = Engine.random.Next(Engine.delta, Engine.form.Height - Engine.Gap - Engine.delta);

            UpPipe = new PictureBox();
            UpPipe.Parent = Engine.form;
            UpPipe.Location = new Point(Engine.form.Width, 0);
            UpPipe.Size = new Size(80, y);
            UpPipe.BackColor = Color.Transparent;
            UpPipe.Image = Image.FromFile("../../Images/pipe.png");
            UpPipe.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            UpPipe.SizeMode = PictureBoxSizeMode.StretchImage;

            DownPipe = new PictureBox();
            DownPipe.Parent = Engine.form;
            DownPipe.Location = new Point(Engine.form.Width, y + Engine.Gap);
            DownPipe.Size = new Size(80, Engine.form.Height - y - Engine.Gap);
            DownPipe.BackColor = Color.Transparent;
            DownPipe.Image = Image.FromFile("../../Images/pipe.png");
            DownPipe.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public void Move()
        {
            UpPipe.Location = new Point(UpPipe.Location.X - 5, UpPipe.Location.Y);
            DownPipe.Location = new Point(DownPipe.Location.X - 5, DownPipe.Location.Y);
        }
    }
}
