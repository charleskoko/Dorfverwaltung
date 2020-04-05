using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung
{
    class Initialize
    {
        
        public Waffe Waffe(string typ, int magie)
        {
            Waffe waffe = new Waffe { typ = typ, magie = magie };
            return waffe;
        }

        public Zwerg Zwerg(string name, int alter, List<Waffe> listWaffe)
        {
            Zwerg zwerg = new Zwerg {name = name, alter = alter, waffen = listWaffe };
            return zwerg;
        }

        public Stamm Stamm(string existenz, string name, List<Zwerg> listZwegen)
        {
            Stamm stamm = new Stamm() { existenz = existenz, name = name, zwergen = listZwegen };

            return stamm;
        }
    }
}
