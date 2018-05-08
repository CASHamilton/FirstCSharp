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

using Cario_CSharp.ViewModel;

namespace Cario_CSharp
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

        private void num0Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.zeroBtnClick();
        }

        private void num1Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.oneBtnClick();
        }

        private void num2Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.twoBtnClick();
        }

        private void num3Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.threeBtnClick();
        }

        private void num4Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.fourBtnClick();
        }

        private void num5Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.fiveBtnClick();
        }

        private void num6Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.sixBtnClick();
        }

        private void num7Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.sevenBtnClick();
            
        }

        private void num8Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.eightBtnClick();

        }

        private void num9Btn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.nineBtnClick();
        }

        private void additionBtn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.additionClick();
        }

        private void multiplicationBtn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.multiplicationClick();
        }

        private void subtractionBtn_Click(object sender, RoutedEventArgs e)
        {
            mvm.CalculatorViewModel.subtractionClick();
        }
    }
}
