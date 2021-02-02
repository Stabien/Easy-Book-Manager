namespace Easy_Book_Manager
{
    partial class Main
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
            this.listBoxLivres = new System.Windows.Forms.ListBox();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonEmprunts = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxGenreAjouter = new System.Windows.Forms.ComboBox();
            this.labelAjouterPanel = new System.Windows.Forms.Label();
            this.buttonEnregisterAjouter = new System.Windows.Forms.Button();
            this.labelAuteurAjouter = new System.Windows.Forms.Label();
            this.labelGenreAjouter = new System.Windows.Forms.Label();
            this.labelEditionAjouter = new System.Windows.Forms.Label();
            this.labelTitreAjouter = new System.Windows.Forms.Label();
            this.textBoxAuteurAjouter = new System.Windows.Forms.TextBox();
            this.textBoxTitreAjouter = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxGenreModifier = new System.Windows.Forms.ComboBox();
            this.labelModifierPanel = new System.Windows.Forms.Label();
            this.buttonEnregisterModifier = new System.Windows.Forms.Button();
            this.labelAuteurModifier = new System.Windows.Forms.Label();
            this.labelGenreModifier = new System.Windows.Forms.Label();
            this.labelEditionModifier = new System.Windows.Forms.Label();
            this.labelStatusModifier = new System.Windows.Forms.Label();
            this.labelTitreModifier = new System.Windows.Forms.Label();
            this.textBoxAuteurModifier = new System.Windows.Forms.TextBox();
            this.textBoxStatusModifier = new System.Windows.Forms.TextBox();
            this.textBoxEditionModifier = new System.Windows.Forms.TextBox();
            this.textBoxTitreModifier = new System.Windows.Forms.TextBox();
            this.comboBoxEditionAjouter = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLivres
            // 
            this.listBoxLivres.FormattingEnabled = true;
            this.listBoxLivres.ItemHeight = 16;
            this.listBoxLivres.Location = new System.Drawing.Point(35, 85);
            this.listBoxLivres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLivres.Name = "listBoxLivres";
            this.listBoxLivres.Size = new System.Drawing.Size(501, 580);
            this.listBoxLivres.TabIndex = 0;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxRecherche.Location = new System.Drawing.Point(35, 28);
            this.textBoxRecherche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(368, 39);
            this.textBoxRecherche.TabIndex = 1;
            this.textBoxRecherche.Text = "Recherche de Livres";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.Location = new System.Drawing.Point(409, 27);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(128, 42);
            this.buttonRechercher.TabIndex = 2;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // buttonEmprunts
            // 
            this.buttonEmprunts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmprunts.Location = new System.Drawing.Point(619, 28);
            this.buttonEmprunts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmprunts.Name = "buttonEmprunts";
            this.buttonEmprunts.Size = new System.Drawing.Size(469, 62);
            this.buttonEmprunts.TabIndex = 3;
            this.buttonEmprunts.Text = "Voir les emprunts";
            this.buttonEmprunts.UseVisualStyleBackColor = true;
            this.buttonEmprunts.Click += new System.EventHandler(this.buttonEmprunts_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.Location = new System.Drawing.Point(33, 683);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(148, 43);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.Location = new System.Drawing.Point(187, 683);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(179, 43);
            this.buttonModifier.TabIndex = 13;
            this.buttonModifier.Text = "Voir/Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.Location = new System.Drawing.Point(371, 683);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(167, 43);
            this.buttonSupprimer.TabIndex = 14;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxEditionAjouter);
            this.panel2.Controls.Add(this.comboBoxGenreAjouter);
            this.panel2.Controls.Add(this.labelAjouterPanel);
            this.panel2.Controls.Add(this.buttonEnregisterAjouter);
            this.panel2.Controls.Add(this.labelAuteurAjouter);
            this.panel2.Controls.Add(this.labelGenreAjouter);
            this.panel2.Controls.Add(this.labelEditionAjouter);
            this.panel2.Controls.Add(this.labelTitreAjouter);
            this.panel2.Controls.Add(this.textBoxAuteurAjouter);
            this.panel2.Controls.Add(this.textBoxTitreAjouter);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 609);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBoxGenreAjouter
            // 
            this.comboBoxGenreAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenreAjouter.FormattingEnabled = true;
            this.comboBoxGenreAjouter.Location = new System.Drawing.Point(91, 327);
            this.comboBoxGenreAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGenreAjouter.Name = "comboBoxGenreAjouter";
            this.comboBoxGenreAjouter.Size = new System.Drawing.Size(287, 36);
            this.comboBoxGenreAjouter.TabIndex = 12;
            // 
            // labelAjouterPanel
            // 
            this.labelAjouterPanel.AutoSize = true;
            this.labelAjouterPanel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjouterPanel.Location = new System.Drawing.Point(101, 38);
            this.labelAjouterPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAjouterPanel.Name = "labelAjouterPanel";
            this.labelAjouterPanel.Size = new System.Drawing.Size(249, 46);
            this.labelAjouterPanel.TabIndex = 11;
            this.labelAjouterPanel.Text = "Ajouter un livre";
            // 
            // buttonEnregisterAjouter
            // 
            this.buttonEnregisterAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregisterAjouter.Location = new System.Drawing.Point(151, 501);
            this.buttonEnregisterAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEnregisterAjouter.Name = "buttonEnregisterAjouter";
            this.buttonEnregisterAjouter.Size = new System.Drawing.Size(164, 47);
            this.buttonEnregisterAjouter.TabIndex = 10;
            this.buttonEnregisterAjouter.Text = "Enregistrer";
            this.buttonEnregisterAjouter.UseVisualStyleBackColor = true;
            // 
            // labelAuteurAjouter
            // 
            this.labelAuteurAjouter.AutoSize = true;
            this.labelAuteurAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuteurAjouter.Location = new System.Drawing.Point(87, 204);
            this.labelAuteurAjouter.Name = "labelAuteurAjouter";
            this.labelAuteurAjouter.Size = new System.Drawing.Size(62, 23);
            this.labelAuteurAjouter.TabIndex = 9;
            this.labelAuteurAjouter.Text = "Auteur";
            // 
            // labelGenreAjouter
            // 
            this.labelGenreAjouter.AutoSize = true;
            this.labelGenreAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenreAjouter.Location = new System.Drawing.Point(88, 297);
            this.labelGenreAjouter.Name = "labelGenreAjouter";
            this.labelGenreAjouter.Size = new System.Drawing.Size(56, 23);
            this.labelGenreAjouter.TabIndex = 8;
            this.labelGenreAjouter.Text = "Genre";
            // 
            // labelEditionAjouter
            // 
            this.labelEditionAjouter.AutoSize = true;
            this.labelEditionAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditionAjouter.Location = new System.Drawing.Point(89, 393);
            this.labelEditionAjouter.Name = "labelEditionAjouter";
            this.labelEditionAjouter.Size = new System.Drawing.Size(63, 23);
            this.labelEditionAjouter.TabIndex = 7;
            this.labelEditionAjouter.Text = "Edition";
            // 
            // labelTitreAjouter
            // 
            this.labelTitreAjouter.AutoSize = true;
            this.labelTitreAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreAjouter.Location = new System.Drawing.Point(88, 111);
            this.labelTitreAjouter.Name = "labelTitreAjouter";
            this.labelTitreAjouter.Size = new System.Drawing.Size(44, 23);
            this.labelTitreAjouter.TabIndex = 5;
            this.labelTitreAjouter.Text = "Titre";
            // 
            // textBoxAuteurAjouter
            // 
            this.textBoxAuteurAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuteurAjouter.Location = new System.Drawing.Point(91, 233);
            this.textBoxAuteurAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAuteurAjouter.Name = "textBoxAuteurAjouter";
            this.textBoxAuteurAjouter.Size = new System.Drawing.Size(287, 34);
            this.textBoxAuteurAjouter.TabIndex = 4;
            // 
            // textBoxTitreAjouter
            // 
            this.textBoxTitreAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitreAjouter.Location = new System.Drawing.Point(92, 139);
            this.textBoxTitreAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitreAjouter.Name = "textBoxTitreAjouter";
            this.textBoxTitreAjouter.Size = new System.Drawing.Size(287, 34);
            this.textBoxTitreAjouter.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.comboBoxGenreModifier);
            this.panel3.Controls.Add(this.labelModifierPanel);
            this.panel3.Controls.Add(this.buttonEnregisterModifier);
            this.panel3.Controls.Add(this.labelAuteurModifier);
            this.panel3.Controls.Add(this.labelGenreModifier);
            this.panel3.Controls.Add(this.labelEditionModifier);
            this.panel3.Controls.Add(this.labelStatusModifier);
            this.panel3.Controls.Add(this.labelTitreModifier);
            this.panel3.Controls.Add(this.textBoxAuteurModifier);
            this.panel3.Controls.Add(this.textBoxStatusModifier);
            this.panel3.Controls.Add(this.textBoxEditionModifier);
            this.panel3.Controls.Add(this.textBoxTitreModifier);
            this.panel3.Location = new System.Drawing.Point(619, 117);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 609);
            this.panel3.TabIndex = 11;
            // 
            // comboBoxGenreModifier
            // 
            this.comboBoxGenreModifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenreModifier.FormattingEnabled = true;
            this.comboBoxGenreModifier.Location = new System.Drawing.Point(93, 284);
            this.comboBoxGenreModifier.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGenreModifier.Name = "comboBoxGenreModifier";
            this.comboBoxGenreModifier.Size = new System.Drawing.Size(287, 36);
            this.comboBoxGenreModifier.TabIndex = 13;
            // 
            // labelModifierPanel
            // 
            this.labelModifierPanel.AutoSize = true;
            this.labelModifierPanel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifierPanel.Location = new System.Drawing.Point(156, 46);
            this.labelModifierPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModifierPanel.Name = "labelModifierPanel";
            this.labelModifierPanel.Size = new System.Drawing.Size(148, 46);
            this.labelModifierPanel.TabIndex = 11;
            this.labelModifierPanel.Text = "Modifier";
            // 
            // buttonEnregisterModifier
            // 
            this.buttonEnregisterModifier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregisterModifier.Location = new System.Drawing.Point(168, 513);
            this.buttonEnregisterModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEnregisterModifier.Name = "buttonEnregisterModifier";
            this.buttonEnregisterModifier.Size = new System.Drawing.Size(152, 47);
            this.buttonEnregisterModifier.TabIndex = 10;
            this.buttonEnregisterModifier.Text = "Enregistrer";
            this.buttonEnregisterModifier.UseVisualStyleBackColor = true;
            // 
            // labelAuteurModifier
            // 
            this.labelAuteurModifier.AutoSize = true;
            this.labelAuteurModifier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuteurModifier.Location = new System.Drawing.Point(89, 182);
            this.labelAuteurModifier.Name = "labelAuteurModifier";
            this.labelAuteurModifier.Size = new System.Drawing.Size(62, 23);
            this.labelAuteurModifier.TabIndex = 9;
            this.labelAuteurModifier.Text = "Auteur";
            // 
            // labelGenreModifier
            // 
            this.labelGenreModifier.AutoSize = true;
            this.labelGenreModifier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenreModifier.Location = new System.Drawing.Point(88, 257);
            this.labelGenreModifier.Name = "labelGenreModifier";
            this.labelGenreModifier.Size = new System.Drawing.Size(56, 23);
            this.labelGenreModifier.TabIndex = 8;
            this.labelGenreModifier.Text = "Genre";
            // 
            // labelEditionModifier
            // 
            this.labelEditionModifier.AutoSize = true;
            this.labelEditionModifier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditionModifier.Location = new System.Drawing.Point(88, 334);
            this.labelEditionModifier.Name = "labelEditionModifier";
            this.labelEditionModifier.Size = new System.Drawing.Size(63, 23);
            this.labelEditionModifier.TabIndex = 7;
            this.labelEditionModifier.Text = "Edition";
            // 
            // labelStatusModifier
            // 
            this.labelStatusModifier.AutoSize = true;
            this.labelStatusModifier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusModifier.Location = new System.Drawing.Point(88, 407);
            this.labelStatusModifier.Name = "labelStatusModifier";
            this.labelStatusModifier.Size = new System.Drawing.Size(56, 23);
            this.labelStatusModifier.TabIndex = 6;
            this.labelStatusModifier.Text = "Status";
            // 
            // labelTitreModifier
            // 
            this.labelTitreModifier.AutoSize = true;
            this.labelTitreModifier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreModifier.Location = new System.Drawing.Point(88, 111);
            this.labelTitreModifier.Name = "labelTitreModifier";
            this.labelTitreModifier.Size = new System.Drawing.Size(44, 23);
            this.labelTitreModifier.TabIndex = 5;
            this.labelTitreModifier.Text = "Titre";
            // 
            // textBoxAuteurModifier
            // 
            this.textBoxAuteurModifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuteurModifier.Location = new System.Drawing.Point(93, 210);
            this.textBoxAuteurModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAuteurModifier.Name = "textBoxAuteurModifier";
            this.textBoxAuteurModifier.Size = new System.Drawing.Size(287, 34);
            this.textBoxAuteurModifier.TabIndex = 4;
            // 
            // textBoxStatusModifier
            // 
            this.textBoxStatusModifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatusModifier.Location = new System.Drawing.Point(92, 436);
            this.textBoxStatusModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStatusModifier.Name = "textBoxStatusModifier";
            this.textBoxStatusModifier.Size = new System.Drawing.Size(287, 34);
            this.textBoxStatusModifier.TabIndex = 2;
            // 
            // textBoxEditionModifier
            // 
            this.textBoxEditionModifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditionModifier.Location = new System.Drawing.Point(92, 362);
            this.textBoxEditionModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEditionModifier.Name = "textBoxEditionModifier";
            this.textBoxEditionModifier.Size = new System.Drawing.Size(287, 34);
            this.textBoxEditionModifier.TabIndex = 1;
            // 
            // textBoxTitreModifier
            // 
            this.textBoxTitreModifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitreModifier.Location = new System.Drawing.Point(92, 139);
            this.textBoxTitreModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitreModifier.Name = "textBoxTitreModifier";
            this.textBoxTitreModifier.Size = new System.Drawing.Size(287, 34);
            this.textBoxTitreModifier.TabIndex = 0;
            // 
            // comboBoxEditionAjouter
            // 
            this.comboBoxEditionAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditionAjouter.FormattingEnabled = true;
            this.comboBoxEditionAjouter.Location = new System.Drawing.Point(91, 420);
            this.comboBoxEditionAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEditionAjouter.Name = "comboBoxEditionAjouter";
            this.comboBoxEditionAjouter.Size = new System.Drawing.Size(287, 36);
            this.comboBoxEditionAjouter.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 774);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonEmprunts);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.listBoxLivres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Book Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLivres;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonEmprunts;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAjouterPanel;
        private System.Windows.Forms.Button buttonEnregisterAjouter;
        private System.Windows.Forms.Label labelAuteurAjouter;
        private System.Windows.Forms.Label labelGenreAjouter;
        private System.Windows.Forms.Label labelEditionAjouter;
        private System.Windows.Forms.Label labelTitreAjouter;
        private System.Windows.Forms.TextBox textBoxAuteurAjouter;
        private System.Windows.Forms.TextBox textBoxTitreAjouter;
        private System.Windows.Forms.ComboBox comboBoxGenreAjouter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelModifierPanel;
        private System.Windows.Forms.Button buttonEnregisterModifier;
        private System.Windows.Forms.Label labelAuteurModifier;
        private System.Windows.Forms.Label labelGenreModifier;
        private System.Windows.Forms.Label labelEditionModifier;
        private System.Windows.Forms.Label labelStatusModifier;
        private System.Windows.Forms.Label labelTitreModifier;
        private System.Windows.Forms.TextBox textBoxAuteurModifier;
        private System.Windows.Forms.TextBox textBoxStatusModifier;
        private System.Windows.Forms.TextBox textBoxEditionModifier;
        private System.Windows.Forms.TextBox textBoxTitreModifier;
        private System.Windows.Forms.ComboBox comboBoxGenreModifier;
        private System.Windows.Forms.ComboBox comboBoxEditionAjouter;
    }
}