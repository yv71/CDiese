using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    class Echo : Commande
    {
        public override string Aide()
        {
            return "echo affiche les mots saisis après";
        }

        protected override bool PeutTraiter(string cmd)
        {
            Boolean peut = false;
            String[] listeMot = cmd.Split(' ');
            if (listeMot[0] == "echo")
            {
                peut = true;
            }
            return peut;
        }

        protected override bool Traiter(string cmd)
        {
            Boolean peut = true;
            String[] listeMot = cmd.Split(' ');
            for (int i = 1; i< listeMot.Length; i++)
            {
                Console.Write(listeMot[i]+" ");
            }
            Console.WriteLine();
            return peut;
        }
    }
}
