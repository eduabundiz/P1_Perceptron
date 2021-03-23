
namespace P1_Perceptron
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelFN = new System.Windows.Forms.Label();
            this.labelTN = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTotalPredNo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTotalPredSi = new System.Windows.Forms.Label();
            this.labelTP = new System.Windows.Forms.Label();
            this.labelFP = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelTotalTotal = new System.Windows.Forms.Label();
            this.labelTotalActSI = new System.Windows.Forms.Label();
            this.labelTotalActNo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(436, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "INICIALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Da click derecho o izquierdo en el siguiente plano para crear puntos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(42, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 325);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Factor de aprendizaje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(436, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(436, 172);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número de épocas máximas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Click Para Inicializar Pesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Click Para Iniciar Adaline";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(439, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "ADALINE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(266, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "IMPLEMENTACIÓN DEL ADALINE";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelN.Location = new System.Drawing.Point(419, 401);
            this.labelN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelN.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(58, 15);
            this.labelN.TabIndex = 14;
            this.labelN.Text = "N = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(419, 416);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.MinimumSize = new System.Drawing.Size(58, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Actual NO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(419, 431);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.MinimumSize = new System.Drawing.Size(58, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Actual SI";
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFN.Location = new System.Drawing.Point(474, 431);
            this.labelFN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFN.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(58, 15);
            this.labelFN.TabIndex = 19;
            this.labelFN.Text = "FN = ";
            // 
            // labelTN
            // 
            this.labelTN.AutoSize = true;
            this.labelTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTN.Location = new System.Drawing.Point(474, 416);
            this.labelTN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTN.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelTN.Name = "labelTN";
            this.labelTN.Size = new System.Drawing.Size(58, 15);
            this.labelTN.TabIndex = 18;
            this.labelTN.Text = "TN =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(474, 401);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.MinimumSize = new System.Drawing.Size(58, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Predijo NO";
            // 
            // labelTotalPredNo
            // 
            this.labelTotalPredNo.AutoSize = true;
            this.labelTotalPredNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPredNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalPredNo.Location = new System.Drawing.Point(474, 444);
            this.labelTotalPredNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPredNo.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelTotalPredNo.Name = "labelTotalPredNo";
            this.labelTotalPredNo.Size = new System.Drawing.Size(58, 15);
            this.labelTotalPredNo.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(419, 444);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.MinimumSize = new System.Drawing.Size(58, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total:";
            // 
            // labelTotalPredSi
            // 
            this.labelTotalPredSi.AutoSize = true;
            this.labelTotalPredSi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPredSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalPredSi.Location = new System.Drawing.Point(528, 444);
            this.labelTotalPredSi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPredSi.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelTotalPredSi.Name = "labelTotalPredSi";
            this.labelTotalPredSi.Size = new System.Drawing.Size(58, 15);
            this.labelTotalPredSi.TabIndex = 25;
            // 
            // labelTP
            // 
            this.labelTP.AutoSize = true;
            this.labelTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTP.Location = new System.Drawing.Point(528, 431);
            this.labelTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTP.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelTP.Name = "labelTP";
            this.labelTP.Size = new System.Drawing.Size(58, 15);
            this.labelTP.TabIndex = 24;
            this.labelTP.Text = "TP = ";
            // 
            // labelFP
            // 
            this.labelFP.AutoSize = true;
            this.labelFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFP.Location = new System.Drawing.Point(528, 416);
            this.labelFP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFP.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelFP.Name = "labelFP";
            this.labelFP.Size = new System.Drawing.Size(58, 15);
            this.labelFP.TabIndex = 23;
            this.labelFP.Text = "FP =";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Location = new System.Drawing.Point(528, 401);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.MinimumSize = new System.Drawing.Size(58, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 15);
            this.label18.TabIndex = 22;
            this.label18.Text = "Predijo SI";
            // 
            // labelTotalTotal
            // 
            this.labelTotalTotal.AutoSize = true;
            this.labelTotalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalTotal.Location = new System.Drawing.Point(581, 444);
            this.labelTotalTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalTotal.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelTotalTotal.Name = "labelTotalTotal";
            this.labelTotalTotal.Size = new System.Drawing.Size(58, 15);
            this.labelTotalTotal.TabIndex = 29;
            // 
            // labelTotalActSI
            // 
            this.labelTotalActSI.AutoSize = true;
            this.labelTotalActSI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalActSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalActSI.Location = new System.Drawing.Point(581, 431);
            this.labelTotalActSI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalActSI.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelTotalActSI.Name = "labelTotalActSI";
            this.labelTotalActSI.Size = new System.Drawing.Size(58, 15);
            this.labelTotalActSI.TabIndex = 28;
            // 
            // labelTotalActNo
            // 
            this.labelTotalActNo.AutoSize = true;
            this.labelTotalActNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalActNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalActNo.Location = new System.Drawing.Point(581, 416);
            this.labelTotalActNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalActNo.MinimumSize = new System.Drawing.Size(58, 13);
            this.labelTotalActNo.Name = "labelTotalActNo";
            this.labelTotalActNo.Size = new System.Drawing.Size(58, 15);
            this.labelTotalActNo.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Location = new System.Drawing.Point(581, 401);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.MinimumSize = new System.Drawing.Size(58, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 15);
            this.label22.TabIndex = 26;
            this.label22.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(437, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 14);
            this.label10.TabIndex = 30;
            this.label10.Text = "Error mímino deseado";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(436, 228);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 20);
            this.textBox3.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(162, 411);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 35);
            this.button3.TabIndex = 32;
            this.button3.Text = "REINICIAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 525);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.CustomProperties = "LabelStyle=Top";
            series1.LabelBackColor = System.Drawing.Color.YellowGreen;
            series1.LabelBorderColor = System.Drawing.Color.Green;
            series1.LabelBorderWidth = 3;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Green;
            series1.MarkerColor = System.Drawing.Color.Green;
            series1.MarkerSize = 10;
            series1.MarkerStep = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = " ";
            series1.ShadowColor = System.Drawing.Color.White;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(659, 168);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SlateGray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(228, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "Error Acumulado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(659, 693);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelTotalTotal);
            this.Controls.Add(this.labelTotalActSI);
            this.Controls.Add(this.labelTotalActNo);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.labelTotalPredSi);
            this.Controls.Add(this.labelTP);
            this.Controls.Add(this.labelFP);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelTotalPredNo);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.labelTN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Actividad 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelTN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelTotalPredNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTotalPredSi;
        private System.Windows.Forms.Label labelTP;
        private System.Windows.Forms.Label labelFP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelTotalTotal;
        private System.Windows.Forms.Label labelTotalActSI;
        private System.Windows.Forms.Label labelTotalActNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label11;
    }
}

