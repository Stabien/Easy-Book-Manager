using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Security.Cryptography;

namespace Easy_Book_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
            try {
                // Db connection
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                // Hashing password width SHA256 
                string hashedPassword = this.hashPassword(textBoxMDP.Text);
                
                // Create request
                SqlCommand command = new SqlCommand($"SELECT id FROM Employes WHERE Login = '{textBoxNom.Text}' AND Password = '{hashedPassword}'", conn);
                
                // Execute request 
                SqlDataReader dataReader = command.ExecuteReader();

                // Check data and close if exist
                if (dataReader.Read())
                {
                    this.closeApp = false;
                    Close();
                }
                else
                    MessageBox.Show("Identifiants invalides !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            catch {
                MessageBox.Show("Erreur"); 
            }
        }
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?",
            "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
                Application.Exit();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.closeApp)
                Application.Exit();
        }
        private string hashPassword(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash
                  .ComputeHash(Encoding.UTF8.GetBytes(password))
                  .Select(item => item.ToString("x2")));
            }
        }
        // Check closing event
        private bool closeApp = true;
    }
}
