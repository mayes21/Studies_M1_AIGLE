using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RemotingInterfaces;

namespace RemotingServeur
{
    public partial class RemoteOperation : RemotingInterfaces.IRemoteOperationUser
    {

        /* Chercher un livre par un numéro ISBN*/
        public ILivre SearchISBN(string isbn)
        {
            foreach (ILivre liv in listLivre)
            {
                if (liv.Isbn.Equals(isbn))
                {
                    Console.WriteLine("Livre trouvé par ISBN [OK]");
                    /*return "Le livre correspondant au Numero ISBN [" + isbn + "] que vous cherchez est dans le catalogue."
                        + "\n" + liv.DetailLivre();*/
                    return liv;
                }
            }
            ILivre livrNull = new Livre("null", "null", "null", 0, "null");
            return livrNull;
            /*return "Le livre correspondant au Numero ISBN [" + isbn + "] que vous cherchez ne se trouve pas dans le catalogue.";*/
        }

        /* Chercher un livre par un nom d'auteur */
        public ILivre SearchAuthor(string auteur)
        {
            foreach (ILivre liv in listLivre)
            {
                if (liv.Author.Equals(auteur))
                {
                    Console.WriteLine("Livre trouvé par auteur [OK]");
                    /*return "Le livre correspondant au nom d'auteur [" + auteur + "] que vous cherchez est dans le catalogue."
                    + "\n" + liv.DetailLivre();*/
                    return liv;
                }
            }
            ILivre livrNull = new Livre("null", "null", "null", 0, "null");
            return livrNull;
            /*return "Le livre correspondant au nom d'auteur [" + auteur + "] que vous cherchez ne se trouve pas dans le catalogue.";*/

        }


    }
}
