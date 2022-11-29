using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_Mozak
{
    public class Kalkulator
    {
        public int PrviBroj { get; set; }
        public int DrugiBroj { get; set; }

        public string Operacija { get; set; }
        private int Rezultat;
        public int MojRezultat
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
        private int MatematickaOperacija(int broj1, int broj2, string operacija)
        {
            int rjesenje = 0;
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
