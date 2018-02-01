using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        public string NameAccount
        {
            get { return txtbxName.Text; }
            set { txtbxName.Text = value; }
        }

        public string Login
        {
            get { return txtbxLogin.Text; }
            set { txtbxLogin.Text = value; }
        }

        public string URL
        {
            get { return txtbxUrl.Text; }
            set { txtbxUrl.Text = value; }
        }

        public string Password
        {
            get { return txtbxPassword.Text; }
            set { txtbxPassword.Text = value; }
        }


        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            GeneratePasswordForm dlgGenerator = new GeneratePasswordForm();
            if (dlgGenerator.ShowDialog() == DialogResult.OK)
            {
                // L'utilisateur valide la génération du mot de passe avec les paramètres choisis
                int nbChar = dlgGenerator.GetNbChar();
                int nbNum = dlgGenerator.GetNbNum();
                int nbSym = dlgGenerator.GetNbSym();
                txtbxPassword.Text = PasswordGenerator.Instance.GeneratePassword(nbChar, nbNum, nbSym);
            }
        }

        private void txtbxPassword_TextChanged_1(object sender, EventArgs e)
        {
            int strength = PasswordGenerator.Instance.PasswordStrength(Password);
            if (strength == 1)
            {
                this.lblPasswordStrength.Text = "FAIBLE";
                this.lblPasswordStrength.BackColor = System.Drawing.Color.Red;
            }
            if (strength == 2)
            {
                this.lblPasswordStrength.Text = "MOYEN";
                this.lblPasswordStrength.BackColor = System.Drawing.Color.DarkOrange;
            }
            if (strength == 3)
            {
                this.lblPasswordStrength.Text = "FORT";
                this.lblPasswordStrength.BackColor = System.Drawing.Color.Green;
            }
        }
    }
}
