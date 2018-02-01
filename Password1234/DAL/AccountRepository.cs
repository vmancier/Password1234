using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;
using System.Globalization;

namespace DAL
{
    public class AccountRepository : Repository, IAccountRepository
    {
        public IList<Account> GetAllPwdFromUser(User user)
        {
            string sixMonthsAgo = DateTime.Today.AddMonths(-6).ToString("yyyy-MM-dd");
            string requete = "select a from Account a where a.MyUser.IdU = " + user.IdU.ToString() + " AND a.Strength > 1" 
                + " AND a.Update >= '" + sixMonthsAgo + "'";

            return Session.CreateQuery(requete).List<Account>();
        }

        public IList<Account> GetAllWeakPwdFromUser(User user)
        {
            string requete = "select a from Account a where a.MyUser.IdU = " + user.IdU.ToString()+" AND a.Strength = 1";
            return Session.CreateQuery(requete).List<Account>();
        }

        public IList<Account> GetAllOldPwdFromUser(User user)
        {
            string sixMonthsAgo = DateTime.Today.AddMonths(-6).ToString("yyyy-MM-dd");
            string requete = "select a from Account a where a.MyUser.IdU = " + user.IdU.ToString()+" AND a.Update < '"+sixMonthsAgo +"'";
            return Session.CreateQuery(requete).List<Account>();
        }

        public void Save(Account account)
        {
            Session.SaveOrUpdate(account);
            Session.Flush();
        }

        public void Delete(Account account)
        {
            if(account!= null)
            {
                Session.Delete(account);
                Session.Flush();
            }
        }

    }
}
