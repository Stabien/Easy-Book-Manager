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
        public Regroupement_Emprunt()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            SqlConnection dbConn = null;
            SqlCommand Lecture = null;
            try
            {
                string connStr = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
                dbConn = new SqlConnection(connStr);
                dbConn.Open();
                Lecture = new SqlCommand
                    (
                        "Select Titre from Livres", dbConn
                    );

                reader = Lecture.ExecuteReader();
                MessageBox.Show("teste");
                while (reader.Read())
                {
                    listBoxAdherent.Items.Add(reader["Titre"]);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (dbConn != null)
                    dbConn.Close();
            }



            
        }
        

    }
}
