using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
        private void initForm1(Image background)
        {
            Engine.form1 = new Form1();
            Engine.form1.BackgroundImage = background;
            this.Visible = false;
            Engine.form1.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            initForm1(button1.BackgroundImage);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            initForm1(button2.BackgroundImage);
        }
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
    }
}
