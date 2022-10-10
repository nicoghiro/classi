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
                int canale = Convert.ToInt32(numericUpDown1);
                int volume = Convert.ToInt32(numericUpDown2);
                Telecomando pop = new Telecomando(textBox1.Text, textBox2.Text, comboBox1.Text,false,canale, volume);
                FactoryTelecomando.setInstance(pop);
                this.Hide();
                Form1 passa = new Form1();
                passa.ShowDialog();
                this.Close();
            }
        }
    }
}
