using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    /// <summary>
    /// Représentation une action  simple
    /// </summary>
    interface Action
    {
        /// <summary>
        /// exécute l'action
        /// </summary>
        /// <param name="cmd">la ligne de commande (paramètres) de l'action</param>
        /// <returns>true si la commande permet au programme de continuer</returns>
        bool Executer(String cmd);
    }
}
