using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi
{
    public class Televisore
    {
        public Televisore(string ilproduttore, string ilmodello)
        {
            produttore = ilproduttore;
            modello = ilmodello;
            stato = false;
            porte = null;
            sorgente = true;
            risoluzione = 1080;
            canale = 1;
            volume = 0;


        }

        public Televisore()
        {
            produttore = "";
            modello = "";
        }
        private bool stato;//accesa o spenta
        private string produttore;
        private string modello;
        private string[] porte;// array di stringhe con il nome delle porte 
        private bool sorgente;//analogica o digitale 
        private int risoluzione;
        private int canale;//canale attualmente selezionato  
        private int volume;
        public Televisore(bool statol, string produttorel, string modellol,  bool sorgentel, int risoluzionel, int canalel, int volumel)
        {
            if (volume <= 100 && volume >= 0 && canale <= 999 && canale >= 0)
            {

                canale = canalel;
                volume = volumel;
            }
            else
            {
                if (volume > 100 || volume < 0)
                {
                    volume = 50;
                    throw new Exception("volume inserito non valido , è stato settato a 50");


                }
                else
                {
                    canale = 999;
                    throw new Exception("canale inserito non valido , è stato settato a 999");

                }
            }
            produttore = produttorel;
            modello = modellol;
            
            sorgente = sorgentel;
            stato = statol;
            risoluzione = risoluzionel;
        }
        public void accendi()
        {
            setStato(true);
        }
        public void inverti()
        {
            stato = !stato;
        }
        public void setRisoluzione(int risoluzionet)
        {
            risoluzione = risoluzionet;
        }
        public void spegni()
        {
            setStato(false);
        }
        private void setPorte(string[] portet)
        {
            porte = portet;
        }
        private void setStato(bool nuovostato)
        {
            stato = nuovostato;
        }
        private void SetCanale(int canalel)
        {
            canale = canalel;
        }
        private void SetSorgente(bool sorgenti)
        {
            //setta la sorgwente in basa alla richiesta
            sorgente = sorgenti;
        }
        public void aumentavolume()
        {
            if (volume != 100)
            {
                volume++;
            }
        }
        public void diminuiscivolume()
        {
            if (volume != 0)
            {
                volume--;
            }
        }
        public void cambiaCanale(int nuovocanale)
        {
            canale = nuovocanale;
        }
        public void aumentaCanale()
        {
            if (canale != 999)
            {
                canale++;
            }
        }
        public void diminuisciCanale()
        {
            if (canale != 999)
            {
                canale--;
            }
        }
        public string getProduttore()
        {
            return produttore;
        }
        public bool getStato()
        {
            return stato;
        }
        public string getModello()
        {
            return modello;
        }

        public int getCanale()
        {
            return canale;
        }
        public int getVolume()
        {
            return volume;
        }
    }
}
