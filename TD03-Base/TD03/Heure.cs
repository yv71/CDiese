using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    class Heure : Commande
    {
        public override string Aide()
        {
            return "heure renvoi l'heure courante";
        }

        protected override bool PeutTraiter(string cmd)
        {
            Boolean peut = false;
            String mot = LitMotClé(cmd);
            if (mot.Equals("heure"))
            {
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {
            Boolean peut = true;
            DateTime d = DateTime.Now;
            String h = d.Hour.ToString();
            String m;
            if (d.Minute < 10)
            {
                m = "0" + d.Minute.ToString();
            }
            else
            {
                m = d.Minute.ToString();
            }
            Console.WriteLine(h+"h"+m);
            return peut;
        }
    }
}
