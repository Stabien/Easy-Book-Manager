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
        string RecuperationidDemprunt = null;
        DateTime today = DateTime.Today;
        int EnvoieDeLid = 0;
        DateTime dateRetourPrevuComp;
        
        public Regroupement_Emprunt()
        {
            InitializeComponent();
            Base();
            initializeComboBox();
        }
        private void Base()
        {
            try
            {
                NomAdherent.Text = "";
                AdresseAdherent.Text = "";
                PrenomAdherent.Text = "";
                TelephoneAdherent.Text = "";

                //Permet la connexion à la bdd

                string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
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
                    listeNom.Add(reader["id"] + " " + reader["Nom"] + " " + reader["Prenom"]);
                    //reader["id"]  reader["Nom"]
                }


                //Remplis la liste jour pas défault
                for (int i = 1; i < 32; i++)
                {
                    JourEmprunt.Items.Add(i);
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


        //--------------------Barre de recherche--------------------//
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {

            try { 
            //Stock dans une string ce qui est mis dans la barre de recherche

            string filtre = SearchBar.Text;

            //Nettoie la listeBox à chaque fois que la barre de recherche change

            listBoxAdherent.Items.Clear();
                //Fait le tour de la list
                foreach (string str in listeNom)
                {
                    //Endroit ou il faut commencer à chercher selon le mot
                    int reco = str.IndexOf(" ", 0, str.Length);
                    reco = reco + 1;

                    //Fait une vérification de la longueur de la recherche
                    if (filtre.Length <= str.Length)
                    {
                        string deb = str.Substring(reco, filtre.Length);
                        //Vérifie que les données de la list correspondent à la barre de recherche + met tout en minuscule
                        if (deb.ToLower() == filtre.ToLower())
                        {
                            //Si la barre de recherche correspond à un bon nom, l'affiche dans la Listbox
                            listBoxAdherent.Items.Add(str);
                        }
                    }
                }
               
            }
            catch (Exception)
            {
                
            }
            
            




        }
        //----------------------------------------------------------//

        //--------------------S'active dès qu'un élément est séléctionner dans la ListboxAdherent--------------------//
        private void listBoxAdherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remet tout les éléments au texte de base// 
            NomAdherent.Text = "";
            AdresseAdherent.Text = "";
            PrenomAdherent.Text = "";
            TelephoneAdherent.Text = "";           
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
                //Empeche l'utilisateur de ne cliquer sur aucun élément et de faire buger la page 
                if (Resultat.Length <= 0)
                {
                    NomAdherent.Text = "";
                    AdresseAdherent.Text = "";
                    PrenomAdherent.Text = "";
                    TelephoneAdherent.Text = "";
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
                                  //Permet de récupérer L'emprunt de l'utilisateur selectionner pour afficher plus tard les livres ET vérifie que l'on ne prenne un ancien emprunt
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

        //--------------------Initialise la combobox à la date d'aujourd'hui-----------------------------------------//
        private void initializeComboBox()
        {
            MoisEmprunt.SelectedIndex = this.today.Month - 1;
            JourEmprunt.SelectedItem = this.today.Day;
            AnneeEmprunt.SelectedItem = this.today.Year.ToString();
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
                    for (int i = 1; i < 29; i++)
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
                    for (int i = 1; i < 31; i++)
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
                    for (int i = 1; i < 31; i++)
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
                    for (int i = 1; i < 31; i++)
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
                    for (int i = 1; i < 31; i++)
                    {
                        JourEmprunt.Items.Add(i);
                    }
                    break;
                default:
                    //Permet d'enlever le texte de la combo box jour au cas ou l'utilisateur aurait rentrer le jour avant le mois
                    JourEmprunt.Text = "Jour";
                    //Nettoie la comboBox jour pour ne pas remplir avec des nombre déjà existant
                    JourEmprunt.Items.Clear();
                    //Remplis la combBox jour par defaut
                    for (int i = 1; i < 32; i++)
                    {
                        JourEmprunt.Items.Add(i);
                    }
                    break;
            }
        }
        //-------------------------------------------------------------------------------------------------------------//

        //--------------------Permet de "Rafraichir" la list des adherents--------------------//
        private void ButtonRefresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Nettoie tout la list pour tout afficher de nouveau
                listBoxAdherent.Items.Clear();
                listeNom.Clear();

                //Ouverture de la bdd

                dbConn.Open();
                //Création des requete SQL

                AdherentCommand = new SqlCommand
                  (
                        "Select Nom, id, Prenom from Adherents where Emprunt_en_cours = 1", dbConn
                  );

                //Demarre le Lecture des requete SQL

                reader = AdherentCommand.ExecuteReader();
                while (reader.Read())
                {
                    //Remplis la liste des adhérents

                    listBoxAdherent.Items.Add(reader["id"] + " " + reader["Nom"] + " " + reader["Prenom"]);
                    listeNom.Add(reader["id"] + " " + reader["Nom"] + " " + reader["Prenom"]);
                    //reader["id"]  reader["Nom"]
                }

                //Enleve les éléments dans la barre de recherche

                SearchBar.Text = null;

                //Vérifie si le reader est ouvert ou fermer puis le ferme²

                if (reader != null)
                    reader.Close();
                if (dbConn != null)
                    dbConn.Close();


                NomAdherent.Text = "";
                AdresseAdherent.Text = "";
                PrenomAdherent.Text = "";
                TelephoneAdherent.Text = "";
                labelDateRetourPrevue.Text = "00/00/0000";
                labelDateEmprunt.Text = "00/00/0000";
                labelDateRetourPrevue.ForeColor = System.Drawing.Color.Black;

                ListeLivreEmprunter.Items.Clear();

                initializeComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenu :" + ex.Message);
            }

        }


        //-------------------------------------------------------------------------------------//




    }
}
    
//² Si le reader n'est pas fermer il ne pourra pas remplir la deuxième liste


