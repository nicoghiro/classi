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
       
        Televisore tv1 = new Televisore(false, "sansunsg", "tv1", true, 1080, 10, 10);
        Televisore tv2 = new Televisore(false, "sony", "tv2", true, 1080, 10, 10);
        Televisore  tv3 = new Televisore(false, "lg", "tv3", true, 1080, 10, 10);
        
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "nessuno")
            {
                tele.setTv(null);
            }
            if (comboBox2.Text == "tv1")
            {
                tele.setTv(tv1);
            }
            if (comboBox2.Text == "tv2")
            {
                tele.setTv(tv2);
            }
            if (comboBox2.Text == "tv3")
            {
                tele.setTv(tv3);
            }
        }
    }
}
