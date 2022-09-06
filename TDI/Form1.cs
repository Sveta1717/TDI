using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pn = new Pen(Brushes.White, 50);             
            pn.DashStyle = DashStyle.Solid; 
            g.DrawEllipse(pn, 100, 100, 500, 500);
            g.FillEllipse(Brushes.Red, 100,100,500,500);
            Rectangle rect = new Rectangle(200, 300, 300, 90);
            g.FillRectangle(Brushes.White, rect);
        }
    }
}
