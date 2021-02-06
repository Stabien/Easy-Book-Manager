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
        SqlDataReader InfoUtilisateur = null;
        //Future connexion
        SqlConnection dbConn = null;
        //Future Commande SQL
        SqlCommand Lecture = null;
        SqlCommand AdherentCommand = null;
        SqlCommand RecuperationDonnees = null;
        List<string> listeNom = new List<string>();
        List<object> ListeTeste = new List<object>();
        List<string> ListeTesteNom = new List<string>();
        string ObjetSelectionner;
        string Mois;
        public Regroupement_Emprunt()
        {
            InitializeComponent();
            Base();



        }
        private void Base()
        {

            
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
                        "Select Nom, id from Adherents", dbConn
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

                    listBoxAdherent.Items.Add(reader["Nom"] + " " + reader["id"]);
                    listeNom.Add(reader["Nom"] + " " + reader["id"]);
                    //reader["id"]  reader["Nom"]
                }

                
                
                
                
               /* if (MoisEmprunt.Items.ToString() == "Fevrier")
                {

                }*/

            }//JourEmprunt
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


        //--------------------Barre de recherche--------------------//
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            //Stock dans une string ce qui est mis dans la barre de recherche

            string filtre = SearchBar.Text;

            //Nettoie la listeBox à chaque fois que la barre de recherche change

            listBoxAdherent.Items.Clear();

            //Fait le tour de la list

            foreach (string str in listeNom)
            {
                //Fait une vérification de la longueur de la recherche

                if (filtre.Length <= str.Length)
                {
                    string deb = str.Substring(0, filtre.Length);

                    //Vérifie que les données de la list correspondent à la barre de recherche + met tout en minuscule

                    if (deb.ToLower() == filtre.ToLower())
                    {
                        //Si la barre de recherche correspond à un bon nom, l'affiche dans la Listbox

                        listBoxAdherent.Items.Add(str);
                    }
                }
            }


        }

        //--------------------S'active dès qu'un élément est séléctionner dans la ListboxAdherent--------------------//
        private void listBoxAdherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remet tout les éléments au texte de base// 
            IdAdherent.Text = "ID";
            NomAdherent.Text = "Nom Adhérent";
            AdresseAdherent.Text = "Adresse";
            PrenomAdherent.Text = "Prénom Adhérent";
            TelephoneAdherent.Text = "Telephone Adhérent";


            try
            {
                //Permet de récuperer l'item séléctionner dans la ListboxAdhérent//

                ObjetSelectionner = listBoxAdherent.GetItemText(listBoxAdherent.SelectedItem);

                //Fait appel à la fonction isNumeric qui permet de récuperer l'id du nom selectionner//

                string Resultat = isNumeric(ObjetSelectionner);

                IdAdherent.Text = Resultat;
                dbConn.Open();
                RecuperationDonnees = new SqlCommand
                    (
                    $"Select * from Adherents where id = {Resultat}", dbConn

                    );

                InfoUtilisateur = RecuperationDonnees.ExecuteReader();
                while (InfoUtilisateur.Read())
                {
                    NomAdherent.Text = InfoUtilisateur["Nom"].ToString();
                    AdresseAdherent.Text = InfoUtilisateur["Adresse"].ToString();
                    PrenomAdherent.Text = InfoUtilisateur["Prenom"].ToString();
                    TelephoneAdherent.Text = InfoUtilisateur["Telephone"].ToString();
                }
                InfoUtilisateur.Close();

                dbConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
        //--------------------Permet de récuperer l'id dans le nom des adhérents--------------------//
        private string isNumeric(string value)
        {
            string res = "";
            foreach (char element in value)
            {
                if (Char.IsDigit(element) == true)
                {
                    res += element;
                }
            }
            return res;
        }

        private void MoisEmprunt_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Permet de récuperer le mois séléctionner de la comboBox
            Mois = MoisEmprunt.GetItemText(MoisEmprunt.SelectedItem);

            List<int> FevrierJour = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                FevrierJour[i] = i;
            }
            
            switch (Mois)
            {
                case "Fevrier":
                    ;
                    break;
                default:
                    MessageBox.Show("Aucun séléctionner");
                    break;



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

