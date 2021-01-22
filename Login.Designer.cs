namespace Easy_Book_Manager
{
    partial class Login
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.groupBoxAuthentification = new System.Windows.Forms.GroupBox();
            this.labelMDP = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.groupBoxAuthentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.CausesValidation = false;
            this.buttonValider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(50, 139);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(98, 32);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.CausesValidation = false;
            this.buttonAnnuler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(184, 139);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(98, 32);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // groupBoxAuthentification
            // 
            this.groupBoxAuthentification.Controls.Add(this.labelMDP);
            this.groupBoxAuthentification.Controls.Add(this.labelNom);
            this.groupBoxAuthentification.Controls.Add(this.textBoxMDP);
            this.groupBoxAuthentification.Controls.Add(this.textBoxNom);
            this.groupBoxAuthentification.Location = new System.Drawing.Point(15, 12);
            this.groupBoxAuthentification.Name = "groupBoxAuthentification";
            this.groupBoxAuthentification.Size = new System.Drawing.Size(303, 111);
            this.groupBoxAuthentification.TabIndex = 7;
            this.groupBoxAuthentification.TabStop = false;
            this.groupBoxAuthentification.Text = "Authentification";
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMDP.Location = new System.Drawing.Point(5, 66);
            this.labelMDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(102, 21);
            this.labelMDP.TabIndex = 8;
            this.labelMDP.Text = "Mot de passe";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(5, 27);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(45, 21);
            this.labelNom.TabIndex = 7;
            this.labelNom.Text = "Nom";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMDP.Location = new System.Drawing.Point(112, 68);
            this.textBoxMDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(166, 29);
            this.textBoxMDP.TabIndex = 2;
            this.textBoxMDP.UseSystemPasswordChar = true;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(112, 27);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(166, 29);
            this.textBoxNom.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(334, 185);
            this.Controls.Add(this.groupBoxAuthentification);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Book Manager";
            this.groupBoxAuthentification.ResumeLayout(false);
            this.groupBoxAuthentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.GroupBox groupBoxAuthentification;
        private System.Windows.Forms.Label labelMDP;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.TextBox textBoxNom;
    }
}

