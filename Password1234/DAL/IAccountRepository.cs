using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux comptes
    /// </summary>
    public interface IAccountRepository
    {
        /// <summary>
        /// Récupère la liste des comptes qui n'ont pas un mot de passe faible 
        /// et qui n'ont pas un mot de passe vieux de plus de 6 mois
        /// </summary>
        /// <param name="user">l'utilisateur</param>
        IList<Account> GetAllPwdFromUser(User user);

        /// <summary>
        /// Récupère la liste des comptes avec un mot de passe faible
        /// </summary>
        /// <param name="user">l'utilisateur</param>
        IList<Account> GetAllWeakPwdFromUser(User user);

        /// <summary>
        /// Récupère la liste des comptes avec un mot de passe vieux de plus de 6 mois
        /// </summary>
        /// <param name="user">l'utilisateur</param>
        IList<Account> GetAllOldPwdFromUser(User user);

        /// <summary>
        /// Sauvegarde un compte
        /// </summary>
        /// <param name="account">le compte</param>
        void Save(Account account);

        /// <summary>
        /// Supprime un compte
        /// </summary>
        /// <param name="account">le compte</param>
        void Delete(Account account);
    }
}
