using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Modélise un utilisateur
    /// </summary>
    public class User
    {
        private int idU;

        public virtual int IdU
        {
            get { return idU; }
            set { idU = value; }
        }

        private string loginU;

        public virtual string LoginU
        {
            get { return loginU; }
            set { loginU = value; }
        }

        private string passwordU;

        public virtual string PasswordU
        {
            get { return passwordU; }
            set { passwordU = value; }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public User() { }

        public User(string loginUtil, string code)
        {
            LoginU = loginUtil;
            PasswordU = code;
        }

        public override string ToString()
        {
            return LoginU;
        }
    }
}
