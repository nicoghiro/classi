using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classi
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text)|| String.IsNullOrEmpty(textBox2.Text)  || String.IsNullOrEmpty(comboBox1.Text))
                {
                MessageBox.Show("inserisci tutti i campi per continuare");
                }
            else
            {
              
                Telecomando pop = new Telecomando(textBox1.Text, textBox2.Text, comboBox1.Text);
                FactoryTelecomando.setInstance(pop);
                this.Hide();
                Form1 passa = new Form1();
                passa.ShowDialog();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
