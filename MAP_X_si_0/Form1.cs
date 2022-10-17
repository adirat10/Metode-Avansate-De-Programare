using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP_X_si_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[,] buttons;
        int n = 3;
        bool IsPlayerX = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (buttons == null)
            {
                buttons = new Button[n, n];
                int size = pictureBox1.Width / 3;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        Button button = new Button();
                        button.Parent = pictureBox1;
                        button.Size = new Size(size, size);
                        button.Location = new Point(i * size, j * size);
                        button.Font = new Font("Comic Sans", 30);
                        button.Click += gridButton_Click;

                        buttons[i, j] = button;
                    }
            }
            else
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        buttons[i, j].Enabled = true;
                        buttons[i, j].Text = "";
                    }
                IsPlayerX = true;
            }
        }
        private void gridButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (IsPlayerX)
            {
                button.Text = "X";
                button.Enabled = false;
            }
            else
            {
                button.Text = "O";
                button.Enabled = false;
            }
            if (CheckGameWon())
            {
                int player = IsPlayerX ? 1 : 2;
                MessageBox.Show($"Player {player} has won", "Game Over");
            }
            else if (CheckGameOver())
                MessageBox.Show("Remiza", "Game Over");

            IsPlayerX = !IsPlayerX;
        }

        bool CheckGameOver()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (buttons[i, j].Enabled)
                        return false;
                }
            return true;
        }

        bool CheckGameWon()
        {
            int sumaX, sumaO;
            for (int i = 0; i < n; i++)
            {
                // verificare pe linii

                sumaX = 0;
                sumaO = 0;
                for (int j = 0; j < n; j++)
                {
                    if (buttons[i, j].Text == "X")
                        sumaX++;
                    else if (buttons[i, j].Text == "O")
                        sumaO++;
                }
                if (sumaX == 3 || sumaO == 3)
                    return true;

                // verificare pe coloane

                sumaX = 0;
                sumaO = 0;
                for (int j = 0; j < n; j++)
                {
                    if (buttons[j, i].Text == "X")
                        sumaX++;
                    else if (buttons[j, i].Text == "O")
                        sumaO++;
                }
                if (sumaX == 3 || sumaO == 3)
                    return true;
            }
            // verificare pe diagonala principala

            sumaX = 0;
            sumaO = 0;
            for (int i = 0; i < n; i++)
            {
                if (buttons[i, i].Text == "X")
                    sumaX++;
                else if (buttons[i, i].Text == "O")
                    sumaO++;
            }
            if (sumaX == 3 || sumaO == 3)
                return true;

            // verificare pe diagonala secundara
            sumaX = 0;
            sumaO = 0;
            for (int i = 0; i < n; i++)
            {
                if (buttons[i, n - i - 1].Text == "X")
                    sumaX++;
                else if (buttons[i, n - i - 1].Text == "O")
                    sumaO++;
            }
            if (sumaX == 3 || sumaO == 3)
                return true;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
