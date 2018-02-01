using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Modélise un compte d'un utilisateur
    /// </summary>
    public class Account
    {
        private DateTime update;

        public virtual DateTime Update
        {
            get { return update; }
            set { update = value; }
        }

        private int idA;

        public virtual int IdA
        {
            get { return idA; }
            set { idA = value; }
        }

        private string loginA;

        public virtual string LoginA
        {
            get { return loginA; }
            set { loginA = value; }
        }

        private string passwordA;

        public virtual string PasswordA
        {
            get { return passwordA; }
            set { passwordA = value; }
        }

        private string name;

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string url;

        public virtual string URL
        {
            get { return url; }
            set { url = value; }
        }

        private int strength;

        public virtual int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        private User myUser;

        public virtual User MyUser
        {
            get { return myUser; }
            set { myUser = value; }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Account() { }

        public Account(User util, string nom, string url, string login, string code)
        {
            MyUser = util;
            Name = nom;
            URL = url;
            LoginA = login;
            PasswordA = code;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
