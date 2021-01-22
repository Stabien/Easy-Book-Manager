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
            string connStr = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Gestion_Biblio;Integrated Security=True";
            SqlConnection dbConn = new SqlConnection(connStr);


        }
        

    }
}
