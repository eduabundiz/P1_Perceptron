using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Perceptron
{
    public partial class Form1 : Form
    {

        int cont = 0;
        List<Point> points = new List<Point>();
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(e.Location);
            Graphics g = Graphics.FromImage(bmp);
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Blue);

            if (e.Button == MouseButtons.Right)
            {
                g.FillEllipse(b1, e.X - 2, e.Y - 2, 10, 10);
            }
            else
            {
                g.FillEllipse(b2, e.X - 2, e.Y - 2, 10, 10);
            }

            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }
    }
}
