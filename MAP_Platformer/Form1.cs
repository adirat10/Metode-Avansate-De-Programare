using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP_Platformer
{
    public partial class Form1 : Form
    {
        public Player player;
        public Form1()
        {
            InitializeComponent();
            Engine.Initialize(this);
            player = new Player();
        }
    }
}
