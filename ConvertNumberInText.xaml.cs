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

namespace WpfApp13
{
    public partial class MainWindow : Window
    {
        private string[] oneCount = new string[9] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private string[] twoCount = new string[10] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private string[] threeCount = new string[8] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

    public MainWindow()
    {
        InitializeComponent();
        writeText.MaxLength = 3;
    }

    private void Close_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Search_Click(object sender, RoutedEventArgs e)
    {
        int number;
        if (int.TryParse(writeText.Text, out number) && number > 0 && number <= 100)
        {
            if (number < 10)
            {
                result.Text = oneCount[number - 1];
            }
            else if (number < 20)
            {
                result.Text = twoCount[number - 10];
            }
            else
            {
                int tens = number / 10;
                int ones = number % 10;

                if (ones == 0)
                {
                    result.Text = threeCount[tens - 2];
                }
                else
                {
                    result.Text = threeCount[tens - 2] + " " + oneCount[ones - 1];
                }
            }

            if (number == 100)
            {
                result.Text = "one hundred";
            }
        }
    }
}
