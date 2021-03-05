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
        List<double> w = new List<double>();
        List<double> x1 = new List<double>();
        List<double> x2 = new List<double>();
        double a;
        double b;
        int epocMax;
        Bitmap bmp;
        
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            createDashbord();
            a = 0.1;
            epocMax = 50;
            b = -0.5;
            x1.Add(-5);
            x1.Add(5);
            button2.Enabled = false;
        }

        //Inicializar el vector de pesos y mostrar la primera linea recta
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text != "")
            {
                epocMax = Convert.ToInt32(textBox2.Text);
            }
            w.Add(0.1);
            w.Add(0.2);

            x2.Add((-b - w[0] * x1[0]) / w[1]);
            x2.Add((-b - w[0] * x1[1]) / w[1]);

            //Dibujar primera linea con las coordenadas [x1[0],x2[0]],[x1[1],x2[1]]
            dibujarLinea(x1[0], x2[0], x1[1], x2[1]);

            button1.Enabled = false;
            button2.Enabled = true;
        }

        //Entrenar el perceptron
        private void button2_Click(object sender, EventArgs e)
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

        private void dibujarLinea(double x1, double y1, double x2, double y2)
        {
            // Create pen.
            Bitmap bmp2 = new Bitmap(bmp);
            Pen blackPen = new Pen(Color.Green, 2);
            Graphics g = Graphics.FromImage(bmp2);

            Point point1 = PointController.planeToPixels(x1, y1, bmp2);
            Point point2 = PointController.planeToPixels(x2, y2, bmp2);

            // Draw line to screen.
            g.DrawLine(blackPen, point1, point2);

            pictureBox1.Image = bmp2;
            pictureBox1.Refresh();

        }

        
    }
}
