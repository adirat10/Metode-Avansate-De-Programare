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
        public static List<Enemy> enemies = new List<Enemy>(), currentWave = new List<Enemy>();
        public static List<List<Enemy>> waves = new List<List<Enemy>>();
        public static Graphics graphics;
        public static Bitmap bitmap;
        public static int horizon = 100, wave = 1;
        public static double time = 0;
        public static double fortHealth = 100;

        public static void Init(Form1 f1)
        {
            form = f1;
            bitmap = new Bitmap(form.Width, form.Height);
            graphics = Graphics.FromImage(bitmap);
            var wave1 = new List<Enemy>();
            wave1.Add(new Enemy(100, 5, 20, 50, 80, 0));
            wave1.Add(new Enemy(100, 5, 20, 50, 80, 20));
            wave1.Add(new Enemy(100, 5, 20, 50, 80, 35));
            wave1.Add(new Enemy(100, 5, 20, 50, 80, 45));
            wave1.Add(new Enemy(100, 5, 20, 50, 80, 55));

            var wave2 = new List<Enemy>();
            wave2.Add(new Enemy(100, 5, 20, 50, 80, 0));
            wave2.Add(new Enemy(100, 5, 20, 50, 80, 10));
            wave2.Add(new Enemy(100, 5, 20, 50, 80, 17));
            wave2.Add(new Enemy(100, 5, 20, 50, 80, 22));
            wave2.Add(new Enemy(100, 5, 20, 50, 80, 27));
            wave2.Add(new Enemy(100, 5, 20, 50, 80, 37));
            wave2.Add(new Enemy(100, 5, 20, 50, 80, 42));
            wave2.Add(new Enemy(100, 5, 20, 50, 80, 45));

            waves.Add(wave1);
            waves.Add(wave2);
            currentWave = wave1;
        }
        public static void Tick()
        {
            time++;
            form.Timelabel.Text = $"{time / 10}s";

            if (!currentWave.Any() && !enemies.Any())
            {
                if (wave < waves.Count)
                    NextWave();
                else
                    Win();
            }

            if (currentWave.Any() && currentWave[0].spawnTime <= time)
            {
                enemies.Add(currentWave[0]);
                currentWave.RemoveAt(0);
            }

            MoveEnemies();
            CheckIfYouLose();
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

        }
        public static void NextWave()
        {
            wave++;
            currentWave = waves[wave - 1];
            time = 0;
            form.WaveLabel.Text = $"Wave {wave}";
        }
        public static void Win()
        {
            form.timer1.Enabled = false;
            form.backgroundSound.Stop();
            MessageBox.Show("You defeated all the enemies!", "You Win!");
            form.Close();
        }
        public static void CheckIfYouLose()
        {
            if (fortHealth <= 0)
            {
                form.timer1.Enabled = false;
                MessageBox.Show("Your fort walls were destroyed!", "You Lose!");
                form.Close();
            }
        }
        public static void MoveEnemies()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Enemy enemy = enemies[i];
                enemy.Move();
                if (enemy.position.Y >= form.Height)
                {
                    fortHealth -= enemy.damage;
                    form.HealthLabel.Text = $"Health:{fortHealth}";
                    enemies.Remove(enemies[i]);
                    i--;
                }
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
