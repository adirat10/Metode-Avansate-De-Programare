using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP_Shooter
{
    public class Enemy
    {
        double health, speed, damage, size;
        Point position;
        PictureBox image;

        public Enemy(double health, double speed, double damage, double size)
        {
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.size = size;
            position = Engine.GetRandomPoint((int)size);

            image = new PictureBox();
            image.Parent = Engine.form.pictureBox1;
            image.Size = new Size((int)size, (int)size);
            image.BackColor = Color.White;
            image.Location = position;
        }
        public void Move()
        {
            position.Y += (int)speed;
            image.Location = position;
        }
    }
}
