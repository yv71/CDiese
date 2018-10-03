using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    /// <summary>
    /// Commande simple : affiche la liste des commandes reconnues
    /// </summary>
    class Help : Commande
    {
        public override string Aide()
        {
            return "help ou ? affiche la liste des commandes";
        }

        protected override bool PeutTraiter(string cmd)
        {
            bool peut = false;
            String mot = LitMotClé(cmd);
            if(mot.Equals("help") || mot.Equals("?"))
            {
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {
            Commande c = this;
            while(c!=null)
            {
                Console.WriteLine(c.Aide());
                c = c.Suivante;
            }
            return true;
        }
    }
}
