using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    class Exit : Commande
    {

        
        public override string Aide()
        {
            return "exit quitte l'invite de commande";
        }

        protected override bool PeutTraiter(string cmd)
        {
            bool peut = false;
            string mot = LitMotClé(cmd);
            if (mot.Equals("exit")){
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {
            Environment.Exit(0);
            return true;
        }
    }
}
