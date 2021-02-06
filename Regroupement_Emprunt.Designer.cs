namespace Easy_Book_Manager
{
    partial class Regroupement_Emprunt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regroupement_Emprunt));
            this.TabEmprunt = new System.Windows.Forms.TabControl();
            this.tabPageAdherentEmprunt = new System.Windows.Forms.TabPage();
            this.listBoxAdherent = new System.Windows.Forms.ListBox();
            this.EtatEmprunt = new System.Windows.Forms.ComboBox();
            this.MoisEmprunt = new System.Windows.Forms.ComboBox();
            this.AnneeEmprunt = new System.Windows.Forms.ComboBox();
            this.JourEmprunt = new System.Windows.Forms.ComboBox();
            this.ListeLivre = new System.Windows.Forms.ListBox();
            this.InfosAdhérents = new System.Windows.Forms.Panel();
            this.AdresseAdherent = new System.Windows.Forms.Label();
            this.TelephoneAdherent = new System.Windows.Forms.Label();
            this.NomAdherent = new System.Windows.Forms.Label();
            this.PrenomAdherent = new System.Windows.Forms.Label();
            this.IdAdherent = new System.Windows.Forms.Label();
            this.BouttonEnregistrer = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.tabPageEmprunt = new System.Windows.Forms.TabPage();
            this.Supprimer_Emprunt = new System.Windows.Forms.Button();
            this.Ajouter_emprunt = new System.Windows.Forms.Button();
            this.Annee_RetourPrevu = new System.Windows.Forms.ComboBox();
            this.Mois_RetourPrevu = new System.Windows.Forms.ComboBox();
            this.Jour_RetourPrevu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mois_Emprunt = new System.Windows.Forms.ComboBox();
            this.Annee_Emprunt = new System.Windows.Forms.ComboBox();
            this.Jour_Emprunt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BouttonEnregistrerAjoutEmprunt = new System.Windows.Forms.Button();
            this.Liste_Livre_Emprunt = new System.Windows.Forms.ListBox();
            this.PanelinfoAdherent = new System.Windows.Forms.Panel();
            this.Telephone_Adherent = new System.Windows.Forms.Label();
            this.Adresse_Adherent = new System.Windows.Forms.Label();
            this.Prenom_Adherent = new System.Windows.Forms.Label();
            this.Nom_Adherent = new System.Windows.Forms.Label();
            this.ListeAdherentGererEmprunt = new System.Windows.Forms.ListBox();
            this.SearchBarAdGererEmprunt = new System.Windows.Forms.Button();
            this.RechercherAdherent = new System.Windows.Forms.TextBox();
            this.ButtonRechercherLivre = new System.Windows.Forms.Button();
            this.SearchBarBook = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TabEmprunt.SuspendLayout();
            this.tabPageAdherentEmprunt.SuspendLayout();
            this.InfosAdhérents.SuspendLayout();
            this.tabPageEmprunt.SuspendLayout();
            this.PanelinfoAdherent.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabEmprunt
            // 
            this.TabEmprunt.AccessibleName = "";
            this.TabEmprunt.Controls.Add(this.tabPageAdherentEmprunt);
            this.TabEmprunt.Controls.Add(this.tabPageEmprunt);
            this.TabEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabEmprunt.Location = new System.Drawing.Point(0, 0);
            this.TabEmprunt.Multiline = true;
            this.TabEmprunt.Name = "TabEmprunt";
            this.TabEmprunt.SelectedIndex = 0;
            this.TabEmprunt.Size = new System.Drawing.Size(855, 592);
            this.TabEmprunt.TabIndex = 0;
            // 
            // tabPageAdherentEmprunt
            // 
            this.tabPageAdherentEmprunt.Controls.Add(this.listBoxAdherent);
            this.tabPageAdherentEmprunt.Controls.Add(this.EtatEmprunt);
            this.tabPageAdherentEmprunt.Controls.Add(this.MoisEmprunt);
            this.tabPageAdherentEmprunt.Controls.Add(this.AnneeEmprunt);
            this.tabPageAdherentEmprunt.Controls.Add(this.JourEmprunt);
            this.tabPageAdherentEmprunt.Controls.Add(this.ListeLivre);
            this.tabPageAdherentEmprunt.Controls.Add(this.InfosAdhérents);
            this.tabPageAdherentEmprunt.Controls.Add(this.BouttonEnregistrer);
            this.tabPageAdherentEmprunt.Controls.Add(this.SearchBar);
            this.tabPageAdherentEmprunt.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdherentEmprunt.Name = "tabPageAdherentEmprunt";
            this.tabPageAdherentEmprunt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdherentEmprunt.Size = new System.Drawing.Size(847, 566);
            this.tabPageAdherentEmprunt.TabIndex = 0;
            this.tabPageAdherentEmprunt.Text = "Gerer Emprunt";
            this.tabPageAdherentEmprunt.UseVisualStyleBackColor = true;
            // 
            // listBoxAdherent
            // 
            this.listBoxAdherent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxAdherent.FormattingEnabled = true;
            this.listBoxAdherent.ItemHeight = 17;
            this.listBoxAdherent.Location = new System.Drawing.Point(8, 49);
            this.listBoxAdherent.Name = "listBoxAdherent";
            this.listBoxAdherent.Size = new System.Drawing.Size(303, 480);
            this.listBoxAdherent.TabIndex = 2;
            this.listBoxAdherent.SelectedIndexChanged += new System.EventHandler(this.listBoxAdherent_SelectedIndexChanged);
            // 
            // EtatEmprunt
            // 
            this.EtatEmprunt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtatEmprunt.FormattingEnabled = true;
            this.EtatEmprunt.ItemHeight = 17;
            this.EtatEmprunt.Location = new System.Drawing.Point(533, 385);
            this.EtatEmprunt.Name = "EtatEmprunt";
            this.EtatEmprunt.Size = new System.Drawing.Size(121, 25);
            this.EtatEmprunt.TabIndex = 7;
            this.EtatEmprunt.Text = "Etat";
            // 
            // MoisEmprunt
            // 
            this.MoisEmprunt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoisEmprunt.FormattingEnabled = true;
            this.MoisEmprunt.Items.AddRange(new object[] {
            "Janvier",
            "Fevrier",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.MoisEmprunt.Location = new System.Drawing.Point(533, 289);
            this.MoisEmprunt.Name = "MoisEmprunt";
            this.MoisEmprunt.Size = new System.Drawing.Size(121, 25);
            this.MoisEmprunt.TabIndex = 5;
            this.MoisEmprunt.Text = "Mois";
            this.MoisEmprunt.SelectedIndexChanged += new System.EventHandler(this.MoisEmprunt_SelectedIndexChanged);
            // 
            // AnneeEmprunt
            // 
            this.AnneeEmprunt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeEmprunt.FormattingEnabled = true;
            this.AnneeEmprunt.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024"});
            this.AnneeEmprunt.Location = new System.Drawing.Point(680, 289);
            this.AnneeEmprunt.Name = "AnneeEmprunt";
            this.AnneeEmprunt.Size = new System.Drawing.Size(121, 25);
            this.AnneeEmprunt.TabIndex = 6;
            this.AnneeEmprunt.Text = "Année";
            // 
            // JourEmprunt
            // 
            this.JourEmprunt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JourEmprunt.FormattingEnabled = true;
            this.JourEmprunt.Location = new System.Drawing.Point(386, 289);
            this.JourEmprunt.Name = "JourEmprunt";
            this.JourEmprunt.Size = new System.Drawing.Size(121, 25);
            this.JourEmprunt.TabIndex = 4;
            this.JourEmprunt.Text = "Jour";
            // 
            // ListeLivre
            // 
            this.ListeLivre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeLivre.FormattingEnabled = true;
            this.ListeLivre.ItemHeight = 17;
            this.ListeLivre.Location = new System.Drawing.Point(386, 144);
            this.ListeLivre.Name = "ListeLivre";
            this.ListeLivre.Size = new System.Drawing.Size(415, 89);
            this.ListeLivre.TabIndex = 3;
            // 
            // InfosAdhérents
            // 
            this.InfosAdhérents.Controls.Add(this.AdresseAdherent);
            this.InfosAdhérents.Controls.Add(this.TelephoneAdherent);
            this.InfosAdhérents.Controls.Add(this.NomAdherent);
            this.InfosAdhérents.Controls.Add(this.PrenomAdherent);
            this.InfosAdhérents.Controls.Add(this.IdAdherent);
            this.InfosAdhérents.Location = new System.Drawing.Point(386, 10);
            this.InfosAdhérents.Name = "InfosAdhérents";
            this.InfosAdhérents.Size = new System.Drawing.Size(415, 96);
            this.InfosAdhérents.TabIndex = 13;
            // 
            // AdresseAdherent
            // 
            this.AdresseAdherent.AutoSize = true;
            this.AdresseAdherent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseAdherent.Location = new System.Drawing.Point(13, 39);
            this.AdresseAdherent.Name = "AdresseAdherent";
            this.AdresseAdherent.Size = new System.Drawing.Size(55, 17);
            this.AdresseAdherent.TabIndex = 9;
            this.AdresseAdherent.Text = "Adresse";
            // 
            // TelephoneAdherent
            // 
            this.TelephoneAdherent.AutoSize = true;
            this.TelephoneAdherent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneAdherent.Location = new System.Drawing.Point(197, 67);
            this.TelephoneAdherent.Name = "TelephoneAdherent";
            this.TelephoneAdherent.Size = new System.Drawing.Size(125, 17);
            this.TelephoneAdherent.TabIndex = 5;
            this.TelephoneAdherent.Text = "Telephone Adhérent";
            // 
            // NomAdherent
            // 
            this.NomAdherent.AutoSize = true;
            this.NomAdherent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomAdherent.Location = new System.Drawing.Point(197, 13);
            this.NomAdherent.Name = "NomAdherent";
            this.NomAdherent.Size = new System.Drawing.Size(94, 17);
            this.NomAdherent.TabIndex = 4;
            this.NomAdherent.Text = "Nom Adhérent";
            // 
            // PrenomAdherent
            // 
            this.PrenomAdherent.AutoSize = true;
            this.PrenomAdherent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomAdherent.Location = new System.Drawing.Point(13, 67);
            this.PrenomAdherent.Name = "PrenomAdherent";
            this.PrenomAdherent.Size = new System.Drawing.Size(110, 17);
            this.PrenomAdherent.TabIndex = 4;
            this.PrenomAdherent.Text = "Prénom Adhérent";
            // 
            // IdAdherent
            // 
            this.IdAdherent.AutoSize = true;
            this.IdAdherent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdAdherent.Location = new System.Drawing.Point(13, 13);
            this.IdAdherent.Name = "IdAdherent";
            this.IdAdherent.Size = new System.Drawing.Size(20, 17);
            this.IdAdherent.TabIndex = 0;
            this.IdAdherent.Text = "ID";
            // 
            // BouttonEnregistrer
            // 
            this.BouttonEnregistrer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BouttonEnregistrer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BouttonEnregistrer.Location = new System.Drawing.Point(549, 513);
            this.BouttonEnregistrer.Name = "BouttonEnregistrer";
            this.BouttonEnregistrer.Size = new System.Drawing.Size(90, 33);
            this.BouttonEnregistrer.TabIndex = 8;
            this.BouttonEnregistrer.Text = "Enregistrer";
            this.BouttonEnregistrer.UseVisualStyleBackColor = false;
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SearchBar.Location = new System.Drawing.Point(8, 10);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(303, 25);
            this.SearchBar.TabIndex = 1;
            this.SearchBar.Tag = "";
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // tabPageEmprunt
            // 
            this.tabPageEmprunt.Controls.Add(this.Supprimer_Emprunt);
            this.tabPageEmprunt.Controls.Add(this.Ajouter_emprunt);
            this.tabPageEmprunt.Controls.Add(this.Annee_RetourPrevu);
            this.tabPageEmprunt.Controls.Add(this.Mois_RetourPrevu);
            this.tabPageEmprunt.Controls.Add(this.Jour_RetourPrevu);
            this.tabPageEmprunt.Controls.Add(this.label2);
            this.tabPageEmprunt.Controls.Add(this.Mois_Emprunt);
            this.tabPageEmprunt.Controls.Add(this.Annee_Emprunt);
            this.tabPageEmprunt.Controls.Add(this.Jour_Emprunt);
            this.tabPageEmprunt.Controls.Add(this.label1);
            this.tabPageEmprunt.Controls.Add(this.BouttonEnregistrerAjoutEmprunt);
            this.tabPageEmprunt.Controls.Add(this.Liste_Livre_Emprunt);
            this.tabPageEmprunt.Controls.Add(this.PanelinfoAdherent);
            this.tabPageEmprunt.Controls.Add(this.ListeAdherentGererEmprunt);
            this.tabPageEmprunt.Controls.Add(this.SearchBarAdGererEmprunt);
            this.tabPageEmprunt.Controls.Add(this.RechercherAdherent);
            this.tabPageEmprunt.Controls.Add(this.ButtonRechercherLivre);
            this.tabPageEmprunt.Controls.Add(this.SearchBarBook);
            this.tabPageEmprunt.Controls.Add(this.listBox1);
            this.tabPageEmprunt.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmprunt.Name = "tabPageEmprunt";
            this.tabPageEmprunt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmprunt.Size = new System.Drawing.Size(847, 566);
            this.tabPageEmprunt.TabIndex = 1;
            this.tabPageEmprunt.Text = "Emprunt";
            this.tabPageEmprunt.UseVisualStyleBackColor = true;
            // 
            // Supprimer_Emprunt
            // 
            this.Supprimer_Emprunt.BackColor = System.Drawing.SystemColors.Window;
            this.Supprimer_Emprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer_Emprunt.Location = new System.Drawing.Point(391, 263);
            this.Supprimer_Emprunt.Name = "Supprimer_Emprunt";
            this.Supprimer_Emprunt.Size = new System.Drawing.Size(77, 23);
            this.Supprimer_Emprunt.TabIndex = 45;
            this.Supprimer_Emprunt.Text = "Supprimer";
            this.Supprimer_Emprunt.UseVisualStyleBackColor = false;
            // 
            // Ajouter_emprunt
            // 
            this.Ajouter_emprunt.BackColor = System.Drawing.SystemColors.Window;
            this.Ajouter_emprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_emprunt.Location = new System.Drawing.Point(8, 532);
            this.Ajouter_emprunt.Name = "Ajouter_emprunt";
            this.Ajouter_emprunt.Size = new System.Drawing.Size(303, 23);
            this.Ajouter_emprunt.TabIndex = 44;
            this.Ajouter_emprunt.Text = "Ajouter";
            this.Ajouter_emprunt.UseVisualStyleBackColor = false;
            // 
            // Annee_RetourPrevu
            // 
            this.Annee_RetourPrevu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annee_RetourPrevu.FormattingEnabled = true;
            this.Annee_RetourPrevu.Location = new System.Drawing.Point(702, 440);
            this.Annee_RetourPrevu.Name = "Annee_RetourPrevu";
            this.Annee_RetourPrevu.Size = new System.Drawing.Size(121, 25);
            this.Annee_RetourPrevu.TabIndex = 43;
            this.Annee_RetourPrevu.Text = "Année";
            // 
            // Mois_RetourPrevu
            // 
            this.Mois_RetourPrevu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mois_RetourPrevu.FormattingEnabled = true;
            this.Mois_RetourPrevu.Location = new System.Drawing.Point(549, 440);
            this.Mois_RetourPrevu.Name = "Mois_RetourPrevu";
            this.Mois_RetourPrevu.Size = new System.Drawing.Size(121, 25);
            this.Mois_RetourPrevu.TabIndex = 42;
            this.Mois_RetourPrevu.Text = "Mois";
            // 
            // Jour_RetourPrevu
            // 
            this.Jour_RetourPrevu.Cursor = System.Windows.Forms.Cursors.Default;
            this.Jour_RetourPrevu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jour_RetourPrevu.FormattingEnabled = true;
            this.Jour_RetourPrevu.Location = new System.Drawing.Point(391, 440);
            this.Jour_RetourPrevu.Name = "Jour_RetourPrevu";
            this.Jour_RetourPrevu.Size = new System.Drawing.Size(121, 25);
            this.Jour_RetourPrevu.TabIndex = 41;
            this.Jour_RetourPrevu.Text = "Jour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(543, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Date de retour prévu";
            // 
            // Mois_Emprunt
            // 
            this.Mois_Emprunt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mois_Emprunt.FormattingEnabled = true;
            this.Mois_Emprunt.Location = new System.Drawing.Point(549, 330);
            this.Mois_Emprunt.Name = "Mois_Emprunt";
            this.Mois_Emprunt.Size = new System.Drawing.Size(121, 25);
            this.Mois_Emprunt.TabIndex = 39;
            this.Mois_Emprunt.Text = "Mois";
            // 
            // Annee_Emprunt
            // 
            this.Annee_Emprunt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annee_Emprunt.FormattingEnabled = true;
            this.Annee_Emprunt.Location = new System.Drawing.Point(702, 330);
            this.Annee_Emprunt.Name = "Annee_Emprunt";
            this.Annee_Emprunt.Size = new System.Drawing.Size(121, 25);
            this.Annee_Emprunt.TabIndex = 38;
            this.Annee_Emprunt.Text = "Année";
            // 
            // Jour_Emprunt
            // 
            this.Jour_Emprunt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Jour_Emprunt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jour_Emprunt.FormattingEnabled = true;
            this.Jour_Emprunt.Location = new System.Drawing.Point(391, 330);
            this.Jour_Emprunt.Name = "Jour_Emprunt";
            this.Jour_Emprunt.Size = new System.Drawing.Size(121, 25);
            this.Jour_Emprunt.TabIndex = 37;
            this.Jour_Emprunt.Text = "Jour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Date d\'emprunt";
            // 
            // BouttonEnregistrerAjoutEmprunt
            // 
            this.BouttonEnregistrerAjoutEmprunt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BouttonEnregistrerAjoutEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BouttonEnregistrerAjoutEmprunt.Location = new System.Drawing.Point(557, 524);
            this.BouttonEnregistrerAjoutEmprunt.Name = "BouttonEnregistrerAjoutEmprunt";
            this.BouttonEnregistrerAjoutEmprunt.Size = new System.Drawing.Size(90, 33);
            this.BouttonEnregistrerAjoutEmprunt.TabIndex = 35;
            this.BouttonEnregistrerAjoutEmprunt.Text = "Enregistrer";
            this.BouttonEnregistrerAjoutEmprunt.UseVisualStyleBackColor = false;
            // 
            // Liste_Livre_Emprunt
            // 
            this.Liste_Livre_Emprunt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liste_Livre_Emprunt.FormattingEnabled = true;
            this.Liste_Livre_Emprunt.ItemHeight = 17;
            this.Liste_Livre_Emprunt.Location = new System.Drawing.Point(391, 151);
            this.Liste_Livre_Emprunt.Name = "Liste_Livre_Emprunt";
            this.Liste_Livre_Emprunt.Size = new System.Drawing.Size(432, 106);
            this.Liste_Livre_Emprunt.TabIndex = 34;
            // 
            // PanelinfoAdherent
            // 
            this.PanelinfoAdherent.BackColor = System.Drawing.SystemColors.Window;
            this.PanelinfoAdherent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelinfoAdherent.Controls.Add(this.Telephone_Adherent);
            this.PanelinfoAdherent.Controls.Add(this.Adresse_Adherent);
            this.PanelinfoAdherent.Controls.Add(this.Prenom_Adherent);
            this.PanelinfoAdherent.Controls.Add(this.Nom_Adherent);
            this.PanelinfoAdherent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelinfoAdherent.Location = new System.Drawing.Point(577, 46);
            this.PanelinfoAdherent.Name = "PanelinfoAdherent";
            this.PanelinfoAdherent.Size = new System.Drawing.Size(246, 95);
            this.PanelinfoAdherent.TabIndex = 33;
            // 
            // Telephone_Adherent
            // 
            this.Telephone_Adherent.AutoSize = true;
            this.Telephone_Adherent.Location = new System.Drawing.Point(3, 71);
            this.Telephone_Adherent.Name = "Telephone_Adherent";
            this.Telephone_Adherent.Size = new System.Drawing.Size(61, 13);
            this.Telephone_Adherent.TabIndex = 15;
            this.Telephone_Adherent.Text = "Téléphone";
            // 
            // Adresse_Adherent
            // 
            this.Adresse_Adherent.AutoSize = true;
            this.Adresse_Adherent.Location = new System.Drawing.Point(3, 49);
            this.Adresse_Adherent.Name = "Adresse_Adherent";
            this.Adresse_Adherent.Size = new System.Drawing.Size(47, 13);
            this.Adresse_Adherent.TabIndex = 15;
            this.Adresse_Adherent.Text = "Adresse";
            // 
            // Prenom_Adherent
            // 
            this.Prenom_Adherent.AutoSize = true;
            this.Prenom_Adherent.Location = new System.Drawing.Point(3, 27);
            this.Prenom_Adherent.Name = "Prenom_Adherent";
            this.Prenom_Adherent.Size = new System.Drawing.Size(46, 13);
            this.Prenom_Adherent.TabIndex = 15;
            this.Prenom_Adherent.Text = "Prénom";
            // 
            // Nom_Adherent
            // 
            this.Nom_Adherent.AutoSize = true;
            this.Nom_Adherent.Location = new System.Drawing.Point(3, 5);
            this.Nom_Adherent.Name = "Nom_Adherent";
            this.Nom_Adherent.Size = new System.Drawing.Size(31, 13);
            this.Nom_Adherent.TabIndex = 0;
            this.Nom_Adherent.Text = "Nom";
            // 
            // ListeAdherentGererEmprunt
            // 
            this.ListeAdherentGererEmprunt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeAdherentGererEmprunt.FormattingEnabled = true;
            this.ListeAdherentGererEmprunt.Location = new System.Drawing.Point(391, 46);
            this.ListeAdherentGererEmprunt.Name = "ListeAdherentGererEmprunt";
            this.ListeAdherentGererEmprunt.Size = new System.Drawing.Size(180, 95);
            this.ListeAdherentGererEmprunt.TabIndex = 32;
            // 
            // SearchBarAdGererEmprunt
            // 
            this.SearchBarAdGererEmprunt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchBarAdGererEmprunt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBarAdGererEmprunt.Location = new System.Drawing.Point(731, 15);
            this.SearchBarAdGererEmprunt.Name = "SearchBarAdGererEmprunt";
            this.SearchBarAdGererEmprunt.Size = new System.Drawing.Size(92, 23);
            this.SearchBarAdGererEmprunt.TabIndex = 31;
            this.SearchBarAdGererEmprunt.Text = "Rechercher";
            this.SearchBarAdGererEmprunt.UseVisualStyleBackColor = false;
            // 
            // RechercherAdherent
            // 
            this.RechercherAdherent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechercherAdherent.Location = new System.Drawing.Point(391, 15);
            this.RechercherAdherent.Name = "RechercherAdherent";
            this.RechercherAdherent.Size = new System.Drawing.Size(334, 25);
            this.RechercherAdherent.TabIndex = 30;
            // 
            // ButtonRechercherLivre
            // 
            this.ButtonRechercherLivre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonRechercherLivre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRechercherLivre.Location = new System.Drawing.Point(219, 6);
            this.ButtonRechercherLivre.Name = "ButtonRechercherLivre";
            this.ButtonRechercherLivre.Size = new System.Drawing.Size(92, 25);
            this.ButtonRechercherLivre.TabIndex = 29;
            this.ButtonRechercherLivre.Text = "Rechercher";
            this.ButtonRechercherLivre.UseVisualStyleBackColor = false;
            // 
            // SearchBarBook
            // 
            this.SearchBarBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SearchBarBook.Location = new System.Drawing.Point(8, 7);
            this.SearchBarBook.Name = "SearchBarBook";
            this.SearchBarBook.Size = new System.Drawing.Size(205, 25);
            this.SearchBarBook.TabIndex = 28;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(8, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 480);
            this.listBox1.TabIndex = 27;
            // 
            // Regroupement_Emprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 592);
            this.Controls.Add(this.TabEmprunt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Regroupement_Emprunt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regroupementform";
            this.TabEmprunt.ResumeLayout(false);
            this.tabPageAdherentEmprunt.ResumeLayout(false);
            this.tabPageAdherentEmprunt.PerformLayout();
            this.InfosAdhérents.ResumeLayout(false);
            this.InfosAdhérents.PerformLayout();
            this.tabPageEmprunt.ResumeLayout(false);
            this.tabPageEmprunt.PerformLayout();
            this.PanelinfoAdherent.ResumeLayout(false);
            this.PanelinfoAdherent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabEmprunt;
        private System.Windows.Forms.TabPage tabPageAdherentEmprunt;
        private System.Windows.Forms.TabPage tabPageEmprunt;
        private System.Windows.Forms.ComboBox EtatEmprunt;
        private System.Windows.Forms.ComboBox MoisEmprunt;
        private System.Windows.Forms.ComboBox AnneeEmprunt;
        private System.Windows.Forms.ComboBox JourEmprunt;
        private System.Windows.Forms.ListBox ListeLivre;
        private System.Windows.Forms.Panel InfosAdhérents;
        private System.Windows.Forms.Label AdresseAdherent;
        private System.Windows.Forms.Label TelephoneAdherent;
        private System.Windows.Forms.Label NomAdherent;
        private System.Windows.Forms.Label PrenomAdherent;
        private System.Windows.Forms.Label IdAdherent;
        private System.Windows.Forms.Button BouttonEnregistrer;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button Supprimer_Emprunt;
        private System.Windows.Forms.Button Ajouter_emprunt;
        private System.Windows.Forms.ComboBox Annee_RetourPrevu;
        private System.Windows.Forms.ComboBox Mois_RetourPrevu;
        private System.Windows.Forms.ComboBox Jour_RetourPrevu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Mois_Emprunt;
        private System.Windows.Forms.ComboBox Annee_Emprunt;
        private System.Windows.Forms.ComboBox Jour_Emprunt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BouttonEnregistrerAjoutEmprunt;
        private System.Windows.Forms.ListBox Liste_Livre_Emprunt;
        private System.Windows.Forms.Panel PanelinfoAdherent;
        private System.Windows.Forms.Label Telephone_Adherent;
        private System.Windows.Forms.Label Adresse_Adherent;
        private System.Windows.Forms.Label Prenom_Adherent;
        private System.Windows.Forms.Label Nom_Adherent;
        private System.Windows.Forms.ListBox ListeAdherentGererEmprunt;
        private System.Windows.Forms.Button SearchBarAdGererEmprunt;
        private System.Windows.Forms.TextBox RechercherAdherent;
        private System.Windows.Forms.Button ButtonRechercherLivre;
        private System.Windows.Forms.TextBox SearchBarBook;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBoxAdherent;
    }
}