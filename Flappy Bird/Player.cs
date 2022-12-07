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
        public const int MaxGravity = 10;
        public Player()
        {
            image = new PictureBox();
            image.Parent = Engine.form1;
            image.Location = new Point(Engine.form1.Left + 50, Engine.form1.Top + 20);
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
            gravity = -MaxGravity - 3;
        }
    }
}
