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



        //VARIABLE TESTE

        DateTime dateRetourPrevuComp;
        string RecuperationidDemprunt = null;
        int EnvoieDeLid = 0;


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

                AdherentCommand = new SqlCommand
                  (
                        "Select Nom, id, Prenom from Adherents where Emprunt_en_cours = 1", dbConn
                   );

                //Vérifie si le reader est ouvert ou fermer puis le ferme²

                if (reader != null)
                    reader.Close();

                //Demarre le Lecture des requete SQL

                reader = AdherentCommand.ExecuteReader();
                while (reader.Read())
                {
                    //Remplis la liste des adhérents

                    listBoxAdherent.Items.Add(reader["id"] + " " + reader["Nom"] + " " + reader["Prenom"]);
                    listeNom.Add(reader["id"] + " " + reader["Nom"]);
                    //reader["id"]  reader["Nom"]
                }


                //Remplis la liste jour pas défault
                for (int i = 0; i < 32; i++)
                {
                    JourEmprunt.Items.Add(i);
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
        //----------------------------------------------------------//






        //--------------------S'active dès qu'un élément est séléctionner dans la ListboxAdherent--------------------//
        private void listBoxAdherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remet tout les éléments au texte de base// 
            IdAdherent.Text = "ID";
            NomAdherent.Text = "Nom Adhérent";
            AdresseAdherent.Text = "Adresse";
            PrenomAdherent.Text = "Prénom Adhérent";
            TelephoneAdherent.Text = "Telephone Adhérent";           
            labelDateRetourPrevue.ForeColor = System.Drawing.Color.Black;


            //Remet la listBox des livre emprunter par défault

            ListeLivreEmprunter.Items.Clear();


            try
            {
                //Permet de récuperer l'item séléctionner dans la ListboxAdhérent//

                ObjetSelectionner = listBoxAdherent.GetItemText(listBoxAdherent.SelectedItem);

                //Fait appel à la fonction isNumeric qui permet de récuperer l'id du nom selectionner//
                string Resultat = null;
                Resultat = isNumeric(ObjetSelectionner);
                IdAdherent.Text = Resultat;
                //Empeche l'utilisateur de ne cliquer sur aucun élément et de faire buger la page 
                if (Resultat.Length <= 0)
                {
                    IdAdherent.Text = "ID";
                    NomAdherent.Text = "Nom Adhérent";
                    AdresseAdherent.Text = "Adresse";
                    PrenomAdherent.Text = "Prénom Adhérent";
                    TelephoneAdherent.Text = "Telephone Adhérent";
                    labelDateRetourPrevue.ForeColor = System.Drawing.Color.Black;
                }
                else
                {


                    dbConn.Open();
                    RecuperationDonnees = new SqlCommand
                        (
                        //Récupère les info d'un utilisateur en fonction de l'id selectionner dans la ListBox Adherent
                        $"Select * from Adherents where id = {Resultat}", dbConn

                        );

                    InfoUtilisateur = RecuperationDonnees.ExecuteReader();
                    //Affiche le information de l'adhérent selectionner 
                    while (InfoUtilisateur.Read())
                    {
                        NomAdherent.Text = InfoUtilisateur["Nom"].ToString();
                        AdresseAdherent.Text = InfoUtilisateur["Adresse"].ToString();
                        PrenomAdherent.Text = InfoUtilisateur["Prenom"].ToString();
                        TelephoneAdherent.Text = InfoUtilisateur["Telephone"].ToString();
                    }
                    if (InfoUtilisateur != null)
                        InfoUtilisateur.Close();




                    //Permet d'afficher les livres emprunter par l'utilisateur dans la CheckBoxlist
                    Lecture = new SqlCommand
                     (
                         $"select * from Emprunt where ID_Adherents = {Resultat}", dbConn
                      );

                    //stock dans une variable dateRetourPrevuComp la date de retour prévue qui servira de comparaison dans une autre boucle
                    InfoUtilisateur = Lecture.ExecuteReader();
                    while (InfoUtilisateur.Read())
                    {
                        //GetDateTime est sur 2 pour dire que c'est la 3ème colonne de la bdd (écrire le nom de la colonne ne fonctionne pas)
                        dateRetourPrevuComp = InfoUtilisateur.GetDateTime(2);
                    }
                    InfoUtilisateur.Close();
                    //Permet de comparer la date d'aujourd'hui avec la date de retour prévue et de stocker tout dans un int, si int = -1 tout va bien sinon retour en retard
                    DateTime DateAujourdhui = DateTime.Today;
                    int comparaison = DateTime.Compare(DateAujourdhui, dateRetourPrevuComp);




                    InfoUtilisateur = Lecture.ExecuteReader();
                    while (InfoUtilisateur.Read())
                    {
                        //Remplis toute les autres info telle que la date de retour prévue + la date ou l'adhérent à emprunter ces livres
                        labelDateEmprunt.Text = InfoUtilisateur["Date_emprunt"].ToString();

                        //Vérifie si la date de retour n'est pas dépasser, si la date est dépasser elle s'affichera en rouge sinon normalement
                        if (comparaison == -1)
                        {
                            labelDateRetourPrevue.Text = InfoUtilisateur["Date_retour_prevu"].ToString();
                        }
                        else
                        {
                            labelDateRetourPrevue.Text = InfoUtilisateur["Date_retour_prevu"].ToString();
                            labelDateRetourPrevue.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (InfoUtilisateur != null)
                        InfoUtilisateur.Close();





                    Lecture = new SqlCommand
                             (
                                  //Permet de récupérer L'emprunt de l'utilisateur selectionner pour afficher plus tard les livres ET vérifie que l'on ne prenne un ancienne emprunt
                                  $"Select ID from Emprunt where Date_de_rendu IS NULL and ID_Adherents = {Resultat}", dbConn
                             );

                    InfoUtilisateur = Lecture.ExecuteReader();

                    while(InfoUtilisateur.Read())
                    {
                        RecuperationidDemprunt = InfoUtilisateur["Id"].ToString();
                    }

                    //Permet de récuperer l'ID dans la table emprunt // Int32 permet de convertir une string en int
                    EnvoieDeLid = Int32.Parse(RecuperationidDemprunt);

                    if (InfoUtilisateur != null)
                        InfoUtilisateur.Close();

                    EnvoieDeLid = Int32.Parse(RecuperationidDemprunt);


                    //Requete Sql qui permet de récupérer les livres emprunter par l'utilisateur selectionner
                    Lecture = new SqlCommand
                        (
                            $"select * from Livres where ID_Emprunt = {EnvoieDeLid}", dbConn
                        );

                    InfoUtilisateur = Lecture.ExecuteReader();

                    while (InfoUtilisateur.Read())
                    {
                        ListeLivreEmprunter.Items.Add(InfoUtilisateur["Titre"]);
                    }

                    if (InfoUtilisateur != null)
                        InfoUtilisateur.Close();
                    dbConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------------//






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
        //-----------------------------------------------------------------------------------------//






        //--------------------Change les jours de la ComboBox jour en fonction du mois selectionner--------------------//
        private void MoisEmprunt_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Permet de récuperer le mois séléctionner de la comboBox

            Mois = MoisEmprunt.GetItemText(MoisEmprunt.SelectedItem);
            //Remplis le nombre de jour dans la comboBox jour en fonction du mois
            switch (Mois)
            {

                case "Fevrier":
                    //Permet d'enlever le texte de la combo box jour au cas ou l'utilisateur aurait rentrer le jour avant le mois
                    JourEmprunt.Text = "Jour";
                    //Nettoie la comboBox jour pour ne pas remplir avec des nombre déjà existant
                    JourEmprunt.Items.Clear();
                    //Remplis la combBox jour en fonction du mois selectionner
                    for (int i = 0; i < 29; i++)
                    {
                        JourEmprunt.Items.Add(i);
                    }
                    break;
                case "Avril":
                    //Permet d'enlever le texte de la combo box jour au cas ou l'utilisateur aurait rentrer le jour avant le mois
                    JourEmprunt.Text = "Jour";
                    //Nettoie la comboBox jour pour ne pas remplir avec des nombre déjà existant
                    JourEmprunt.Items.Clear();
                    //Remplis la combBox jour en fonction du mois selectionner
                    for (int i = 0; i < 31; i++)
                    {
                        JourEmprunt.Items.Add(i);
                    }
                    break;
                case "Juin":
                    //Permet d'enlever le texte de la combo box jour au cas ou l'utilisateur aurait rentrer le jour avant le mois
                    JourEmprunt.Text = "Jour";
                    //Nettoie la comboBox jour pour ne pas remplir avec des nombre déjà existant
                    JourEmprunt.Items.Clear();
                    //Remplis la combBox jour en fonction du mois selectionner
                    for (int i = 0; i < 31; i++)
                    {
                        JourEmprunt.Items.Add(i);
                    }
                    break;
                case "Septembre":
                    //Permet d'enlever le texte de la combo box jour au cas ou l'utilisateur aurait rentrer le jour avant le mois
                    JourEmprunt.Text = "Jour";
                    //Nettoie la comboBox jour pour ne pas remplir avec des nombre déjà existant
                    JourEmprunt.Items.Clear();
                    //Remplis la combBox jour en fonction du mois selectionner
                    for (int i = 0; i < 31; i++)
                    {
                        JourEmprunt.Items.Add(i);
                    }
                    break;
                case "Novembre":
                    //Permet d'enlever le texte de la combo box jour au cas ou l'utilisateur aurait rentrer le jour avant le mois
                    JourEmprunt.Text = "Jour";
                    //Nettoie la comboBox jour pour ne pas remplir avec des nombre déjà existant
                    JourEmprunt.Items.Clear();
                    //Remplis la combBox jour en fonction du mois selectionner
                    for (int i = 0; i < 31; i++)
                    {
                        JourEmprunt.Items.Add(i);
                    }
                    break;

                default:
                    //Permet d'enlever le texte de la combo box jour au cas ou l'utilisateur aurait rentrer le jour avant le mois
                    JourEmprunt.Text = "Jour";
                    //Nettoie la comboBox jour pour ne pas remplir avec des nombre déjà existant
                    JourEmprunt.Items.Clear();
                    //Remplis la combBox jour en fonction du mois selectionner
                    for (int i = 0; i < 32; i++)
                    {
                        JourEmprunt.Items.Add(i);
                    }
                    break;



            }

        }


        //-------------------------------------------------------------------------------------------------------------//




        /* DateTime DateAujourdhui = DateTime.Today;
         int comparaison = DateTime.Compare(DateAujourdhui, )*/


    }
}
    
//² Si le reader n'est pas fermer il ne pourra pas remplir la deuxième liste




//Rajouter Date de rendu prévue
//Rajouter date ou le livre a été emprunter