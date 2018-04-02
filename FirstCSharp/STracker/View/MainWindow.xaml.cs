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
    }
}
