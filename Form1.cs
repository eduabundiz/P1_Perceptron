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
using System.Threading;

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
        List<int> Y = new List<int>();
        double a;
        int epocMax;
        double errorDeseado;
        Bitmap bmp;
        Bitmap bmp2;
        Bitmap bmpLocal;
        bool done;

        int bicolor;
        Pen blackPen;
        Pen blackPen2;

        List<Brush> b = new List<Brush>();
        int hiddenLayers;
        int clases;
        List<int> neuronasPorCapa = new List<int>();
        List<double[,]> pesos;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            createDashbord();
            a = 0.1;
            errorDeseado = 0.001;
            epocMax = 500;
            x1.Add(-5);
            x1.Add(5);
            button2.Enabled = false;
            button6.Enabled = false;
            bicolor = 0;
            blackPen = new Pen(Color.Blue, 2);
            blackPen2 = new Pen(Color.Red, 2);
            
        }

        //Inicializar el vector de pesos y mostrar la primera linea recta
        private void button1_Click(object sender, EventArgs e)
        {
            w.Clear();
            x2.Clear();
            bmp2 = new Bitmap(bmp);
            bmpLocal = new Bitmap(bmp2);

            if (textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text != "")
            {
                epocMax = Convert.ToInt32(textBox2.Text);
            }
            if (textBox3.Text != "")
            {
                errorDeseado = Convert.ToDouble(textBox3.Text);
            }

            //Generar vector de pesos de forma aleatoria

            pesos = new List<double[,]>();

            for (int i=0;i<hiddenLayers;i++)
            {
                double[,] matriz = new double[neuronasPorCapa[i], 3];
                pesos.Add(matriz);
            }

            double[,] matriz2 = new double[clases, 3];
            pesos.Add(matriz2);
            neuronasPorCapa.Add(clases);

            Random rnd = new Random();
            Random rnd2 = new Random();

            for(int i=0; i<pesos.Count; i++)
            {
                for(int j=0; j<neuronasPorCapa[i]; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        int numRan = rnd2.Next();
                        if(numRan%2==0)
                        {
                            pesos[i][j, k] = rnd.NextDouble();
                        }
                        else
                        {
                            pesos[i][j, k] = rnd.NextDouble()*-1;
                        }
                        
                    }
                }
            }

            //Dibujar variedades lineales que corresponden a los pesos de la primera capa oculta

            x2.Add(0);
            x2.Add(0);

            for (int i = 0; i < neuronasPorCapa[0]; i++)
            {
                x2[0] = (-pesos[0][i, 1] * x1[0] + pesos[0][i, 0]) / pesos[0][i, 2];
                x2[1] = (-pesos[0][i, 1] * x1[1] + pesos[0][i, 0]) / pesos[0][i, 2];
                //Dibujar primera linea con las coordenadas [x1[0],x2[0]],[x1[1],x2[1]]
                dibujarLinea(x1[0], x2[0], x1[1], x2[1]);
            }

            button2.Enabled = true;
        }

        //Entrenar el perceptron
        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            double error;
            double errorAcum = 0;
            done = false;
            while (errorDeseado > errorAcum || cont<epocMax)
            {
                errorAcum = 0;
                for (int i = 0; i < planePoints.Count(); i++)
                {
                    x2[0] = (-w[1] * x1[0] + w[0]) / w[2];
                    x2[1] = (-w[1] * x1[1] + w[0]) / w[2];
                    dibujarLinea(x1[0], x2[0], x1[1], x2[1]);

                    error = Y[i] - sigmoide(multWX(w,planePoints[i]));
                    errorAcum += Math.Pow(error,2);
                    w[0] = w[0] + 2*a * error * sigmoide(multWX(w, planePoints[i]))*(1- sigmoide(multWX(w, planePoints[i])))*-1;
                    w[1] = w[1] + 2 * a * error * sigmoide(multWX(w, planePoints[i])) * (1 - sigmoide(multWX(w, planePoints[i]))) * planePoints[i].X;
                    w[2] = w[2] + 2 * a * error * sigmoide(multWX(w, planePoints[i])) * (1 - sigmoide(multWX(w, planePoints[i]))) * planePoints[i].Y;
                }
                errorAcum = errorAcum / planePoints.Count();


                //graficar error cuadrático **********MEMO AQUI VA LA GRAFICA SEGUN NOSOTROS :)****************


                Thread.Sleep(50);


                if (errorDeseado>errorAcum)
                {
                    break;
                }
                cont++;
                if(cont==epocMax)
                {
                    break;
                }
            }
            x2[0] = (-w[1] * x1[0] + w[0]) / w[2];
            x2[1] = (-w[1] * x1[1] + w[0]) / w[2];
            dibujarLinea(x1[0], x2[0], x1[1], x2[1]);
            if (cont < epocMax)
            {
                done = true;
            }

            if (done)
            {
                MessageBox.Show("Terminó en la época: " + cont.ToString());
                bmp = bmp2;
            }
            else if (cont >= epocMax)
            {
                MessageBox.Show("Llegó a las épocas máximas: " + cont.ToString());
            }

        }

        private double multWX(List<double> pesos, PlanePoint punto)
        {
            return pesos[0] * -1 + pesos[1] * punto.X + pesos[2] * punto.Y;
        } 

        private double sigmoide(double wx)
        {
            double calculo;
            calculo = 1 / (1 + Math.Pow(Math.E, -wx));
            return calculo; 
        }

        private void evaluarPunto(Point p)
        {
            Graphics g = Graphics.FromImage(bmpLocal);
            Brush b1 = new SolidBrush(Color.Brown);
            Brush b2 = new SolidBrush(Color.Coral);
            double calculo = 0;
            PlanePoint planePoint = new PlanePoint(PointController.pixelsToPlane(p, bmpLocal));
            calculo = (w[0] * -1 + w[1] * planePoint.X + w[2] * planePoint.Y);
            if (calculo > 0)
                g.FillEllipse(b1, p.X - 6, p.Y - 6, 10, 10);
            else
                g.FillEllipse(b2, p.X - 6, p.Y - 6, 10, 10);

            pictureBox1.Image = bmpLocal;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(e.Location);
            Graphics g = Graphics.FromImage(bmp);
            Brush b1 = new SolidBrush(Color.Brown);
            Brush b2 = new SolidBrush(Color.Coral);

            Point clicked = new Point(e.X, e.Y);
            Point example = new Point();

            if (done)
            {
                //Evaluar punto de prueba una vez que el perceptron ya esta entrenado
                evaluarPunto(clicked);
                return;

            }
            
            g.FillEllipse(b[comboBox2.SelectedIndex], e.X - 6, e.Y - 6, 10, 10);
            Y.Add(comboBox2.SelectedIndex);

            //Instanciar el punto del plano con los valores dados
            PlanePoint planePoint = new PlanePoint(PointController.pixelsToPlane(clicked, bmp));

            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
            planePoints.Add(planePoint);

        }

        private void createDashbord()
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    bmp.SetPixel(j, i, Color.White);
                }
            }
            Graphics g = Graphics.FromImage(bmp);
            Brush b1 = new SolidBrush(Color.Black);
            Pen p1 = new Pen(b1);

            g.DrawLine(p1, bmp.Width / 2, 0, bmp.Width / 2, bmp.Height);
            g.DrawLine(p1, 0, bmp.Height / 2, bmp.Width, bmp.Height / 2);

            int segmWidth = bmp.Width / 10;
            int segmHeight = bmp.Height / 10;

            for (int i = 0; i < 10; i++)
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
            try
            {
                // Create pen.
                
                Graphics g = Graphics.FromImage(bmp2);

                Point point1 = PointController.planeToPixels(x1, y1, bmp2);
                Point point2 = PointController.planeToPixels(x2, y2, bmp2);

                // Draw line to screen.
                if (bicolor == 0) 
                { 
                    g.DrawLine(blackPen, point1, point2); 
                    bicolor = 1; 
                }
                else 
                { 
                    g.DrawLine(blackPen2, point1, point2); 
                    bicolor = 0; 
                }

                pictureBox1.Image = bmp2;
                pictureBox1.Refresh();

                //Thread.Sleep(200);
            }
            catch
            {
                if (x1 < 0) x1 = 0;
                if (x2 < 0) x2 = 0;
                if (y1 < 0) y1 = 0;
                if (y2 < 0) y2 = 0;
                dibujarLinea(x1, y1, x2, y2);
            }


        }

        //Pintar mitades de bitmap
        private void pintarMitades()
        {
            
            double calculo = 0;
            for (int i=0; i<bmpLocal.Height;i++)
            {
                for (int j=0; j<bmpLocal.Width;j++)
                {
                    Color c = bmpLocal.GetPixel(j, i);
                    if (c.R == 255)
                    {
                        if(c.G == 255)
                        {
                            if(c.B == 255)
                            {
                                PlanePoint convertir = PointController.pixelsToPlane(j, i, bmp);
                                calculo = sigmoide(multWX(w, convertir));
                                if (calculo >= 0.5)
                                {
                                    
                                    Color nuevo = new Color();
                                    nuevo = Color.Orange;
                                    double x = Math.Round(calculo * 255);
                                    int xI = Convert.ToInt32(x);
                                    Color newColor = Color.FromArgb( xI, nuevo.R, nuevo.G,nuevo.B);
                                    bmpLocal.SetPixel(j, i, newColor);


                                }
                                else
                                {
                                    Color nuevo = new Color();
                                    nuevo = Color.Purple;
                                    double x = Math.Round(calculo * 255);
                                    int xI = Convert.ToInt32(x);
                                    xI = Math.Abs(255 - xI);
                                    Color newColor = Color.FromArgb(xI, nuevo.R, nuevo.G, nuevo.B);
                                    bmpLocal.SetPixel(j, i, newColor);
                                }
                            }
                        }
                    }
                }
            }
            pictureBox1.Image = bmpLocal;
            pictureBox1.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            points.Clear();
            planePoints.Clear();
            w.Clear();
            x1.Clear();
            x2.Clear();
            Y.Clear();            

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Refresh();
            createDashbord();
            x1.Add(-5);
            x1.Add(5);
            button1.Enabled = true;
            button2.Enabled = false;
            done = false;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            b.Clear();
            if (textBox6.Text != "")
            {
                clases = Convert.ToInt32(textBox6.Text);

                for (int i = 0; i < clases; i++)
                {
                    Random r = new Random(50+i);
                    Color bc = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
                    Brush bru = new SolidBrush(bc);
                    b.Add(bru);
                    comboBox2.Items.Add("Clase " + i);

                }
                comboBox2.SelectedIndex=0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hiddenLayers = Convert.ToInt32(numericUpDown2.Value);

            neuronasPorCapa.Clear();
            for(int i=0; i < hiddenLayers; i++)
            {
                neuronasPorCapa.Add(0);
            }

            button6.Enabled = true;
            numericUpDown1.Maximum = hiddenLayers;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            neuronasPorCapa[Convert.ToInt32(numericUpDown1.Value) - 1] = Convert.ToInt32(textBox5.Text);
            listBox1.Items.Add("Capa "+ numericUpDown1.Value+" Neuronas "+ neuronasPorCapa[Convert.ToInt32(numericUpDown1.Value) - 1]);
        }
    }
}
