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
        public double health, speed, damage, size, positionX;
        public Point position;

        public Enemy(double health, double speed, double damage, double size)
        {
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.size = size;
            position = Engine.GetRandomPoint((int)size);
            positionX = position.X;
        }
        public void Move()
        {
            position.Y += (int)speed;
            size += 1.0 / 4;
            positionX -= 1.0 / 8;
            position.X = (int)positionX;
        }
        public void GetShot(Point click)
        {
            if (click.X > position.X && click.X < position.X + size && click.Y > position.Y && click.Y < position.Y + size)
            {
                health -= 20;
                Engine.graphics.DrawString("20", new Font("Arial", 12), new SolidBrush(Color.Black), click.X,click.Y-20);
                Engine.form.pictureBox1.Image = Engine.bitmap;
            }
        }
    }
}
