using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnNumero0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação");
            }

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação");
            }
       
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else
                MessageBox.Show("Error");
        }
    }
}