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
                String[] test = cmd.Split(' ');
                String stch = test[0];
                try
                {
                    switch (stch)
                    {
                        case "help" :
                            commande = new Help();
                            break;
                        case "?":
                            commande = new Help();
                            break;
                        case "exit":
                            commande = new Exit();
                            break;
                        case "echo":
                            commande = new Echo();
                            break;
                        case "date":
                            commande = new Date();
                            break;
                        case "heure":
                            commande = new Heure();
                            break;
                        case "log":
                            commande = new Log();
                            break;
                    }

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
