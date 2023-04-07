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
            if (int.Parse(writeText.Text) <= 100 && int.Parse(writeText.Text) > 0)
            {
                int a = int.Parse(writeText.Text);
                string[] oneCount = new string[9] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
                string[] twoCount = new string[10] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] threeCount = new string[8] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                if (a < 10)
                {
                    result.Text = oneCount[a - 1];
                }
                else if (a == 10) 
                    result.Text = twoCount[0];
                else if (a < 20)
                {
                    result.Text = twoCount[a - 10];
                }
                else if (a == 20) 
                    result.Text = threeCount[0];
                else if (a < 30)
                {
                    result.Text = threeCount[0] + " " + oneCount[a - 21];
                }
                else if (a == 30) 
                    result.Text = threeCount[1];
                else if (a < 40)
                {
                    result.Text = threeCount[1] + " " + oneCount[a - 31];
                }
                else if (a == 40) 
                    result.Text = threeCount[2];
                else if (a < 50)
                {
                    result.Text = threeCount[2] + " " + oneCount[a - 41];
                }
                else if (a == 50) 
                    result.Text = threeCount[3];
                else if (a < 60)
                {
                    result.Text = threeCount[3] + " " + oneCount[a - 51];
                }
                else if (a == 60) 
                    result.Text = threeCount[4];
                else if (a < 70)
                {
                    result.Text = threeCount[4] + " " + oneCount[a - 61];
                }
                else if (a == 70) 
                    result.Text = threeCount[5];
                else if (a < 80)
                {
                    result.Text = threeCount[5] + " " + oneCount[a - 71];
                }
                else if (a == 80) 
                    result.Text = threeCount[6];
                else if (a < 90)
                {
                    result.Text = threeCount[6] + " " + oneCount[a - 81];
                }
                else if (a == 90) 
                    result.Text = threeCount[7];
                else if (a < 100)
                {
                    result.Text = threeCount[7] + " " + oneCount[a - 91];
                }
                else if (a == 100)
                {
                    result.Text = "one hundred";
                }
            }
        }
    }
}
