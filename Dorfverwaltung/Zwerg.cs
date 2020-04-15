using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung
{
    class Zwerg
    {
        
        /// <summary>
        /// Namen der Zwerge
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Alter der Zwerge
        /// </summary>
        public int alter { get; set; }
        /// <summary>
        /// Waffen der Zwerge
        /// </summary>
        public List<Waffe> waffen { get; set; }

        /// <summary>
        /// Summe der Magie der Waffen, die ein Zwerg besitzt
        /// </summary>
        public int machfaktor 
        {
        get 
            {
                int sum = 0;
                foreach (Waffe waffe in waffen)
                {
                      sum += waffe.magie; 
                }
                return sum;
            } 
        }
    }
}
