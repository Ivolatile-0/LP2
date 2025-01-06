using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteComponentes_M1
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
            listBox1.SelectedIndex = 0; // deixando setado o primeiro da lista
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") // (textBox1.Text==String.Empty)
              MessageBox.Show("Não preenchou o nome");
            else
                MessageBox.Show(textBox1.Text);
/*
            if (checkBox1.Checked)
                MessageBox.Show("é a primeira viagem do cliente");
            else
                MessageBox.Show("já viajou com a agência");
*/
            if (checkBox1.CheckState==CheckState.Indeterminate)
                MessageBox.Show("Não informou primeira viagem");
            else if (checkBox1.CheckState == CheckState.Checked)
                MessageBox.Show("é a primeira viagem do cliente");
            else
                MessageBox.Show("Não é a primeira viagem");


            if (comboBox1.SelectedIndex==-1)
                MessageBox.Show("não selecionou o destino");
            else
                MessageBox.Show("o destino é:"+comboBox1.SelectedItem.ToString());

            DateTime auxiliar;
            if (DateTime.TryParse(maskedTextBox1.Text, out auxiliar))
                MessageBox.Show("Data viagem válida");
            else
                MessageBox.Show("Data viagem inválida");

            //for (var i = 0; i <= checkedListBox1.CheckedItems.Count - 1; i++)
            //    MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());

            string stringona = "";

            for (var i = 0; i <= checkedListBox1.CheckedItems.Count - 1; i++)
                stringona = stringona + checkedListBox1.CheckedItems[i].ToString();

            MessageBox.Show(stringona);

        }
    }
}
