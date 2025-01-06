using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("1");
            listBox1.Items.Add("2");
            listBox1.Items.Add("3");
            listBox1.Items.Add("4");
            listBox1.Items.Add("5");
            listBox1.Items.Add("6");
            listBox1.SelectedIndex = 0;//deixando o primeiro marcado
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //(textBox1.Text==String.Empty)
                MessageBox.Show("Não preencheu o nome");
            else
                MessageBox.Show(textBox1.Text);
            if (checkBox1.Checked)
                MessageBox.Show("É a primeira viagem do cliente");
            else
                MessageBox.Show("Já viajou com a empresa");
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Não selecionou o destino");
            else
                MessageBox.Show("O destino é: " + comboBox1.SelectedItem.ToString());
            
            DateTime auxiliar;
            if (DateTime.TryParse(maskedTextBox1.Text, out auxiliar))
                MessageBox.Show("Data válida");
            else
                MessageBox.Show("Data inválida");
            for (var i = 0; i < checkedListBox1.CheckedItems.Count - 1; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            }
        }
    }
}
