using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux utilisateurs
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Récupère la liste des utilisateurs
        /// </summary>
        IList<User> GetAll();

        /// <summary>
        /// Sauvegarde un utilisateur
        /// </summary>
        /// <param name="user">l'utilisateur</param>
        void Save(User user);

        /// <summary>
        /// Supprime un utilisateur
        /// </summary>
        /// <param name="user">l'utilisateur</param>
        void Delete(User user);

        /// <summary>
        /// Connecte un utilisateur
        /// </summary>
        /// <param name="login">identifiant de l'utilisateur</param>
        /// <param name="password">mot de passe de l'utilisateur</param>
        User Connection(string login, string password);
    }
}
