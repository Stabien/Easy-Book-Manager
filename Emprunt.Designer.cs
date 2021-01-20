namespace Easy_Book_Manager
{
    partial class Emprunt
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
            this.ListeAdherentsEmprunt = new System.Windows.Forms.ListBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.BouttonEnregistrer = new System.Windows.Forms.Button();
            this.InfosAdhérents = new System.Windows.Forms.Panel();
            this.AdresseAdherent = new System.Windows.Forms.Label();
            this.TelephoneAdherent = new System.Windows.Forms.Label();
            this.NomAdherent = new System.Windows.Forms.Label();
            this.PrenomAdherent = new System.Windows.Forms.Label();
            this.IdAdherent = new System.Windows.Forms.Label();
            this.ListeLivre = new System.Windows.Forms.ListBox();
            this.JourEmprunt = new System.Windows.Forms.ComboBox();
            this.AnneeEmprunt = new System.Windows.Forms.ComboBox();
            this.MoisEmprunt = new System.Windows.Forms.ComboBox();
            this.EtatEmprunt = new System.Windows.Forms.ComboBox();
            this.ButtonRechercherAd = new System.Windows.Forms.Button();
            this.InfosAdhérents.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListeAdherentsEmprunt
            // 
            this.ListeAdherentsEmprunt.FormattingEnabled = true;
            this.ListeAdherentsEmprunt.Location = new System.Drawing.Point(12, 51);
            this.ListeAdherentsEmprunt.Name = "ListeAdherentsEmprunt";
            this.ListeAdherentsEmprunt.Size = new System.Drawing.Size(303, 524);
            this.ListeAdherentsEmprunt.TabIndex = 0;
            this.ListeAdherentsEmprunt.SelectedIndexChanged += new System.EventHandler(this.ListeAdherentsEmprunt_SelectedIndexChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchBar.Location = new System.Drawing.Point(12, 12);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(205, 23);
            this.SearchBar.TabIndex = 1;
            this.SearchBar.Text = "Rechercher un adhérent";
            // 
            // BouttonEnregistrer
            // 
            this.BouttonEnregistrer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BouttonEnregistrer.Location = new System.Drawing.Point(546, 542);
            this.BouttonEnregistrer.Name = "BouttonEnregistrer";
            this.BouttonEnregistrer.Size = new System.Drawing.Size(90, 33);
            this.BouttonEnregistrer.TabIndex = 2;
            this.BouttonEnregistrer.Text = "Enregistrer";
            this.BouttonEnregistrer.UseVisualStyleBackColor = false;
            // 
            // InfosAdhérents
            // 
            this.InfosAdhérents.Controls.Add(this.AdresseAdherent);
            this.InfosAdhérents.Controls.Add(this.TelephoneAdherent);
            this.InfosAdhérents.Controls.Add(this.NomAdherent);
            this.InfosAdhérents.Controls.Add(this.PrenomAdherent);
            this.InfosAdhérents.Controls.Add(this.IdAdherent);
            this.InfosAdhérents.Location = new System.Drawing.Point(390, 12);
            this.InfosAdhérents.Name = "InfosAdhérents";
            this.InfosAdhérents.Size = new System.Drawing.Size(415, 96);
            this.InfosAdhérents.TabIndex = 3;
            // 
            // AdresseAdherent
            // 
            this.AdresseAdherent.AutoSize = true;
            this.AdresseAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdresseAdherent.Location = new System.Drawing.Point(13, 39);
            this.AdresseAdherent.Name = "AdresseAdherent";
            this.AdresseAdherent.Size = new System.Drawing.Size(60, 17);
            this.AdresseAdherent.TabIndex = 9;
            this.AdresseAdherent.Text = "Adresse";
            this.AdresseAdherent.Click += new System.EventHandler(this.label1_Click);
            // 
            // TelephoneAdherent
            // 
            this.TelephoneAdherent.AutoSize = true;
            this.TelephoneAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TelephoneAdherent.Location = new System.Drawing.Point(197, 67);
            this.TelephoneAdherent.Name = "TelephoneAdherent";
            this.TelephoneAdherent.Size = new System.Drawing.Size(138, 17);
            this.TelephoneAdherent.TabIndex = 5;
            this.TelephoneAdherent.Text = "Telephone Adhérent";
            // 
            // NomAdherent
            // 
            this.NomAdherent.AutoSize = true;
            this.NomAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NomAdherent.Location = new System.Drawing.Point(197, 13);
            this.NomAdherent.Name = "NomAdherent";
            this.NomAdherent.Size = new System.Drawing.Size(99, 17);
            this.NomAdherent.TabIndex = 4;
            this.NomAdherent.Text = "Nom Adhérent";
            // 
            // PrenomAdherent
            // 
            this.PrenomAdherent.AutoSize = true;
            this.PrenomAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PrenomAdherent.Location = new System.Drawing.Point(13, 67);
            this.PrenomAdherent.Name = "PrenomAdherent";
            this.PrenomAdherent.Size = new System.Drawing.Size(119, 17);
            this.PrenomAdherent.TabIndex = 4;
            this.PrenomAdherent.Text = "Prénom Adhérent";
            // 
            // IdAdherent
            // 
            this.IdAdherent.AutoSize = true;
            this.IdAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IdAdherent.Location = new System.Drawing.Point(13, 13);
            this.IdAdherent.Name = "IdAdherent";
            this.IdAdherent.Size = new System.Drawing.Size(21, 17);
            this.IdAdherent.TabIndex = 0;
            this.IdAdherent.Text = "ID";
            // 
            // ListeLivre
            // 
            this.ListeLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListeLivre.FormattingEnabled = true;
            this.ListeLivre.ItemHeight = 16;
            this.ListeLivre.Location = new System.Drawing.Point(390, 146);
            this.ListeLivre.Name = "ListeLivre";
            this.ListeLivre.Size = new System.Drawing.Size(415, 84);
            this.ListeLivre.TabIndex = 4;
            // 
            // JourEmprunt
            // 
            this.JourEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.JourEmprunt.FormattingEnabled = true;
            this.JourEmprunt.Location = new System.Drawing.Point(390, 291);
            this.JourEmprunt.Name = "JourEmprunt";
            this.JourEmprunt.Size = new System.Drawing.Size(121, 24);
            this.JourEmprunt.TabIndex = 5;
            this.JourEmprunt.Text = "Jour";
            // 
            // AnneeEmprunt
            // 
            this.AnneeEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AnneeEmprunt.FormattingEnabled = true;
            this.AnneeEmprunt.Location = new System.Drawing.Point(684, 291);
            this.AnneeEmprunt.Name = "AnneeEmprunt";
            this.AnneeEmprunt.Size = new System.Drawing.Size(121, 24);
            this.AnneeEmprunt.TabIndex = 6;
            this.AnneeEmprunt.Text = "Année";
            // 
            // MoisEmprunt
            // 
            this.MoisEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MoisEmprunt.FormattingEnabled = true;
            this.MoisEmprunt.Location = new System.Drawing.Point(537, 291);
            this.MoisEmprunt.Name = "MoisEmprunt";
            this.MoisEmprunt.Size = new System.Drawing.Size(121, 24);
            this.MoisEmprunt.TabIndex = 7;
            this.MoisEmprunt.Text = "Mois";
            // 
            // EtatEmprunt
            // 
            this.EtatEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EtatEmprunt.FormattingEnabled = true;
            this.EtatEmprunt.Location = new System.Drawing.Point(537, 387);
            this.EtatEmprunt.Name = "EtatEmprunt";
            this.EtatEmprunt.Size = new System.Drawing.Size(121, 24);
            this.EtatEmprunt.TabIndex = 8;
            this.EtatEmprunt.Text = "Etat";
            // 
            // ButtonRechercherAd
            // 
            this.ButtonRechercherAd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonRechercherAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonRechercherAd.Location = new System.Drawing.Point(223, 12);
            this.ButtonRechercherAd.Name = "ButtonRechercherAd";
            this.ButtonRechercherAd.Size = new System.Drawing.Size(92, 23);
            this.ButtonRechercherAd.TabIndex = 9;
            this.ButtonRechercherAd.Text = "Rechercher";
            this.ButtonRechercherAd.UseVisualStyleBackColor = false;
            // 
            // Emprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 592);
            this.Controls.Add(this.ButtonRechercherAd);
            this.Controls.Add(this.EtatEmprunt);
            this.Controls.Add(this.MoisEmprunt);
            this.Controls.Add(this.AnneeEmprunt);
            this.Controls.Add(this.JourEmprunt);
            this.Controls.Add(this.ListeLivre);
            this.Controls.Add(this.InfosAdhérents);
            this.Controls.Add(this.BouttonEnregistrer);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.ListeAdherentsEmprunt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Emprunt";
            this.Text = "Emprunt";
            this.InfosAdhérents.ResumeLayout(false);
            this.InfosAdhérents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListeAdherentsEmprunt;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button BouttonEnregistrer;
        private System.Windows.Forms.Panel InfosAdhérents;
        private System.Windows.Forms.Label TelephoneAdherent;
        private System.Windows.Forms.Label NomAdherent;
        private System.Windows.Forms.Label PrenomAdherent;
        private System.Windows.Forms.Label IdAdherent;
        private System.Windows.Forms.ListBox ListeLivre;
        private System.Windows.Forms.ComboBox JourEmprunt;
        private System.Windows.Forms.ComboBox AnneeEmprunt;
        private System.Windows.Forms.ComboBox MoisEmprunt;
        private System.Windows.Forms.ComboBox EtatEmprunt;
        private System.Windows.Forms.Label AdresseAdherent;
        private System.Windows.Forms.Button ButtonRechercherAd;
    }
}