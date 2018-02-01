using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IWifiRepository wifiRepository = new WifiRepository();
            IUserRepository userRepository = new UserRepository();
            IAccountRepository accountRepository = new AccountRepository();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SignInForm signInForm = new SignInForm(wifiRepository, userRepository, accountRepository);
            signInForm.Show();
            Application.Run();
        }
    }
}
