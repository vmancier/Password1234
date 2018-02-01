using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Modélise un point d'accès Wifi d'un utilisateur
    /// </summary>
    public class Wifi
    {
        private User myUser;

        public virtual User MyUser
        {
            get { return myUser; }
            set { myUser = value; }
        }

        private int idW;

        public virtual int IdW
        {
            get { return idW; }
            set { idW = value; }
        }

        private string ssid;

        public virtual string Ssid
        {
            get { return ssid; }
            set { ssid = value; }
        }

        private string passwordW;

        public virtual string PasswordW
        {
            get { return passwordW; }
            set { passwordW = value; }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Wifi() { }

        public Wifi(User util, string ssid, string code)
        {
            MyUser = util;
            Ssid = ssid;
            PasswordW = code;
        }

        public override string ToString()
        {
            return Ssid;
        }
    }
}
