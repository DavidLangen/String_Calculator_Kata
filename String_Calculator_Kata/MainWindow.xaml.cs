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
            String eingabe = tbx_string_eingabe.Text;

            tbx_string_eingabe.Text = "";

            int ergebnis = sck.Calculator(eingabe);

            lbl_ergebnis_ausgabe.Content = "" + ergebnis;
        }

        private void btn_schließen_Click(object sender, RoutedEventArgs e)
        {
            w_fenster.Close();
        }

    }
}
