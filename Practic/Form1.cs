using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            icon = new Icon("../../../Images/flower_nature_icon_186016.ico", new Size(size,size));
        }
        int size = 64;
        Icon icon;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawEllipse(Pens.Red, 400, 300, 200, 150);
            //e.Graphics.DrawEllipse(Pens.Purple, 350, 50, 100, 300);
            //e.Graphics.DrawEllipse(Pens.Red, 200, 300, 200, 150);
            e.Graphics.DrawIcon(icon,new Rectangle(0,0,size,size));
        }
    }
}
