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

namespace _2_pr_isrpo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            H.Text = "5,5";
            P.Text = "4,3";
            R.Text = "2,8";
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая 2 Вар 7";
            double h = double.Parse(H.Text);
            Itog.Text += Environment.NewLine + "H=" + h.ToString();
            double p = double.Parse(P.Text);
            Itog.Text += Environment.NewLine + "P=" + p.ToString();
            double r = double.Parse(R.Text);
            Itog.Text += Environment.NewLine + "R=" + r.ToString();

            double i = Math.Sqrt(h*h + (p - r)*(p - r));
            Itog.Text += Environment.NewLine + "Результат i =" + i.ToString();
            
        }
    }
}
