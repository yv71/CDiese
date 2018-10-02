using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    class Date : Commande
    {
        string[] str;
        string oui;
        public override string Aide()
        {
            return "date renvoie la date courante";
        }

        protected override bool PeutTraiter(string cmd)
        {
            bool peut = false;
            string mot = LitMotClé(cmd);
            if (mot.Equals("date"))
            {
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {
            str = LitParamètres(cmd);
            if (cmd.Equals("date"))
            {
                Console.WriteLine(DateTime.Now.ToString("dd/MM/yy"));
            }
            else
            {

                oui = str[0];
                if (oui.Equals("l"))
                {
                    Console.Write("Nous sommes le ");
                    Console.Write(DateTime.Now.ToString("dd"));
                    Console.Write("e jour du ");
                    Console.Write(DateTime.Now.ToString("MM"));
                    Console.Write("e mois de l'année");
                    Console.Write(DateTime.Now.ToString(" yyyy.\n"));
                }
            }
            return true;
        }
    }
}
