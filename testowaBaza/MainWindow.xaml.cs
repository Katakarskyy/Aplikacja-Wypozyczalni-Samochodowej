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
using System.Data.OleDb;
using System.Windows.Markup;

namespace AplikacjaWypozyczalniSamochodowej
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();          
        }
        private void CenaOd_GotFocus(object sender, RoutedEventArgs e)
        {
            CenaOd.Clear();
        }

        private void CenaDo_GotFocus(object sender, RoutedEventArgs e)
        {
            CenaDo.Clear();
        }
        private void Imie_GotFocus(object sender, RoutedEventArgs e)
        {
            Imie.Clear();
        }
        private void Nazwisko_GotFocus(object sender, RoutedEventArgs e)
        {
            Nazwisko.Clear();
        }
        private void NrPesel_GotFocus(object sender, RoutedEventArgs e)
        {
            NrPesel.Clear();
        }
        private void Miasto_GotFocus(object sender, RoutedEventArgs e)
        {
            Miasto.Clear();
        }
        private void Ulica_GotFocus(object sender, RoutedEventArgs e)
        {
            Ulica.Clear();
        }
        private void NrDom_GotFocus(object sender, RoutedEventArgs e)
        {
            NrDom.Clear();
        }
        
    }
}
