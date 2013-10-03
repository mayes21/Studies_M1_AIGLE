using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientDateDuJour;

namespace ClientDateDuJour
{
    class Program
    {
        
        
        /*public struct DateJourRecup
        {
            public int day;
            public int month;
            public int year;

            public int hour;
            public int minute;
            public int second;
        }*/

        static void Main(string[] args)
        {
            localhost.Service proxy = new localhost.Service();

            Console.WriteLine("------ La date du jour ------");
            Console.WriteLine("Le jour = {0}", proxy.ConsulterDateDuJourStructure().jour);
            Console.WriteLine("Le mois = {0}", proxy.ConsulterDateDuJourStructure().mois);
            Console.WriteLine("L'année = {0}", proxy.ConsulterDateDuJourStructure().annee);
            Console.WriteLine("L'heure = {0}:{1}:{2}", proxy.ConsulterDateDuJourStructure().heure, proxy.ConsulterDateDuJourStructure().minute, proxy.ConsulterDateDuJourStructure().seconde);

            Console.ReadLine();
        }

        
    }
}
