using DAL;
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
    public partial class SignInForm : Form
    {
        private IWifiRepository wifiRepository;
        private IUserRepository userRepository;
        private IAccountRepository accountRepository;

        public SignInForm(IWifiRepository wifiRepository, IUserRepository userRepository, IAccountRepository accountRepository)
        {
            InitializeComponent();

            this.wifiRepository = wifiRepository;
            this.userRepository = userRepository;
            this.accountRepository = accountRepository;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string login = txtbxLogin.Text;
            string password = txtbxPassword.Text;

            User user = userRepository.Connection(login, password);

            ConnectionUser(user);
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm dlgSignUp = new SignUpForm();
            if (dlgSignUp.ShowDialog() == DialogResult.OK)
            {
                // L'inscription est validée
                string login = dlgSignUp.GetLogin();
                string password = dlgSignUp.GetPassword();
                User user = new User(login, password);

                // Sauvegarde du nouvel utilisateur
                userRepository.Save(user);

                ConnectionUser(user);
            }
        }

        /// <summary>
        /// Connecte l'utilisateur à l'application
        /// </summary>
        /// <param name="user">l'utilisateur</param>
        private void ConnectionUser(User user)
        {
            if (user != null)
            {
                MainForm mainForm = new MainForm(wifiRepository, userRepository, accountRepository, user);
                mainForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Identifiant ou Mot de passe incorrect !", "Impossible de se connecter", MessageBoxButtons.OK);
            }
        }
    }
}
