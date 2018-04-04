using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using FirstCSharp.ViewModel;

namespace FirstCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly MainViewModel mvm;
        public MainWindow()
        {
            InitializeComponent();
            mvm = DataContext as MainViewModel;
        }

        private void equalBtnClick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.equalsClick();
        }
        private void minusBtnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.minusclick();
        }
        private void plusBtnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.plusclick();
        }
        private void divisionBtnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.divisionclick();
        }
        private void multiplicationBtnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.multiplicationclick();
        }
        private void num0Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num0click();
        }
        private void num1Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num1click();
        }
        private void num2Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num2click();
        }
        private void num3Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num3click();
        }
        private void num4Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num4click();
        }
        private void num5Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num5click();
        }
        private void num6Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num6click();
        }
        private void num7Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num7click();
        }
        private void num8Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num8click();
        }
        private void num9Btnclick(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.num9click();
        }








    }
}
