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

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceReferenceCalc.CalculatorClient serviceClient;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            serviceClient = new ServiceReferenceCalc.CalculatorClient();
            double num1 = int.Parse(tbNum1.Text);
            double num2 = int.Parse(tbNum2.Text);
            string op = (sender as Button).Content.ToString();
            double result = 0;
            if (op.Equals("+"))
                result = serviceClient.Sum(num1, num2);
            if (op.Equals("-"))
                result = serviceClient.Sub(num1, num2);
            if (op.Equals("*"))
                result = serviceClient.Mul(num1, num2);
            if (op.Equals("/"))
                result = serviceClient.Div(num1, num2);
            lblResult.Content = result.ToString();
        }
    }
}
