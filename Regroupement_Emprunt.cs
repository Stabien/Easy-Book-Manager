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

namespace Easy_Book_Manager
{

    public partial class Regroupement_Emprunt : Form
    {
        //Future lecture données
        SqlDataReader reader = null;
        //Future connexion
        SqlConnection dbConn = null;
        //Future Commande SQL
        SqlCommand Lecture = null;
        SqlCommand AdherentCommand = null;
        List<string> listeNom = new List<string>();


        public Regroupement_Emprunt()
        {
            InitializeComponent();
            Base();          



        }
        private void Base()
        {

            object[] Dynamique = { };
            
            try
            {
                //Permet la connexion à la bdd

                string connStr = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
                dbConn = new SqlConnection(connStr);

                //Ouverture de la bdd

                dbConn.Open();

                //Création des requete SQL

                Lecture = new SqlCommand
                    (
                        "Select Titre from Livres", dbConn
                    );
                AdherentCommand = new SqlCommand
                  (
                        "Select Nom from Adherents", dbConn
                   );
                //Demarre le Lecture des requete SQL

                reader = Lecture.ExecuteReader();

                //Boucle qui tourne tant qu'il reste des éléments dans la bdd

                while (reader.Read())
                {
                    //Remplis la liste des Livres

                    ListeLivre.Items.Add(reader["Titre"]);
                    
                }
                //Vérifie si le reader est ouvert ou fermer puis le ferme²

                if (reader != null)
                    reader.Close();

                //Demarre le Lecture des requete SQL

                reader = AdherentCommand.ExecuteReader();
                while (reader.Read())
                {
                    //Remplis la liste des adhérents

                    listBoxAdherent.Items.Add(reader["Nom"]);
                    listeNom.Add(reader["Nom"].ToString());
                }
            }
            //Récupere les erreurs
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            //Ferme la base de données + le reader
            finally
            {
                if (reader != null)
                    reader.Close();
                if (dbConn != null)
                    dbConn.Close();
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string filtre = SearchBar.Text;
            listBoxAdherent.Items.Clear();
            foreach (string str in listeNom)
            {
                if (filtre.Length <= str.Length)
                {
                    string deb = str.Substring(0, filtre.Length);
                    if (deb.ToLower() == filtre.ToLower())
                    {
                        listBoxAdherent.Items.Add(str);
                    }
                }
                
            }



        }












        /*
        private void ButtonRechercherAd_Click(object sender, EventArgs e)
        {
            SqlConnection dbConn = null;
            string connStr = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
            dbConn = new SqlConnection(connStr);
            SqlCommand Lecture = null;
            dbConn.Open();

                Lecture = new SqlCommand
                 (
                       $"Select Nom from Adherents where Nom like '{SearchBar.Text}%'", dbConn
                 );
            //Nettoie toute la liste pour ensuite afficher le résultat de la recherche 
            listBoxAdherent.Items.Clear();
            
        }*/
    }
 }
    
//² Si le reader n'est pas fermer il ne pourra pas remplir la deuxième liste

