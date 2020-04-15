using System;
using System.Collections.Generic;

namespace Dorfverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize initialize = new Initialize();
            Menu menu = new Menu();

            //Initialisierung der Waffen
            Waffe axe_12 = initialize.Waffe("axe_12", 12);
            Waffe schwert = initialize.Waffe("schwert", 15);
            Waffe zauberstab = initialize.Waffe("zauberstab", 45);
            Waffe streitHammer = initialize.Waffe("streithammer", 15);
            Waffe axe_17 = initialize.Waffe("axe_17", 17);

            //Waffenliste für jeden Zwerg
            List<Waffe> gimliWaffen = new List<Waffe>() { axe_12, schwert };
            List<Waffe> zwingliWaffen = new List<Waffe>() { zauberstab, streitHammer };
            List<Waffe> gumliWaffen = new List<Waffe>() { axe_17 };

            //Initialisierung der Zwerge 
            Zwerg Gimli = initialize.Zwerg("gimli",140, gimliWaffen);
            Zwerg Zwingli = initialize.Zwerg("zwingli",70, zwingliWaffen);
            Zwerg Gumli = initialize.Zwerg("gumli", 163, gumliWaffen); ;

            //Zwergenliste für jeden Stamm
            List<Zwerg> altobarZwergen = new List<Zwerg>() { Gimli, Zwingli };
            List<Zwerg> elbknechteZwergen = new List<Zwerg>() { Gumli };

            //Initialisierung der Stämme
            Stamm altobarden = initialize.Stamm("1247ndk", "altobarden", altobarZwergen);
            Stamm elbknechte = initialize.Stamm("1023 ndk", "elbknechte", elbknechteZwergen);

            //Objektliste
            List<Waffe> Waffen = new List<Waffe>() { axe_12, schwert, zauberstab, streitHammer, axe_17};
            List<Zwerg> Zwerge = new List<Zwerg>() { Gimli, Zwingli, Gumli };
            List<Stamm> Stämme = new List<Stamm>() { altobarden, elbknechte};

            menu.Hauptmenü(Waffen, Stämme, Zwerge);
        }
    }
}
