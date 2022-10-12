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
    public partial class Form1 : Form
    {
        Telecomando tele=  FactoryTelecomando.getInstance();
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tele.aumentavolume();
            int vol = tele.getVolume();
            string volu = Convert.ToString(vol);
            MessageBox.Show(volu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tele.diminuiscivolume();
            int vol = tele.getVolume();
            string volu = Convert.ToString(vol);
            MessageBox.Show(volu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tele.aumentaCanale();
            int vol = tele.getCanale();
            string volu = Convert.ToString(vol);
            MessageBox.Show(volu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tele.diminuisciCanale();
            int vol = tele.getCanale();
            string volu = Convert.ToString(vol);
            MessageBox.Show(volu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tele.inverti();
            bool vol = tele.getStato();
            string volu =Convert.ToString(vol);
            MessageBox.Show(volu);
            
        }
    }
}
