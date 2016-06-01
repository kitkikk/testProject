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

namespace Integral_test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        const int m = 1000;
        const int n = 1000;

        public MainWindow()
        {
            InitializeComponent();
        }

        private double f(double x, double y)
        {
            return (x * x + x * y - y * y);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = 0.0, b = 5.0, c = 0.0, d = 8.0;
            double integral = 0.0;
            double dx = (b - a) / m;
            double dy = (d - c) / n;
            double x0, y0, x1, y1;
            x0 = a;
            y0 = c;
            for (int i = 0; i < m+1; i++)
            {
                x1 = x0 + dx*i;
                for (int j = 0; j < n+1; j++)
                {
                    y1 = y0+dy*j;
                   // integral += f((x0+x1)/2.0,(y0+y1)/2.0); //накопление интегральной суммы
                    integral += f(x1+dx/2.0, y1+dy/2.0);
                    //y0 = y1;
                }
                //x0 = x1;
            }
            integral *= dx * dy;
            double z = 0;
        }
    }
}
