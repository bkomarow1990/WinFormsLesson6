using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork2
{
    public partial class Form1 : Form
    {
        int number;
        public Form1()
        {
            InitializeComponent();
            number = new Random().Next(10);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int userNumber = int.Parse(textBox1.Text);
            if (userNumber == number)
            {
                errorProvider2.SetError(textBox1,"You have guessed number!!!");
                errorProvider1.SetError(textBox1,string.Empty);
                errorProvider1.Clear();
            }
            else if (number < userNumber )
            {
                errorProvider1.SetError(textBox1,$"My number is less than your");
            }
            else
            {
                errorProvider1.SetError(textBox1, "My number is greater than your");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(500);
            this.Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
