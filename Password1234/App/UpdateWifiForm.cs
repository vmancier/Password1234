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
    public partial class UpdateWifiForm : Form
    {
        
        public UpdateWifiForm(Wifi wifi)
        {
            InitializeComponent();

            ssidTB.Text = wifi.Ssid;
            pwdWifiTB.Text = wifi.PasswordW;

            Wifi = wifi;
        }

        public string Ssid
        {
            get { return ssidTB.Text; }
            set { ssidTB.Text = value; }
        }

        public string Password
        {
            get { return pwdWifiTB.Text; }
            set { pwdWifiTB.Text = value; }
        }

        public Wifi Wifi { get; set; }

        private void pwdWifiTB_TextChanged(object sender, EventArgs e)
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

        private void btnGeneratePassword_Click_1(object sender, EventArgs e)
        {
            GeneratePasswordForm dlgGenerator = new GeneratePasswordForm();
            if (dlgGenerator.ShowDialog() == DialogResult.OK)
            {
                // L'utilisateur valide la génération du mot de passe avec les paramètres choisis
                int nbChar = dlgGenerator.GetNbChar();
                int nbNum = dlgGenerator.GetNbNum();
                int nbSym = dlgGenerator.GetNbSym();
                pwdWifiTB.Text = PasswordGenerator.Instance.GeneratePassword(nbChar, nbNum, nbSym);
            }
        }
    }
}
