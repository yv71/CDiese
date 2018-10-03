using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    /// <summary>
    /// Interpréteur de commandes en mode console. Compose des commandes
    /// </summary>
    /// <see cref="Commande"/>
    class Interpréteur
    {
        private Commande commande;
        public Interpréteur()
        {
            commande = new Help();
            commande.Ajouter(new Exit());
            commande.Ajouter(new Echo());
            commande.Ajouter(new Heure());
            commande.Ajouter(new Date());
            commande.Ajouter(new dec2bin());
        }

        /// <summary>
        /// Exécute l'interpréteur
        /// </summary>
        public void Run()
        {
            bool continuer = true;
            while (continuer)
            {
                Console.Write("[Entrez votre commande] ");
                String cmd = Console.ReadLine();
                try
                {
                    continuer = commande.Executer(cmd);
                }
                catch (Exception x)
                {
                    Console.WriteLine("[ERREUR] " + x.Message);
                }
            }
        }
    }
}
