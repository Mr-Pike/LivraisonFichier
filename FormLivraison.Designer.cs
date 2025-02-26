namespace LivraisonFichier
{
    partial class FormLivraison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLivraison));
            this.ButtonLivrer = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonDossierLiv = new System.Windows.Forms.Button();
            this.DateTimePickerModif = new System.Windows.Forms.DateTimePicker();
            this.ButtonDossierDev = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxDossierLiv = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxDossierDev = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLivrer
            // 
            this.ButtonLivrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLivrer.Location = new System.Drawing.Point(186, 151);
            this.ButtonLivrer.Name = "ButtonLivrer";
            this.ButtonLivrer.Size = new System.Drawing.Size(104, 24);
            this.ButtonLivrer.TabIndex = 0;
            this.ButtonLivrer.Text = "Livrer";
            this.ButtonLivrer.UseVisualStyleBackColor = true;
            this.ButtonLivrer.Click += new System.EventHandler(this.ButtonLivrer_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ButtonDossierLiv);
            this.GroupBox1.Controls.Add(this.DateTimePickerModif);
            this.GroupBox1.Controls.Add(this.ButtonDossierDev);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.TextBoxDossierLiv);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.TextBoxDossierDev);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(448, 126);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Paramétrage";
            // 
            // ButtonDossierLiv
            // 
            this.ButtonDossierLiv.Location = new System.Drawing.Point(386, 52);
            this.ButtonDossierLiv.Name = "ButtonDossierLiv";
            this.ButtonDossierLiv.Size = new System.Drawing.Size(39, 20);
            this.ButtonDossierLiv.TabIndex = 5;
            this.ButtonDossierLiv.Text = "...";
            this.ButtonDossierLiv.UseVisualStyleBackColor = true;
            this.ButtonDossierLiv.Click += new System.EventHandler(this.ButtonDossierLiv_Click);
            // 
            // DateTimePickerModif
            // 
            this.DateTimePickerModif.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.DateTimePickerModif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerModif.Location = new System.Drawing.Point(189, 87);
            this.DateTimePickerModif.Name = "DateTimePickerModif";
            this.DateTimePickerModif.Size = new System.Drawing.Size(236, 20);
            this.DateTimePickerModif.TabIndex = 2;
            // 
            // ButtonDossierDev
            // 
            this.ButtonDossierDev.Location = new System.Drawing.Point(386, 19);
            this.ButtonDossierDev.Name = "ButtonDossierDev";
            this.ButtonDossierDev.Size = new System.Drawing.Size(39, 20);
            this.ButtonDossierDev.TabIndex = 2;
            this.ButtonDossierDev.Text = "...";
            this.ButtonDossierDev.UseVisualStyleBackColor = true;
            this.ButtonDossierDev.Click += new System.EventHandler(this.ButtonDossierDev_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 91);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(104, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Date de modification";
            // 
            // TextBoxDossierLiv
            // 
            this.TextBoxDossierLiv.Location = new System.Drawing.Point(189, 52);
            this.TextBoxDossierLiv.Name = "TextBoxDossierLiv";
            this.TextBoxDossierLiv.Size = new System.Drawing.Size(190, 20);
            this.TextBoxDossierLiv.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Dossier de livraison";
            // 
            // TextBoxDossierDev
            // 
            this.TextBoxDossierDev.Location = new System.Drawing.Point(189, 19);
            this.TextBoxDossierDev.Name = "TextBoxDossierDev";
            this.TextBoxDossierDev.Size = new System.Drawing.Size(190, 20);
            this.TextBoxDossierDev.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(133, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Dossier de développement";
            // 
            // FormLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 187);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ButtonLivrer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLivraison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livraison de fichiers";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLivrer;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.DateTimePicker DateTimePickerModif;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TextBoxDossierLiv;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TextBoxDossierDev;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ButtonDossierDev;
        private System.Windows.Forms.Button ButtonDossierLiv;
    }
}

