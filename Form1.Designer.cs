
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(655, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "INICIALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Da click derecho o izquierdo en el siguiente plano para crear puntos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(89, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Factor de aprendizaje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(655, 198);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(655, 295);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 26);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número de épocas máximas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Da click al siguiente botón para inicializar el vector de pesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Da click al siguiente botón para entrenar el perceptrón";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(655, 496);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "PERCEPTRÓN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(398, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(411, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "IMPLEMENTACIÓN DEL PERCEPTRÓN";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelN.Location = new System.Drawing.Point(662, 588);
            this.labelN.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(85, 22);
            this.labelN.TabIndex = 14;
            this.labelN.Text = "N = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(662, 610);
            this.label8.MinimumSize = new System.Drawing.Size(85, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Actual NO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(662, 632);
            this.label9.MinimumSize = new System.Drawing.Size(85, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Actual SI";
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFN.Location = new System.Drawing.Point(744, 632);
            this.labelFN.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(85, 22);
            this.labelFN.TabIndex = 19;
            this.labelFN.Text = "FN = ";
            // 
            // labelTN
            // 
            this.labelTN.AutoSize = true;
            this.labelTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTN.Location = new System.Drawing.Point(744, 610);
            this.labelTN.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelTN.Name = "labelTN";
            this.labelTN.Size = new System.Drawing.Size(85, 22);
            this.labelTN.TabIndex = 18;
            this.labelTN.Text = "TN =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(744, 588);
            this.label12.MinimumSize = new System.Drawing.Size(85, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 22);
            this.label12.TabIndex = 17;
            this.label12.Text = "Predijo NO";
            // 
            // labelTotalPredNo
            // 
            this.labelTotalPredNo.AutoSize = true;
            this.labelTotalPredNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPredNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalPredNo.Location = new System.Drawing.Point(744, 654);
            this.labelTotalPredNo.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelTotalPredNo.Name = "labelTotalPredNo";
            this.labelTotalPredNo.Size = new System.Drawing.Size(85, 22);
            this.labelTotalPredNo.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(662, 654);
            this.label14.MinimumSize = new System.Drawing.Size(85, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 22);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total:";
            // 
            // labelTotalPredSi
            // 
            this.labelTotalPredSi.AutoSize = true;
            this.labelTotalPredSi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPredSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalPredSi.Location = new System.Drawing.Point(826, 654);
            this.labelTotalPredSi.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelTotalPredSi.Name = "labelTotalPredSi";
            this.labelTotalPredSi.Size = new System.Drawing.Size(85, 22);
            this.labelTotalPredSi.TabIndex = 25;
            // 
            // labelTP
            // 
            this.labelTP.AutoSize = true;
            this.labelTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTP.Location = new System.Drawing.Point(826, 632);
            this.labelTP.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelTP.Name = "labelTP";
            this.labelTP.Size = new System.Drawing.Size(85, 22);
            this.labelTP.TabIndex = 24;
            this.labelTP.Text = "TP = ";
            // 
            // labelFP
            // 
            this.labelFP.AutoSize = true;
            this.labelFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFP.Location = new System.Drawing.Point(826, 610);
            this.labelFP.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelFP.Name = "labelFP";
            this.labelFP.Size = new System.Drawing.Size(85, 22);
            this.labelFP.TabIndex = 23;
            this.labelFP.Text = "FP =";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Location = new System.Drawing.Point(826, 588);
            this.label18.MinimumSize = new System.Drawing.Size(85, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 22);
            this.label18.TabIndex = 22;
            this.label18.Text = "Predijo SI";
            // 
            // labelTotalTotal
            // 
            this.labelTotalTotal.AutoSize = true;
            this.labelTotalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalTotal.Location = new System.Drawing.Point(904, 654);
            this.labelTotalTotal.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelTotalTotal.Name = "labelTotalTotal";
            this.labelTotalTotal.Size = new System.Drawing.Size(85, 22);
            this.labelTotalTotal.TabIndex = 29;
            // 
            // labelTotalActSI
            // 
            this.labelTotalActSI.AutoSize = true;
            this.labelTotalActSI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalActSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalActSI.Location = new System.Drawing.Point(904, 632);
            this.labelTotalActSI.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelTotalActSI.Name = "labelTotalActSI";
            this.labelTotalActSI.Size = new System.Drawing.Size(85, 22);
            this.labelTotalActSI.TabIndex = 28;
            // 
            // labelTotalActNo
            // 
            this.labelTotalActNo.AutoSize = true;
            this.labelTotalActNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalActNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalActNo.Location = new System.Drawing.Point(904, 610);
            this.labelTotalActNo.MinimumSize = new System.Drawing.Size(85, 20);
            this.labelTotalActNo.Name = "labelTotalActNo";
            this.labelTotalActNo.Size = new System.Drawing.Size(85, 22);
            this.labelTotalActNo.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Location = new System.Drawing.Point(904, 588);
            this.label22.MinimumSize = new System.Drawing.Size(85, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 22);
            this.label22.TabIndex = 26;
            this.label22.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1699, 710);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Actividad 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

