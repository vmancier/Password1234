using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux points d'accès wifi
    /// </summary>
    public interface IWifiRepository
    {
        /// <summary>
        /// Récupère la liste des points d'accès wifi d'un utilisateur 
        /// </summary>
        /// <param name="user">l'utilisateur</param>
        IList<Wifi> GetAllFromUser(User user);


        /// <summary>
        /// Sauvegarde un point d'accès wifi
        /// </summary>
        /// <param name="wifi">le point d'accès wifi</param>
       void Save(Wifi wifi);

        /// <summary>
        /// Supprime un point d'accès wifi
        /// </summary>
        /// <param name="wifi">le point d'accès wifi</param>
        void Delete(Wifi wifi);
    }
}
