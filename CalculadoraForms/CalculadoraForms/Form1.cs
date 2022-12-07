using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0; decimal valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void btnVrgl_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                textResultado.Text += ".";
            }
            else
            {
                MessageBox.Show("Informe um valor primeiro.");
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            

            if (textResultado.Text != "")
            {
                valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    textResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "SUBTRAI")
                {
                    textResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULTIPLICA")
                {
                    textResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "DIVIDE")
                {
                    textResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
            else
            {
                MessageBox.Show("Informe a operação a ser realizada antes.");
            }
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação.");
            }
        }

        private void btnSubt_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "SUBTRAI";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação.");
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "MULTIPLICA";
                lblOperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação.");
            }
        }

        private void btnDivs_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "DIVIDE";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação.");
            }
        }

        private void btnInvSnl_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = Convert.ToString(decimal.Parse(textResultado.Text) * (-1));

            } 
            else
            {
                MessageBox.Show("Digite um valor numérico diferente de zero para inversão de sinal.");
            }
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }
    }
}
