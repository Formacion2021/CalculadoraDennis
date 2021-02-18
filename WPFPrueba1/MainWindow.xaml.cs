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

namespace WPFPrueba1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text+=1;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox1.Text += 2;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox1.Text += 3;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textbox1.Text += 4;

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textbox1.Text += 5;

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textbox1.Text += 6;

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textbox1.Text += 7;

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textbox1.Text += 8;

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textbox1.Text += 9;

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textbox1.Text += 0;
        }


        public void realizarOperacion()
        {
            string result = textbox1.Text, op;
            string[] array;
            double a,b;

            array = result.Split();

            a = System.Double.Parse(array[0]);
            op = array[1];
            b = System.Double.Parse(array[2]);

            lista_historial.Items.Add(result);
            textbox1.Clear();

            if(op == "+")
            {
                textbox1.Text+= (a+b);
                lista_historial.Items.Add(a + b);
            }
            else if (op == "-")
            {
                textbox1.Text += (a - b);
                lista_historial.Items.Add(a - b);
            }
            else if (op == "*")
            {
                textbox1.Text += (a * b);
                lista_historial.Items.Add(a * b);
            }
            else if (op == "/")
            {
                textbox1.Text += (a / b);
                lista_historial.Items.Add(a / b);
            }





        }

        private void Boton_sumar_Click_1(object sender, RoutedEventArgs e)
        {
            textbox1.Text += " + ";

        }

        private void Boton_dividir_Click_1(object sender, RoutedEventArgs e)
        {
            textbox1.Text += " / ";

        }

        private void Boton_restar_Click_1(object sender, RoutedEventArgs e)
        {

            textbox1.Text += " - ";
        }

        private void Boton_result_Click_1(object sender, RoutedEventArgs e)
        {
            textbox1.Text += " = ";
            realizarOperacion();

        }
        private void Boton_multiplicar_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += " * " ;
            
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textbox1.Clear();
        }
    }
}
