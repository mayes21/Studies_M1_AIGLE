using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfServiceLibrary;
using System.ServiceModel;

namespace ClientWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Là, la classe de proxy est générée dynamiquement à l'execution... 
             * je ne la vois pas, elle est implicite, c'est pour cela que j'utilise le nom 
             * de l'interface et non pas le nom de la classe 
             * 
             * 
             */

            IService1 serviceProxy = new ChannelFactory<IService1>("AppClient").CreateChannel();

            Console.WriteLine(serviceProxy.GetData(75));

            CompositeType type = new CompositeType();

            type.BoolValue = true;
            type.StringValue = "Bonjour Mayes ";

            Console.WriteLine(serviceProxy.GetDataUsingDataContract(type).BoolValue);
            Console.WriteLine(serviceProxy.GetDataUsingDataContract(type).StringValue);

            Console.WriteLine("Appuyez sur <Entree> pour quitter...");
            Console.ReadLine();
        }
    }
}
