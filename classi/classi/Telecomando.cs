using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi
{

    public class FactoryTelecomando
    {
        static private Telecomando t = null;

        static public Telecomando getInstance()
        {
            return t;
        }

        static public void setInstance(Telecomando telecomando)
        {
            t=telecomando;
        }

    }

    public class Telecomando
    {
        private string produttore;
        private string modello;
        private string funzionamento;
        private bool stato;
        private int canale;
        private int volume;
        public Telecomando(string produttorel, string modellol, string funzionamentol, bool statol, int canalel, int volumel)
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
            funzionamento = funzionamentol;
            stato = statol;   }




        

        public Telecomando(string produttorel, string modellol, string funzionamentol) { 
            produttore=produttorel;
            modello=modellol;
            funzionamento=funzionamentol;
        }
<<<<<<< HEAD
        public Telecomando(string produttorel, string modellol, string funzionamentol)
        {
            produttore = produttorel;
            modello = modellol;
            funzionamento = funzionamentol;
          

        }
        public void inverti()
=======
        public void inverti ()
>>>>>>> parent of e45c0c3 (Merge branch 'main' of https://github.com/nicoghiro/domotica)
        {
            stato =! stato;
        }
        public void aumentavolume ()
        {
            if (volume != 100){
            volume++; 
            }
        }
        public void diminuiscivolume()
        {
            if(volume != 0) { 
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
        public string getFunzionamento()
        {
            return funzionamento;
        }
        public int getCanale()
        {
            return canale;
        }
        public int getVolume()
        { return volume; 
        }
    }
}
