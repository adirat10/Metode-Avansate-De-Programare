using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MAP_Shooter
{
    public static class Engine
    {
        public static Form1 form;
        public static Random random = new Random();
        public static List<Enemy> enemies = new List<Enemy>(), currentWave = new List<Enemy>();
        public static List<List<Enemy>> waves = new List<List<Enemy>>();
        public static Graphics graphics, healthBarGraphics;
        public static Bitmap bitmap, healtBarBitmap;

        public static int horizon = 100, wave = 1;
        public static double time = 0;
        public static double fortHealth = 100;

        public static void Init(Form1 f1)
        {
            form = f1;
            bitmap = new Bitmap(form.Width, form.Height);
            graphics = Graphics.FromImage(bitmap);

            healtBarBitmap = new Bitmap(form.HealthBar.Width, form.HealthBar.Height);
            healthBarGraphics = Graphics.FromImage(healtBarBitmap);
            DrawGradient();

            var wave1 = new List<Enemy>();
            wave1.Add(new NormalEnemy(0));
            wave1.Add(new NormalEnemy(20));
            wave1.Add(new NormalEnemy(35));
            wave1.Add(new NormalEnemy(45));
            wave1.Add(new FatEnemy(55));

            var wave2 = new List<Enemy>();
            wave2.Add(new NormalEnemy(0));
            wave2.Add(new NormalEnemy(10));
            wave2.Add(new NormalEnemy(17));
            wave2.Add(new NormalEnemy(22));
            wave2.Add(new NormalEnemy(27));
            wave2.Add(new FatEnemy(37));
            wave2.Add(new FatEnemy(42));
            wave2.Add(new FatEnemy(45));

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
                if (enemy.position.Y >= form.pictureBox1.Height)
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
        public static bool IsPixelTransparent(Point click, Enemy enemy)
        {
            int x = click.X - enemy.position.X;
            int y = click.Y - enemy.position.Y;
            Bitmap zombie = new Bitmap((int)enemy.sizeX, (int)enemy.sizeY);
            Graphics grp = Graphics.FromImage(zombie);
            grp.DrawImage(enemy.image, 0, 0, (int)enemy.sizeX, (int)enemy.sizeY);
            return zombie.GetPixel(x, y).ToArgb() == 0;
        }
        public static void DrawGradient()
        {
            float width = form.HealthBar.Width * (float)(fortHealth / 100);

            var redYellowbrush = new LinearGradientBrush(new RectangleF(0, 0, width / 2, form.HealthBar.Height), Color.Red, Color.Yellow, 0f);
            var yellowGreenbrush = new LinearGradientBrush(new RectangleF(0, 0, width / 2, form.HealthBar.Height), Color.Yellow, Color.Green, 0f);
            healthBarGraphics.FillRectangle(redYellowbrush, 0, 0, width / 2, form.HealthBar.Height);
            healthBarGraphics.FillRectangle(yellowGreenbrush, 0, 0, width / 2, form.HealthBar.Height);

            healthBarGraphics.FillRectangle(new SolidBrush(Color.DarkGray), width, 0, form.HealthBar.Width, form.HealthBar.Height);
            form.HealthBar.Image = healtBarBitmap;
        }
        public static void UpdateDisplay()
        {
            graphics.DrawImage(form.background, 0, 0, form.Width, form.Height);

            enemies.Sort((Enemy e1, Enemy e2) => e1.position.Y - e2.position.Y);
            foreach (Enemy enemy in enemies)
            {
                enemy.Draw();
            }
            form.pictureBox1.Image = bitmap;
        }
        public static void BlurBackground()
        {
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.Black)), 0, 0, form.Width, form.Height);
            form.pictureBox1.Image = bitmap;
        }
    }
}
