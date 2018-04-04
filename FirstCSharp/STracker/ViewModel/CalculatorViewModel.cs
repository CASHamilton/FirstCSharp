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

namespace FirstCSharp.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        #region ViewModel Prepwork
        #region Constructor
        private readonly MainViewModel _mvm;
        public CalculatorViewModel(MainViewModel mvm)
        {
            _mvm = mvm;
            Constructor();
        }
        #endregion
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
        #endregion  //no need to edit anything in this region

        #region properties
        private float _result;
        public float Result
        {
            set { _result = value; OnPropertyChanged("Result"); }
            get { return _result; }
        }




        #endregion

        #region methods
        private void Constructor()
        {
            Result = 0;
        }

        public void equalsClick()
        {



        }
        public void minusclick()
            {

        }
        public void plusclick()
        {

        }
        public void divisionclick()
        {

        }
        public void multiplicationclick()
        {

        }
        public void num0click()
        {

        }
        public void num1click()
        {

        }
        public void num2click()
        {

        }
        public void num3click()
        {

        }
        public void num4click()
        {

        }
        public void num5click()
        {

        }
        public void num6click()
        {

        }
        public void num7click()
        {

        }
        public void num8click()
        {

        }
        public void num9click()
        {

        }


        #endregion
    }
}