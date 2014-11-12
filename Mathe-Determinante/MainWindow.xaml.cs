using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Determinante
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            tabellen_fuellen();
            berechnen();
        }

        private void tabellen_fuellen()
        {
            String x1, x2, x3, y1, y2, y3, z1, z2, z3, erg1, erg2, erg3;

            //Eingegebene Werte übernehmen
            x1 = textBox_x1.Text;
            x2 = textBox_x2.Text;
            x3 = textBox_x3.Text;

            y1 = textBox_y1.Text;
            y2 = textBox_y2.Text;
            y3 = textBox_y3.Text;

            z1 = textBox_z1.Text;
            z2 = textBox_z2.Text;
            z3 = textBox_z3.Text;

            erg1 = textBox_erg1.Text;
            erg2 = textBox_erg2.Text;
            erg3 = textBox_erg3.Text;


            //DX befüllen
            textBox_DX_x1.Text = erg1;
            textBox_DX_x2.Text = erg2;
            textBox_DX_x3.Text = erg3;

            textBox_DX_y1.Text = y1;
            textBox_DX_y2.Text = y2;
            textBox_DX_y3.Text = y3;

            textBox_DX_z1.Text = z1;
            textBox_DX_z2.Text = z2;
            textBox_DX_z3.Text = z3;

            //DY befüllen
            textBox_DY_x1.Text = x1;
            textBox_DY_x2.Text = x2;
            textBox_DY_x3.Text = x3;

            textBox_DY_y1.Text = erg1;
            textBox_DY_y2.Text = erg2;
            textBox_DY_y3.Text = erg3;

            textBox_DY_z1.Text = z1;
            textBox_DY_z2.Text = z2;
            textBox_DY_z3.Text = z3;

            //DZ befüllen
            textBox_DZ_x1.Text = x1;
            textBox_DZ_x2.Text = x2;
            textBox_DZ_x3.Text = x3;

            textBox_DZ_y1.Text = y1;
            textBox_DZ_y2.Text = y2;
            textBox_DZ_y3.Text = y3;

            textBox_DZ_z1.Text = erg1;
            textBox_DZ_z2.Text = erg2;
            textBox_DZ_z3.Text = erg3;

        }

        private void berechnen()
        {
            double x1, x2, x3, y1, y2, y3, z1, z2, z3, erg1, erg2, erg3;

            //Stringzu Double
            x1 = Convert.ToDouble(textBox_x1.Text);
            x2 = Convert.ToDouble(textBox_x2.Text);
            x3 = Convert.ToDouble(textBox_x3.Text);

            y1 = Convert.ToDouble(textBox_y1.Text);
            y2 = Convert.ToDouble(textBox_y2.Text);
            y3 = Convert.ToDouble(textBox_y3.Text);

            z1 = Convert.ToDouble(textBox_z1.Text);
            z2 = Convert.ToDouble(textBox_z2.Text);
            z3 = Convert.ToDouble(textBox_z3.Text);

            erg1 = Convert.ToDouble(textBox_erg1.Text);
            erg2 = Convert.ToDouble(textBox_erg2.Text);
            erg3 = Convert.ToDouble(textBox_erg3.Text);

            //D berechnen
            double ergebnis_D = (x1 * y2 * z3) + (y1 * z2 * x3) + (z1 * x2 * y3) - (x3 * y2 * z1) - (y3 * z2 * x1) - (z3 * x2 * y1);

            string Text = string.Format("{0}", ergebnis_D);
            label_ergebnis_D.Content = Text;

            //Dx berechnen
            double ergebnis_Dx = (erg1 * y2 * z3) + (y1 * z2 * erg3) + (z1 * erg2 * y3) - (erg3 * y2 * z1) - (y3 * z2 * erg1) - (z3 * erg2 * y1);

            Text = string.Format("{0}", ergebnis_Dx);
            label_ergebnis_DX.Content = Text;

            //Dy berechnen
            double ergebnis_Dy = (x1 * erg2 * z3) + (erg1 * z2 * x3) + (z1 * x2 * erg3) - (x3 * erg2 * z1) - (erg3 * z2 * x1) - (z3 * x2 * erg1);

            Text = string.Format("{0}", ergebnis_Dy);
            label_ergebnis_DY.Content = Text;

            //Dz berechnen
            double ergebnis_Dz = (x1 * y2 * erg3) + (y1 * erg2 * x3) + (erg1 * x2 * y3) - (x3 * y2 * erg1) - (y3 * erg2 * x1) - (erg3 * x2 * y1);

            Text = string.Format("{0}", ergebnis_Dz);
            label_ergebnis_DZ.Content = Text;

            //X berechnen
            double ergebnis_x = ergebnis_Dx / ergebnis_D;

            Text = string.Format("{0}", ergebnis_x);
            label_ergebnis_x.Content = Text;

            //Y berechnen
            double ergebnis_y = ergebnis_Dy / ergebnis_D;

            Text = string.Format("{0}", ergebnis_y);
            label_ergebnis_y.Content = Text;

            //Z berechnen
            double ergebnis_z = ergebnis_Dz / ergebnis_D;

            Text = string.Format("{0}", ergebnis_z);
            label_ergebnis_z.Content = Text;
        }
    }
}
