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
using System.Text.RegularExpressions;

namespace Easy_Book_Manager
{
    public partial class Gestion_Adherent : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
        List<string> allAdherents = new List<string>();
        int currentIdAdherent = -1;

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
            if (listBoxAdherent.SelectedItem != null)
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
            
        }

        private void buttonValiderModifAd_Click(object sender, EventArgs e)
        {
            if (this.currentIdAdherent != -1)
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
                        this.currentIdAdherent = -1;

                        // Clear fields
                        textBoxModifNomAd.Text = "";
                        textBoxModifPrenomAd.Text = "";
                        textBoxModifAgeAd.Text = "";
                        textBoxModifTelAd.Text = "";
                        textBoxModifAdresseAd.Text = "";
                    }
                    else
                        MessageBox.Show("Erreur lors de la saisie du formulaire");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un adhérent");
            }
        }

        private void buttonValiderAjoutAd_Click(object sender, EventArgs e)
        {
            try
            {
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

                    // Refresh page
                    this.textBoxSearchAdherent.Text = "";
                    this.currentIdAdherent = -1;
                    this.listBoxDisplayAdherents();
                }
                else
                    MessageBox.Show("Erreur lors de la saisie du formulaire");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteAdherent_Click(object senser, EventArgs e)
        {
            if (listBoxAdherent.SelectedItem != null)
            {
                if (this.currentIdAdherent != -1)
                {   // Get first name and last name without id
                    string nameAdherent = Regex.Replace(listBoxAdherent.SelectedItem.ToString(), @"\d", "");
                    // Ask user before deleting adherent
                    DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer" + nameAdherent + " de la base de données ?",
                    "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            // Open db
                            SqlConnection conn = new SqlConnection(connString);
                            conn.Open();
                            // Prepare request
                            SqlCommand deleteAdherent = new SqlCommand("DELETE adherents WHERE id= " + this.currentIdAdherent, conn);
                            // Execute request
                            SqlDataReader reader = deleteAdherent.ExecuteReader();

                            // Refresh page
                            this.listBoxDisplayAdherents();
                            this.textBoxSearchAdherent.Text = "";
                            this.currentIdAdherent = -1;

                            // Clear fields
                            textBoxModifNomAd.Text = "";
                            textBoxModifPrenomAd.Text = "";
                            textBoxModifAgeAd.Text = "";
                            textBoxModifTelAd.Text = "";
                            textBoxModifAdresseAd.Text = "";
                        }
                        catch
                        {
                            MessageBox.Show("Cet adhérent ne peut pas être supprimé car il a un emprunt en cours");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un adhérent");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un adhérent");
            }
        }

        private void CloseGestionAdherent_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Gestion_Adherent_Load(object sender, EventArgs e)
        {

        }
    }
}
