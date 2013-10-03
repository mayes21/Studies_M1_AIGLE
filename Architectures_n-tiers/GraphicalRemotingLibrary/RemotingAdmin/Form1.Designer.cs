namespace RemotingAdmin
{
    partial class RemoteAdmin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAbonne = new System.Windows.Forms.Button();
            this.textBoxPswAbonne = new System.Windows.Forms.TextBox();
            this.passwordAbonne = new System.Windows.Forms.Label();
            this.textBoxPseudoAbonne = new System.Windows.Forms.TextBox();
            this.pseudoAbonne = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonLivre = new System.Windows.Forms.Button();
            this.textBoxEditeur = new System.Windows.Forms.TextBox();
            this.textBoxnbrExemp = new System.Windows.Forms.TextBox();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.textBoxAuteur = new System.Windows.Forms.TextBox();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.labelEditeur = new System.Windows.Forms.Label();
            this.labelExemplaire = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelAuteur = new System.Windows.Forms.Label();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.groupBoxAuth = new System.Windows.Forms.GroupBox();
            this.labelPseudoAdmin = new System.Windows.Forms.Label();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonAuthAdmin = new System.Windows.Forms.Button();
            this.groupBoxAdmin.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.groupBoxAuth);
            this.groupBoxAdmin.Controls.Add(this.tabControlAdmin);
            this.groupBoxAdmin.Location = new System.Drawing.Point(66, 33);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(586, 331);
            this.groupBoxAdmin.TabIndex = 0;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Gestion Admin";
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPage1);
            this.tabControlAdmin.Controls.Add(this.tabPage2);
            this.tabControlAdmin.Location = new System.Drawing.Point(35, 37);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(520, 265);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAbonne);
            this.tabPage1.Controls.Add(this.textBoxPswAbonne);
            this.tabPage1.Controls.Add(this.passwordAbonne);
            this.tabPage1.Controls.Add(this.textBoxPseudoAbonne);
            this.tabPage1.Controls.Add(this.pseudoAbonne);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajout Abonné";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAbonne
            // 
            this.buttonAbonne.Location = new System.Drawing.Point(324, 124);
            this.buttonAbonne.Name = "buttonAbonne";
            this.buttonAbonne.Size = new System.Drawing.Size(96, 23);
            this.buttonAbonne.TabIndex = 4;
            this.buttonAbonne.Text = "Ajouter l\'abonné";
            this.buttonAbonne.UseVisualStyleBackColor = true;
            this.buttonAbonne.Click += new System.EventHandler(this.buttonAbonne_Click);
            // 
            // textBoxPswAbonne
            // 
            this.textBoxPswAbonne.Location = new System.Drawing.Point(266, 74);
            this.textBoxPswAbonne.Name = "textBoxPswAbonne";
            this.textBoxPswAbonne.Size = new System.Drawing.Size(154, 20);
            this.textBoxPswAbonne.TabIndex = 3;
            // 
            // passwordAbonne
            // 
            this.passwordAbonne.AutoSize = true;
            this.passwordAbonne.Location = new System.Drawing.Point(31, 77);
            this.passwordAbonne.Name = "passwordAbonne";
            this.passwordAbonne.Size = new System.Drawing.Size(173, 13);
            this.passwordAbonne.TabIndex = 2;
            this.passwordAbonne.Text = "Saisir le mot de passe de l\'abonné :";
            // 
            // textBoxPseudoAbonne
            // 
            this.textBoxPseudoAbonne.Location = new System.Drawing.Point(266, 39);
            this.textBoxPseudoAbonne.Name = "textBoxPseudoAbonne";
            this.textBoxPseudoAbonne.Size = new System.Drawing.Size(154, 20);
            this.textBoxPseudoAbonne.TabIndex = 1;
            // 
            // pseudoAbonne
            // 
            this.pseudoAbonne.AutoSize = true;
            this.pseudoAbonne.Location = new System.Drawing.Point(31, 42);
            this.pseudoAbonne.Name = "pseudoAbonne";
            this.pseudoAbonne.Size = new System.Drawing.Size(188, 13);
            this.pseudoAbonne.TabIndex = 0;
            this.pseudoAbonne.Text = "Saisir le nom d\'utilisateur de l\'abonné : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonLivre);
            this.tabPage2.Controls.Add(this.textBoxEditeur);
            this.tabPage2.Controls.Add(this.textBoxnbrExemp);
            this.tabPage2.Controls.Add(this.textBoxIsbn);
            this.tabPage2.Controls.Add(this.textBoxAuteur);
            this.tabPage2.Controls.Add(this.textBoxTitre);
            this.tabPage2.Controls.Add(this.labelEditeur);
            this.tabPage2.Controls.Add(this.labelExemplaire);
            this.tabPage2.Controls.Add(this.labelTitre);
            this.tabPage2.Controls.Add(this.labelAuteur);
            this.tabPage2.Controls.Add(this.labelIsbn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ajout Livre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonLivre
            // 
            this.buttonLivre.Location = new System.Drawing.Point(327, 190);
            this.buttonLivre.Name = "buttonLivre";
            this.buttonLivre.Size = new System.Drawing.Size(80, 23);
            this.buttonLivre.TabIndex = 11;
            this.buttonLivre.Text = "Ajouté le livre";
            this.buttonLivre.UseVisualStyleBackColor = true;
            this.buttonLivre.Click += new System.EventHandler(this.buttonLivre_Click);
            // 
            // textBoxEditeur
            // 
            this.textBoxEditeur.Location = new System.Drawing.Point(225, 150);
            this.textBoxEditeur.Name = "textBoxEditeur";
            this.textBoxEditeur.Size = new System.Drawing.Size(182, 20);
            this.textBoxEditeur.TabIndex = 10;
            // 
            // textBoxnbrExemp
            // 
            this.textBoxnbrExemp.Location = new System.Drawing.Point(225, 116);
            this.textBoxnbrExemp.Name = "textBoxnbrExemp";
            this.textBoxnbrExemp.Size = new System.Drawing.Size(182, 20);
            this.textBoxnbrExemp.TabIndex = 9;
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(225, 83);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(182, 20);
            this.textBoxIsbn.TabIndex = 8;
            // 
            // textBoxAuteur
            // 
            this.textBoxAuteur.Location = new System.Drawing.Point(225, 50);
            this.textBoxAuteur.Name = "textBoxAuteur";
            this.textBoxAuteur.Size = new System.Drawing.Size(182, 20);
            this.textBoxAuteur.TabIndex = 7;
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(225, 16);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(182, 20);
            this.textBoxTitre.TabIndex = 6;
            // 
            // labelEditeur
            // 
            this.labelEditeur.AutoSize = true;
            this.labelEditeur.Location = new System.Drawing.Point(43, 154);
            this.labelEditeur.Name = "labelEditeur";
            this.labelEditeur.Size = new System.Drawing.Size(126, 13);
            this.labelEditeur.TabIndex = 5;
            this.labelEditeur.Text = "Saisir le nom de l\'éditeur :";
            // 
            // labelExemplaire
            // 
            this.labelExemplaire.AutoSize = true;
            this.labelExemplaire.Location = new System.Drawing.Point(43, 120);
            this.labelExemplaire.Name = "labelExemplaire";
            this.labelExemplaire.Size = new System.Drawing.Size(153, 13);
            this.labelExemplaire.TabIndex = 4;
            this.labelExemplaire.Text = "Saisir le nombre d\'exemplaires :";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(43, 19);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(106, 13);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Saisir le titre du livre :";
            // 
            // labelAuteur
            // 
            this.labelAuteur.AutoSize = true;
            this.labelAuteur.Location = new System.Drawing.Point(43, 53);
            this.labelAuteur.Name = "labelAuteur";
            this.labelAuteur.Size = new System.Drawing.Size(124, 13);
            this.labelAuteur.TabIndex = 2;
            this.labelAuteur.Text = "Saisir le nom de l\'auteur :";
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(43, 86);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(152, 13);
            this.labelIsbn.TabIndex = 3;
            this.labelIsbn.Text = "Saisir le numéro ISBN du livre :";
            // 
            // groupBoxAuth
            // 
            this.groupBoxAuth.Controls.Add(this.buttonAuthAdmin);
            this.groupBoxAuth.Controls.Add(this.textBoxPass);
            this.groupBoxAuth.Controls.Add(this.labelPassword);
            this.groupBoxAuth.Controls.Add(this.textBoxPseudo);
            this.groupBoxAuth.Controls.Add(this.labelPseudoAdmin);
            this.groupBoxAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuth.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAuth.Name = "groupBoxAuth";
            this.groupBoxAuth.Size = new System.Drawing.Size(586, 331);
            this.groupBoxAuth.TabIndex = 1;
            this.groupBoxAuth.TabStop = false;
            this.groupBoxAuth.Text = "Autentification";
            // 
            // labelPseudoAdmin
            // 
            this.labelPseudoAdmin.AutoSize = true;
            this.labelPseudoAdmin.Location = new System.Drawing.Point(116, 59);
            this.labelPseudoAdmin.Name = "labelPseudoAdmin";
            this.labelPseudoAdmin.Size = new System.Drawing.Size(77, 16);
            this.labelPseudoAdmin.TabIndex = 0;
            this.labelPseudoAdmin.Text = "Username :";
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(222, 55);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(155, 22);
            this.textBoxPseudo.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(116, 98);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(74, 16);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password :";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(222, 93);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(155, 22);
            this.textBoxPass.TabIndex = 3;
            // 
            // buttonAuthAdmin
            // 
            this.buttonAuthAdmin.Location = new System.Drawing.Point(277, 129);
            this.buttonAuthAdmin.Name = "buttonAuthAdmin";
            this.buttonAuthAdmin.Size = new System.Drawing.Size(99, 23);
            this.buttonAuthAdmin.TabIndex = 4;
            this.buttonAuthAdmin.Text = "S\'authentifier";
            this.buttonAuthAdmin.UseVisualStyleBackColor = true;
            this.buttonAuthAdmin.Click += new System.EventHandler(this.buttonAuthAdmin_Click);
            // 
            // RemoteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 405);
            this.Controls.Add(this.groupBoxAdmin);
            this.Name = "RemoteAdmin";
            this.Text = "Remote Admin";
            this.groupBoxAdmin.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxAuth.ResumeLayout(false);
            this.groupBoxAuth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAbonne;
        private System.Windows.Forms.TextBox textBoxPswAbonne;
        private System.Windows.Forms.Label passwordAbonne;
        private System.Windows.Forms.TextBox textBoxPseudoAbonne;
        private System.Windows.Forms.Label pseudoAbonne;
        private System.Windows.Forms.Button buttonLivre;
        private System.Windows.Forms.TextBox textBoxEditeur;
        private System.Windows.Forms.TextBox textBoxnbrExemp;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.TextBox textBoxAuteur;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.Label labelEditeur;
        private System.Windows.Forms.Label labelExemplaire;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelAuteur;
        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.Button buttonAuthAdmin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.Label labelPseudoAdmin;
    }
}

