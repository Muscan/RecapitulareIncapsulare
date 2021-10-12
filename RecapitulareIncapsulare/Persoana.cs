using System;
using System.Collections.Generic;
using System.Text;

namespace RecapitulareIncapsulare
{
    class Persoana
    {
        private String Nume;
        private int Varsta;
        
        public Persoana(string nume, int varsta)
        {
            this.Nume = nume;
            this.Varsta = varsta;
        }
        public Persoana()
        {

        }

        public void  setNume(string nume)
        {
            this.Nume = nume; 
        }
        public void setVarsta(int varsta)
        {
            this.Varsta = varsta;
        }

        public  string getNume()
        {
            return this.Nume;
        }
        public  int getVarsta()
        {
            return this.Varsta;
        }

        public string Descriere()
        {
            string persoanaDetails = "";

            persoanaDetails += Nume + ' ';
            persoanaDetails += Varsta ;
            return persoanaDetails ;
        }

        public void printPersoana()
        {
            Console.WriteLine(this.Descriere());
        }

        

    }
}
