using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    class dec2bin : Commande
    {
        public override string Aide()
        {
            return "dec2bin convertit un nombre en base 2 sur 32 bits";
        }

        protected override bool PeutTraiter(string cmd)
        {
            Boolean retour = false;
            String mot = LitMotClé(cmd);
            if (mot.Equals("dec2bin"))
            {
                retour = true;
            }
            return retour;
        }

        protected override bool Traiter(string cmd)
        {
            Boolean retour = true;
            String[] liste = LitParamètres(cmd);
            String nb = liste[0];
            Int32 n = Convert.ToInt32(nb);
            Console.WriteLine(Convert.ToString(n,2));
            return retour;
        }
    }
}
