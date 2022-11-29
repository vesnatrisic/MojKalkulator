using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_Mozak
{
    public class Kalkulator
    {
        public float PrviBroj { get; set; }
        public float DrugiBroj { get; set; }

        public string Operacija { get; set; }
        private float Rezultat;
        public float MojRezultat
        {
            get
            {
                //Rezultat = PrviBroj + DrugiBroj;
                Rezultat = MatematickaOperacija(PrviBroj, DrugiBroj, Operacija);
                return Rezultat;
            }
            set { }
        }
        /// <summary>
        /// Opisuje funkcionalnost ovog ispod. Stavi misa na MatematickaOperacija pa vidi.
        /// </summary>
        private float MatematickaOperacija(float broj1, float broj2, string operacija)
        {
            float rjesenje = 0;
            switch (operacija)
            {
                case "+":
                    rjesenje = broj1 + broj2;
                    break;
                case "-":
                    rjesenje = broj1 - broj2;
                    break;
                case "*":
                    rjesenje = broj1 * broj2;
                    break;
                case "/":
                    rjesenje = broj1 / broj2;
                    break;
            }
            return rjesenje;
        }
    }
}
