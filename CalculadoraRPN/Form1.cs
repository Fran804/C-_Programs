using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTSLib;

namespace CalculadoraRPN
{
    public partial class Form1 : Form
    {
        ArrayStack<double> stack = new ArrayStack<double>(50);
        public Form1()
        {
            InitializeComponent();
        }
        private void recorrerStack()
        {
            int largoStack = stack.Size;
            txtStack.Text = "";
            for (int i = 0; i < largoStack; i++)
            {
                txtStack.Text += $"{stack.Size - i}: {stack[i]}\r\n";
            }
        }

        public void añadirSinEspaciosStack()
        {
            string[] datosT;
            datosT = txtDatos.Text.Split();

            for (int i = 0; i < datosT.Length; i++)
            {
                stack.Push(Convert.ToDouble(datosT[i])); 
            }
        }

        public void borrarStack()
        {
            int largoStack = stack.Size;
            for (int i = 0; i < largoStack; i++)
            {
                stack.Pop();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes" || txtDatos.Text == "")
            {
                return;
            }
            añadirSinEspaciosStack();
            recorrerStack();
            txtDatos.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn6.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn7.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn8.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn9.Text;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btnPunto.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text += btn0.Text;
            }
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtDatos.Text += " ";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 2)
            {
                double num1 = stack.Pop();
                double num2 = stack.Pop();
                double sum = num1 + num2;
                stack.Push(sum);
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 2)
            {
                double num2 = stack.Pop();
                double num1 = stack.Pop();
                double resta = num1 - num2;
                stack.Push(resta);
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 2)
            {
                double num1 = stack.Pop();
                double num2 = stack.Pop();
                double multi = num1 * num2;
                stack.Push(multi);
                recorrerStack();
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnEntre_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 2)
            {
                double num2 = stack.Pop();
                double num1 = stack.Pop();
                double entre = num1 / num2;
                stack.Push(entre);
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text != "" || stack.IsEmpty())
            {
                return;
            }
            else
            {
                borrarStack();
            }
            recorrerStack();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            if (txtDatos.Text != "")
            {
                txtDatos.Text = txtDatos.Text.Remove(txtDatos.Text.Length - 1);
            }
            else
            {
                return;
            }
        }

        private void btnDup_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "No hay valores suficientes")
            {
                txtDatos.Clear();
            }
            if (stack.IsEmpty() == false)
            {
                if (txtDatos.Text != "")
                {
                    return;
                }
                else
                {
                    double num1;
                    num1 = stack.Pop();
                    stack.Push(num1);
                    stack.Push(num1);
                    txtDatos.Clear();
                }
            }
            else
            {
                return;
            }
            recorrerStack();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 1)
            {
                double num1 = stack.Pop();
                double num2 = num1 * Math.PI / 180;
                double sin = Math.Sin(num2);
                stack.Push(sin);
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 1)
            {
                double num1 = stack.Pop();
                double num2 = num1 * Math.PI / 180;
                double cos = Math.Cos(num2);
                stack.Push(cos);
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 1)
            {
                double num1 = stack.Pop();
                double num2 = num1 * Math.PI / 180;
                double tan = Math.Tan(num2);
                stack.Push(tan);
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 1)
            {
                double num1 = stack.Pop();
                if (num1 > 0)
                {
                    double num2 = -1 * (num1);
                    stack.Push(num2);
                }
                else if (num1 < 0)
                {
                    double num2 = -1 * (num1);
                    stack.Push(num2);
                }
                else
                {
                    stack.Push(num1);
                }
            }            
            recorrerStack();
            
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "" & stack.Size < 1)
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 1)
            {
                double num1 = stack.Pop();
                double num2 = num1 * num1;
                stack.Push(num2);
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnInversa_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "" & stack.Size < 1)
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 1)
            {
                double num1 = stack.Pop();
                double num2 = 1 / num1;
                stack.Push(num2);
            }
            recorrerStack();
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 2)
            {
                double num2 = stack.Pop();
                double num1 = stack.Pop();
                double pow = Math.Pow(num1, num2);
                stack.Push(pow);
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text == "" & stack.Size < 1)
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 1)
            {
                double num1 = stack.Pop();
                double num2 = Math.Sqrt(num1);
                stack.Push(num2);
                txtDatos.Clear();
            }
            recorrerStack();
        }

        private void btnXElevadoInversa_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                txtDatos.Text = "No hay valores suficientes";
            }
            if (txtDatos.Text != "" & txtDatos.Text != "No hay valores suficientes")
            {
                stack.Push(Convert.ToDouble(txtDatos.Text));
                txtDatos.Clear();
            }
            if (stack.Size >= 2)
            {
                double num2 = stack.Pop();
                double num1 = stack.Pop();
                double pow = Math.Pow(num1, (1/ num2));
                stack.Push(pow);
                recorrerStack();
                txtDatos.Clear();
            }
            else
            {
                txtDatos.Text = "No hay valores suficientes";
            }
        }
    }
}
