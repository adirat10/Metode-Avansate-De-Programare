using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public class Player
    {
        public PictureBox image;
        public int gravity = 0;
        public const int MaxGravity = 13;
        public Player()
        {
            image = new PictureBox();
            image.Parent = Engine.form;
            image.Location = new Point(Engine.form.Left + 50, Engine.form.Height / 2);
            image.Size = new Size(70, 60);
            image.BackColor = Color.Transparent;
            image.Image = Image.FromFile("../../Images/bird.png");
            image.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public void Fall()
        {
            image.Top += gravity;
            gravity++;
            if (gravity > MaxGravity)
                gravity = MaxGravity;
        }
        public void Jump()
        {
            gravity = -MaxGravity;
        }
    }
}
