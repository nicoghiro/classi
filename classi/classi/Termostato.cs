using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi
{
    public class Termostato
    {
        private string produttore;
        private string modello;
        private string numserie;
        private bool stato;
        private bool funzionamento;//true =scaldamento e acqua calda sanitaria,false=acqua calda sanitaria
        public int temperatura;
        public Caldaia caldaia;
        
        public Termostato()
        {
            setProduttore(null);
            setModello(null);
            setNumserie(null);
            setStato(false);
            setfunz(true);
            setTemparatura(0);
            setCaldaia(null);

        }
        public Termostato(string produttore, string modello, string numserie, bool stato, bool funzionamento, int temperatura, Caldaia caldaia)
        {
            this.produttore = produttore;
            this.modello = modello;
            this.numserie = numserie;
            this.stato = stato;
            this.funzionamento = funzionamento;
            this.temperatura = temperatura;
            this.caldaia = caldaia;
        }

        public void setProduttore(string profuttoret)
        {

            produttore = profuttoret;

        }
        public void setModello(string modellot)
        {
            modello = modellot;
        }
        public void setNumserie(string numseriet)
        {
            numserie = numseriet;
        }
        public void setTemparatura(int tempe)
        {
           caldaia.setTemparatura(tempe);
        }
        public void aumeTemparatura()
        {
            caldaia.aumeTemparatura();
        }
        public void dimiTemparatura()
        {
            caldaia.dimiTemparatura();
        }
        public void setStato(bool stato)
        {
            caldaia.setStato(stato);
        }
        public void setfunz(bool funz)
        {
           caldaia.setfunz(funz);
        }
        public void setCaldaia(Caldaia cal)
        {
            caldaia = cal;
        }
        public Caldaia getCaldaia()
        {
            return caldaia;
        }
        public string getProduttore()
        {
            return produttore;
        }
        public string getModello()
        {
            return modello;
        }
        public string getNumserie()
        {
            return numserie;
        }
        public bool getStato()
        {
            bool ris = caldaia.getStato();
            return ris;
        }
        public int getTemp()
        {
            
            int ris = caldaia.getTemperatura();
            return ris;
        }
        public bool getFunz()
        {
            bool ris= caldaia.getFunzionamento();
            return ris;
        }
    }
}
