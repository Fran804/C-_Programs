namespace CalculadoraRPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDup = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnPor = new System.Windows.Forms.Button();
            this.btnMasMenos = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnEntre = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnInversa = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnXElevadoInversa = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtStack = new System.Windows.Forms.TextBox();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(32, 263);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDup
            // 
            this.btnDup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDup.Location = new System.Drawing.Point(109, 263);
            this.btnDup.Margin = new System.Windows.Forms.Padding(4);
            this.btnDup.Name = "btnDup";
            this.btnDup.Size = new System.Drawing.Size(69, 28);
            this.btnDup.TabIndex = 3;
            this.btnDup.Text = "DUP";
            this.btnDup.UseVisualStyleBackColor = false;
            this.btnDup.Click += new System.EventHandler(this.btnDup_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOff.Location = new System.Drawing.Point(188, 265);
            this.btnOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(301, 28);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "APAGAR";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSin.Location = new System.Drawing.Point(32, 299);
            this.btnSin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(69, 28);
            this.btnSin.TabIndex = 5;
            this.btnSin.Text = "SIN";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCos.Location = new System.Drawing.Point(109, 299);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(69, 28);
            this.btnCos.TabIndex = 6;
            this.btnCos.Text = "COS";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTan.Location = new System.Drawing.Point(187, 299);
            this.btnTan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(69, 28);
            this.btnTan.TabIndex = 7;
            this.btnTan.Text = "TAN";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(264, 299);
            this.btnMas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(69, 28);
            this.btnMas.TabIndex = 8;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(341, 299);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(32, 335);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 28);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(109, 335);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 28);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(187, 335);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 28);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(264, 335);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(69, 28);
            this.btnMenos.TabIndex = 13;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnPor
            // 
            this.btnPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPor.Location = new System.Drawing.Point(341, 335);
            this.btnPor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPor.Name = "btnPor";
            this.btnPor.Size = new System.Drawing.Size(69, 28);
            this.btnPor.TabIndex = 14;
            this.btnPor.Text = "*";
            this.btnPor.UseVisualStyleBackColor = true;
            this.btnPor.Click += new System.EventHandler(this.btnPor_Click);
            // 
            // btnMasMenos
            // 
            this.btnMasMenos.Location = new System.Drawing.Point(419, 335);
            this.btnMasMenos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasMenos.Name = "btnMasMenos";
            this.btnMasMenos.Size = new System.Drawing.Size(69, 28);
            this.btnMasMenos.TabIndex = 15;
            this.btnMasMenos.Text = "+/-";
            this.btnMasMenos.UseVisualStyleBackColor = true;
            this.btnMasMenos.Click += new System.EventHandler(this.btnMasMenos_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(32, 370);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 28);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(109, 370);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 28);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(187, 370);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 28);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnEntre
            // 
            this.btnEntre.Location = new System.Drawing.Point(264, 370);
            this.btnEntre.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntre.Name = "btnEntre";
            this.btnEntre.Size = new System.Drawing.Size(69, 28);
            this.btnEntre.TabIndex = 19;
            this.btnEntre.Text = "/";
            this.btnEntre.UseVisualStyleBackColor = true;
            this.btnEntre.Click += new System.EventHandler(this.btnEntre_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(341, 370);
            this.btnCuadrado.Margin = new System.Windows.Forms.Padding(4);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(69, 28);
            this.btnCuadrado.TabIndex = 20;
            this.btnCuadrado.Text = "x^2";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnInversa
            // 
            this.btnInversa.Location = new System.Drawing.Point(419, 370);
            this.btnInversa.Margin = new System.Windows.Forms.Padding(4);
            this.btnInversa.Name = "btnInversa";
            this.btnInversa.Size = new System.Drawing.Size(69, 28);
            this.btnInversa.TabIndex = 21;
            this.btnInversa.Text = "1/x";
            this.btnInversa.UseVisualStyleBackColor = true;
            this.btnInversa.Click += new System.EventHandler(this.btnInversa_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(32, 406);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 28);
            this.btn7.TabIndex = 22;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(109, 406);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 28);
            this.btn8.TabIndex = 23;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(187, 406);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 28);
            this.btn9.TabIndex = 24;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(264, 406);
            this.btnPow.Margin = new System.Windows.Forms.Padding(4);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(69, 28);
            this.btnPow.TabIndex = 25;
            this.btnPow.Text = "POW";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(341, 406);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(69, 28);
            this.btnSqrt.TabIndex = 26;
            this.btnSqrt.Text = "X^(1/2)";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnXElevadoInversa
            // 
            this.btnXElevadoInversa.Location = new System.Drawing.Point(419, 406);
            this.btnXElevadoInversa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXElevadoInversa.Name = "btnXElevadoInversa";
            this.btnXElevadoInversa.Size = new System.Drawing.Size(69, 28);
            this.btnXElevadoInversa.TabIndex = 27;
            this.btnXElevadoInversa.Text = "X^(1/y)";
            this.btnXElevadoInversa.UseVisualStyleBackColor = true;
            this.btnXElevadoInversa.Click += new System.EventHandler(this.btnXElevadoInversa_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(32, 442);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(69, 28);
            this.btnPunto.TabIndex = 28;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(109, 442);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(69, 28);
            this.btn0.TabIndex = 29;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(187, 442);
            this.btnSpace.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(69, 28);
            this.btnSpace.TabIndex = 30;
            this.btnSpace.Text = "SPACE";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEnter.Location = new System.Drawing.Point(264, 442);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(224, 28);
            this.btnEnter.TabIndex = 31;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtStack
            // 
            this.txtStack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtStack.Enabled = false;
            this.txtStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStack.Location = new System.Drawing.Point(32, 26);
            this.txtStack.Margin = new System.Windows.Forms.Padding(4);
            this.txtStack.Multiline = true;
            this.txtStack.Name = "txtStack";
            this.txtStack.ReadOnly = true;
            this.txtStack.Size = new System.Drawing.Size(455, 174);
            this.txtStack.TabIndex = 32;
            // 
            // txtDatos
            // 
            this.txtDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDatos.Enabled = false;
            this.txtDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(32, 208);
            this.txtDatos.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ReadOnly = true;
            this.txtDatos.Size = new System.Drawing.Size(455, 43);
            this.txtDatos.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(532, 511);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.txtStack);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnXElevadoInversa);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnInversa);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnEntre);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMasMenos);
            this.Controls.Add(this.btnPor);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnDup);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculadora RPN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDup;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnPor;
        private System.Windows.Forms.Button btnMasMenos;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnEntre;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnInversa;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnXElevadoInversa;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtStack;
        private System.Windows.Forms.TextBox txtDatos;
    }
}

