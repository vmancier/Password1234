using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste des utilisateurs :");
            IUserRepository userRepo = new UserRepository();
            IList<User> userList = userRepo.GetAll();
            foreach (User u in userList)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine();
            Console.WriteLine("Connexion du premier utilisateur ...");
            User firstUser = userRepo.Connection("test1", "mdp789");
            if(firstUser.IdU == 1)
            {
                Console.WriteLine("Connexion réussie.");
            }else
            {
                Console.WriteLine("!!! La connexion a échoué !!!");
            }
            Console.WriteLine();
            IAccountRepository accountRepo = new AccountRepository();
            Console.WriteLine("Liste de ses comptes avec un mot de passe faible :");
            IList<Account> accountList = accountRepo.GetAllWeakPwdFromUser(firstUser);
            foreach (Account a in accountList)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Liste de ses comptes avec un mot de passe vieux de 6 mois ou + :");
            accountList = accountRepo.GetAllOldPwdFromUser(firstUser);
            foreach (Account a in accountList)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Liste de ses autres comptes :");
            accountList = accountRepo.GetAllPwdFromUser(firstUser);
            foreach (Account a in accountList)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("Liste de ses points d'accès Wifi :");
            IWifiRepository wifiRepo = new WifiRepository();
            IList<Wifi> wifiList = wifiRepo.GetAllFromUser(firstUser);
            foreach (Wifi w in wifiList)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();
            Console.WriteLine("Ajout d'un nouvel utilisateur ...");
            string loginU = "utilisateur1";
            string passwordU = "hg9gj.33f";
            User user = new User(loginU, passwordU);
            userRepo.Save(user);
            if (user.IdU != 0)
            {
                Console.WriteLine("Nouvel utilisateur ajouté !");
            }
            else
            {
                Console.WriteLine("!!! Un nouvel utilisateur n'a pas pu être ajouté !!!");
            }

            Console.WriteLine("Ajout d'un nouveau compte pour le 1er utilisateur ...");
            string name = "Site1";
            string url = "site1.com";
            string login = "logintest";
            string passwordA = "hg9gj.33fv";
            Account account = new Account(userList[0], name, url, login, passwordA);
            accountRepo.Save(account);
            if (account.IdA != 0)
            {
                Console.WriteLine("Compte ajouté !");
            }else{
                Console.WriteLine("!!! Le compte n'a pas pu être ajouté !!!");
            }

            Console.WriteLine("Ajout d'un nouveau point d'accès wifi pour le 1er utilisateur ...");
            string SSID = "Site1";
            string passwordW = "hg9gj.33fw";
            Wifi wifi = new Wifi(firstUser, SSID, passwordW);
            wifiRepo.Save(wifi);
            if (wifi.IdW != 0)
            {
                Console.WriteLine("Point d'accès Wifi ajouté !");
            }
            else
            {
                Console.WriteLine("!!! Le point d'accès Wifi n'a pas pu être ajouté !!!");
            }

            Console.WriteLine();
            Console.WriteLine("Modification d'un utilisateur... ");
            user.PasswordU = "testUpdateU";
            userRepo.Save(user);
            Console.WriteLine("Modification d'un compte... ");
            account.PasswordA = "testUpdateA";
            accountRepo.Save(account);
            Console.WriteLine("Modification d'un point d'accès... ");
            wifi.PasswordW = "testUpdateW";
            wifiRepo.Save(wifi);

            Console.WriteLine();
            Console.WriteLine("Suppression d'un utilisateur... ");
            userRepo.Delete(user);
            Console.WriteLine("Suppression d'un compte... ");
            accountRepo.Delete(account);
            Console.WriteLine("Suppression d'un point d'accès... ");
            wifiRepo.Delete(wifi);

            Console.WriteLine();
            Console.WriteLine("Generation de mot de passe... ");
            string password = PasswordGenerator.Instance.GeneratePassword(10,3,3);
            Console.WriteLine("Mot de passe généré : "+ password);
            Console.WriteLine("Calcul de la force du mot de passe généré... ");
            Console.WriteLine(PasswordGenerator.Instance.PasswordStrength(password)); 

            Console.WriteLine();
            Console.WriteLine("Terminé");
            Console.WriteLine("\nTests OK !");

            Console.ReadKey();
        }
    }
}
