using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

namespace RemotingAbonne
{
    class RemoteAbonne
    {
        static void Main(string[] args)
        {

            RemotingInterfaces.IRemoteOperationAbonne remoteOperation;

            try
            {
                TcpChannel channel = new TcpChannel();

                ChannelServices.RegisterChannel(channel, true);

                remoteOperation = (RemotingInterfaces.IRemoteOperationAbonne)Activator.GetObject(
                    typeof(RemotingInterfaces.IRemoteOperationAbonne),
                    "tcp://localhost:1069/RemoteOperation");

                Console.WriteLine("\n <RemoteAbonne> Connecter au <serveur> via le port [1069]... [OK].\n");
                //Console.ReadLine();

                

                Console.WriteLine("\n\t----------------- Se connecter ------------------");
                Console.WriteLine("\t|                                               |");
                Console.Write("\t|\tLOGIN : ");
                string pseudo = Console.ReadLine();
                Console.Write("\t|\tPASSWORD : ");
                string mdp = Console.ReadLine();
                Console.WriteLine("\t|                                               |");
                Console.WriteLine("\t-------------------------------------------------");

                if (remoteOperation.Authentification(pseudo, mdp))
                {
                    Console.WriteLine("Vous êtes maintenant connecté.\n");

                    int choix;
                
                    do
                    {

                        Console.WriteLine("------------ MENU ------------");
                        Console.WriteLine("\t 1- Consulter la liste des livres.");
                        Console.WriteLine("\t 2- Ajouter un commentaire à un livre.");
                        Console.WriteLine("\t 3- Quitter.");

                        Console.Write("Veuillez saisir votre choix : ");

                        string ch;
                        ch = Console.ReadLine();

                        int.TryParse(ch, out choix);

                        switch (choix)
                        {
                            case 1:

                                Console.WriteLine("\n\t-- La liste des livres par Titre -- \n");

                                foreach (string str in remoteOperation.AfficherListeLivres())
                                {
                                    Console.WriteLine("[Titre] = {0}", str);
                                }

                                Console.WriteLine("\n\n");
                                break;

                            case 2:

                                Console.WriteLine("\n\t-- Commenter un livre -- \n");

                                Console.Write("Saisir le titre du livre que vous voulez commenter : ");
                                string titre = Console.ReadLine();
                                Console.Write("Saisir le commentaire : ");
                                string commentaire = Console.ReadLine();

                                Console.WriteLine(remoteOperation.CommenterLivre(titre, commentaire));

                                Console.WriteLine("\n\n");
                                break;

                            case 3:
                                Console.WriteLine("Vous êtes maintenant deconnecté.");
                                Console.WriteLine("Appuyez sur <Entrée> pour quitter.");
                                Console.ReadLine();
                                break;

                            default:
                                Console.WriteLine("Choix Invalide [ECHEC]");
                                break;

                        }

                    } while (choix != 3);



                    
                }
                else
                {
                    Console.WriteLine(" /!\\ Echec de l'authentification. [ECHEC]\n");
                    Console.ReadLine();
                }


              //  Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("\nErreur de connexion au serveur [ECHEC].");
                Console.ReadLine();
            }
        }
    }
}
