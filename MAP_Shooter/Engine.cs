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
        public static Enemy enemy;
        public static int horizon = 100;
        public static void Init(Form1 f1)
        {
            form = f1;
            enemy = new Enemy(0, 5, 0, 50);
        }
        public static Point GetRandomPoint(int size)
        {
            return new Point(random.Next(form.Width - size), horizon - size);
        }
    }
}
