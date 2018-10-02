using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    class Log : Commande
    {
        string[] str;
        string oui;

        public override string Aide()
        {
            return "log renvoie le logarithme d'un réel au format x,x";
        }

        protected override bool PeutTraiter(string cmd)
        {
            bool peut = false;
            string mot = LitMotClé(cmd);
            if (mot.Equals("log"))
            {
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {
            str = LitParamètres(cmd);
            oui = str[0];
            double x = Convert.ToDouble(oui);
            if (x <= 0)
            {
                Console.WriteLine("Le log n'existe pas");
            }
            else
            {
                x = Math.Log(x);
                Console.WriteLine(x);
            }
            
            return true;
        }
    }
}
