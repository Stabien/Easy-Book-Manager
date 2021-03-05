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
        SqlCommand GerrerAdherentCommand = null;
        SqlCommand LivresCommand = null;
        SqlCommand RecuperationDonnees = null;
        SqlCommand ChopperID = null;
        SqlCommand CreationEmprunt = null;
        SqlCommand UpdateAdherent = null;
        SqlCommand UpdateLivres = null;
        SqlDataAdapter adapter = new SqlDataAdapter();
        List<string> listeNom = new List<string>();
        List<string> listeLivres = new List<string>();
        List<string> listeAdherent = new List<string>();
        List<object> ListeTeste = new List<object>();
        List<string> ListeTesteNom = new List<string>();
        string ID_cree = null;
        string ObjetSelectionner;
        string ObjectSelect;
        string Mois;
        string RecuperationidDemprunt = null;
        string Resultat = null;
        string Answer = null;
        string Livres;
        string Adherents;
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
                   "Select Nom, id, Prenom from Adherents where Emprunt_en_cours is not null", dbConn
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





            //---------------try pour faire apparaitre les livres de la page emprunt --------- #Yann --------//
            try
            {
                dbConn.Open();

                //Creation requete SQL
                LivresCommand = new SqlCommand
                    (
                        "Select ID, Titre, Auteur, Emprunte from Livres", dbConn
                    );

                //Verifie si le reader est ouvert ou fermer puis le ferme

                if (reader != null)
                    reader.Close();
                //Demmare la lecture des requetes SQL

                reader = LivresCommand.ExecuteReader();
                while (reader.Read())
                {
                    //Remplis la listBoxLivres avec des livres

                    listBoxLivres.Items.Add(reader["ID"] + " " + reader["Titre"] + " " + reader["Auteur"]);
                    listeLivres.Add(reader["Titre"] + "  " + reader["Auteur"] + " " + reader["Emprunte"]);
                }
            }
            //Recupere les erreurs
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Ferme la base de donnees + le reader
            finally
            {
                if (reader != null)
                    reader.Close();
                if (dbConn != null)
                    dbConn.Close();
            }

            //------------try pour faire apparaitre les adherents dans la page emprunt --------- #Yann --------//
            try
            {
                dbConn.Open();

                GerrerAdherentCommand = new SqlCommand
                (
                    "Select Nom, id, Prenom from Adherents", dbConn
                );

                reader = GerrerAdherentCommand.ExecuteReader();
                while (reader.Read())
                {
                    //Remplis la listbox ListeAdherentGererEmprunt des adherents
                    ListeAdherentGererEmprunt.Items.Add(reader["id"] + " " + reader["Nom"] + " " + reader["Prenom"]);
                    listeAdherent.Add(reader["id"] + " " + reader["Nom"] + " " + reader["Prenom"]);
                }
            }
            //Recupere les erreurs
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Ferme la base de donnees + le reader
            finally
            {
                if (reader != null)
                    reader.Close();
                if (dbConn != null)
                    dbConn.Close();
            }
            //attraper la date d'aujourd'hui et date retour (= date auj + 30 jours) et affecter au label date
            try
            {
                
                DateTime dateTime = DateTime.Now;
                //afficher a d_emprunt la date d'auj sous format jour-mois-annee
                this.d_emprunt.Text = dateTime.ToString("dd-MM-yyyy");
                DateTime arendre = DateTime.Now;
                DateTime datelimite = arendre.AddDays(30);
                this.d_retour.Text = datelimite.ToString("dd-MM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Ferme la base de donnees + le reader
            finally
            {

            }
        }


        //--------------------Barre de recherche--------------------//
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {

            try
            {
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

                    while (InfoUtilisateur.Read())
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
                        "Select Nom, id, Prenom from Adherents where Emprunt_en_cours is not null", dbConn
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
        //-----------------------------------------------------------------------------------//


        //--------------------Lance les requetes SQL pour rendre des livres--------------------//
        private void BouttonEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                //Vérifie que tout les champs sont remplis
                if (checkBoxRendreLivre.Checked == true && JourEmprunt.SelectedItem != null && ListeLivreEmprunter.CheckedItems.Count != 0 && listBoxAdherent.SelectedItem != null)
                {
                    //Vérifie si l'utiliseateur a sélectionner tout les livres
                    if (ListeLivreEmprunter.CheckedItems.Count == ListeLivreEmprunter.Items.Count)
                    {
                        dbConn.Open();
                        //"Supprime" les livres emprunter
                        foreach (string Livre in ListeLivreEmprunter.CheckedItems)
                        {
                            string BonLivre = Livre.Replace("'", "''");
                            Lecture = new SqlCommand
                        (
                             $"UPDATE Livres SET Emprunte = 0 , ID_Emprunt = NULL WHERE Titre = '{BonLivre}'", dbConn
                         );
                            reader = Lecture.ExecuteReader();

                            reader.Read();

                            reader.Close();

                        }
                        //Retire l'emprunt de l'utilisateur
                        Lecture = new SqlCommand
                                                (
                                                    $"UPDATE Adherents SET Emprunt_en_cours = NULL WHERE ID = {Resultat}", dbConn
                                                 );
                        reader = Lecture.ExecuteReader();

                        reader.Read();

                        reader.Close();

                        //récupère la date de retour
                        DateTime DateFinal = DateComplete();


                        Lecture = new SqlCommand
                            (
                                $"UPDATE Emprunt SET Date_de_rendu = '{DateFinal}' WHERE ID_Adherents = {Resultat} and Date_de_rendu is null", dbConn
                             );

                        reader = Lecture.ExecuteReader();

                        reader.Read();

                        reader.Close();

                        dbConn.Close();


                        MessageBox.Show("Opération Validée");
                        Nettoyage();


                    }
                    else
                    {

                        dbConn.Open();

                        //"Supprime" les livres emprunter
                        foreach (string Livre in ListeLivreEmprunter.CheckedItems)
                        {
                            string BonLivre = Livre.Replace("'", "''");
                            Lecture = new SqlCommand
                        (
                             $"UPDATE Livres SET Emprunte = 0 , ID_Emprunt = NULL WHERE Titre = '{BonLivre}'", dbConn
                         );
                            reader = Lecture.ExecuteReader();

                            reader.Read();

                            reader.Close();

                        }
                        dbConn.Close();
                        MessageBox.Show("Opération Validée");
                        Nettoyage();
                    }

                }
                else
                {
                    MessageBox.Show("Merci de bien vouloir rentrer toute les informations");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //--------------------------------------------------------------------------------------//



        //------------------------Permet de récupérer la date de rendu------------------------//
        private DateTime DateComplete()
        {
            string Jour = JourEmprunt.SelectedItem.ToString();
            string Mois = (MoisEmprunt.SelectedIndex + 1).ToString();
            string Annee = AnneeEmprunt.SelectedItem.ToString();
            string datefinal = Jour + '-' + Mois + '-' + Annee;
            DateTime DateEnd = DateTime.Parse(datefinal);
            return DateEnd;
        }
        //------------------------------------------------------------------------------------//

        private void Nettoyage()
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
                        "Select Nom, id, Prenom from Adherents where Emprunt_en_cours is not null", dbConn
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
            if (dbConn != null)
                dbConn.Close();
        }


        //---------------SearchBarBook de la page Emprunt -------#Yann------//


        private void SearchBarAdherent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Stock dans une string ce qui est mis dans la barre de recherche

                string filtre = SearchBarAdherent.Text;

                //Nettoie la listeBox à chaque fois que la barre de recherche change

                ListeAdherentGererEmprunt.Items.Clear();
                //Fait le tour de la list
                foreach (string str in listeAdherent)
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
                            ListeAdherentGererEmprunt.Items.Add(str);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenu :" + ex.Message);
            }
        }

        private void SearchBarBook_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Stock dans une string ce qui est mis dans la barre de recherche

                string filtre = SearchBarBook.Text;

                //Nettoie la listeBox à chaque fois que la barre de recherche change

                listBoxLivres.Items.Clear();
                //Fait le tour de la list
                foreach (string str in listeLivres)
                {

                    //Fait une vérification de la longueur de la recherche
                    if (filtre.Length <= str.Length)
                    {
                        string deb = str.Substring(0, filtre.Length);
                        //Vérifie que les données de la list correspondent à la barre de recherche + met tout en minuscule
                        if (deb.ToLower() == filtre.ToLower())
                        {
                            //Si la barre de recherche correspond à un bon nom, l'affiche dans la Listbox
                            listBoxLivres.Items.Add(str);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenu :" + ex.Message);
            }
        }

        private void ListeAdherentGererEmprunt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On stock l'adherents selectionnee pour plus tard dans le bouton enregistrer
            Adherents = ListeAdherentGererEmprunt.SelectedItem.ToString();

            //Remet tout les éléments au texte de base// 
            nAdherent.Text = "";
            aAdherent.Text = "";
            pAdherent.Text = "";
            tAdherent.Text = "";


            //Remet la listBox des livre emprunter par défault

            Liste_Livre_Emprunt.Items.Clear();

            try
            {
                //Permet de récuperer l'item séléctionner dans la ListboxAdhérent//

                ObjectSelect = ListeAdherentGererEmprunt.GetItemText(ListeAdherentGererEmprunt.SelectedItem);

                //Fait appel à la fonction isNumeric qui permet de récuperer l'id du nom selectionner//
                Answer = isNumeric(ObjectSelect);
                //Empeche l'utilisateur de ne cliquer sur aucun élément et de faire buger la page 
                if (Answer.Length <= 0)
                {
                    nAdherent.Text = "";
                    aAdherent.Text = "";
                    pAdherent.Text = "";
                    tAdherent.Text = "";
                }
                else
                {
                    dbConn.Open();
                    RecuperationDonnees = new SqlCommand
                        (
                        //Récupère les info d'un utilisateur en fonction de l'id selectionner dans la ListBox Adherent
                        $"Select * from Adherents where id = {Answer}", dbConn

                        );

                    InfoUtilisateur = RecuperationDonnees.ExecuteReader();
                        //Affiche l'information de l'adhérent selectionner 
                        while (InfoUtilisateur.Read())
                        {
                            nAdherent.Text = InfoUtilisateur["Nom"].ToString();
                            aAdherent.Text = InfoUtilisateur["Adresse"].ToString();
                            pAdherent.Text = InfoUtilisateur["Prenom"].ToString();
                            tAdherent.Text = InfoUtilisateur["Telephone"].ToString();
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenu :" + ex.Message);
            }
            finally
            {
                //fermer la connection sinon on pourra pas reselectionner un autre adherents.
                dbConn.Close();
            }
        }


        private void listBoxLivres_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Stock le livre selectionnee dans la variable Livres pour l'appeler avec la fonction Ajouter dans l'autre Liste_Livre_Emprunt
            Livres = listBoxLivres.SelectedItem.ToString();

        }
        private void Ajouter_emprunt_Click(object sender, EventArgs e)
        {
            //rajout du livre selectionne dans Liste_Livre_Emprunt
            bool addtolist = true;
            if (Liste_Livre_Emprunt.Items.Count==0)
            {
                Liste_Livre_Emprunt.Items.Add(Livres);
            }
            else
            {
                for (int x=0; x<Liste_Livre_Emprunt.Items.Count; x++)
                {
                    if (Liste_Livre_Emprunt.Items[x].ToString() == Livres)
                    {
                        MessageBox.Show("Ce livre est déjà ajouté");
                        addtolist = false;
                    }
                }
                if (addtolist == true)
                {
                    Liste_Livre_Emprunt.Items.Add(Livres);
                }
            }
            
            

        }

        private void Supprimer_Emprunt_Click(object sender, EventArgs e)
        {
            //supprimer les Livres de Liste_Livre_Emprunt
            Liste_Livre_Emprunt.Items.Remove(Liste_Livre_Emprunt.SelectedItem);

        }

        //---------------------------------------Boutton Enregistrer de la Page Emprunt ---------------------------#Yann----------//
        private void BouttonEnregistrerAjoutEmprunt_Click(object sender, EventArgs e)
        {
            //3 if pour 3 situations differentes. Livresbox vide? Adherents pas selectionnee? --> msg erreur sinon lance try{
            if (Liste_Livre_Emprunt.Items.Count == 0) 
            {
                MessageBox.Show("Selectionner les livres");
            }
            if (ListeAdherentGererEmprunt.SelectedIndex == -1)
            {
                MessageBox.Show("Selectionner l'adherent");
            }
            if (Liste_Livre_Emprunt.Items.Count != 0 && ListeAdherentGererEmprunt.SelectedIndex != -1)
            {
                try
                {
                    /* Tout existe sauf emprunt, du coup on cree emprunt d'abord puis on update les autres tables. 
                     * On va d'abord cree tout les variables necessaires pous stocker nos donnes */
                    //stock l'element selectionne de ListeAdherentGererEmprunt et la mettre dans le string
                    string container = ListeAdherentGererEmprunt.GetItemText(ListeAdherentGererEmprunt.SelectedItem);
                    //prendre l'ID de la string de l'adherents
                    string IDadherent = isNumeric(container);
                    int ID_adherent = Int32.Parse(IDadherent);
                    //catch la date d'aujourd'hui
                    DateTime DAuj = DateTime.Today;
                    //rajoute 1 mois a la date de retour
                    DateTime DRet = DAuj.AddMonths(1);


                    dbConn.Open();
                    //prepare requete sql dans une string pour cree l'emprunt qui n'existe pas
                    string sql_emprunt = $"Insert into emprunt (Date_emprunt, Date_retour_prevu, ID_Adherents, ID_Employes) Values('{DAuj}', '{DRet}', {ID_adherent}, 1) ";
                    //Command SQL "CreationEmprunt" execute le string precedant contre la database, on passe la connection dbConn aussi
                    CreationEmprunt = new SqlCommand(sql_emprunt, dbConn);
                    //association de la commande Insert SQL a notre adapter
                    adapter.InsertCommand = new SqlCommand(sql_emprunt, dbConn);
                    //Methode ExecuteNonQuery necessaire pour realiser insert,delete,update vers la database
                    adapter.InsertCommand.ExecuteNonQuery();       
                    //fermeture de connection avec la database pour faire future requete
                    CreationEmprunt.Dispose();


                    /*update des donnes de la table Livre et Adherents, pour cela, on doit chopper l'ID generee de l'emprunt. */
                    //chopper ID 
                    //prepare requete sql dans une string pour chopper le tout dernier ID emprunt qui a etait cree par la requete precedente.
                    string sql_choppeID = "SELECT IDENT_CURRENT ('Emprunt') AS Current_Identity;  ";
                    //commande Sql qui execute la requete contre la base de donnee
                    ChopperID = new SqlCommand(sql_choppeID, dbConn);   
                    /*data reader qui fetche les infos, plus precisement les lignes de la table/requete appele, 
                     *dans notre cas, notre requete SQL retourne une seule ligne et colonne qui correspond a l'ID 
                     *de l'emprunt cree */
                    reader = ChopperID.ExecuteReader();
                    //boucle pour lire toute les lignes meme si dans notre cas il y a qu'une seule ligne
                    while (reader.Read())
                    {
                        //Stocker ID de l'emprunt qui se trouve dans le 0eme colonne dans une variable pendant la lecture 
                        ID_cree = ID_cree + reader.GetValue(0);
                    }
                    //ferme le reader pour pouvoir realiser future requete
                    reader.Close();
                    //ID de l'emprunt
                    int ID_emprunt = Int32.Parse(ID_cree);

                    
                    /*update info de l'adherent colonne emprunt_en_cour */
                    string sql_adherent = $"UPDATE Adherents SET Emprunt_en_cours = {ID_emprunt} WHERE ID = {ID_adherent}";
                    //Command SQL "UpdateAdherent" execute le string precedant contre la database, on passe la connection dbConn aussi
                    UpdateAdherent = new SqlCommand(sql_adherent, dbConn);
                    ////association de la commande Update SQL a notre adapter
                    adapter.UpdateCommand = new SqlCommand(sql_adherent, dbConn);
                    ////Methode ExecuteNonQuery necessaire pour realiser insert,delete,update vers la database
                    adapter.UpdateCommand.ExecuteNonQuery();
                    //fermeture de la co pour future requete
                    UpdateAdherent.Dispose();


                    /*update info des livres qui ont ete empruntee par l'adherent */
                    //boucle pour parcourir tout les livres dans la listbox de livre ajoutee.
                    //Fonction qui parcour les string Livres et choppe juste le premier nombre qui correspond a l'ID du livre
                    foreach (string Livre in Liste_Livre_Emprunt.Items)
                    {
                        //Fonction qui parcour les string Livres et attrape le premier nombre pour le stocker comme ID du livre.
                        string ID_livre = null;
                        int val;
                        for (int i = 0; i < Livre.Length; i++)
                        {
                            if (Char.IsDigit(Livre[i]))
                                ID_livre += Livre[i];
                            else if (ID_livre.Length != 0)
                                break;
                        }
                        if (ID_livre.Length > 0)
                            val = int.Parse(ID_livre);

                        /*update info des livres dont l'ID on a chopper 
                         * dans la fonction precedente ID_livre pour trouver nos bouquin qu'on va emprunter.
                         * update dans les colonnes Emprunt et ID_Emprunt qui va correspondre a l'ID de l'emprunt */
                        string sql_livres = $"UPDATE Livres SET Emprunte = 1 , ID_Emprunt = {ID_emprunt} WHERE ID = {ID_livre}";
                        UpdateLivres = new SqlCommand(sql_livres, dbConn);

                        adapter.UpdateCommand = new SqlCommand(sql_livres, dbConn);
                        adapter.UpdateCommand.ExecuteNonQuery();

                        UpdateLivres.Dispose();

                    }
                    MessageBox.Show("Emprunt termine!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenu :" + ex.Message);
                }
                finally
                {
                    dbConn.Close();
                }
                
            }
            
        }

       
    }
}
    
//² Si le reader n'est pas fermer il ne pourra pas remplir la deuxième liste


