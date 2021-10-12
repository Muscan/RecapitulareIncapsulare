using System;
using System.Collections.Generic;
using System.Text;

namespace RecapitulareIncapsulare
{
    class Car
    {
        private String marcaMasina;
        private int anFabricatie;

        public Car()
        {

        }
        public Car(string marcaMasina, int anFabricatie)
        {
            this.marcaMasina = marcaMasina;
            this.anFabricatie = anFabricatie;
        }
        public String getMarcaMasina()
        {
            return marcaMasina;
        }
        public int getAnFabricatie()
        {
            return anFabricatie;
        }

        public void setMarcaMasina(string marcaMasina)
        {
            this.marcaMasina = marcaMasina;
        }

        public void setAnFabricatie(int anFabricatie)
        {
            this.anFabricatie = anFabricatie;
        }

        public string CarDescription()
        {
            string carDesc = "";
            carDesc += marcaMasina + ' ';
            carDesc += anFabricatie;
            return carDesc;
        }
       
    }
}
