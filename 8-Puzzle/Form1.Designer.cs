namespace _8_Puzzle
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnF9 = new System.Windows.Forms.Button();
            this.btnF8 = new System.Windows.Forms.Button();
            this.btnF7 = new System.Windows.Forms.Button();
            this.btnF6 = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnF4 = new System.Windows.Forms.Button();
            this.btnF3 = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCont = new System.Windows.Forms.Label();
            this.btnF1 = new System.Windows.Forms.Button();
            this.btnRst = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnRevolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulación 8-Puzzle con Búsqueda Ciega";
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btn1.Location = new System.Drawing.Point(45, 66);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "2";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.UseWaitCursor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btn2.Location = new System.Drawing.Point(151, 66);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "8";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.UseWaitCursor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btn3.Location = new System.Drawing.Point(257, 66);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.UseWaitCursor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btn6.Location = new System.Drawing.Point(257, 172);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "4";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.UseWaitCursor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btn5.Location = new System.Drawing.Point(151, 172);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "6";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.UseWaitCursor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btn4.Location = new System.Drawing.Point(45, 172);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "1";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.UseWaitCursor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btn9.Location = new System.Drawing.Point(257, 278);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 100);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "5";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.UseWaitCursor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btn8.Location = new System.Drawing.Point(151, 278);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.UseWaitCursor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btn7.Location = new System.Drawing.Point(45, 278);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.UseWaitCursor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnF9
            // 
            this.btnF9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnF9.Location = new System.Drawing.Point(660, 278);
            this.btnF9.Name = "btnF9";
            this.btnF9.Size = new System.Drawing.Size(100, 100);
            this.btnF9.TabIndex = 18;
            this.btnF9.Text = "5";
            this.btnF9.UseVisualStyleBackColor = true;
            this.btnF9.UseWaitCursor = true;
            // 
            // btnF8
            // 
            this.btnF8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnF8.Location = new System.Drawing.Point(554, 278);
            this.btnF8.Name = "btnF8";
            this.btnF8.Size = new System.Drawing.Size(100, 100);
            this.btnF8.TabIndex = 17;
            this.btnF8.Text = "6";
            this.btnF8.UseVisualStyleBackColor = true;
            this.btnF8.UseWaitCursor = true;
            // 
            // btnF7
            // 
            this.btnF7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnF7.Location = new System.Drawing.Point(448, 278);
            this.btnF7.Name = "btnF7";
            this.btnF7.Size = new System.Drawing.Size(100, 100);
            this.btnF7.TabIndex = 16;
            this.btnF7.Text = "7";
            this.btnF7.UseVisualStyleBackColor = true;
            this.btnF7.UseWaitCursor = true;
            // 
            // btnF6
            // 
            this.btnF6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnF6.Location = new System.Drawing.Point(660, 172);
            this.btnF6.Name = "btnF6";
            this.btnF6.Size = new System.Drawing.Size(100, 100);
            this.btnF6.TabIndex = 15;
            this.btnF6.Text = "4";
            this.btnF6.UseVisualStyleBackColor = true;
            this.btnF6.UseWaitCursor = true;
            // 
            // btnF5
            // 
            this.btnF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnF5.Location = new System.Drawing.Point(554, 172);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(100, 100);
            this.btnF5.TabIndex = 14;
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.UseWaitCursor = true;
            // 
            // btnF4
            // 
            this.btnF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnF4.Location = new System.Drawing.Point(448, 172);
            this.btnF4.Name = "btnF4";
            this.btnF4.Size = new System.Drawing.Size(100, 100);
            this.btnF4.TabIndex = 13;
            this.btnF4.Text = "8";
            this.btnF4.UseVisualStyleBackColor = true;
            this.btnF4.UseWaitCursor = true;
            // 
            // btnF3
            // 
            this.btnF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnF3.Location = new System.Drawing.Point(660, 66);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(100, 100);
            this.btnF3.TabIndex = 12;
            this.btnF3.Text = "3";
            this.btnF3.UseVisualStyleBackColor = true;
            this.btnF3.UseWaitCursor = true;
            // 
            // btnF2
            // 
            this.btnF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnF2.Location = new System.Drawing.Point(554, 66);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(100, 100);
            this.btnF2.TabIndex = 11;
            this.btnF2.Text = "2";
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(138, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Estado Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(537, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado Final";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(390, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Movimientos Realizados:";
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCont.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCont.Location = new System.Drawing.Point(625, 482);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(23, 25);
            this.lblCont.TabIndex = 22;
            this.lblCont.Text = "0";
            this.lblCont.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnF1
            // 
            this.btnF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnF1.Location = new System.Drawing.Point(448, 66);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(100, 100);
            this.btnF1.TabIndex = 23;
            this.btnF1.Text = "1";
            this.btnF1.UseVisualStyleBackColor = true;
            this.btnF1.UseWaitCursor = true;
            // 
            // btnRst
            // 
            this.btnRst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRst.Location = new System.Drawing.Point(114, 454);
            this.btnRst.Name = "btnRst";
            this.btnRst.Size = new System.Drawing.Size(203, 39);
            this.btnRst.TabIndex = 24;
            this.btnRst.Text = "Resetear";
            this.btnRst.UseVisualStyleBackColor = true;
            this.btnRst.Click += new System.EventHandler(this.btnrst_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAsignar.Location = new System.Drawing.Point(114, 503);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(203, 39);
            this.btnAsignar.TabIndex = 25;
            this.btnAsignar.Text = "Reasignar Botones";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnRevolver
            // 
            this.btnRevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRevolver.Location = new System.Drawing.Point(114, 553);
            this.btnRevolver.Name = "btnRevolver";
            this.btnRevolver.Size = new System.Drawing.Size(203, 39);
            this.btnRevolver.TabIndex = 26;
            this.btnRevolver.Text = "Revolver";
            this.btnRevolver.UseVisualStyleBackColor = true;
            this.btnRevolver.Click += new System.EventHandler(this.btnRevolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.btnRevolver);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnRst);
            this.Controls.Add(this.btnF1);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnF9);
            this.Controls.Add(this.btnF8);
            this.Controls.Add(this.btnF7);
            this.Controls.Add(this.btnF6);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.btnF4);
            this.Controls.Add(this.btnF3);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Agente de Búsqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnF9;
        private System.Windows.Forms.Button btnF8;
        private System.Windows.Forms.Button btnF7;
        private System.Windows.Forms.Button btnF6;
        private System.Windows.Forms.Button btnF5;
        private System.Windows.Forms.Button btnF4;
        private System.Windows.Forms.Button btnF3;
        private System.Windows.Forms.Button btnF2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Button btnF1;
        private System.Windows.Forms.Button btnRst;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnRevolver;
    }
}

