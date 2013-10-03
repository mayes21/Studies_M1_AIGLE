namespace IG_WebServiceAbonne
{
    partial class form1
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
            this.Catalogue = new System.Windows.Forms.GroupBox();
            this.ListBoxTitre = new System.Windows.Forms.ListBox();
            this.commentButton = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewComment = new System.Windows.Forms.ListView();
            this.Commentaires = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Catalogue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Catalogue
            // 
            this.Catalogue.Controls.Add(this.ListBoxTitre);
            this.Catalogue.Location = new System.Drawing.Point(403, 24);
            this.Catalogue.Name = "Catalogue";
            this.Catalogue.Size = new System.Drawing.Size(177, 318);
            this.Catalogue.TabIndex = 1;
            this.Catalogue.TabStop = false;
            this.Catalogue.Text = "Catalogue";
            // 
            // ListBoxTitre
            // 
            this.ListBoxTitre.FormattingEnabled = true;
            this.ListBoxTitre.Location = new System.Drawing.Point(21, 29);
            this.ListBoxTitre.Name = "ListBoxTitre";
            this.ListBoxTitre.Size = new System.Drawing.Size(132, 277);
            this.ListBoxTitre.TabIndex = 2;
            // 
            // commentButton
            // 
            this.commentButton.Location = new System.Drawing.Point(224, 126);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(90, 23);
            this.commentButton.TabIndex = 3;
            this.commentButton.Text = "Commenter";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(20, 36);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(294, 73);
            this.textBoxComment.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.commentButton);
            this.groupBox1.Controls.Add(this.textBoxComment);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un commentaire";
            // 
            // listViewComment
            // 
            this.listViewComment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Commentaires});
            this.listViewComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewComment.Location = new System.Drawing.Point(3, 16);
            this.listViewComment.Name = "listViewComment";
            this.listViewComment.Size = new System.Drawing.Size(331, 110);
            this.listViewComment.TabIndex = 0;
            this.listViewComment.UseCompatibleStateImageBehavior = false;
            this.listViewComment.View = System.Windows.Forms.View.List;
            // 
            // Commentaires
            // 
            this.Commentaires.Text = "Commentaires";
            this.Commentaires.Width = 326;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewComment);
            this.groupBox2.Location = new System.Drawing.Point(29, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 129);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des commentaires";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Catalogue);
            this.Controls.Add(this.groupBox1);
            this.Name = "form1";
            this.Text = "Web Service Abonne Consumer";
            this.Catalogue.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Catalogue;
        private System.Windows.Forms.ListBox ListBoxTitre;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewComment;
        private System.Windows.Forms.ColumnHeader Commentaires;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

