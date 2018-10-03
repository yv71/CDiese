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
            return "date retourne la date du jour";
        }

        protected override bool PeutTraiter(string cmd)
        {
            Boolean peut = false;
            String mot = LitMotClé(cmd);
            if (mot.Equals("date"))
            {
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {
            Boolean peut = true;
            DateTime d = DateTime.Now;
            String y = d.Year.ToString();
            String m = d.Month.ToString();
            String day = d.Day.ToString();
            if (d.Month < 10)
            {
                m = "0" + d.Month.ToString();
            }
            if (d.Day < 10)
            {
                day = "0" + d.Day.ToString();
            }
            Console.WriteLine(day + "/" + m + "/" + y);
            return peut;
        }
    }
}
