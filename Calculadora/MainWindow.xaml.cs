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
using System.Text.RegularExpressions;

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double resulActual;
        private string opActual;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_7(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("7");
        }

        private void Button_Ce(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.Clear();
            resulActual = 0;

        }

        private void Button_Del(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            if (txt.Text.Length > 0) txt.Text = txt.Text.Remove(txt.Text.Length - 1);
        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("8");
        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("9");
        }
        private void Button_4(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("4");
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("5");
        }

        private void Button_Mul (object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            resulActual += double.Parse(txt.Text);
            opActual = "Mul";
            txt.Clear();
        }

        private void Button_Igual(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            try
            {
                switch (opActual)
                {
                    case "Mul":
                        txt.Text = (resulActual * double.Parse(txt.Text)).ToString();
                        break;
                    case "Div":
                        txt.Text = (resulActual / double.Parse(txt.Text)).ToString();
                        break;
                    case "Min":
                        txt.Text = (resulActual - double.Parse(txt.Text)).ToString();
                        break;
                    case "Sum":
                        txt.Text = (resulActual + double.Parse(txt.Text)).ToString();
                        break;
                }
            } catch (FormatException)
            {
                txt.Clear();
            }
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("6");
        }
        private void Button_1(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("1");
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("2");
        }
        private void Button_3(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("3");
        }
        private void Button_0(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            txt.AppendText("0");
        }
        private void Button_Point(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            string punto = @"\.";
            Regex rx = new Regex(punto);

            MatchCollection matches = rx.Matches(txt.Text);

            if(matches.Count.Equals(0) && txt.Text != "") txt.AppendText(".");


        }
        private void Button_Div(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            resulActual = double.Parse(txt.Text);
            opActual = "Div";
            txt.Clear();
        }

        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            resulActual = double.Parse(txt.Text);
            opActual = "Min";
            txt.Clear();
        }
        private void Button_Sum(object sender, RoutedEventArgs e)
        {
            TextBox txt = this.FindName("Caja") as TextBox;
            resulActual += double.Parse(txt.Text);
            opActual = "Sum";
            txt.Clear();
        }
    }
}
