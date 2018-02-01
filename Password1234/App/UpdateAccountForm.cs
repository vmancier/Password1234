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
    public partial class UpdateAccountForm : Form
    {
        public UpdateAccountForm(Account account)
        {
            InitializeComponent();
            this.Account = account;

            nameTB.Text = account.Name;
            urlTB.Text = account.URL;
            loginTB.Text = account.LoginA;
            pwdAccountTB.Text = account.PasswordA;
            Strength = account.Strength;
        }

        public string NameAccount
        {
            get { return nameTB.Text; }
            set { nameTB.Text = value; }
        }

        public string URL
        {
            get { return urlTB.Text; }
            set { urlTB.Text = value; }
        }

        public string Login
        {
            get { return loginTB.Text; }
            set { loginTB.Text = value; }
        }

        public string Password
        {
            get { return pwdAccountTB.Text; }
            set { pwdAccountTB.Text = value; }
        }

        public int Strength { get; set;  }

        public Account Account { get; set; }


        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            GeneratePasswordForm dlgGenerator = new GeneratePasswordForm();
            if (dlgGenerator.ShowDialog() == DialogResult.OK)
            {
                // L'utilisateur valide la génération du mot de passe avec les paramètres choisis
                int nbChar = dlgGenerator.GetNbChar();
                int nbNum = dlgGenerator.GetNbNum();
                int nbSym = dlgGenerator.GetNbSym();
                pwdAccountTB.Text = PasswordGenerator.Instance.GeneratePassword(nbChar, nbNum, nbSym);
            }
    }

        private void pwdAccountTB_TextChanged(object sender, EventArgs e)
        {
            Strength = PasswordGenerator.Instance.PasswordStrength(Password);
            if (Strength == 1)
            {
                this.lblPasswordStrength.Text = "FAIBLE";
                this.lblPasswordStrength.BackColor = System.Drawing.Color.Red;
            }
            else if (Strength == 2)
            {
                this.lblPasswordStrength.Text = "MOYEN";
                this.lblPasswordStrength.BackColor = System.Drawing.Color.DarkOrange;
            }
            else if (Strength == 3)
            {
                this.lblPasswordStrength.Text = "FORT";
                this.lblPasswordStrength.BackColor = System.Drawing.Color.Green;
            }
        }
    }
}
