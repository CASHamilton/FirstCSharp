using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FirstCSharp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region mainviewmodel creation
        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

        #region viewmodel creation
        //ViewModels
        private CalculatorViewModel _calculatorviewmodel;
        public CalculatorViewModel CalculatorViewModel
        {
            get { return _calculatorviewmodel; }
            set { _calculatorviewmodel = value; OnPropertyChanged("CalculatorViewModel"); }
        }
        #endregion

        #region properties
        private MainViewModel _mvm;
        public MainViewModel(MainViewModel mvm)
        {
            _mvm = mvm;
        }
        #endregion 

        #region methods
        //constructor
        public MainViewModel()
        {
            _mvm = this;
            CalculatorViewModel = new CalculatorViewModel(this);
        }
        #endregion
    }
}
