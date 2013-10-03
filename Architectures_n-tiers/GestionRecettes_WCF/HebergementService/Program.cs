using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HebergementService
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost serviceHost = new ServiceHost(typeof(ServiceRecettes.ServiceImpl)))
            {
                try
                {
                    // Open the ServiceHost to start listening for messages
                    serviceHost.Open();

                    // The service can now be accessed
                    Console.WriteLine("Le service est pres à l'emploi...");
                    Console.WriteLine("Appuyez sur <ENTREE> pour arreter le service.");

                    Console.ReadLine();

                    // Close the ServiceHost
                    serviceHost.Close();
                }
                catch (TimeoutException timeProblem)
                {
                    Console.WriteLine(timeProblem.Message);
                    Console.ReadLine();
                }
                catch (CommunicationException commProblem)
                {
                    Console.WriteLine(commProblem.Message);
                    Console.ReadLine();
                }

            }
        }
    }
}
