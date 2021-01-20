namespace Easy_Book_Manager
{
    partial class GererEmprunt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListeLivre = new System.Windows.Forms.ListBox();
            this.SearchBarBook = new System.Windows.Forms.TextBox();
            this.ButtonRechercherLivre = new System.Windows.Forms.Button();
            this.RechercherAdherent = new System.Windows.Forms.TextBox();
            this.SearchBarAdGererEmprunt = new System.Windows.Forms.Button();
            this.ListeAdherentGererEmprunt = new System.Windows.Forms.ListBox();
            this.PanelinfoAdherent = new System.Windows.Forms.Panel();
            this.Telephone_Adherent = new System.Windows.Forms.Label();
            this.Adresse_Adherent = new System.Windows.Forms.Label();
            this.Prenom_Adherent = new System.Windows.Forms.Label();
            this.Nom_Adherent = new System.Windows.Forms.Label();
            this.Liste_Livre_Emprunt = new System.Windows.Forms.ListBox();
            this.BouttonEnregistrerAjoutEmprunt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Jour_Emprunt = new System.Windows.Forms.ComboBox();
            this.Annee_Emprunt = new System.Windows.Forms.ComboBox();
            this.Mois_Emprunt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Jour_RetourPrevu = new System.Windows.Forms.ComboBox();
            this.Mois_RetourPrevu = new System.Windows.Forms.ComboBox();
            this.Annee_RetourPrevu = new System.Windows.Forms.ComboBox();
            this.Ajouter_emprunt = new System.Windows.Forms.Button();
            this.Supprimer_Emprunt = new System.Windows.Forms.Button();
            this.PanelinfoAdherent.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListeLivre
            // 
            this.ListeLivre.FormattingEnabled = true;
            this.ListeLivre.Location = new System.Drawing.Point(12, 51);
            this.ListeLivre.Name = "ListeLivre";
            this.ListeLivre.Size = new System.Drawing.Size(303, 524);
            this.ListeLivre.TabIndex = 1;
            // 
            // SearchBarBook
            // 
            this.SearchBarBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchBarBook.Location = new System.Drawing.Point(12, 12);
            this.SearchBarBook.Name = "SearchBarBook";
            this.SearchBarBook.Size = new System.Drawing.Size(205, 23);
            this.SearchBarBook.TabIndex = 2;
            this.SearchBarBook.Text = "Rechercher un livre";
            // 
            // ButtonRechercherLivre
            // 
            this.ButtonRechercherLivre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonRechercherLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonRechercherLivre.Location = new System.Drawing.Point(223, 12);
            this.ButtonRechercherLivre.Name = "ButtonRechercherLivre";
            this.ButtonRechercherLivre.Size = new System.Drawing.Size(92, 23);
            this.ButtonRechercherLivre.TabIndex = 10;
            this.ButtonRechercherLivre.Text = "Rechercher";
            this.ButtonRechercherLivre.UseVisualStyleBackColor = false;
            // 
            // RechercherAdherent
            // 
            this.RechercherAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RechercherAdherent.Location = new System.Drawing.Point(380, 12);
            this.RechercherAdherent.Name = "RechercherAdherent";
            this.RechercherAdherent.Size = new System.Drawing.Size(334, 23);
            this.RechercherAdherent.TabIndex = 11;
            this.RechercherAdherent.Text = "Rechercher un adhérent";
            // 
            // SearchBarAdGererEmprunt
            // 
            this.SearchBarAdGererEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchBarAdGererEmprunt.Location = new System.Drawing.Point(720, 12);
            this.SearchBarAdGererEmprunt.Name = "SearchBarAdGererEmprunt";
            this.SearchBarAdGererEmprunt.Size = new System.Drawing.Size(92, 23);
            this.SearchBarAdGererEmprunt.TabIndex = 12;
            this.SearchBarAdGererEmprunt.Text = "Rechercher";
            this.SearchBarAdGererEmprunt.UseVisualStyleBackColor = true;
            // 
            // ListeAdherentGererEmprunt
            // 
            this.ListeAdherentGererEmprunt.FormattingEnabled = true;
            this.ListeAdherentGererEmprunt.Location = new System.Drawing.Point(380, 51);
            this.ListeAdherentGererEmprunt.Name = "ListeAdherentGererEmprunt";
            this.ListeAdherentGererEmprunt.Size = new System.Drawing.Size(180, 95);
            this.ListeAdherentGererEmprunt.TabIndex = 13;
            // 
            // PanelinfoAdherent
            // 
            this.PanelinfoAdherent.BackColor = System.Drawing.SystemColors.Window;
            this.PanelinfoAdherent.Controls.Add(this.Telephone_Adherent);
            this.PanelinfoAdherent.Controls.Add(this.Adresse_Adherent);
            this.PanelinfoAdherent.Controls.Add(this.Prenom_Adherent);
            this.PanelinfoAdherent.Controls.Add(this.Nom_Adherent);
            this.PanelinfoAdherent.Location = new System.Drawing.Point(566, 51);
            this.PanelinfoAdherent.Name = "PanelinfoAdherent";
            this.PanelinfoAdherent.Size = new System.Drawing.Size(246, 95);
            this.PanelinfoAdherent.TabIndex = 14;
            // 
            // Telephone_Adherent
            // 
            this.Telephone_Adherent.AutoSize = true;
            this.Telephone_Adherent.Location = new System.Drawing.Point(3, 71);
            this.Telephone_Adherent.Name = "Telephone_Adherent";
            this.Telephone_Adherent.Size = new System.Drawing.Size(58, 13);
            this.Telephone_Adherent.TabIndex = 15;
            this.Telephone_Adherent.Text = "Téléphone";
            this.Telephone_Adherent.Click += new System.EventHandler(this.Telephone_Adherent_Click);
            // 
            // Adresse_Adherent
            // 
            this.Adresse_Adherent.AutoSize = true;
            this.Adresse_Adherent.Location = new System.Drawing.Point(3, 49);
            this.Adresse_Adherent.Name = "Adresse_Adherent";
            this.Adresse_Adherent.Size = new System.Drawing.Size(45, 13);
            this.Adresse_Adherent.TabIndex = 15;
            this.Adresse_Adherent.Text = "Adresse";
            // 
            // Prenom_Adherent
            // 
            this.Prenom_Adherent.AutoSize = true;
            this.Prenom_Adherent.Location = new System.Drawing.Point(3, 27);
            this.Prenom_Adherent.Name = "Prenom_Adherent";
            this.Prenom_Adherent.Size = new System.Drawing.Size(43, 13);
            this.Prenom_Adherent.TabIndex = 15;
            this.Prenom_Adherent.Text = "Prénom";
            // 
            // Nom_Adherent
            // 
            this.Nom_Adherent.AutoSize = true;
            this.Nom_Adherent.Location = new System.Drawing.Point(3, 5);
            this.Nom_Adherent.Name = "Nom_Adherent";
            this.Nom_Adherent.Size = new System.Drawing.Size(29, 13);
            this.Nom_Adherent.TabIndex = 0;
            this.Nom_Adherent.Text = "Nom";
            // 
            // Liste_Livre_Emprunt
            // 
            this.Liste_Livre_Emprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Liste_Livre_Emprunt.FormattingEnabled = true;
            this.Liste_Livre_Emprunt.ItemHeight = 16;
            this.Liste_Livre_Emprunt.Location = new System.Drawing.Point(380, 152);
            this.Liste_Livre_Emprunt.Name = "Liste_Livre_Emprunt";
            this.Liste_Livre_Emprunt.Size = new System.Drawing.Size(432, 100);
            this.Liste_Livre_Emprunt.TabIndex = 15;
            // 
            // BouttonEnregistrerAjoutEmprunt
            // 
            this.BouttonEnregistrerAjoutEmprunt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BouttonEnregistrerAjoutEmprunt.Location = new System.Drawing.Point(546, 542);
            this.BouttonEnregistrerAjoutEmprunt.Name = "BouttonEnregistrerAjoutEmprunt";
            this.BouttonEnregistrerAjoutEmprunt.Size = new System.Drawing.Size(90, 33);
            this.BouttonEnregistrerAjoutEmprunt.TabIndex = 16;
            this.BouttonEnregistrerAjoutEmprunt.Text = "Enregistrer";
            this.BouttonEnregistrerAjoutEmprunt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(543, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date d\'emprunt";
            // 
            // Jour_Emprunt
            // 
            this.Jour_Emprunt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Jour_Emprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Jour_Emprunt.FormattingEnabled = true;
            this.Jour_Emprunt.Location = new System.Drawing.Point(380, 331);
            this.Jour_Emprunt.Name = "Jour_Emprunt";
            this.Jour_Emprunt.Size = new System.Drawing.Size(121, 24);
            this.Jour_Emprunt.TabIndex = 18;
            this.Jour_Emprunt.Text = "Jour";
            // 
            // Annee_Emprunt
            // 
            this.Annee_Emprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Annee_Emprunt.FormattingEnabled = true;
            this.Annee_Emprunt.Location = new System.Drawing.Point(691, 331);
            this.Annee_Emprunt.Name = "Annee_Emprunt";
            this.Annee_Emprunt.Size = new System.Drawing.Size(121, 24);
            this.Annee_Emprunt.TabIndex = 19;
            this.Annee_Emprunt.Text = "Année";
            this.Annee_Emprunt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Mois_Emprunt
            // 
            this.Mois_Emprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Mois_Emprunt.FormattingEnabled = true;
            this.Mois_Emprunt.Location = new System.Drawing.Point(538, 331);
            this.Mois_Emprunt.Name = "Mois_Emprunt";
            this.Mois_Emprunt.Size = new System.Drawing.Size(121, 24);
            this.Mois_Emprunt.TabIndex = 20;
            this.Mois_Emprunt.Text = "Mois";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(532, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date de retour prévu";
            // 
            // Jour_RetourPrevu
            // 
            this.Jour_RetourPrevu.Cursor = System.Windows.Forms.Cursors.Default;
            this.Jour_RetourPrevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Jour_RetourPrevu.FormattingEnabled = true;
            this.Jour_RetourPrevu.Location = new System.Drawing.Point(380, 458);
            this.Jour_RetourPrevu.Name = "Jour_RetourPrevu";
            this.Jour_RetourPrevu.Size = new System.Drawing.Size(121, 24);
            this.Jour_RetourPrevu.TabIndex = 22;
            this.Jour_RetourPrevu.Text = "Jour";
            // 
            // Mois_RetourPrevu
            // 
            this.Mois_RetourPrevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Mois_RetourPrevu.FormattingEnabled = true;
            this.Mois_RetourPrevu.Location = new System.Drawing.Point(538, 458);
            this.Mois_RetourPrevu.Name = "Mois_RetourPrevu";
            this.Mois_RetourPrevu.Size = new System.Drawing.Size(121, 24);
            this.Mois_RetourPrevu.TabIndex = 23;
            this.Mois_RetourPrevu.Text = "Mois";
            // 
            // Annee_RetourPrevu
            // 
            this.Annee_RetourPrevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Annee_RetourPrevu.FormattingEnabled = true;
            this.Annee_RetourPrevu.Location = new System.Drawing.Point(691, 458);
            this.Annee_RetourPrevu.Name = "Annee_RetourPrevu";
            this.Annee_RetourPrevu.Size = new System.Drawing.Size(121, 24);
            this.Annee_RetourPrevu.TabIndex = 24;
            this.Annee_RetourPrevu.Text = "Année";
            // 
            // Ajouter_emprunt
            // 
            this.Ajouter_emprunt.BackColor = System.Drawing.SystemColors.Window;
            this.Ajouter_emprunt.Location = new System.Drawing.Point(321, 267);
            this.Ajouter_emprunt.Name = "Ajouter_emprunt";
            this.Ajouter_emprunt.Size = new System.Drawing.Size(54, 23);
            this.Ajouter_emprunt.TabIndex = 25;
            this.Ajouter_emprunt.Text = "Add";
            this.Ajouter_emprunt.UseVisualStyleBackColor = false;
            // 
            // Supprimer_Emprunt
            // 
            this.Supprimer_Emprunt.BackColor = System.Drawing.SystemColors.Window;
            this.Supprimer_Emprunt.Location = new System.Drawing.Point(321, 296);
            this.Supprimer_Emprunt.Name = "Supprimer_Emprunt";
            this.Supprimer_Emprunt.Size = new System.Drawing.Size(54, 23);
            this.Supprimer_Emprunt.TabIndex = 26;
            this.Supprimer_Emprunt.Text = "Del";
            this.Supprimer_Emprunt.UseVisualStyleBackColor = false;
            // 
            // GererEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 592);
            this.Controls.Add(this.Supprimer_Emprunt);
            this.Controls.Add(this.Ajouter_emprunt);
            this.Controls.Add(this.Annee_RetourPrevu);
            this.Controls.Add(this.Mois_RetourPrevu);
            this.Controls.Add(this.Jour_RetourPrevu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mois_Emprunt);
            this.Controls.Add(this.Annee_Emprunt);
            this.Controls.Add(this.Jour_Emprunt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BouttonEnregistrerAjoutEmprunt);
            this.Controls.Add(this.Liste_Livre_Emprunt);
            this.Controls.Add(this.PanelinfoAdherent);
            this.Controls.Add(this.ListeAdherentGererEmprunt);
            this.Controls.Add(this.SearchBarAdGererEmprunt);
            this.Controls.Add(this.RechercherAdherent);
            this.Controls.Add(this.ButtonRechercherLivre);
            this.Controls.Add(this.SearchBarBook);
            this.Controls.Add(this.ListeLivre);
            this.Name = "GererEmprunt";
            this.Text = "Easy Book Manager";
            this.PanelinfoAdherent.ResumeLayout(false);
            this.PanelinfoAdherent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListeLivre;
        private System.Windows.Forms.TextBox SearchBarBook;
        private System.Windows.Forms.Button ButtonRechercherLivre;
        private System.Windows.Forms.TextBox RechercherAdherent;
        private System.Windows.Forms.Button SearchBarAdGererEmprunt;
        private System.Windows.Forms.ListBox ListeAdherentGererEmprunt;
        private System.Windows.Forms.Panel PanelinfoAdherent;
        private System.Windows.Forms.Label Telephone_Adherent;
        private System.Windows.Forms.Label Adresse_Adherent;
        private System.Windows.Forms.Label Prenom_Adherent;
        private System.Windows.Forms.Label Nom_Adherent;
        private System.Windows.Forms.ListBox Liste_Livre_Emprunt;
        private System.Windows.Forms.Button BouttonEnregistrerAjoutEmprunt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Jour_Emprunt;
        private System.Windows.Forms.ComboBox Annee_Emprunt;
        private System.Windows.Forms.ComboBox Mois_Emprunt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Jour_RetourPrevu;
        private System.Windows.Forms.ComboBox Mois_RetourPrevu;
        private System.Windows.Forms.ComboBox Annee_RetourPrevu;
        private System.Windows.Forms.Button Ajouter_emprunt;
        private System.Windows.Forms.Button Supprimer_Emprunt;
    }
}