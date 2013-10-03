using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace RemotingUser
{
    public partial class Form1 : Form
    {
        private RemotingInterfaces.IRemoteOperationUser remoteOperation;


        public Form1()
        {
            InitializeComponent();
            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, true);
                remoteOperation = (RemotingInterfaces.IRemoteOperationUser)Activator.GetObject(
                    typeof(RemotingInterfaces.IRemoteOperationUser),
                    "tcp://localhost:1069/RemoteOperation");
            }
            catch 
            { 
                MessageBox.Show("Erreur de connexion au serveur"); 
            }

        }

        private void buttonSearchIsbn_Click(object sender, EventArgs e)
        {
            if (remoteOperation != null)
            {
                string isbn = textBoxIsbn.Text.Trim();
                if (isbn.Length != 0)
                {
                    MessageBox.Show(remoteOperation.SearchISBN(isbn), "Détails du livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxIsbn.Clear();
                }
                else
                {
                    MessageBox.Show("Veuillez saisir un numero ISBN dans la zone de saisie.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }


            }
        }

        private void buttonSearchAuthor_Click(object sender, EventArgs e)
        {
            if (remoteOperation != null)
            {
                string auteur = textBoxAuthor.Text.Trim();
                if (auteur.Length != 0)
                {
                    MessageBox.Show(remoteOperation.SearchAuthor(auteur), "Détails du livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxAuthor.Clear();
                }
                else
                {
                    MessageBox.Show("Veuillez saisir un nom d'auteur dans la zone de saisie.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }


            }
        }
    }
}
