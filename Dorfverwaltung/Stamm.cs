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

        /// <summary>
        /// Summe der Machtfaktoren der Zwerge, die ein Stamm besitzt
        /// </summary>
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
        /// Errechnen der Steuer für einen Stamm
        /// </summary>
        /// <param name="machtfaktor"></param>
        /// <returns></returns>
        public double SteuerRechnung(int machtfaktor)
        {
            return machtfaktor * 2.125;
        }
    }


}
