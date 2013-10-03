using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemotingServeur
{
    class Livre : MarshalByRefObject, RemotingInterfaces.ILivre
    {
        private List<string> listComment;

        /* Constructeur avec params */
        public Livre(string titre, string auteur, string isbn, int nbrExemp, string editeur)
        {
            this.listComment = new List<string>();

            this.Title = titre;
            this.Author = auteur;
            this.Isbn = isbn;
            this.NbrExemplaire = nbrExemp;
            this.Editor = editeur;
        }

        /* Accesseurs */
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int NbrExemplaire { get; set; }
        public string Editor { get; set; }

        public List<string> ListComment
        {
            get { return this.listComment; }
        }



        /* Afficher les détails d'un livre */
        public string DetailLivre()
        {
            string detail = "- Titre = " + this.Title + "\n- Auteur = " + this.Author + "\n- ISBN = " + this.Isbn + "\n- Nombre d'exemplaires = " + this.NbrExemplaire + "\n- Editeur = " + this.Editor;
            return detail;
        }




    }
}
