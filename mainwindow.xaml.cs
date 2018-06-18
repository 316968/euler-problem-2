//quinn parker-joyes
//June 18 2018
//euler problem 2
// fibonacci stuff


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

namespace eulerProblem2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long firstFib = 1;
        long secondFib = 1;
        long result;
        long sum;

        public MainWindow()
        {
            InitializeComponent();
            
            while(result < 4000000)
            {   
                //if the result divides evenly, then the result is added to the sum
                if((result % 2) == 0)
                {
                    sum += result;
                    
                }
                // the result is previous previous number plus the previous number
                result = firstFib + secondFib;
                //very previous number becomes the previous previous number
                secondFib = firstFib;
                //result becomes previous number
                firstFib = result;
            }
            MessageBox.Show(sum.ToString());
        }
    }
}
