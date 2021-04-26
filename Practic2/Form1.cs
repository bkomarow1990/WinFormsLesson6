using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                if (this.player.Left >= this.Width - this.player.Height - 60)
                {
                    return;
                }
                if (e.Alt)
                {
                    this.player.Left += 55;
                }
                else
                {
                    this.player.Left += 5;
                }
                
            }
            else if (e.KeyCode == Keys.A)
            {
                if (this.player.Left <= 0)
                {
                    return;
                }
                if (e.Alt)
                {
                    this.player.Left -= 55;
                }
                else
                {
                    this.player.Left -= 5;

                }
                


            }
            else if (e.KeyCode == Keys.Add)
            {
                this.player.Width += 15;
                this.player.Height += 15;
             }
            else if (e.KeyCode == Keys.Subtract)
            {
                this.player.Width -= 15;
                this.player.Height -= 15;
            }
            else if (e.KeyCode == Keys.Home)
            {
                this.player.Left = this.Width-this.player.Width-50;
                this.player.Top = this.Height-this.player.Height-50;
            }
            else if (e.KeyCode == Keys.End)
            {
                this.player.Left = 0;
                this.player.Top = this.Height-this.player.Height-50;
            }
            else if (e.KeyCode == Keys.W)
            {
                if (this.player.Top <= this.player.Height-100)
                {
                    return;
                }
                if (e.Alt)
                {
                    this.player.Top -= 55;
                }
                else
                {
                    this.player.Top-= 5;

                }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (this.player.Top >= 250)
                {
                    return;
                }
                if (e.Alt)
                {
                    this.player.Top += 55;
                }
                else
                {
                    this.player.Top += 5;

                }
            }

        }
    }
}
