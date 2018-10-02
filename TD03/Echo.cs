using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    class Echo : Commande
    {
        string[] str;
        string oui;

        public override string Aide()
        {
            return "echo retourne la chaîne de caractères suivant 'echo'";

        }

        protected override bool PeutTraiter(string cmd)
        {
            bool peut = false;
            string mot = LitMotClé(cmd);
            if (mot.Equals("echo"))
            {
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {
            Commande c = this;
            int i;
            oui = "";
            str = LitParamètres(cmd);
            for (i = 0; i < str.Length; i++)
            {
                oui += str[i];
            }
            Console.WriteLine(oui);
            return true;
        }
    }
}
