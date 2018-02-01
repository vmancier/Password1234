using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class WifiRepository : Repository, IWifiRepository
    {
        public void Delete(Wifi wifi)
        {
            if (wifi !=null)
            {
                Session.Delete(wifi);
                Session.Flush();
            }
        }

        public IList<Wifi> GetAllFromUser(User user)
        {
            string requete = "select w from Wifi w where w.MyUser.IdU = " + user.IdU.ToString();
            return Session.CreateQuery(requete).List<Wifi>();
        }

        public void Save(Wifi wifi)
        {
            Session.SaveOrUpdate(wifi);
            Session.Flush();
        }
    }
}
