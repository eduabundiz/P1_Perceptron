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
        List<PlanePoint> planePoints = new List<PlanePoint>();
        Bitmap bmp;
        
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            createDashbord();
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

            Point clicked = new Point(e.X, e.Y);
            Point example = new Point();
                        
            if (e.Button == MouseButtons.Right)
            {
                g.FillEllipse(b1, e.X - 2, e.Y - 2, 10, 10);
            }
            else
            {
                g.FillEllipse(b2, e.X - 2, e.Y - 2, 10, 10);
            }

            //Instanciar el punto del plano con los valores dados
            PlanePoint planePoint = new PlanePoint( PointController.pixelsToPlane(clicked,bmp));            

            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
            planePoints.Add(planePoint);
            
            example = PointController.planeToPixels(planePoint.X,planePoint.Y, bmp);

            MessageBox.Show("(" + planePoint.X + "," + planePoint.Y + ")");

        }

        private void createDashbord()
        {
            Graphics g = Graphics.FromImage(bmp);
            Brush b1 = new SolidBrush(Color.Black);
            Pen p1 = new Pen(b1);

            g.DrawLine(p1, bmp.Width / 2, 0, bmp.Width / 2, bmp.Height);
            g.DrawLine(p1, 0, bmp.Height / 2,  bmp.Width, bmp.Height / 2);

            int segmWidth = bmp.Width / 10;
            int segmHeight = bmp.Height / 10;

            for(int i = 0; i < 10; i++)
            {
                if (i == 5) continue;
                g.DrawLine(p1, segmWidth * i, bmp.Height / 2 - 3, segmWidth * i, bmp.Height / 2 + 3);
                g.DrawLine(p1, bmp.Width / 2 - 3, segmHeight * i, bmp.Width / 2 + 3, segmHeight * i);
            }


            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }
    }
}
