using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    class Heure : Commande
    {
        string[] str;
        string oui;

        public override string Aide()
        {
            return "heure affiche la date courante";
        }

        protected override bool PeutTraiter(string cmd)
        {
            bool peut = false;
            string mot = LitMotClé(cmd);
            if (mot.Equals("heure"))
            {
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {
            if (cmd.Equals("heure"))
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm"));
            }
            else {
                str = LitParamètres(cmd);
                oui = str[0];
                if (oui.Equals("l"))
                {
                    Console.Write(DateTime.Now.ToString("HH"));
                    Console.Write(" Heures et ");
                    Console.Write(DateTime.Now.ToString("mm"));
                    Console.Write(" minutes.\n");
                }
            }
            
            return true;
        }
    }
}
