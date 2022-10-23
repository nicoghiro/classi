using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi
{
    public class Caldaia
    {
        private string produttore;
        private string modello;
        private string numserie;
        private bool stato;
        private bool funzionamento;//true =scaldamento e acqua calda sanitaria,false=acqua calda sanitaria
        public int temperatura;
        public Caldaia()
        {
            setfunz(true);
            setModello(null);
            setNumserie(null);
            setProduttore(null);
            setStato(false);
            setTemparatura(0);


        }
        public Caldaia(string produttore, string modello, string numserie, bool stato, bool funzionamento, int temperatura)
        {
            this.produttore = produttore;
            this.modello = modello;
            this.numserie = numserie;
            this.stato = stato;
            this.funzionamento = funzionamento;
            this.temperatura = temperatura;
        }
        public Caldaia(bool statol, bool funzionamentol, int temperatural) {
            setfunz(funzionamentol);
            setModello(null);
            setNumserie(null);
            setProduttore(null);
            setStato(statol);
            setTemparatura(temperatural);
        }


        public void setProduttore(string profuttoret)
        {
            
            produttore = profuttoret;
            
        }
        public void setModello(string modellot)
        {
            modello = modellot;
        }
        public void spegni()
        {
            setStato(false);
        }

        private void setStato(bool nuovostato)
        {
            stato = nuovostato;
        }
        public void accendi()
        {
            setStato(true);
        }
        public void setNumserie(string numseriet)
        {
            numserie = numseriet;   
        }
        public void setfunz(bool funz)
        {
            if (stato == true) { 
            funzionamento = funz;
            }
        }
        public void setTemparatura(int tempe)
        {
            if (stato == true)
            {
                temperatura = tempe;
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
        public bool getFunzionamento()
        {
            return funzionamento;
        }
        public string getNumserie()
        {
            return numserie;
        }
        public int getTemperatura()
        {
            return temperatura;
        }
    }
}
