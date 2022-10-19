using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi
{
    public class Televisore
    {
        
        private bool stato;//accesa o spenta
        private string produttore;
        private string modello;
        private string[] porte;// array di stringhe con il nome delle porte 
        private bool sorgente;//analogica o digitale 
        private int risoluzione;
        private int canale;//canale attualmente selezionato  
        private int volume;
          public Televisore(string ilproduttore, string ilmodello)
        {
            setProduttore(ilproduttore);
            setModello(ilmodello);  
            setStato(false);
            setPorte(null);
            setSorgente(true);
            setRisoluzione(1080);
            SetCanale(1);
            setVolume(0);
        }

        public Televisore()
        {
            setProduttore("");
            setModello("");  
            setStato(false);
            setPorte(null);
            setSorgente(true);
            setRisoluzione(1080);
            SetCanale(1);
            setVolume(0);
        }
        public Televisore(bool statol, string produttorel, string modellol,string[] portel  ,bool sorgentel, int risoluzionel, int canalel, int volumel)
        {
            if (volume <= 100 && volume >= 0 && canale <= 999 && canale >= 0)
            {
                SetCanale(canalel);
                setVolume(volumel);
              
            }
            else
            {
                if (volume > 100 || volume < 0)
                {
                    setVolume(50);
                    throw new Exception("volume inserito non valido , è stato settato a 50");


                }
                else
                {
                    SetCanale(1);
                    throw new Exception("canale inserito non valido , è stato settato a 999");

                }
            }
            setProduttore(produttorel);
            setModello(modellol);
            setPorte(portel);
            setSorgente(sorgentel);
            setStato(statol);
            setRisoluzione(risoluzionel);
            
        }
        public void accendi()
        {
            setStato(true);
        }
        public void inverti()
        {
            stato = !stato;
        }
        public void setProduttore(string profuttoret)
        {
           produttore=profuttoret;
        }
        public void setRisoluzione(int risoluzionet)
        {
            risoluzione = risoluzionet;
        }
           public void setVolume(int volumet)
        {
            volume=volumet;
        }
          public void setModello(string modellot)
        {
            modello = modellot;
        }
        public void setPorte(string[] portet)
        {
            porte = portet;
        }
          public void setSorgente(bool sorgentet)
        {
            sorgente=sorgentet; 
        }
        public void spegni()
        {
            setStato(false);
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
