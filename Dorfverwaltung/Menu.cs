using System;
using System.Collections.Generic;
using System.Text;

namespace Dorfverwaltung
{
    class Menu
    {
        static int index = 0;

        /// <summary>
        /// Hauptfunktion die das Hauptmenü anzeigt und die Benutzeroberfläche
        /// </summary>
        /// <param name="listWaffe"></param>
        /// <param name="listStamm"></param>
        /// <param name="listZwegen"></param>
        public void Hauptmenü(List<Waffe> listWaffe, List<Stamm> listStamm, List<Zwerg> listZwegen)
        {

            List<string> menuItem = new List<string>()
            {
                "Gesamtsteuer",
                "Zwergenstämme",
                "Neues Artefakt vergeben",
                "Artefakt zurücknehmen",
                "Exit"
            };

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                string selectedMenuItem = drawMenu(menuItem);

                if (selectedMenuItem == "Gesamtsteuer")
                {
                    Gesamtsteuer(listStamm);
                }

                if (selectedMenuItem == "Artefakt zurücknehmen")
                {
                    Console.Clear();
                    int count = 1, userEingabe, max=3 ;

                    foreach (Zwerg zwerg in listZwegen)
                    {
                        Console.WriteLine(count + ": " + "Name des Zwerges: " + zwerg.name);
                        count++;
                    }

                    do
                    {
                        Console.WriteLine("");
                        Console.Write("Wählen Sie eine Nummer ");
                        int.TryParse(Console.ReadLine(), out userEingabe);                                         

                    }

                    while (userEingabe < 1 || userEingabe > max);

                    int trueChoice = userEingabe - 1;
                    ArtefaktZurucknemmen(listZwegen[trueChoice]);
                }

                if (selectedMenuItem == "Zwergenstämme")
                {
                    Zwergenstämme(listStamm);
                }

                if (selectedMenuItem == "Neues Artefakt vergeben")
                {
                     Artefakt(listWaffe, listZwegen);
                }

                if (selectedMenuItem == "Exit")
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private static string drawMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {

                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t\t\t\t\t" + items[i]);

                }
                else
                {
                    Console.WriteLine("\t\t\t\t\t" + items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();
            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1) { index = 0; }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0) { index = items.Count - 1; }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }
            Console.Clear();
            return "";
        }

        /// <summary>
        /// Funktion die die Gesamtsteuer anzeigt und berechnet
        /// </summary>
        /// <param name="listStamm"></param>
        private static void Gesamtsteuer(List<Stamm> listStamm)
        {
            double sum = 0;
            foreach (Stamm stamm in listStamm)
            {
                sum += stamm.machfaktor;
            }
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t              ******************");
            Console.WriteLine("\t\t\t\t\t              *  GESAMTSTEUER  *");
            Console.WriteLine("\t\t\t\t\t              ******************");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t              ********************************");
            Console.WriteLine("\t\t\t\t\t              *    STÄMME    **    STEUER    *");
            Console.WriteLine("\t\t\t\t\t              ********************************");
            Console.WriteLine("\t\t\t\t\t              *  " + listStamm[0].name + "  **  " + listStamm[0].SteuerRechnung(listStamm[0].machfaktor) + "     *");
            Console.WriteLine("\t\t\t\t\t              ********************************");
            Console.WriteLine("\t\t\t\t\t              *  " + listStamm[1].name + "  **  " + listStamm[1].SteuerRechnung(listStamm[1].machfaktor) + "     *");
            Console.WriteLine("\t\t\t\t\t              ********************************");
            Console.WriteLine("\t\t\t\t\t              *    SUMME :        " + sum * 2.125 + "        *");
            Console.WriteLine("\t\t\t\t\t              ********************************");
            Console.Read();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listStamm"></param>
        private static void Zwergenstämme(List<Stamm> listStamm)
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t              *****************");
            Console.WriteLine("\t\t\t\t\t              * ZWERGENSTÄMME *");
            Console.WriteLine("\t\t\t\t\t              *****************");

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.Write("\t\t\t*********************");
            Console.WriteLine("\t\t\t\t\t*********************");
            Console.Write("\t\t\t*    " + listStamm[0].name + "     *"); Console.WriteLine("\t\t\t\t\t*     " + listStamm[1].name + "    *");
            Console.Write("\t\t\t*********************"); Console.WriteLine("\t\t\t\t\t*********************");
            Console.Write("\t\t\t* Existenz: " + listStamm[0].existenz + " *"); Console.WriteLine("\t\t\t\t\t* Existenz: " + listStamm[1].existenz + "*");
            Console.Write("\t\t\t* Machtfaktor: " + listStamm[0].machfaktor + "   *"); Console.WriteLine("\t\t\t\t\t* Machtfaktor: " + listStamm[1].machfaktor + "   *");
            Console.Write("\t\t\t*********************"); Console.WriteLine("\t\t\t\t\t*********************");
            Console.Write("\t\t\t           *"); Console.WriteLine("\t\t\t\t\t                 *");
            Console.Write("\t\t\t           *"); Console.WriteLine("\t\t\t\t\t                 *");
            Console.Write("\t\t\t           *"); Console.WriteLine("\t\t\t\t\t                 *");

            Console.Write("\t\t******************"); Console.Write("   ******************"); Console.WriteLine("\t\t\t\t******************");
            Console.Write("\t\t*     " + listStamm[0].zwergen[0].name + "      *"); Console.Write("   *     " + listStamm[0].zwergen[1].name + "    *"); Console.WriteLine("\t\t\t\t*     " + listStamm[1].zwergen[0].name + "      *");
            Console.Write("\t\t******************"); Console.Write("   ******************"); Console.WriteLine("\t\t\t\t******************");
            Console.Write("\t\t* Alter:" + listStamm[0].zwergen[0].alter + "      *"); Console.Write("   * Alter:" + listStamm[0].zwergen[1].alter + "       *"); Console.WriteLine("\t\t\t\t*  Alter:" + listStamm[1].zwergen[0].alter + "     *");
            Console.Write("\t\t* Machtfaktor:" + listStamm[0].zwergen[0].machfaktor + " *"); Console.Write("   * Machtfaktor:" + listStamm[0].zwergen[1].machfaktor + " *"); Console.WriteLine("\t\t\t\t*  Machfaktor:" + listStamm[1].zwergen[0].machfaktor + "  *");
            Console.Write("\t\t****************** "); Console.Write("  ******************"); Console.WriteLine("\t\t\t\t******************");
            Console.Read();
        }

        /// <summary>
        /// Funktion die Wahl des Benutzers speichert
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="themax"></param>
        /// <returns></returns>
        private static int TrueChoice(int choice, int themax)
        {
            int trueChoice = 0;
            do
            {
                Console.WriteLine("");
                Console.Write("Wählen Sie eine Nummer: ");
                int.TryParse(Console.ReadLine(), out choice);
            }
            while (choice < 1 || choice > themax);

            trueChoice = choice - 1;
            return trueChoice;
        }

        /// <summary>
        /// Funktion die ein neues Artefakt an Zwerg gibt
        /// </summary>
        /// <param name="listWaffe"></param>
        /// <param name="listZwegen"></param>
        private static void Artefakt(List<Waffe> listWaffe, List<Zwerg> listZwegen)
        {
            #region Declaration

            int userEingabe = 0, max = 5;
            int count = 0;
            string selectedWaffe = "null";
            string selectedZwerge = "null";
            Waffe newArtefeakt = null;
            Zwerg zwergWithNewArtefakt = null;

            #endregion

            Console.Clear();


            #region Waffe selection

            foreach (Waffe artefakt in listWaffe)
            {
                count++;
                Console.WriteLine(count + ": " + "Typ: " + artefakt.typ + " / Magie: " + artefakt.magie);
            }

            userEingabe = TrueChoice(userEingabe, max);
            selectedWaffe = listWaffe[userEingabe].typ;
            #endregion

            #region zwerg selection
            count =  0;
            userEingabe = 0;
            max = 3;
            Console.Clear();
            foreach (Zwerg zwerge in listZwegen)
            {
                count++;
                Console.WriteLine(count + ": " + "Name: " + zwerge.name + " / Alter: " + zwerge.alter);
            }

            userEingabe = TrueChoice(userEingabe, max);
            selectedZwerge = listZwegen[userEingabe].name;


            #endregion

            #region Add new Waffe 


            foreach (Waffe waffe in listWaffe)
            {
                if (waffe.typ == selectedWaffe)
                {
                    newArtefeakt = waffe;
                }
            }

            foreach (Zwerg zwerg in listZwegen)
            {
                if (zwerg.name == selectedZwerge)
                {
                    zwergWithNewArtefakt = zwerg;
                }
            }

            zwergWithNewArtefakt.waffen.Add(newArtefeakt);

            #endregion
        }

        /// <summary>
        /// Funktion die Artefakt entfernt
        /// </summary>
        /// <param name="zwerg"></param>
        public static void  ArtefaktZurucknemmen( Zwerg zwerg)
        {
            int count = 1;
            int userEingabe = 0, maxChoice = 0;

            Console.Clear();
            if (zwerg.waffen.Count > 0)
            {
                foreach (Waffe waffe in zwerg.waffen)
                {
                    Console.WriteLine(count + ": " + "Waffe name: " + waffe.typ);
                    count++;
                    maxChoice = count;
                }

                userEingabe = TrueChoice(userEingabe, maxChoice);

                zwerg.waffen.RemoveAt(userEingabe);
            }
            else
            {
                Console.WriteLine(zwerg.name + " Hat keine Waffe");
                int.TryParse(Console.ReadLine(), out userEingabe);
            }
            
        }
    }
}


