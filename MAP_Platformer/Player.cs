using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP_Platformer
{
    public class Player
    {
        public PictureBox image;

        public Player()
        {
            image = new PictureBox();
            image.Parent = Engine.form;
            image.Location = new Point(Engine.form.Width / 2, Engine.form.Height * 3 / 4);
            image.Size = new Size(100, 100);
            image.BackColor = Color.ForestGreen;
        }
    }
}
