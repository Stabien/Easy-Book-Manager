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
using System.Text.RegularExpressions;

namespace Easy_Book_Manager
{
    public partial class Main : Form
    {

        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
        List<string> registrationsList = new List<string>();
        

        public Main()
        {
            InitializeComponent();
            

        }

        private void Main_Load(object sender, EventArgs e)
        {

            Login dlg = new Login();
            dlg.ShowDialog();
            registrationsList=loadlistlivre();
            SqlConnection dbConn = new SqlConnection(connStr);
            string sql1 = "select ID, Categorie from Categories";
            dbConn.Open();
            SqlCommand command1;
            SqlDataReader data1;
            command1 = new SqlCommand(sql1, dbConn);
            data1 = command1.ExecuteReader();
            while (data1.Read())
            {
                comboBoxGenreAjouter.Items.Add(data1.GetValue(0)+"-"+data1.GetValue(1));
            }
            dbConn.Close();
        }

        private string SqlValidString(string s)
        {
            string sbis = "";
            foreach(var c in s)
            {
                if (c.ToString() == "'")
                {
                    sbis = sbis + "''";
                }
                else
                {
                    sbis=sbis+c.ToString();
                }
            }
            return sbis;
        }

        private string RecupID(string s)
        {
            string sbis = "";
            foreach (var c in s)
            {
                if (c.ToString() == "-")
                {
                    return sbis;
                }
                else
                {
                    sbis = sbis + c;
                }
            }
                return sbis;
        }

        private List<string> loadlistlivre()
        {
            SqlConnection dbConn = new SqlConnection(connStr);
            dbConn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql= "SELECT Titre, Auteur FROM Livres";
            command = new SqlCommand(sql, dbConn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                listBoxLivres.Items.Add(dataReader.GetValue(0) + " - " + dataReader.GetValue(1));
            }
            dbConn.Close();
            listBoxLivres.BeginUpdate();
            
            listBoxLivres.EndUpdate();
            List<string> listlivres = new List<string>();
            foreach (object item in listBoxLivres.Items)
            {
                listlivres.Add(item.ToString());
            }

            return listlivres;
        }

        private void listBoxLivres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (labelAjouterPanel.Text=="Modifier un livre")
            {
                SqlConnection dbConn = new SqlConnection(connStr);
                dbConn.Open();
                SqlCommand command;
                SqlDataReader data;
                string sql= "SELECT Titre, Auteur, Categories.ID, Categories.Categorie, Edition FROM Livres inner join Categories on Livres.Categorie=Categories.ID where Titre='" + SqlValidString(listBoxLivres.SelectedItem.ToString()) + "'";
                command = new SqlCommand(sql, dbConn);
                data = command.ExecuteReader();
                while (data.Read())
                {
                    textBoxTitreAjouter.Text = data.GetValue(0).ToString();
                    textBoxAuteurAjouter.Text = data.GetValue(1).ToString();
                    comboBoxGenreAjouter.SelectedItem = data.GetValue(2).ToString()+"-"+ data.GetValue(3).ToString();
                    textBoxEditionAjouter.Text = data.GetValue(4).ToString();

                }
            }
            
            
        }


        private void buttonModifier_Click(object sender, EventArgs e)
        {
            labelAjouterPanel.Text = "Modifier un livre";
            
        }

        private void buttonEnregisterAjouter_Click(object sender, EventArgs e)
        {
            if (labelAjouterPanel.Text == "Modifier un livre")
            {
                SqlConnection dbConn = new SqlConnection(connStr);
                SqlCommand command = new SqlCommand("update Livres set Titre = @Titre, Auteur = @Auteur, Categorie = @Genre, Edition = @Edition where Titre ="+SqlValidString(listBoxLivres.SelectedItem.ToString()), dbConn);
                command.Parameters.AddWithValue("@Titre", SqlValidString(textBoxTitreAjouter.Text));
                command.Parameters.AddWithValue("@Auteur", textBoxAuteurAjouter.Text);
                command.Parameters.AddWithValue("@Genre", RecupID(comboBoxGenreAjouter.SelectedItem.ToString()));
                command.Parameters.AddWithValue("@Edition", textBoxEditionAjouter.Text);
                dbConn.Open();
                command.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Livre modifié avec succès");
                textBoxTitreAjouter.Text = "";
                textBoxAuteurAjouter.Text = "";
                textBoxEditionAjouter.Text = "";
                comboBoxGenreAjouter.SelectedItem = null;
                loadlistlivre();
                
            }
            else
            {
                
                SqlConnection dbConn = new SqlConnection(connStr);
                SqlCommand command = new SqlCommand("INSERT INTO Livres (Titre, Auteur, Categorie, Edition, Emprunte) VALUES (@Titre, @Auteur, @Genre, @Edition,0)", dbConn);
                command.Parameters.AddWithValue("@Titre", SqlValidString(textBoxTitreAjouter.Text));
                command.Parameters.AddWithValue("@Auteur", textBoxAuteurAjouter.Text);
                command.Parameters.AddWithValue("@Genre", RecupID(comboBoxGenreAjouter.SelectedItem.ToString()));
                command.Parameters.AddWithValue("@Edition", textBoxEditionAjouter.Text);
                dbConn.Open();
                command.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Livre enregistré");
                textBoxTitreAjouter.Text = "";
                textBoxAuteurAjouter.Text = "";
                textBoxEditionAjouter.Text = "";
                comboBoxGenreAjouter.SelectedItem = null;
                loadlistlivre();
                
            }
        }


        
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            labelAjouterPanel.Text = "Ajouter un livre";
            textBoxTitreAjouter.Text = "";
            textBoxAuteurAjouter.Text = "";
            comboBoxGenreAjouter.SelectedItem = null;
            textBoxEditionAjouter.Text = "";
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listBoxLivres.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un livre");
            }
            else
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce livre?", listBoxLivres.SelectedItem.ToString(), MessageBoxButtons.YesNo);

                if (result.ToString() == "Yes")
                {
                    SqlConnection dbConn = new SqlConnection(connStr);
                    SqlCommand command = new SqlCommand("delete from Livres where Titre='" + SqlValidString(listBoxLivres.SelectedItem.ToString()) + "'", dbConn);
                    dbConn.Open();
                    command.ExecuteNonQuery();
                    dbConn.Close();
                    MessageBox.Show("Livre supprimé avec succès");
                    loadlistlivre();
                }
            }
            
            
        }
        

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            

            listBoxLivres.BeginUpdate();
            listBoxLivres.Items.Clear();

            if (!string.IsNullOrEmpty(textBoxRecherche.Text))
            {
                foreach (string str in registrationsList)
                {
                    if (str.ToLower().Contains(textBoxRecherche.Text.ToLower()))
                    {
                        listBoxLivres.Items.Add(str);
                    }
                }
            }
            else
            {
                foreach (string item in registrationsList)
                {
                    listBoxLivres.Items.Add(item); //there is no any filter string, so add all data we have in Store
                }
            }
                
                

            listBoxLivres.EndUpdate();
        }

        private void textBoxRecherche_Click(object sender, EventArgs e)
        {
            textBoxRecherche.Text = "";
        }

        private void buttonEmprunts_Click(object sender, EventArgs e)
        {
            Regroupement_Emprunt dlg = new Regroupement_Emprunt();
            dlg.ShowDialog();
        }

        private void buttonAdherents_Click(object sender, EventArgs e)
        {
            Gestion_Adherent dlg = new Gestion_Adherent();
            dlg.ShowDialog();
        }
    }
}
