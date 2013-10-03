using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemotingInterfaces
{
    public interface IRemoteOperationAdmin
    {
        string AddLivre(string title, string author, string isbn, int nbrExemplaire, string editeur);
        string AddAbonne(string username, string password);
        bool AuthAdmin(string user, string pass);
    }

    public interface IRemoteOperationUser
    {
        ILivre SearchISBN(string isbn);
        ILivre SearchAuthor(string auteur);
    }

    public interface IRemoteOperationAbonne
    {
        bool Authentification(string user, string psw);
        List<ILivre> AfficherListeLivres();
        string CommenterLivre(string titreLivre, string comment);
        List<string> GetListTitre();
        List<string> GetListComment(string titreLiv);
    }

    public interface ILivre
    {

        string DetailLivre();
        string Title { get; set; }
        string Author { get; set; }
        string Isbn { get; set; }
        int NbrExemplaire { get; set; }
        string Editor { get; set; }
        List<string> ListComment { get; }
    }


}
