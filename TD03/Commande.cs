using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD03
{
    /// <summary>
    /// Représente une commande de l'interpréteur
    /// </summary>
    abstract class Commande : Action
    {
        #region attributs et propriétés
        private Commande suivante;
        public Commande Suivante
        {
            get { return suivante; }
        }
        #endregion


        /// <summary>
        /// Ajoute une commande à l'interpréteur
        /// </summary>
        /// <param name="c"></param>
        public void Ajouter(Commande c)
        {
            if (suivante != null)
                suivante.Ajouter(c);
            else
                suivante = c;
        }

        /// <summary>
        /// Fournit une aide sur la commande
        /// </summary>
        /// <returns>un texte donnant une aide sur la commande</returns>
        abstract public String Aide();


        public bool Executer(String cmd)
        {
            bool encore = true;
            if(PeutTraiter(cmd))
            {
                encore = Traiter(cmd);
            }
            else
            {
                if (suivante != null)
                    encore = suivante.Executer(cmd);
                else
                    throw new Exception("Commande inconnue");
            }
            return encore;
        }

        /// <summary>
        /// Indique si la commande est traitable
        /// </summary>
        /// <param name="cmd">la ligne de commande à traiter</param>
        /// <returns>true si la commande est exécutable</returns>
        abstract protected bool PeutTraiter(String cmd);

        /// <summary>
        /// Effectue le travail propre de la commande
        /// </summary>
        /// <param name="cmd">la ligne de commandes (paramètres)</param>
        /// <returns>True si l'application continue</returns>
        abstract protected bool Traiter(String cmd);

        /// <summary>
        /// Récupère le mot-clé de la commande (1er mot)
        /// </summary>
        /// <param name="cmd">la ligne de commandes</param>
        /// <returns>le mot-clé</returns>
        protected String LitMotClé(String cmd)
        {
            String[] mots = cmd.Split(' ');
            return mots[0];
        }

        /// <summary>
        /// Récupère les paramètres de la commande
        /// </summary>
        /// <param name="cmd">la commande à découper</param>
        /// <returns>un tableau de chaines contenant les paramètres</returns>
        protected String[] LitParamètres(String cmd)
        {
            String[] mots = cmd.Split(' ');
            String[] par = new String[mots.Length-1];
            for(int i=1;i<mots.Length;i++)
            {
                par[i-1] = mots[i];
            }
            return par;
            
        }

    }
}
