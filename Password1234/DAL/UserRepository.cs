using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class UserRepository : Repository, IUserRepository
    {
        public void Delete(User user)
        {
            if(user != null)
            {
                Session.Delete(user);
                Session.Flush();
            }
        }

        public IList<User> GetAll()
        {
            return Session.Query<User>().ToList();
        }
        public IList<User> GetUser(string login, string password)
        {
            string requete = "select u from User u where u.LoginU = " + login + " and u.PasswordU = " + password;
            return Session.CreateQuery(requete).List<User>();
        }

        public void Save(User user)
        {
            Session.SaveOrUpdate(user);
            Session.Flush();
        }

        public User Connection(string login, string password)
        {
            string requete = "select u from User u where u.LoginU ='" + login + "' AND u.PasswordU = '"+ password +"'";
            return Session.CreateQuery(requete).SetMaxResults(1).UniqueResult<User>();
        }

    }
}
