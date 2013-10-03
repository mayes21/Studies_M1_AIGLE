using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

namespace RemotingAdmin
{
    class RemoteAdministrateur
    {
        static void Main(string[] args)
        {

            RemotingInterfaces.IRemoteOperationAdmin remoteOperation;

            try
            {
                TcpChannel channel = new TcpChannel();

                ChannelServices.RegisterChannel(channel, true);

                remoteOperation = (RemotingInterfaces.IRemoteOperationAdmin)Activator.GetObject(
                    typeof(RemotingInterfaces.IRemoteOperationAdmin),
                    "tcp://localhost:1069/RemoteOperation");

                Console.WriteLine("\n <RemoteAdmin> Connecter au <serveur> via le port [1069]... [OK].\n");
                //Console.ReadLine();

                int choix;
                
                do
                {

                Console.WriteLine("------------ MENU ------------");
                Console.WriteLine("\t 1- Ajouter un livre.");
                Console.WriteLine("\t 2- Ajouter un abonné.");
                Console.WriteLine("\t 3- Quitter.");

                Console.Write("Veuillez saisir votre choix : ");

                string ch;
                ch = Console.ReadLine();

                int.TryParse(ch, out choix);

                switch (choix)
                {
                    case 1:

                            Console.Write("Saisir le titre du livre : ");
                            string titre = Console.ReadLine();
                            Console.Write("Saisir le nom de l'auteur : ");
                            string auteur = Console.ReadLine();
                            Console.Write("Saisir le numero ISBN du livre : ");
                            string isbn = Console.ReadLine();
                            Console.Write("Saisir le nombre d'exemplaire : ");
                            string nbrExemp = Console.ReadLine();
                            int nbrExem;
                            int.TryParse(nbrExemp, out nbrExem);
                            Console.Write("Saisir le nom de l'editeur : ");
                            string editeur = Console.ReadLine();

                            remoteOperation.AddLivre(titre, auteur, isbn, nbrExem, editeur);
                            Console.WriteLine("\nAjout Livre [OK]");

                            Console.WriteLine("\n\n");
                            break;

                    case 2:

                            Console.WriteLine("Saisir le username de l'abonné : ");
                            string user = Console.ReadLine();

                            Console.WriteLine("Saisir le password de l'abonné : ");
                            string pass = Console.ReadLine();

                            remoteOperation.AddAbonne(user, pass);
                            Console.WriteLine("\nAjout Abonné [OK]");

                            Console.WriteLine("\n\n");
                            break;
                    
                    case 3:
                            Console.WriteLine("Déconnexion");
                            Console.ReadLine();
                            break;
                    default:

                            Console.WriteLine("Choix Invalide [ECHEC]");
                            break;
                }
                
                }while(choix != 3);
            }
            catch 
            { 
                Console.WriteLine("Erreur de connexion au serveur [ECHEC]");
                Console.ReadLine();
            }

        }

           
            

        
    }
}
