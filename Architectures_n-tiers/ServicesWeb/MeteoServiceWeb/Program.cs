using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeteoServiceWeb.net.webservicex.www;
using System.Xml;
using MeteoServiceWeb.net.webservicex.www1;
using System.Globalization;


namespace MeteoServiceWeb
{
    class Program
    {
        static void Main(string[] args)
        {

            /* --------------------- FIRST PART -----------------------*/


            /*
             * @@@@@ Déclarations
             * 
             */


            GlobalWeather proxy1 = new GlobalWeather();

            XmlDocument xmlDoc = new XmlDocument();
            XmlDocument xmlDocWeather = new XmlDocument();

            List<string> listVilles = new List<string>();

            Console.Write("Saisir le nom du pays dont vous souhaitez lister les villes : ");
            string pays = Console.ReadLine();

            try
            {
                /* Transformation du flux résultant en document XML */
                xmlDoc.LoadXml(proxy1.GetCitiesByCountry(pays));
                Console.WriteLine("Chargement Country/City effectué [OK]...\n");
            }
            catch
            {
                Console.WriteLine("Erreur de transformation en document XML (Country/City) [ECHEC]");
            }

            /* Sauvegarder le résultat dans un fichier xml */
            xmlDoc.Save(@"C:\Users\Amayas\Documents\Visual Studio 2010\Projects\ServiceWeb\MeteoServiceWeb\Villes.xml");

            /* Extraire les villes (<City></City>) du flux XML et les ajouter à une liste */
            foreach (XmlNode e in xmlDoc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode i in e.ChildNodes)
                {
                    if (i.Name.Equals("City"))
                    {
                        listVilles.Add(i.InnerText);
                    }
                }
                Console.WriteLine("\n");
            }


            /* Afficher les villes sauvegarder dans la liste "listVilles" */
            int cpt = 1;
            foreach (string city in listVilles)
            {
                Console.WriteLine("Ville {0} = {1}", cpt, city);
                cpt++;
            }


            Console.Write("Saisir le nom de la ville dont vous souhaitez connaitre la meteo : ");
            string ville = Console.ReadLine();

            /* Sauvegarde du flux résultant dans une variable */
            string xmlWeather = proxy1.GetWeather(ville, pays);

            try
            {
                /* Transformation du flux résultant en document XML */
                xmlDocWeather.LoadXml(xmlWeather);
                Console.WriteLine("Chargement Weather effectué [OK]...\n");
            }
            catch
            {
                Console.WriteLine("Erreur de transformation en document XML (Weather) [ECHEC]");
            }

            /* Sauvegarder le résultat dans un fichier xml */
            xmlDocWeather.Save(@"C:\Users\Amayas\Documents\Visual Studio 2010\Projects\ServiceWeb\MeteoServiceWeb\Weather.xml");

            /* Extraction des informations (vent, temperature, ciel), en precisant la date du releve meteo. */

            /*
             *  @@@@ DECLARATIONS BIS
             * 
             */

            string dateHeure = null;
            string vent = null;
            string temperature = null;
            string ciel = null;

            //Console.WriteLine(xmlDocWeather.DocumentElement.InnerText);

            foreach (XmlNode e in xmlDocWeather.DocumentElement.ChildNodes)
            {
                if (e.Name.Equals("Time"))
                {
                    dateHeure = e.InnerText;
                }

                if (e.Name.Equals("Wind"))
                {
                    vent = e.InnerText;
                }

                if (e.Name.Equals("Temperature"))
                {
                    temperature = e.InnerText;
                }

                if (e.Name.Equals("SkyConditions"))
                {
                    ciel = e.InnerText;
                }

            }

            Console.WriteLine("La date = " + dateHeure);
            Console.WriteLine("Le vent = " + vent);
            Console.WriteLine("La temperature = " + temperature);
            Console.WriteLine("Le ciel = " + ciel);

            




            /* -------------------- SECOND PART ------------------- */

            ConvertTemperature proxy2 = new ConvertTemperature();

            Console.Write("\nSaisir la temperature à convertir : ");
            string tempStr = Console.ReadLine();
            double temp = double.Parse(tempStr, CultureInfo.InvariantCulture);

            Console.Write("\nSaisir l'unité de temperature que vous voulez convertir (degreeCelsius/degreeFahrenheit): ");
            string tempUnit = Console.ReadLine();

            switch (tempUnit)
            {
                case "degreeCelsius":

                    double celsKelv = proxy2.ConvertTemp(temp, TemperatureUnit.degreeCelsius, TemperatureUnit.kelvin);
                    Console.WriteLine("\nLa temperature en Kelvin = {0}", celsKelv);
                    break;

                case "degreeFahrenheit":

                    double fahKelv = proxy2.ConvertTemp(temp, TemperatureUnit.degreeFahrenheit, TemperatureUnit.kelvin);
                    Console.WriteLine("\nLa temperature en Kelvin = {0}", fahKelv);
                    break;

                default:
                    Console.WriteLine("Choix invalide !!");
                    break;

            }
            
            

           


        }
    }
}
