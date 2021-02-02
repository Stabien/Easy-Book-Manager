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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
           // Login dlg = new Login();
            // dlg.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)

        {

            string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";

            SqlConnection dbConn = new SqlConnection(connStr);

            string sqlStr = @"SELECT Titre FROM Livres";

            SqlCommand cmd = new SqlCommand(sqlStr, dbConn);

            dbConn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            listBoxLivres.BeginUpdate();

            listBoxLivres.Items.Clear();

            while (rdr.Read())

            {

                listBoxLivres.Items.Add(rdr.GetString(0));

            }

            rdr.Close();

            dbConn.Close();

            listBoxLivres.EndUpdate();

        }

        private void buttonEmprunts_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
