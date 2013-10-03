using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IG_WebServiceUser.localhost;
using IG_WebServiceUser.com.daehosting.webservices;

namespace IG_WebServiceUser
{
    public partial class Form1 : Form
    {
        Service webSer = new Service();
        ISBNService isbnWS = new ISBNService();

        public Form1()
        {
            InitializeComponent();
        }

        private void SearchISBNButton_Click(object sender, EventArgs e)
        {

            string isbn = textBoxISBNws.Text.Trim();
            if (isbn.Length != 0)
            {
                //if (isbnWS.IsValidISBN13(isbn) || isbnWS.IsValidISBN10(isbn))
               // {
                    if (webSer.SearchByISBNWS(isbn).Equals("Le livre correspondant au numero ISBN [" + isbn + "] que vous cherchez est dans le catalogue."))
                    {
                        MessageBox.Show("Le livre est dans le catalogue", "Livre trouvé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxISBNws.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Le livre n'est pas dans le catalogue", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        textBoxISBNws.Clear();
                    }
                //}
                //else
                //{
                 //   MessageBox.Show("Le numero ISBN que vous avez saisi n'est pas valide.");
                 //   textBoxISBNws.Clear();
               // }

            }
            else
            {
                MessageBox.Show("Veuillez saisir un numero ISBN dans la zone de saisie.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void SearchAuthorButton_Click(object sender, EventArgs e)
        {
            string auteur = textBoxAUTEURws.Text.Trim();
            if (auteur.Length != 0)
            {
                if (webSer.SearchByAuthorWS(auteur).Equals("Le livre correspondant au nom d'auteur [" + auteur + "] que vous cherchez est dans le catalogue."))
                {
                    MessageBox.Show("Le livre est dans le catalogue", "Livre trouvé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxAUTEURws.Clear();
                }
                else
                {
                    MessageBox.Show("Le livre n'est pas dans le catalogue", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    textBoxAUTEURws.Clear();
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un numero ISBN dans la zone de saisie.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

    }
}
