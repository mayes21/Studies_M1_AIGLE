using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IG_Proj02
{
    public partial class frmSaisiesBoutons : Form
    {
        public frmSaisiesBoutons()
        {
            InitializeComponent();
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            // on affiche le texte qui a été saisi dans le TextBox textboxSaisie
            string texte = textBoxSaisie.Text.Trim();
            if (texte.Length != 0)
            {
                MessageBox.Show("Texte saisi = " + texte, "Vérification de la saisie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Saissez un texte...", "Vérification de la saisie", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
