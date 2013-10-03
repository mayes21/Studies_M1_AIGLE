using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

namespace RemotingAdmin
{
    public partial class RemoteAdmin : Form
    {

        private RemotingInterfaces.IRemoteOperationAdmin remoteOperation;

        public RemoteAdmin()
        {
            InitializeComponent();
            
           //groupBoxAdmin.Hide();
           //tabControlAdmin.Hide();

            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, true);
                remoteOperation = (RemotingInterfaces.IRemoteOperationAdmin)Activator.GetObject(
                    typeof(RemotingInterfaces.IRemoteOperationAdmin),
                    "tcp://localhost:1069/RemoteOperation");
            }
            catch
            {
                MessageBox.Show("Erreur de connexion au serveur");
            }

        }

        private void buttonAuthAdmin_Click(object sender, EventArgs e)
        {

            if (remoteOperation != null)
            {
                string username = textBoxPseudo.Text.Trim();
                string password = textBoxPass.Text.Trim();

                if (username.Length != 0 || password.Length != 0)
                {
                    if (remoteOperation.AuthAdmin(username, password))
                    {
                        groupBoxAuth.Hide();
                        groupBoxAdmin.Show();
                        tabControlAdmin.Show();

                        
                    }
                    else
                    {
                        MessageBox.Show("Username et/ou mot de passe incorrect !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                        textBoxPseudo.Clear();
                        textBoxPass.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs de saisie SVP !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }



        private void buttonAbonne_Click(object sender, EventArgs e)
        {

            
            if (remoteOperation != null)
            {
                string pseudo = textBoxPseudoAbonne.Text.Trim();
                string password = textBoxPswAbonne.Text.Trim();

                if (pseudo.Length != 0 || password.Length != 0)
                {
                    MessageBox.Show(remoteOperation.AddAbonne(pseudo, password),"Ajout effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPseudoAbonne.Clear();
                    textBoxPswAbonne.Clear(); 
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs de saisie SVP !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLivre_Click(object sender, EventArgs e)
        {
            string titre = textBoxTitre.Text.Trim();
            string auteur = textBoxAuteur.Text.Trim();
            string isbn = textBoxIsbn.Text.Trim();
            int nbrExemp = Int32.Parse(textBoxnbrExemp.Text.Trim());
            string editeur = textBoxEditeur.Text.Trim();

            if (titre.Length != 0 || auteur.Length != 0 || isbn.Length != 0 || nbrExemp != 0 || editeur.Length != 0)
            {
                MessageBox.Show(remoteOperation.AddLivre(titre, auteur, isbn, nbrExemp, editeur),"Ajout effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTitre.Clear();
                textBoxAuteur.Clear();
                textBoxIsbn.Clear();
                textBoxnbrExemp.Clear();
                textBoxEditeur.Clear();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs de saisie SVP !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        





    }
}
