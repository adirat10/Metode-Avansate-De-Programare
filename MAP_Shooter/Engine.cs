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
    public static class Engine
    {
        public static Form1 form;
        public static Random random = new Random();
        public static List<Enemy> enemies = new List<Enemy>(), wave = new List<Enemy>();
        public static Graphics graphics;
        public static Bitmap bitmap;
        public static int horizon = 100;
        public static int time = 0;
        public static void Init(Form1 f1)
        {
            form = f1;
            bitmap = new Bitmap(form.Width, form.Height);
            graphics = Graphics.FromImage(bitmap);
            wave.Add(new Enemy(100, 5, 0, 50, 80, 0));
            wave.Add(new Enemy(100, 5, 0, 50, 80, 20));
            wave.Add(new Enemy(100, 5, 0, 50, 80, 35));
            wave.Add(new Enemy(100, 5, 0, 50, 80, 45));
            wave.Add(new Enemy(100, 5, 0, 50, 80, 55));
        }
        public static void Tick()
        {
            time++;
            if (wave.Any() && wave[0].spawnTime <= time)
            {
                enemies.Add(wave[0]);
                wave.RemoveAt(0);
            }
            foreach (Enemy enemy in enemies)
            {
                enemy.Move();
            }
            UpdateDisplay();
        }
        public static void Shoot(Point click)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].GetShot(click);
                if (enemies[i].health <= 0)
                {
                    enemies.Remove(enemies[i]);
                    i--;
                }
            }
            if (!wave.Any() && !enemies.Any())
            {
                form.timer1.Enabled = false;
                MessageBox.Show("You defeated all the enemies!", "You Win!");
                form.Close();
            }
        }
        public static Point GetRandomPoint(int sizeX, int sizeY)
        {
            return new Point(random.Next(form.Width - sizeX), horizon - sizeY);
        }
        public static void UpdateDisplay()
        {
            graphics.DrawImage(form.background, 0, 0, form.Width, form.Height);

            foreach (Enemy enemy in enemies)
            {
                graphics.DrawImage(form.target, enemy.position.X, enemy.position.Y, (int)enemy.sizeX, (int)enemy.sizeY);
                //graphics.FillRectangle(new SolidBrush(Color.White), enemy.position.X, enemy.position.Y, (int)enemy.size, (int)enemy.size);
            }
            form.pictureBox1.Image = bitmap;
        }
    }
}
