using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MAP_Shooter
{
    public class NormalEnemy : Enemy
    {
        public static Image ghost = Image.FromFile("../../Images/ghost3.png");
        public NormalEnemy(int spawnTime) : base(100, 5, 20, 50, 80, spawnTime)
        {
            image = ghost;
        }
        public override void Move()
        {
            position.Y += (int)speed;
            sizeX += 1.0 / 4;
            sizeY += 1.0 / 2;
            positionX -= 1.0 / 8;
            position.X = (int)positionX;
        }
        public override void Draw()
        {
            Engine.graphics.DrawImage(image, position.X, position.Y, (int)sizeX, (int)sizeY);
        }
    }
    public class FatEnemy : Enemy
    {
        public static Image fatEnemy = Image.FromFile("../../Images/ghost2.png");
        public FatEnemy(int spawnTime) : base(250, 2, 20, 100, 100, spawnTime)
        {
            image = fatEnemy;
        }
        public override void Move()
        {
            position.Y += (int)speed;
            sizeX += 1.0 / 4;
            sizeY += 1.0 / 2;
            positionX -= 1.0 / 8;
            position.X = (int)positionX;
        }
        public override void Draw()
        {
            Engine.graphics.DrawImage(image, position.X, position.Y, (int)sizeX, (int)sizeY);
        }
    }
}
