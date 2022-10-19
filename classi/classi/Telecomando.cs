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
            t = telecomando;
        }

    }

    public class Telecomando
    {
        private string produttore;
        private string modello;
        private string funzionamento;
        private Televisore tv;








        public Telecomando(string produttorel, string modellol, string funzionamentol, Televisore tvl)
        {
            setProduttore(produttorel);
            setModello(modellol);
            setFunzionamento(funzionamentol);
            setTv(tvl);
            

        }
        public Telecomando(string produttorel, string modellol, string funzionamentol)
        {
            setProduttore(produttorel);
            setModello(modellol);
            setFunzionamento(funzionamentol);


        }
        public void setTv(Televisore tl)
        {
            tv= tl;
        }
        public void setProduttore(string profuttoret)
        {
            produttore = profuttoret;
        }
        public void setModello(string modellot)
        {
            modello = modellot;
        }
        public void setFunzionamento(string funzionamentot)
        {
            funzionamento = funzionamentot;
        }
        public void inverti()
        {
            if (tv != null)
            {
                tv.inverti();
            }
        }
        public void aumentavolume()
        {
            if (tv != null)
            {
                tv.aumentavolume();
            }
        }
        public void diminuiscivolume()
        {
            if (tv != null)
            {
                tv.diminuiscivolume();
            }
        }
        public void cambiaCanale(int nuovocanale)
        {
            if (tv != null)
            {
                tv.cambiaCanale(nuovocanale);
            }
        }
        public void aumentaCanale()
        {
            if (tv != null)
            {
                tv.aumentaCanale();
            }
        }
        public void diminuisciCanale()
        {
            if (tv != null)
            {
                tv.diminuisciCanale();

            }
        }
        public string getProduttore()
        {
            return produttore;
        }
        public bool getStato()
        {
            bool ris;
            if (tv != null)
            {
                ris = tv.getStato();
                return ris;
            }
            else
            {
                ris = false;
                return ris;
            }

        }
        public string getModello()
        {
           return modello;
        }
        public Televisore getTV()
        {
            return tv;
        }
        public string getFunzionamento()
        {
            return funzionamento;
        }
        public int getCanale()
        {
            int ris;
            if (tv != null)
            {
                ris = tv.getCanale();
                return ris;
            }
            else
            {
                ris = 0;
                return ris;
            }
        }
        public int getVolume()
        {
            int ris;
            if (tv != null)
            {
                ris = tv.getVolume();
                return ris;
            }
            else
            {
                ris = -1;
                return ris;
            }
        }
    }
}