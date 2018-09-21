using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD02
{
    /// <summary>
    /// représente un annuaire => composition de personnes
    /// </summary>
    /// <see cref="Personne"/>
    public class Annuaire
    {
        #region associations
        private List<Personne> contacts = new List<Personne>();
        #endregion

        #region opérations
        /// <summary>
        /// Ajoute une personne aux contacts
        /// </summary>
        /// <param name="p">la personne à ajouter</param>
        public void NouveauContact(Personne p)
        {
            contacts.Add(p);
        }
        /// <summary>
        /// Supprime une personne des contacts
        /// </summary>
        /// <param name="p">la personne à supprimer</param>
        public void SupprimerContact(Personne p)
        {
            contacts.Remove(p);
        }
        /// <summary>
        /// Fournit les contacts
        /// </summary>
        /// <returns>un tableau contenant les contacts</returns>
        public Personne[] ListerContacts()
        {
            return contacts.ToArray();
        }

        /// <summary>
        /// Fournit les contacts dont le nom commence par l'initale donnée
        /// </summary>
        /// <param name="initiale">l'initiale (case-sensitive)</param>
        /// <returns>un tableau contenant les contacts</returns>
        public Personne[] ListerContacts(char initiale)
        {
            return contacts.FindAll((p) => p.Nom[0] == initiale).ToArray();
        }
        #endregion
    }
}
