using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD02
{
    /// <summary>
    /// Représente une personne
    /// </summary>
    public class Personne
    {
        #region attributs
        private string nom;
        private string prénom;
        private string adresse;
        private string téléphone;
        #endregion

        #region propriétés
        /// <summary>
        /// Obtient ou fixe le nom de la personne
        /// </summary>
        public string Nom { get => nom; set => nom = value.ToUpper(); }
        /// <summary>
        /// Obtient ou fixe le prénom de la persone
        /// </summary>
        public string Prénom { get => prénom;
            set {
                if(value!=null && value.Length>0)
                {
                    prénom = char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }                
            }
        }
        
        /// <summary>
        /// Obtient ou fixe l'adresse de la personne
        /// </summary>
        public string Adresse { get => adresse; set => adresse = value; }
        /// <summary>
        /// Obtient ou fixe le numéro de téléphone de la personne
        /// </summary>
        public string Téléphone { get => téléphone; set => téléphone = value; }

        /// <summary>
        /// Obtient l'identité de la personne
        /// </summary>
        public string Identité
        {
            get { return Nom + " " + Prénom; }            
        }
        #endregion

        /// <summary>
        /// Initialise une personne
        /// </summary>
        /// <param name="nom">le nom de la personne</param>
        /// <param name="prénom">le prénom de la personne</param>
        public Personne(string nom, string prénom)
        {
            Nom = nom;
            Prénom = prénom;
        }

        public Personne(Personne p)
        {
            Nom = p.Nom;
            Prénom = p.Prénom;
            Adresse = p.Adresse;
            Téléphone = p.Téléphone;
        }

        public void Copier(Personne p)
        {
            this.Nom = p.Nom;
            this.Prénom = p.Prénom;
            this.Adresse = p.Adresse;
            this.Téléphone = p.Téléphone;
        }
        /// <summary>
        /// Obtient une représentation "chaîne" de la personne
        /// </summary>
        /// <returns>une chaîne représentant la personne</returns>
        public override string ToString()
        {
            return Identité;
        }


    }
}
