namespace IG_WebServiceUser
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxISBNws = new System.Windows.Forms.TextBox();
            this.textBoxAUTEURws = new System.Windows.Forms.TextBox();
            this.SearchISBNButton = new System.Windows.Forms.Button();
            this.SearchAuthorButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchISBNButton);
            this.groupBox1.Controls.Add(this.textBoxISBNws);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chercher Par ISBN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchAuthorButton);
            this.groupBox2.Controls.Add(this.textBoxAUTEURws);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(45, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chercher Par Auteur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir le numéro ISBN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saisir me nom de l\'auteur :";
            // 
            // textBoxISBNws
            // 
            this.textBoxISBNws.Location = new System.Drawing.Point(183, 38);
            this.textBoxISBNws.Name = "textBoxISBNws";
            this.textBoxISBNws.Size = new System.Drawing.Size(163, 20);
            this.textBoxISBNws.TabIndex = 1;
            // 
            // textBoxAUTEURws
            // 
            this.textBoxAUTEURws.Location = new System.Drawing.Point(183, 44);
            this.textBoxAUTEURws.Name = "textBoxAUTEURws";
            this.textBoxAUTEURws.Size = new System.Drawing.Size(163, 20);
            this.textBoxAUTEURws.TabIndex = 2;
            // 
            // SearchISBNButton
            // 
            this.SearchISBNButton.Location = new System.Drawing.Point(385, 38);
            this.SearchISBNButton.Name = "SearchISBNButton";
            this.SearchISBNButton.Size = new System.Drawing.Size(75, 23);
            this.SearchISBNButton.TabIndex = 3;
            this.SearchISBNButton.Text = "Rechercher";
            this.SearchISBNButton.UseVisualStyleBackColor = true;
            this.SearchISBNButton.Click += new System.EventHandler(this.SearchISBNButton_Click);
            // 
            // SearchAuthorButton
            // 
            this.SearchAuthorButton.Location = new System.Drawing.Point(385, 41);
            this.SearchAuthorButton.Name = "SearchAuthorButton";
            this.SearchAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.SearchAuthorButton.TabIndex = 4;
            this.SearchAuthorButton.Text = "Rechercher";
            this.SearchAuthorButton.UseVisualStyleBackColor = true;
            this.SearchAuthorButton.Click += new System.EventHandler(this.SearchAuthorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 316);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Web Service User Consummer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchISBNButton;
        private System.Windows.Forms.TextBox textBoxISBNws;
        private System.Windows.Forms.Button SearchAuthorButton;
        private System.Windows.Forms.TextBox textBoxAUTEURws;
    }
}

