using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemotingServeur
{
    public partial class RemoteOperation : RemotingInterfaces.IRemoteOperationAdmin
    {

        Dictionary<string, string> listAbonne = new Dictionary<string, string>();


        /* Ajouter un livre à la liste des livres */
        public string AddLivre(string titre, string author, string isbn, int nbrExemplaire, string editeur)
        {
            foreach (Livre liv in listLivre)
            {
                if (liv.Title.Equals(titre))
                {
                    return "Livre [" + titre + "] existe déjà.";
                }
            }
            listLivre.Add(new Livre(titre, author, isbn, nbrExemplaire, editeur));
            this.Afficher();
            return "Livre [" + titre + "] ajouté avec succès.";

        }

        /* Ajouter un abonné à la liste des abonnés */
        public string AddAbonne(string username, string password)
        {
            if (listAbonne.ContainsKey(username))
            {
                return "Abonné [" + username + "] existe déjà.";
            }
            listAbonne.Add(username, password);
            this.ConsulterListeAbonnes();
            return "Abonné [" + username + "] ajouté avec succès.";

        }

        /* Authentification des administrateurs */
        public bool AuthAdmin(string user, string pass)
        {
            string password = "";
            if (listAdmin.ContainsKey(user))
            {
                if (listAdmin.TryGetValue(user, out password))
                {
                    if (password.Equals(pass))
                    {
                        Console.WriteLine("Authentification Admin [OK]");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Authentification Admin [ECHEC]");
                        return false;
                    }
                }
            }
            return false;
        }

        /* Afficher la liste des livres */
        private void Afficher()
        {
            Console.WriteLine("\n\t------- Détails des livres -------\n");
            foreach (Livre liv in listLivre)
            {
                Console.WriteLine(liv.DetailLivre());
                Console.WriteLine();
            }
        }

        /* Consulter la liste des abonnés */
        private void ConsulterListeAbonnes()
        {
            foreach (KeyValuePair<string, string> pair in listAbonne)
            {
                Console.WriteLine(pair.Key);
            }
        }
    }
}
