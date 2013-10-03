namespace IG_Proj04
{
    partial class remoteUserForm
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
            this.saisiIsbn = new System.Windows.Forms.Label();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.IsbnSearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saisiIsbn
            // 
            this.saisiIsbn.AutoSize = true;
            this.saisiIsbn.Location = new System.Drawing.Point(20, 53);
            this.saisiIsbn.Name = "saisiIsbn";
            this.saisiIsbn.Size = new System.Drawing.Size(107, 13);
            this.saisiIsbn.TabIndex = 1;
            this.saisiIsbn.Text = "Veuillez saisir l\'ISBN :";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(164, 50);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(137, 20);
            this.textBoxIsbn.TabIndex = 2;
            // 
            // IsbnSearchButton
            // 
            this.IsbnSearchButton.Location = new System.Drawing.Point(358, 50);
            this.IsbnSearchButton.Name = "IsbnSearchButton";
            this.IsbnSearchButton.Size = new System.Drawing.Size(75, 23);
            this.IsbnSearchButton.TabIndex = 3;
            this.IsbnSearchButton.Text = "Search";
            this.IsbnSearchButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxIsbn);
            this.groupBox1.Controls.Add(this.IsbnSearchButton);
            this.groupBox1.Controls.Add(this.saisiIsbn);
            this.groupBox1.Location = new System.Drawing.Point(43, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By ISBN";
            // 
            // remoteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 356);
            this.Controls.Add(this.groupBox1);
            this.Name = "remoteUserForm";
            this.Text = "Remote User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label saisiIsbn;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.Button IsbnSearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

