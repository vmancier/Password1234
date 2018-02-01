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
    public partial class MainForm : Form
    {
        private IWifiRepository wifiRepository;
        private IUserRepository userRepository;
        private IAccountRepository accountRepository;
        private User user;
        private Account selectedAccount;
        private Wifi selectedWifi; 

        public MainForm(IWifiRepository wifiRepository, IUserRepository userRepository, IAccountRepository accountRepository, User user)
        {
            InitializeComponent();

            this.wifiRepository = wifiRepository;
            this.userRepository = userRepository;
            this.accountRepository = accountRepository;
            this.user = user;

            RefreshAccountListBox();
            RefreshWifiListbox();

        }

        /// <summary>
        /// Actualise les informations des champs de texte 
        /// avec les données du compte sélectionné
        /// </summary
        public void RefreshAccountTextBox()
        {
            if(selectedAccount != null)
            {
                nameTB.Text = selectedAccount.Name;
                urlTB.Text = selectedAccount.URL;
                loginTB.Text = selectedAccount.LoginA;
                pwdAccountTB.Text = selectedAccount.PasswordA;
            }
            else
            {
                nameTB.Text = "";
                urlTB.Text = "";
                loginTB.Text = "";
                pwdAccountTB.Text = "";
            }
        }

        /// <summary>
        /// Actualise l'affichage des listes de comptes
        /// </summary
        public void RefreshAccountListBox()
        {
            oldPwdLB.DataSource = null;
            oldPwdLB.DataSource = accountRepository.GetAllOldPwdFromUser(user);
            oldPwdLB.ClearSelected();

            weakPwdLB.DataSource = null;
            weakPwdLB.DataSource = accountRepository.GetAllWeakPwdFromUser(user);
            weakPwdLB.ClearSelected();

            pwdLB.DataSource = null;
            pwdLB.DataSource = accountRepository.GetAllPwdFromUser(user);


            // Sélectionne le 1er compte
            if (pwdLB.SelectedIndex == -1 && weakPwdLB.Items.Count != 0)
            {
                weakPwdLB.SelectedIndex = 0;
            }
            else if(weakPwdLB.SelectedIndex ==-1 && oldPwdLB.Items.Count != 0 && pwdLB.Items.Count == 0)
            {
                oldPwdLB.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Supprime le compte sélectionné
        /// </summary
        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce compte ?", "Suppression Compte",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                accountRepository.Delete(selectedAccount);
                selectedAccount = null;
                RefreshAccountListBox();
                RefreshAccountTextBox();
            }
         }

        private void pwdLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pwdLB.SelectedItem != null)
            {
                selectedAccount = (Account)pwdLB.SelectedItem;
                weakPwdLB.SelectedIndex = -1;
                oldPwdLB.SelectedIndex = -1;
                RefreshAccountTextBox();
            }
        }

        private void weakPwdLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weakPwdLB.SelectedItem != null)
            {
                selectedAccount = (Account)weakPwdLB.SelectedItem;
                pwdLB.SelectedIndex = -1;
                oldPwdLB.SelectedIndex = -1;
                RefreshAccountTextBox();
            }
        }

        private void oldPwdLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oldPwdLB.SelectedItem != null)
            {
                selectedAccount = (Account)oldPwdLB.SelectedItem;
                pwdLB.SelectedIndex = -1;
                weakPwdLB.SelectedIndex = -1;
                RefreshAccountTextBox();
            }
        }

        private void wifiLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wifiLB.SelectedItem != null)
            {
                selectedWifi = (Wifi)wifiLB.SelectedItem;
                ssidTB.Text = selectedWifi.Ssid;
                pwdWifiTB.Text = selectedWifi.PasswordW;
            }
        }

        /// <summary>
        /// Actualise l'affichage de la liste des points d'accès wifi
        /// </summary
        private void RefreshWifiListbox()
        {
            wifiLB.DataSource = null;
            wifiLB.DataSource = wifiRepository.GetAllFromUser(user);
        }

        /// <summary>
        /// Supprime le point d'accès wifi sélectionné
        /// </summary
        private void deleteWifiBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce point wifi ?", "Suppression Wifi",
MessageBoxButtons.YesNo, MessageBoxIcon.Question)
== DialogResult.Yes)
            {
                wifiRepository.Delete(selectedWifi);
                RefreshWifiListbox();
                ssidTB.Text = selectedWifi.Ssid;
                pwdWifiTB.Text = selectedWifi.PasswordW;
            }
        }

        /// <summary>
        /// Modifie les informations du compte sélectionné
        /// </summary>
        private void updateAccountBtn_Click(object sender, EventArgs e)
        {
            UpdateAccountForm updateAccountForm = new UpdateAccountForm(selectedAccount);
            if (updateAccountForm.ShowDialog() == DialogResult.OK)
            {
                // Récupère les informations du form
                Account account = updateAccountForm.Account;
                account.Name = updateAccountForm.NameAccount;
                account.URL = updateAccountForm.URL;
                account.LoginA = updateAccountForm.Login;
                account.PasswordA = updateAccountForm.Password;
                account.Update = DateTime.Now;
                account.Strength = updateAccountForm.Strength;

                // Sauvegarde les changements du compte
                accountRepository.Save(account);

                // Actualise l'affichage
                RefreshAccountListBox();
                RefreshAccountTextBox();
            }
        }

        /// <summary>
        /// Modifie les informations du point d'accès wifi sélectionné
        /// </summary>
        private void updateWifiBtn_Click(object sender, EventArgs e)
        {
            UpdateWifiForm updateWifiForm = new UpdateWifiForm(selectedWifi);
            if (updateWifiForm.ShowDialog() == DialogResult.OK)
            {
                // Récupère les informations du form
                Wifi wifi = updateWifiForm.Wifi;
                wifi.Ssid = updateWifiForm.Ssid;
                wifi.PasswordW = updateWifiForm.Password;

                // Sauvegarde les changements du point d'accès
                wifiRepository.Save(wifi);

                // Actualise l'affichage
                RefreshWifiListbox();
                ssidTB.Text = selectedWifi.Ssid;
                pwdWifiTB.Text = selectedWifi.PasswordW;
            }
        }

        /// <summary>
        /// Ajoute un compte pour l'utilisateur connecté
        /// </summary>
        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccountForm = new AddAccountForm();
            if (addAccountForm.ShowDialog() == DialogResult.OK)
            {
                if (addAccountForm.NameAccount!="")
                {
                    // Récupère les informations du form
                    Account account = new Account();
                    account.Name = addAccountForm.NameAccount;
                    account.URL = addAccountForm.URL;
                    account.LoginA = addAccountForm.Login;
                    account.PasswordA = addAccountForm.Password;
                    account.MyUser = user;
                    account.Strength = PasswordGenerator.Instance.PasswordStrength(account.PasswordA);
                    account.Update = DateTime.Now;

                    // Crée un nouveau compte
                    accountRepository.Save(account);

                    // Actualise l'affichage
                    RefreshAccountListBox();
                    RefreshAccountTextBox();
                }
                else
                {
                    MessageBox.Show("Le compte n'a pas pu être ajouté car le nom est vide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddWifiBtn_Click(object sender, EventArgs e)
        {
            AddWifiForm addWifiForm = new AddWifiForm();
            if (addWifiForm.ShowDialog() == DialogResult.OK)
            {
                if (addWifiForm.SsidWifi != "")
                {
                    // Récupère les informations du form
                    Wifi wifi = new Wifi();
                    wifi.Ssid = addWifiForm.SsidWifi;
                    wifi.PasswordW = addWifiForm.Password;
                    wifi.MyUser = user;

                    // Crée un nouveau point d'accès wifi
                    wifiRepository.Save(wifi);

                    // Actualise l'affichage
                    RefreshWifiListbox();
                    ssidTB.Text = selectedWifi.Ssid;
                    pwdWifiTB.Text = selectedWifi.PasswordW;
                }
                else
                {
                    MessageBox.Show("Le point d'accès Wifi n'a pas pu être ajouté car le SSID est vide !", "Attention", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir vous déconnecter ?", "Deconnexion",
MessageBoxButtons.YesNo, MessageBoxIcon.Question)
== DialogResult.Yes)
            {
                this.Close();
                SignInForm dlgSignIn = new SignInForm(wifiRepository, userRepository, accountRepository);
                dlgSignIn.Show();
            }
        }
    }
}
