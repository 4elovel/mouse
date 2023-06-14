using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseMove += Form1_MouseMove;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;
            label1.Text = "Координати миші: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }
    }
}
