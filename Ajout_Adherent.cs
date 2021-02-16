using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace Easy_Book_Manager
{
    public partial class Ajout_Adherent : Form
    {
        public Ajout_Adherent()
        {
            InitializeComponent();
        }
        private void button_Valider_ad_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
            try {
                bool checkFields = true;

                // Check all fields 
                if (textBoxNomAd.Text.Length < 3 || textBoxPrenomAd.Text.Length < 3)
                    checkFields = false;
                if (textBoxAgeAd.Text.Length < 1 || !this.isNumeric(textBoxAgeAd.Text))
                    checkFields = false;
                if (textBoxTelAd.Text.Length < 10 || !this.isNumeric(textBoxTelAd.Text))
                    checkFields = false;
                if (textBoxAdresseAd.Text.Length < 5)
                    checkFields = false;

                // If checkFields is true, execute request
                if (checkFields)
                {
                    int ageAd = int.Parse(textBoxAgeAd.Text);

                    Console.WriteLine(ageAd);
                    // Db connection
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();

                    // Create request and execute request
                    SqlCommand command = new SqlCommand($"INSERT INTO Adherents (Nom, Prenom, Adresse, Telephone, Age) VALUES (@nom, @prenom, @adresse, @telephone, @age)", conn);
                    command.Parameters.AddWithValue("@nom", textBoxNomAd.Text);
                    command.Parameters.AddWithValue("@prenom", textBoxPrenomAd.Text);
                    command.Parameters.AddWithValue("@adresse", textBoxAdresseAd.Text);
                    command.Parameters.AddWithValue("@telephone", textBoxTelAd.Text);
                    command.Parameters.AddWithValue("@age", ageAd);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Nouvel adhérent ajouté !");

                    // Clear fields
                    textBoxNomAd.Text = "";
                    textBoxPrenomAd.Text = "";
                    textBoxAgeAd.Text = "";
                    textBoxTelAd.Text = "";
                    textBoxAdresseAd.Text = "";
                }
                else
                    MessageBox.Show("Erreur lors de la saisie du formulaire");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_Annuler_ad_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment annuler ?",
            "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Application.Exit();
        }
        private bool isNumeric(string value)
        {
            foreach (char element in value)
                if (!Char.IsDigit(element))
                    return false;
            return true;
        }

        private void Ajout_Adherent_Load(object sender, EventArgs e)
        {

        }
    }
}
