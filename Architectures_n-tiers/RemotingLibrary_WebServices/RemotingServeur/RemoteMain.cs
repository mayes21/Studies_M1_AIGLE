using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace RemotingServeur
{
    class RemoteMain
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                // Création d'un nouveau canal d'écoute sur le port 1069
                TcpChannel channel = new TcpChannel(1069);

                // Enregistrement du canal
                ChannelServices.RegisterChannel(channel, true);

                // Démarrage de l'écoute en exposant l'objet en Singleton
                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(RemoteOperation),
                    "RemoteOperation",
                    WellKnownObjectMode.Singleton);

                Console.WriteLine("\nLe serveur a démarré avec succés...");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Erreur lors du démarrage du serveur [ERROR]");
                Console.ReadLine();
            }
        }
    }
}
