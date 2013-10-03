namespace IG_Proj02
{
    partial class frmSaisiesBoutons
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
            this.labelSaisie = new System.Windows.Forms.Label();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.textBoxSaisie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSaisie
            // 
            this.labelSaisie.AutoSize = true;
            this.labelSaisie.Location = new System.Drawing.Point(41, 27);
            this.labelSaisie.Name = "labelSaisie";
            this.labelSaisie.Size = new System.Drawing.Size(41, 13);
            this.labelSaisie.TabIndex = 0;
            this.labelSaisie.Text = "Saisie :";
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Location = new System.Drawing.Point(135, 70);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficher.TabIndex = 1;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // textBoxSaisie
            // 
            this.textBoxSaisie.Location = new System.Drawing.Point(110, 24);
            this.textBoxSaisie.Name = "textBoxSaisie";
            this.textBoxSaisie.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaisie.TabIndex = 2;
            // 
            // frmSaisiesBoutons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.textBoxSaisie);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.labelSaisie);
            this.Name = "frmSaisiesBoutons";
            this.Text = "Saisies et boutons - 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaisie;
        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.TextBox textBoxSaisie;
    }
}

