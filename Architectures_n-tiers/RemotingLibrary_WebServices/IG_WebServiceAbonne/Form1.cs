using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IG_WebServiceAbonne.localhost;

namespace IG_WebServiceAbonne
{
    public partial class form1 : Form
    {

        Service webSer = new Service();

        public form1()
        {
            InitializeComponent();
            
            ListBoxTitre.DataSource = webSer.getListTitre();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            string currentItem = ListBoxTitre.SelectedItem.ToString();
            string commentaire = textBoxComment.Text.Trim();
            if (commentaire.Length != 0)
            {
                MessageBox.Show(webSer.CommentBookWS(currentItem, commentaire), "Commentaire ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxComment.Clear();
                listViewComment.Clear();
                foreach (string coms in webSer.getListComment(currentItem))
                {
                    listViewComment.Items.Add(coms);
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner le  champs de saisie commentaire SVP !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }


    }
}
