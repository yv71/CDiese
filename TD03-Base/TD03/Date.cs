using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    class Date : Commande
    {
        public override string Aide()
        {
            return "date retourne la date du jour (ajouter court après renvoi la date courte et ajouter long renvoi la date longue)";
        }

        protected override bool PeutTraiter(string cmd)
        {
            Boolean peut = false;            
            String mot = LitMotClé(cmd);
            String[] liste = mot.Split(' ');
            if (liste[0].Equals("date"))
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
                        Console.WriteLine("Date du jour : "+ loong());
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

        public String court()
        {
            DateTime d = DateTime.Now;
            String retour = d.ToShortDateString();
            return retour;
        }

        public String loong()
        {
            DateTime d = DateTime.Now;
            String retour = d.ToLongDateString();
            return retour;
        }
    }
}
