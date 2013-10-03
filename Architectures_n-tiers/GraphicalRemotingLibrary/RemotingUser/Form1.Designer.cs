namespace RemotingUser
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
            this.buttonSearchIsbn = new System.Windows.Forms.Button();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.saisirIsbn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearchAuthor = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearchIsbn);
            this.groupBox1.Controls.Add(this.textBoxIsbn);
            this.groupBox1.Controls.Add(this.saisirIsbn);
            this.groupBox1.Location = new System.Drawing.Point(57, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By ISBN";
            // 
            // buttonSearchIsbn
            // 
            this.buttonSearchIsbn.Location = new System.Drawing.Point(452, 31);
            this.buttonSearchIsbn.Name = "buttonSearchIsbn";
            this.buttonSearchIsbn.Size = new System.Drawing.Size(80, 23);
            this.buttonSearchIsbn.TabIndex = 2;
            this.buttonSearchIsbn.Text = "Chercher";
            this.buttonSearchIsbn.UseVisualStyleBackColor = true;
            this.buttonSearchIsbn.Click += new System.EventHandler(this.buttonSearchIsbn_Click);
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(247, 33);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(167, 20);
            this.textBoxIsbn.TabIndex = 1;
            // 
            // saisirIsbn
            // 
            this.saisirIsbn.AutoSize = true;
            this.saisirIsbn.Location = new System.Drawing.Point(32, 36);
            this.saisirIsbn.Name = "saisirIsbn";
            this.saisirIsbn.Size = new System.Drawing.Size(192, 13);
            this.saisirIsbn.TabIndex = 0;
            this.saisirIsbn.Text = "Veuillez saisir le numéro ISBN du livre : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearchAuthor);
            this.groupBox2.Controls.Add(this.textBoxAuthor);
            this.groupBox2.Controls.Add(this.labelAuthor);
            this.groupBox2.Location = new System.Drawing.Point(57, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By Author";
            // 
            // buttonSearchAuthor
            // 
            this.buttonSearchAuthor.Location = new System.Drawing.Point(452, 28);
            this.buttonSearchAuthor.Name = "buttonSearchAuthor";
            this.buttonSearchAuthor.Size = new System.Drawing.Size(80, 23);
            this.buttonSearchAuthor.TabIndex = 2;
            this.buttonSearchAuthor.Text = "Chercher";
            this.buttonSearchAuthor.UseVisualStyleBackColor = true;
            this.buttonSearchAuthor.Click += new System.EventHandler(this.buttonSearchAuthor_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(247, 30);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(167, 20);
            this.textBoxAuthor.TabIndex = 1;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(35, 33);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(161, 13);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Veuillez saisir le nom de l\'auteur :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Remoting User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label saisirIsbn;
        private System.Windows.Forms.Button buttonSearchIsbn;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearchAuthor;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;

    }
}

