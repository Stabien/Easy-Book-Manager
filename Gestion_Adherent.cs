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
    public partial class Gestion_Adherent : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
        List<string> allAdherents = new List<string>();
        int currentIdAdherent;

        public Gestion_Adherent()
        {
            InitializeComponent();
            listBoxDisplayAdherents();

        }
        private void listBoxDisplayAdherents()
        {
            try
            {
                // Open db
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                // Prepare command
                SqlCommand getAllAdherents = new SqlCommand("SELECT ID, Nom, Prenom FROM Adherents", conn);
                // Execute request
                SqlDataReader reader = getAllAdherents.ExecuteReader();

                // Clear both list
                this.allAdherents.Clear();
                this.listBoxAdherent.Items.Clear();

                while (reader.Read())
                {
                    // Fill both list
                    this.allAdherents.Add(reader["id"] + " " + reader["Nom"] + " " + reader["Prenom"]);
                    this.listBoxAdherent.Items.Add(reader["id"] + " " + reader["Nom"] + " " + reader["Prenom"]);
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void textBoxSearchAdherent_TextChanged(object sender, EventArgs e)
        {
            string research = this.textBoxSearchAdherent.Text;
            
            this.listBoxAdherent.Items.Clear();

            foreach (string adherents in this.allAdherents)
            {
                if (adherents.ToLower().Contains(research.ToLower()))
                    this.listBoxAdherent.Items.Add(adherents);
            }
        }

        private void listBoxAdherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string adherentSelected = listBoxAdherent.GetItemText(listBoxAdherent.SelectedItem);
            this.currentIdAdherent = int.Parse(this.getId(adherentSelected));

            try
            {
                // Open database
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                // Prepare request
                SqlCommand getAllAdherents = new SqlCommand("SELECT * FROM Adherents WHERE id=" + this.currentIdAdherent, conn);
                // Execute request
                SqlDataReader reader = getAllAdherents.ExecuteReader();

                while (reader.Read())
                {
                    textBoxModifNomAd.Text = reader["Nom"].ToString();
                    textBoxModifPrenomAd.Text = reader["Prenom"].ToString();
                    textBoxModifAgeAd.Text = reader["Age"].ToString();
                    textBoxModifTelAd.Text = reader["Telephone"].ToString();
                    textBoxModifAdresseAd.Text = reader["Adresse"].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonValiderModifAd_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkFields = true;

                // Check all fields 
                if (textBoxModifNomAd.Text.Length < 3 || textBoxModifPrenomAd.Text.Length < 3)
                    checkFields = false;
                if (textBoxModifAgeAd.Text.Length < 1 || !this.isNumeric(textBoxModifAgeAd.Text))
                    checkFields = false;
                if (textBoxModifTelAd.Text.Length < 10 || !this.isNumeric(textBoxModifTelAd.Text))
                    checkFields = false;
                if (textBoxModifAdresseAd.Text.Length < 5)
                    checkFields = false;

                // If checkFields is true, execute request
                if (checkFields)
                {
                    int ageAd = int.Parse(textBoxModifAgeAd.Text);

                    // Db connection
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();

                    // Create request and execute request
                    SqlCommand updateAdherent = new SqlCommand($"UPDATE Adherents SET Nom = @nom, Prenom = @prenom, Adresse = @adresse, Telephone = @telephone, Age = @age WHERE id =" + this.currentIdAdherent, conn);
                    updateAdherent.Parameters.AddWithValue("@nom", textBoxModifNomAd.Text);
                    updateAdherent.Parameters.AddWithValue("@prenom", textBoxModifPrenomAd.Text);
                    updateAdherent.Parameters.AddWithValue("@adresse", textBoxModifAdresseAd.Text);
                    updateAdherent.Parameters.AddWithValue("@telephone", textBoxModifTelAd.Text);
                    updateAdherent.Parameters.AddWithValue("@age", ageAd);
                    updateAdherent.ExecuteNonQuery();
                    
                    MessageBox.Show("Modifications enregistrées !");
                 
                    this.listBoxDisplayAdherents();
                    this.textBoxSearchAdherent.Text = "";

                }
                else
                    MessageBox.Show("Erreur lors de la saisie du formulaire");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonValiderAjoutAd_Click(object sender, EventArgs e)
        {
            try {
                bool checkFields = true;

                // Check all fields 
                if (textBoxAjoutNomAd.Text.Length < 3 || textBoxAjoutPrenomAd.Text.Length < 3)
                    checkFields = false;
                if (textBoxAjoutAgeAd.Text.Length < 1 || !this.isNumeric(textBoxAjoutAgeAd.Text))
                    checkFields = false;
                if (textBoxAjoutTelAd.Text.Length < 10 || !this.isNumeric(textBoxAjoutTelAd.Text))
                    checkFields = false;
                if (textBoxAjoutAdresseAd.Text.Length < 5)
                    checkFields = false;

                // If checkFields is true, execute request
                if (checkFields)
                {
                    int ageAd = int.Parse(textBoxAjoutAgeAd.Text);

                    Console.WriteLine(ageAd);
                    // Db connection
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();

                    // Create request and execute request
                    SqlCommand command = new SqlCommand($"INSERT INTO Adherents (Nom, Prenom, Adresse, Telephone, Age) VALUES (@nom, @prenom, @adresse, @telephone, @age)", conn);
                    command.Parameters.AddWithValue("@nom", textBoxAjoutNomAd.Text);
                    command.Parameters.AddWithValue("@prenom", textBoxAjoutPrenomAd.Text);
                    command.Parameters.AddWithValue("@adresse", textBoxAjoutAdresseAd.Text);
                    command.Parameters.AddWithValue("@telephone", textBoxAjoutTelAd.Text);
                    command.Parameters.AddWithValue("@age", ageAd);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Nouvel adhérent ajouté !");

                    // Clear fields
                    textBoxAjoutNomAd.Text = "";
                    textBoxAjoutPrenomAd.Text = "";
                    textBoxAjoutAgeAd.Text = "";
                    textBoxAjoutTelAd.Text = "";
                    textBoxAjoutAdresseAd.Text = "";
                }
                else
                    MessageBox.Show("Erreur lors de la saisie du formulaire");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAnnulerAjoutAd_Click(object sender, EventArgs e)
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
        private string getId(string value)
        {
            string res = "";
            foreach (char element in value)
                if (Char.IsDigit(element) == true)
                    res += element;
            return res;
        }
        private void Ajout_Adherent_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControlGestionAdherents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAjoutNomAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
