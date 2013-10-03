using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RemotingInterfaces;

namespace RemotingServeur
{
    public partial class RemoteOperation : IRemoteOperationAbonne
    {



        /* Afficher la liste des livres [TITRES]*/
        public List<string> AfficherListeLivres()
        {
            List<string> listTitres = new List<string>();

            foreach (Livre li in listLivre)
            {
                listTitres.Add(li.Title);
            }

            return listTitres;
        }

        /* Commenter un livre */
        public string CommenterLivre(string titreLivre, string comment)
        {
            
            foreach (Livre li in listLivre)
            {
                if (li.Title.Equals(titreLivre))
                {
                    li.ListComment.Add(comment);

                    Console.WriteLine();
                    foreach(string st in li.ListComment)
                    {
                        Console.WriteLine(st);
                    }
                    Console.WriteLine();
                    return "\nCommentaire ajouté avec succès!\n";
                }
            }
            return "Ajout commentaire [ECHEC] : Le livre n'est pas dans la liste.\n";
        }

        /* Authentification des abonnés */
        public bool Authentification(string user, string psw)
        {
            string password = "";
            if (listAbonne.ContainsKey(user))
            {
                if (listAbonne.TryGetValue(user, out password))
                {
                    if (password.Equals(psw))
                    {
                        Console.WriteLine("Authentification Abonné [OK]");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Authentification Abonné [ECHEC]");
                        return false;
                    }
                }
            }
            return false;
        }

        

    }
}
