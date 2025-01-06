using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteEventos_M1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void txtEndereco_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Endereço ganhou o foco");
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (txtEmail.Text=="")
            {
                MessageBox.Show("E-mail vazio");
                txtEmail.Focus();
            }
        }

        private void txtTelefone_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefone.Text=="")
            {
                MessageBox.Show("Telefone vazio");
                e.Cancel = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (Char)13)
            {
                SendKeys.Send("{TAB}");

                e.Handled = true;//desabilita o beep
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Nome perdeu o foco");
        }

    
            private void txtTelefone_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtTelefone.Text=="")
            {
                MessageBox.Show("telefone vazio");
                e.Cancel = true;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TESTE DO MSGBOX", "TITULO",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
