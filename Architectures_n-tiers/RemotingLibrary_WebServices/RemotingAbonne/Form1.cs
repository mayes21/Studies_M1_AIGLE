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
using RemotingInterfaces;

namespace RemotingAbonne
{
    public partial class RemoteAbonne : Form
    {

        private RemotingInterfaces.IRemoteOperationAbonne remoteOperation;

        public RemoteAbonne()
        {
            InitializeComponent();
            tabControlAbonne.Hide();
            //textBoxResult.Hide();
            comboBoxTitre.Hide();
            groupBoxListLiv.Hide();

            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, true);
                remoteOperation = (RemotingInterfaces.IRemoteOperationAbonne)Activator.GetObject(
                    typeof(RemotingInterfaces.IRemoteOperationAbonne),
                    "tcp://localhost:1069/RemoteOperation");
            }
            catch
            {
                MessageBox.Show("Erreur de connexion au serveur");
            }
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {


            if (remoteOperation != null)
            {
                string username = textBoxPseudo.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                if (username.Length != 0 || password.Length != 0)
                {
                    if (remoteOperation.Authentification(username, password))
                    {


                        groupBoxAuth.Hide();
                        tabControlAbonne.Show();
                        comboBoxTitre.Show();
                        groupBoxListLiv.Show();
                        //textBoxResult.Show();

                    }
                    else
                    {
                        MessageBox.Show("Username et/ou mot de passe incorrect !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                        textBoxPseudo.Clear();
                        textBoxPassword.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs de saisie SVP !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonListTitre_Click(object sender, EventArgs e)
        {
            List<ILivre> listLivre = remoteOperation.AfficherListeLivres();
            List<string> listTitre = new List<string>();
            foreach (ILivre liv in listLivre)
            {
                listTitre.Add(liv.Title);
            }

            comboBoxTitre.DataSource = listTitre;

        }

        private void buttonComm_Click(object sender, EventArgs e)
        {
            string titr = textBoxTitreAComm.Text.Trim();
            string comm = textBoxCommentaire.Text.Trim();

            if (titr.Length != 0 || comm.Length != 0)
            {
                MessageBox.Show(remoteOperation.CommenterLivre(titr, comm), "Commentaire ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTitreAComm.Clear();
                textBoxCommentaire.Clear();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs de saisie SVP !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }




    }
}
