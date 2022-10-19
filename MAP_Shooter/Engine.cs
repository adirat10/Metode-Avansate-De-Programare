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
        public static void Init(Form1 f1)
        {
            form = f1;
            new Enemy(0,0,0,100);
        }
    }
}
