using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLesson6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clarBtn_Click(object sender, EventArgs e)
        {
            this.infoLbl.Text = string.Empty;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            infoLbl.Text = $"KeyDown {e.KeyCode}\t Alt: {e.Alt}\t Shift: {e.Shift} \t Ctrl: {e.Control}";
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                MessageBox.Show("!!!","Exit?",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            infoLbl.Text = $"KeyPress {e.KeyChar}\t  with code {(uint)e.KeyChar}";

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            infoLbl.Text = $"KeyUp  {e.KeyCode}\t Alt: {e.Alt}\t Shift: {e.Shift} \t Ctrl: {e.Control}";
        }
    }
}
