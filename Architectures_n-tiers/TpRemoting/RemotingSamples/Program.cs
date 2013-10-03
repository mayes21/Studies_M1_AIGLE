using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemotingSamples
{
    public class ForwardMe : MarshalByRefObject
    {
        public void CallMe(String text)
        {
            Console.WriteLine(text);
        }
    }

    public class HelloServer : MarshalByRefObject
    {
        private int compteur;

        // Constructeur de la classe HelloServer
        public HelloServer()
        {
            Console.WriteLine("HelloServer activ");
            compteur = 0;
        }

        public String HelloMethod(String name, ForwardMe obj)
        {
            obj.CallMe("Message venant du serveur.");
            Console.WriteLine("Hello.HelloMethod : {0}", name);
            return "Bonjour " + name;
        }

        public int CountMe()
        {
            compteur++;
            return compteur;
        }
    }
}
