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
                // DB connexion
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                // Création de la requête
                SqlCommand command = new SqlCommand($"SELECT id FROM Employes WHERE Login = '{textBoxNom.Text}' AND Password = '{textBoxMDP.Text}'", conn);
                
                //Exécution et lecture de la requête 
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read()) {
                    Close();
                }
                MessageBox.Show("Identifiants invalides !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch {
                MessageBox.Show("Erreur"); 
            }
        }
        private static void ReadSingleRow(IDataRecord record)
        {
            Console.WriteLine(String.Format("{0}, {1}", record[0], record[1]));
        }
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?",
            "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                Application.Exit();
        }
    }
}
