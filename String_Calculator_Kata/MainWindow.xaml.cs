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

namespace String_Calculator_Kata
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringCalculatorKata sck;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void w_fenster_Loaded(object sender, RoutedEventArgs e)
        {
            sck = new StringCalculatorKata();
        }

        private void btn_berechnen_Click(object sender, RoutedEventArgs e)
        {
            Berechnen();
        }

        private void btn_schließen_Click(object sender, RoutedEventArgs e)
        {
            w_fenster.Close();
        }

        private void lbx_berechnungen_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            String berechnung = lbx_berechnungen.SelectedItem.ToString();
            String[] gleichung = berechnung.Split('=');

            tbx_string_eingabe.Text = gleichung[0];
            lbl_ergebnis_ausgabe.Content = berechnung;
        }

        private void tbx_string_eingabe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Berechnen();
            }
        }

        private void Berechnen()
        {
            String eingabe = tbx_string_eingabe.Text;
            int ergebnis = sck.Calculator(eingabe);

            String berechnung = eingabe + "=" + ergebnis;

            tbx_string_eingabe.Text = "";

            lbl_ergebnis_ausgabe.Content = berechnung;

            sck.AddCalculation(berechnung);

            lbx_berechnungen.Items.Add(sck.LastCalculation());
        }
    }
}
