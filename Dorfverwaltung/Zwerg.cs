using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung
{
    class Zwerg
    {
        

        public string name { get; set; }
        public int alter { get; set; }
        public List<Waffe> waffen { get; set; }

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
