﻿namespace Easy_Book_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listBoxLivres = new System.Windows.Forms.ListBox();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.buttonEmprunts = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEditionAjouter = new System.Windows.Forms.TextBox();
            this.comboBoxGenreAjouter = new System.Windows.Forms.ComboBox();
            this.labelAjouterPanel = new System.Windows.Forms.Label();
            this.buttonEnregisterAjouter = new System.Windows.Forms.Button();
            this.labelAuteurAjouter = new System.Windows.Forms.Label();
            this.labelGenreAjouter = new System.Windows.Forms.Label();
            this.labelEditionAjouter = new System.Windows.Forms.Label();
            this.labelTitreAjouter = new System.Windows.Forms.Label();
            this.textBoxAuteurAjouter = new System.Windows.Forms.TextBox();
            this.textBoxTitreAjouter = new System.Windows.Forms.TextBox();
            this.buttonAdherents = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLivres
            // 
            this.listBoxLivres.FormattingEnabled = true;
            this.listBoxLivres.ItemHeight = 20;
            this.listBoxLivres.Location = new System.Drawing.Point(39, 106);
            this.listBoxLivres.Name = "listBoxLivres";
            this.listBoxLivres.Size = new System.Drawing.Size(564, 724);
            this.listBoxLivres.TabIndex = 0;
            this.listBoxLivres.SelectedIndexChanged += new System.EventHandler(this.listBoxLivres_SelectedIndexChanged);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxRecherche.Location = new System.Drawing.Point(39, 35);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(564, 45);
            this.textBoxRecherche.TabIndex = 1;
            this.textBoxRecherche.Text = "Recherche de Livres";
            this.textBoxRecherche.Click += new System.EventHandler(this.textBoxRecherche_Click);
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // buttonEmprunts
            // 
            this.buttonEmprunts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmprunts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmprunts.Location = new System.Drawing.Point(696, 35);
            this.buttonEmprunts.Name = "buttonEmprunts";
            this.buttonEmprunts.Size = new System.Drawing.Size(249, 77);
            this.buttonEmprunts.TabIndex = 3;
            this.buttonEmprunts.Text = "Gestion Emprunts";
            this.buttonEmprunts.UseVisualStyleBackColor = true;
            this.buttonEmprunts.Click += new System.EventHandler(this.buttonEmprunts_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.Location = new System.Drawing.Point(38, 854);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(166, 54);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.Location = new System.Drawing.Point(210, 854);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(201, 54);
            this.buttonModifier.TabIndex = 13;
            this.buttonModifier.Text = "Voir/Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.Location = new System.Drawing.Point(417, 854);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(188, 54);
            this.buttonSupprimer.TabIndex = 14;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxEditionAjouter);
            this.panel2.Controls.Add(this.comboBoxGenreAjouter);
            this.panel2.Controls.Add(this.labelAjouterPanel);
            this.panel2.Controls.Add(this.buttonEnregisterAjouter);
            this.panel2.Controls.Add(this.labelAuteurAjouter);
            this.panel2.Controls.Add(this.labelGenreAjouter);
            this.panel2.Controls.Add(this.labelEditionAjouter);
            this.panel2.Controls.Add(this.labelTitreAjouter);
            this.panel2.Controls.Add(this.textBoxAuteurAjouter);
            this.panel2.Controls.Add(this.textBoxTitreAjouter);
            this.panel2.Location = new System.Drawing.Point(696, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 760);
            this.panel2.TabIndex = 12;
            // 
            // textBoxEditionAjouter
            // 
            this.textBoxEditionAjouter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxEditionAjouter.Location = new System.Drawing.Point(102, 525);
            this.textBoxEditionAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEditionAjouter.Name = "textBoxEditionAjouter";
            this.textBoxEditionAjouter.Size = new System.Drawing.Size(320, 39);
            this.textBoxEditionAjouter.TabIndex = 13;
            // 
            // comboBoxGenreAjouter
            // 
            this.comboBoxGenreAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenreAjouter.FormattingEnabled = true;
            this.comboBoxGenreAjouter.Location = new System.Drawing.Point(104, 408);
            this.comboBoxGenreAjouter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxGenreAjouter.Name = "comboBoxGenreAjouter";
            this.comboBoxGenreAjouter.Size = new System.Drawing.Size(322, 40);
            this.comboBoxGenreAjouter.TabIndex = 12;
            // 
            // labelAjouterPanel
            // 
            this.labelAjouterPanel.AutoSize = true;
            this.labelAjouterPanel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjouterPanel.Location = new System.Drawing.Point(114, 48);
            this.labelAjouterPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAjouterPanel.Name = "labelAjouterPanel";
            this.labelAjouterPanel.Size = new System.Drawing.Size(299, 55);
            this.labelAjouterPanel.TabIndex = 11;
            this.labelAjouterPanel.Text = "Ajouter un livre";
            // 
            // buttonEnregisterAjouter
            // 
            this.buttonEnregisterAjouter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEnregisterAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnregisterAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregisterAjouter.Location = new System.Drawing.Point(170, 626);
            this.buttonEnregisterAjouter.Name = "buttonEnregisterAjouter";
            this.buttonEnregisterAjouter.Size = new System.Drawing.Size(184, 58);
            this.buttonEnregisterAjouter.TabIndex = 10;
            this.buttonEnregisterAjouter.Text = "Enregistrer";
            this.buttonEnregisterAjouter.UseVisualStyleBackColor = true;
            this.buttonEnregisterAjouter.Click += new System.EventHandler(this.buttonEnregisterAjouter_Click);
            // 
            // labelAuteurAjouter
            // 
            this.labelAuteurAjouter.AutoSize = true;
            this.labelAuteurAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuteurAjouter.Location = new System.Drawing.Point(98, 255);
            this.labelAuteurAjouter.Name = "labelAuteurAjouter";
            this.labelAuteurAjouter.Size = new System.Drawing.Size(76, 30);
            this.labelAuteurAjouter.TabIndex = 9;
            this.labelAuteurAjouter.Text = "Auteur";
            // 
            // labelGenreAjouter
            // 
            this.labelGenreAjouter.AutoSize = true;
            this.labelGenreAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenreAjouter.Location = new System.Drawing.Point(99, 371);
            this.labelGenreAjouter.Name = "labelGenreAjouter";
            this.labelGenreAjouter.Size = new System.Drawing.Size(68, 30);
            this.labelGenreAjouter.TabIndex = 8;
            this.labelGenreAjouter.Text = "Genre";
            // 
            // labelEditionAjouter
            // 
            this.labelEditionAjouter.AutoSize = true;
            this.labelEditionAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditionAjouter.Location = new System.Drawing.Point(100, 491);
            this.labelEditionAjouter.Name = "labelEditionAjouter";
            this.labelEditionAjouter.Size = new System.Drawing.Size(77, 30);
            this.labelEditionAjouter.TabIndex = 7;
            this.labelEditionAjouter.Text = "Edition";
            // 
            // labelTitreAjouter
            // 
            this.labelTitreAjouter.AutoSize = true;
            this.labelTitreAjouter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreAjouter.Location = new System.Drawing.Point(99, 138);
            this.labelTitreAjouter.Name = "labelTitreAjouter";
            this.labelTitreAjouter.Size = new System.Drawing.Size(54, 30);
            this.labelTitreAjouter.TabIndex = 5;
            this.labelTitreAjouter.Text = "Titre";
            // 
            // textBoxAuteurAjouter
            // 
            this.textBoxAuteurAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuteurAjouter.Location = new System.Drawing.Point(102, 291);
            this.textBoxAuteurAjouter.Name = "textBoxAuteurAjouter";
            this.textBoxAuteurAjouter.Size = new System.Drawing.Size(324, 39);
            this.textBoxAuteurAjouter.TabIndex = 4;
            // 
            // textBoxTitreAjouter
            // 
            this.textBoxTitreAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitreAjouter.Location = new System.Drawing.Point(104, 174);
            this.textBoxTitreAjouter.Name = "textBoxTitreAjouter";
            this.textBoxTitreAjouter.Size = new System.Drawing.Size(322, 39);
            this.textBoxTitreAjouter.TabIndex = 0;
            // 
            // buttonAdherents
            // 
            this.buttonAdherents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdherents.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdherents.Location = new System.Drawing.Point(970, 35);
            this.buttonAdherents.Name = "buttonAdherents";
            this.buttonAdherents.Size = new System.Drawing.Size(254, 77);
            this.buttonAdherents.TabIndex = 15;
            this.buttonAdherents.Text = "Gestion Adhérents";
            this.buttonAdherents.UseVisualStyleBackColor = true;
            this.buttonAdherents.Click += new System.EventHandler(this.buttonAdherents_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 968);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonAdherents);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonEmprunts);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.listBoxLivres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Book Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLivres;
        private System.Windows.Forms.TextBox textBoxRecherche;
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
        private System.Windows.Forms.TextBox textBoxEditionAjouter;
        private System.Windows.Forms.Button buttonAdherents;
        
    }
}