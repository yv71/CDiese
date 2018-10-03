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
            return "heure retourne l'heure courante (ajouter court après renvoi l'heure courte et ajouter long renvoi l'heure longue)";
        }

        protected override bool PeutTraiter(string cmd)
        {
            Boolean peut = false;
            String mot = LitMotClé(cmd);
            String[] liste = mot.Split(' ');
            if (liste[0].Equals("heure"))
            {
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {

            Boolean peut = true;
            String mot = cmd;
            String[] liste = mot.Split(' ');
            if (liste.Length == 2)
            {
                switch (liste[1])
                {
                    case "long":
                        Console.WriteLine("Date du jour : " + loong());
                        break;
                    default:
                        Console.WriteLine("Date du jour : " + court());
                        break;
                }
            }
            else
            {
                Console.WriteLine("Date du jour : " + court());
            }

            return peut;
        }

        private string loong()
        {
            DateTime d = DateTime.Now;
            String retour = d.ToLongTimeString();
            return retour;
        }

        private string court()
        {
            DateTime d = DateTime.Now;
            String retour = d.ToShortTimeString();
            return retour;
        }
    }
}
