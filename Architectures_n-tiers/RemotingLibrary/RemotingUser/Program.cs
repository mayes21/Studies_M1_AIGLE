using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

namespace RemotingUser
{
    class RemoteUser
    {
        static void Main(string[] args)
        {
            RemotingInterfaces.IRemoteOperationUser remoteOperation;

            try
            {
                TcpChannel channel = new TcpChannel();

                ChannelServices.RegisterChannel(channel, true);

                remoteOperation = (RemotingInterfaces.IRemoteOperationUser)Activator.GetObject(
                    typeof(RemotingInterfaces.IRemoteOperationUser),
                    "tcp://localhost:1069/RemoteOperation");

                Console.WriteLine("\n <RemoteUser> Connecter au <serveur> via le port [1069]... [OK].\n");
                //Console.ReadLine();


                int choix;
                
                do
                {

                    Console.WriteLine("------------ MENU ------------");
                    Console.WriteLine("\t 1- Rechercher un livre par numero ISBN.");
                    Console.WriteLine("\t 2- Rechercher un livre par nom d'auteur");
                    Console.WriteLine("\t 3- Quitter.");

                    Console.Write("Veuillez saisir votre choix : ");

                    string ch;
                    ch = Console.ReadLine();

                    int.TryParse(ch, out choix);

                    switch (choix)
                    {
                        case 1:
                            Console.Write("Saisir le numero ISBN du livre : ");
                            string isbn = Console.ReadLine();
                            Console.WriteLine(remoteOperation.SearchISBN(isbn));

                            Console.WriteLine("\n\n");
                            break;

                        case 2:
                            Console.Write("Saisir le nom de l'auteur : ");
                            string auteur = Console.ReadLine();
                            Console.WriteLine(remoteOperation.SearchAuthor(auteur));

                            Console.WriteLine("\n\n");
                            break;
                        
                        case 3:
                            Console.WriteLine("A Bientot ! ");
                            Console.WriteLine("Appuyez sur <Entrée> pour quitter.");
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Choix Invalide [ECHEC]");
                            break;

                    }

                } while (choix != 3);
            }
            catch
            {
                Console.WriteLine("\nErreur de connexion au serveur [ECHEC].");
                Console.ReadLine();
            }


        }
    }
}
