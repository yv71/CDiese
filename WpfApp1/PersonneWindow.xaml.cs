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
using System.Windows.Shapes;
using TD02;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour PersonneWindow.xaml
    /// </summary>
    public partial class PersonneWindow : Window
    {
        public PersonneWindow(Personne p)
        {
            InitializeComponent();
            DataContext = p;
        }

        private void valider(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void annuler(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
