using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung
{
    class Stamm
    {
        public string name { get; set; }

        public string existenz { get; set; }

        public List<Zwerg> zwergen { get; set; }

        public int machfaktor
        {
            get
            {
                int sum = 0;
                foreach (Zwerg zwerg in zwergen)
                {
                    sum +=zwerg.machfaktor;
                }
                return sum;
            }
        }

        /// <summary>
        /// Rechnen die Steur für eine Stamm
        /// </summary>
        /// <param name="machtfaktor">sum of each dwarf machtfaktor</param>
        /// <returns></returns>
        public double SteuerRechnung(int machtfaktor)
        {
            return machtfaktor * 2.125;
        }
    }


}
