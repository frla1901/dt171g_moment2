/*
* Moment 2 DT172G - Programmering i C# 
* Konsolapplikation där inmatat datum visar vilken veckodag det var.
* Skapad av Frida Lazzari november 2021
*/

using System;

namespace dt171g_moment2
{
    class WeekDay
    {
        /* 
            * Metod för att hitta veckodag för ett specifikt datum
            * Tar 3 argument - år, månad och dag.
            */
        static void ZellerAlgoritm(int year,
                        int month, int day)
        {
            if (month == 1)
            {
                month = 13;
                year--;
            }
            if (month == 2)
            {
                month = 14;
                year--;
            }
            /* 
            * Beräkningar enligt Zellers Algoritm 
            */

            // noll-baserat århundrade t.ex. 20 för 2021 och 19 för 1977
            int c = year / 100;
            // århundradets år-tal t.ex. 21 för året 2021 eller 77 för året 1977)
            int y = year % 100;
            // månad 
            int m = month;
            // dag
            int d = day;
            // veckodag (0 = lördag, 1 = söndag osv.)
            int h = d + 13 * (m + 1) / 5 + y + y / 4 + c / 4 + 5 * c;
            h = h % 7;
            /* 
            * switch sats med 7 olika case. 
            * beroende på resultat av det inmatade datumet visas vilken dag det var.
            */
            switch (h)
            {
                case 0:
                    Console.WriteLine("Det var en lördag");
                    break;

                case 1:
                    Console.WriteLine("Det var en söndag");
                    break;

                case 2:
                    Console.WriteLine(" Det var en måndag");
                    break;

                case 3:
                    Console.WriteLine("Det var en tisdag");
                    break;

                case 4:
                    Console.WriteLine("Det var en onsdag");
                    break;

                case 5:
                    Console.WriteLine("Det var en torsdag");
                    break;

                case 6:
                    Console.WriteLine("Det var en fredag");
                    break;
            }

        }
        // Konstanter för vilka år (1800-9999) som ska anses vara giltiga (span)
        const int MAX_VALID_YR = 9999;
        const int MIN_VALID_YR = 1900;

        static bool isLeap(int year)
        {
            // Beräkning av skottår 
            // Returnerar true om året är 
            // multipel av 4 och inte
            // multipel av 100. Eller
            // multipel av 400
            return (((year % 4 == 0) &&
                    (year % 100 != 0)) ||
                    (year % 400 == 0));
        }

        static bool isValidDate(int year,
                                int month,
                                int day)
        {

            // Om år, månad och dag inte är inom det givna spannet
            if (year > MAX_VALID_YR ||
                year < MIN_VALID_YR)
                return false;
            // månad = 1-12
            if (month < 1 || month > 12)
                return false;
            // dag = 1-31
            if (day < 1 || day > 31)
                return false;

            // Hantering av antal dagar i februari
            // inklusive skottår
            if (month == 2)
            {
                if (isLeap(year))
                    return (day <= 29);
                else
                    return (day <= 28);
            }
            // Hantering av april, june, september och november 
            // måste ha 30 dagar eller färre
            if (month == 4 || month == 6 ||
                month == 9 || month == 11)
                return (day <= 30);

            return true;
        }
        // metod för kontroll av datum samt utskrift till konsollen
        public static void Main(string[] args)
        {
            /* Inmatade värden från kommandotolken/terminal. 
            * Strängarna för år, månad & dag konverteras till integers med hjälp av int.Parse. 
            */
            Console.WriteLine($"{Environment.NewLine}Vilket år är du född? (ÅÅÅÅ) ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilken månad är du född? (MM)");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilket dag är du född? (DD)");
            int day = int.Parse(Console.ReadLine());
            
            // Validering av inmatat datum 
            // OBS! byt datum och testa om det är giligt eller inte
            if (isValidDate(year, month, day))
            {
                Console.WriteLine($"{Environment.NewLine}Korrekt inmatat datum");

                // Utskrift av vilken veckodag det var 
                ZellerAlgoritm(year, month, day);
            }
            // Om inte korrekt inmatat datum - Felmeddelande
            else
                Console.WriteLine("Tyvärr är inte ett giltigt datum! Skriv datumet i formatet ÅÅÅÅ,MM,DD");
                Console.Write($"{Environment.NewLine}Tryck på valfri tangent.");
                Console.ReadKey(true);
        }

    }
}

