using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Book_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            if ((textBoxNom.Text == "admin") && (textBoxMDP.Text == "1234"))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Identifiants invalides !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?",
                "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                Application.Exit();
  
        }


    }
}
