using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung
{
    class Initialize
    {
        /// <summary>
        /// Methode, um ein Objekt Waffe zu erstellen
        /// </summary>
        /// <param name="typ"></param>
        /// <param name="magie"></param>
        /// <returns></returns>
        public Waffe Waffe(string typ, int magie)
        {
            Waffe waffe = new Waffe { typ = typ, magie = magie };
            return waffe;
        }

        /// <summary>
        /// Methode, um ein Objekt Zwerg zu erstellen
        /// </summary>
        /// <param name="name"></param>
        /// <param name="alter"></param>
        /// <param name="listWaffe"></param>
        /// <returns></returns>
        public Zwerg Zwerg(string name, int alter, List<Waffe> listWaffe)
        {
            Zwerg zwerg = new Zwerg {name = name, alter = alter, waffen = listWaffe };
            return zwerg;
        }

        /// <summary>
        /// Methode, um ein Objekt Stamm zu erstellen
        /// </summary>
        /// <param name="existenz"></param>
        /// <param name="name"></param>
        /// <param name="listZwegen"></param>
        /// <returns></returns>
        public Stamm Stamm(string existenz, string name, List<Zwerg> listZwegen)
        {
            Stamm stamm = new Stamm() { existenz = existenz, name = name, zwergen = listZwegen };

            return stamm;
        }
    }
}
