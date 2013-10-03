namespace RemotingAbonne
{
    partial class RemoteAbonne
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
            this.groupBoxAuth = new System.Windows.Forms.GroupBox();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.tabControlAbonne = new System.Windows.Forms.TabControl();
            this.tabPageConsulter = new System.Windows.Forms.TabPage();
            this.buttonListTitre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxTitre = new System.Windows.Forms.ComboBox();
            this.groupBoxListLiv = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitreAComm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.buttonComm = new System.Windows.Forms.Button();
            this.groupBoxAuth.SuspendLayout();
            this.tabControlAbonne.SuspendLayout();
            this.tabPageConsulter.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxListLiv.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAuth
            // 
            this.groupBoxAuth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxAuth.Controls.Add(this.buttonAuth);
            this.groupBoxAuth.Controls.Add(this.textBoxPassword);
            this.groupBoxAuth.Controls.Add(this.textBoxPseudo);
            this.groupBoxAuth.Controls.Add(this.labelPassword);
            this.groupBoxAuth.Controls.Add(this.labelLogin);
            this.groupBoxAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxAuth.Location = new System.Drawing.Point(89, 69);
            this.groupBoxAuth.Name = "groupBoxAuth";
            this.groupBoxAuth.Size = new System.Drawing.Size(434, 217);
            this.groupBoxAuth.TabIndex = 0;
            this.groupBoxAuth.TabStop = false;
            this.groupBoxAuth.Text = "Authentification";
            // 
            // buttonAuth
            // 
            this.buttonAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAuth.Location = new System.Drawing.Point(254, 149);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(122, 27);
            this.buttonAuth.TabIndex = 4;
            this.buttonAuth.Text = "Se connecter";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(185, 90);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(191, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPseudo.Location = new System.Drawing.Point(185, 51);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(191, 22);
            this.textBoxPseudo.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPassword.Location = new System.Drawing.Point(64, 96);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(74, 16);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password :";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLogin.Location = new System.Drawing.Point(64, 57);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(77, 16);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Username :";
            // 
            // tabControlAbonne
            // 
            this.tabControlAbonne.Controls.Add(this.tabPageConsulter);
            this.tabControlAbonne.Controls.Add(this.tabPage2);
            this.tabControlAbonne.Location = new System.Drawing.Point(89, 69);
            this.tabControlAbonne.Name = "tabControlAbonne";
            this.tabControlAbonne.SelectedIndex = 0;
            this.tabControlAbonne.Size = new System.Drawing.Size(444, 217);
            this.tabControlAbonne.TabIndex = 0;
            // 
            // tabPageConsulter
            // 
            this.tabPageConsulter.Controls.Add(this.buttonListTitre);
            this.tabPageConsulter.Controls.Add(this.label1);
            this.tabPageConsulter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageConsulter.Location = new System.Drawing.Point(4, 24);
            this.tabPageConsulter.Name = "tabPageConsulter";
            this.tabPageConsulter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsulter.Size = new System.Drawing.Size(436, 189);
            this.tabPageConsulter.TabIndex = 0;
            this.tabPageConsulter.Text = "Consulter la liste des livres";
            this.tabPageConsulter.UseVisualStyleBackColor = true;
            // 
            // buttonListTitre
            // 
            this.buttonListTitre.Location = new System.Drawing.Point(235, 44);
            this.buttonListTitre.Name = "buttonListTitre";
            this.buttonListTitre.Size = new System.Drawing.Size(75, 23);
            this.buttonListTitre.TabIndex = 2;
            this.buttonListTitre.Text = "Par titre";
            this.buttonListTitre.UseVisualStyleBackColor = true;
            this.buttonListTitre.Click += new System.EventHandler(this.buttonListTitre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulter la liste des livres par titre :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonComm);
            this.tabPage2.Controls.Add(this.textBoxCommentaire);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxTitreAComm);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commenter un livre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxTitre
            // 
            this.comboBoxTitre.FormattingEnabled = true;
            this.comboBoxTitre.Location = new System.Drawing.Point(39, 26);
            this.comboBoxTitre.Name = "comboBoxTitre";
            this.comboBoxTitre.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTitre.TabIndex = 1;
            // 
            // groupBoxListLiv
            // 
            this.groupBoxListLiv.Controls.Add(this.comboBoxTitre);
            this.groupBoxListLiv.Location = new System.Drawing.Point(585, 69);
            this.groupBoxListLiv.Name = "groupBoxListLiv";
            this.groupBoxListLiv.Size = new System.Drawing.Size(200, 213);
            this.groupBoxListLiv.TabIndex = 2;
            this.groupBoxListLiv.TabStop = false;
            this.groupBoxListLiv.Text = "Liste des livres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saisir le titre du livre à commenter :";
            // 
            // textBoxTitreAComm
            // 
            this.textBoxTitreAComm.Location = new System.Drawing.Point(250, 45);
            this.textBoxTitreAComm.Name = "textBoxTitreAComm";
            this.textBoxTitreAComm.Size = new System.Drawing.Size(144, 21);
            this.textBoxTitreAComm.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saisir le commentaire :";
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Location = new System.Drawing.Point(181, 78);
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(213, 52);
            this.textBoxCommentaire.TabIndex = 3;
            // 
            // buttonComm
            // 
            this.buttonComm.Location = new System.Drawing.Point(306, 146);
            this.buttonComm.Name = "buttonComm";
            this.buttonComm.Size = new System.Drawing.Size(88, 23);
            this.buttonComm.TabIndex = 4;
            this.buttonComm.Text = "Commenter";
            this.buttonComm.UseVisualStyleBackColor = true;
            this.buttonComm.Click += new System.EventHandler(this.buttonComm_Click);
            // 
            // RemoteAbonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 435);
            this.Controls.Add(this.tabControlAbonne);
            this.Controls.Add(this.groupBoxAuth);
            this.Controls.Add(this.groupBoxListLiv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RemoteAbonne";
            this.Text = "Remote Abonné";
            this.groupBoxAuth.ResumeLayout(false);
            this.groupBoxAuth.PerformLayout();
            this.tabControlAbonne.ResumeLayout(false);
            this.tabPageConsulter.ResumeLayout(false);
            this.tabPageConsulter.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxListLiv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.TabControl tabControlAbonne;
        private System.Windows.Forms.TabPage tabPageConsulter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonListTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTitre;
        private System.Windows.Forms.GroupBox groupBoxListLiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitreAComm;
        private System.Windows.Forms.Button buttonComm;
    }
}

