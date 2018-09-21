using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TD02;

namespace WpfApp1
{

    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Annuaire annuaire = new Annuaire();
        public MainWindow()
        {
            InitializeComponent();
            annuaire.NouveauContact(new Personne("harris", "steve"));
            annuaire.NouveauContact(new Personne("dickinson", "bruce"));
            annuaire.NouveauContact(new Personne("murray", "dave"));
            annuaire.NouveauContact(new Personne("smith", "adrian"));
            annuaire.NouveauContact(new Personne("gers", "jannick"));
            annuaire.NouveauContact(new Personne("mc brain", "nicko"));
            AfficheListe();
        }

        private void AfficheListe()
        {
            contacts.Items.Clear(); // efface la liste existante
            Personne[] liste = annuaire.ListerContacts();
            foreach (Personne p in liste)
            {
                contacts.Items.Add(p);
            }
        }

        private void nouveau(object sender, RoutedEventArgs e)
        {
            Personne p = new Personne("", "");
            PersonneWindow fen = new PersonneWindow(p);
            if (fen.ShowDialog() == true)
            {
                annuaire.NouveauContact(p);
                AfficheListe();
            }
        }

        private void supprimer(object sender, RoutedEventArgs e)
        {
            if (contacts.SelectedItem is Personne p)
            {
                annuaire.SupprimerContact(p);
                AfficheListe();
                LB_recherche.Items.Clear();
            }
            else if (LB_recherche.SelectedItem is Personne j)
            {
                annuaire.SupprimerContact(j);
                AfficheListe();
                LB_recherche.Items.Clear();
            }
        }

        private void modifier(object sender, RoutedEventArgs e)
        {
            if (contacts.SelectedItem is Personne p)
            {
                Personne copy = new Personne(p);
                PersonneWindow fen = new PersonneWindow(copy);
                if (fen.ShowDialog() == true)
                {
                    p.Copier(copy);
                    LB_recherche.Items.Clear();
                }               
                AfficheListe();

            }
            else if(LB_recherche.SelectedItem is Personne j)
            {
                Personne copy = new Personne(j);
                PersonneWindow fen = new PersonneWindow(copy);
                if (fen.ShowDialog() == true)
                {
                    j.Copier(copy);
                    LB_recherche.Items.Clear();
                }
                AfficheListe();
            }

        }

        private void Rechercher(object sender, RoutedEventArgs e)
        {
            LB_recherche.Items.Clear();
            if (TB_Nom.GetLineText(0) != null && TB_Prenom.GetLineText(0) != null)
            {
                String Nom = TB_Nom.GetLineText(0);
                String Prenom = TB_Prenom.GetLineText(0);
                foreach (Personne p in annuaire.ListerContacts())
                {
                    if (Nom.ToLower() == p.Nom.ToLower() && Prenom.ToLower() == p.Prénom.ToLower())
                    {
                        LB_recherche.Items.Add(p);
                    }
                }

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.Write("test");
        }
    }
}
