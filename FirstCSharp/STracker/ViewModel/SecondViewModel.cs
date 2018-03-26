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
    public class SecondViewModel : INotifyPropertyChanged
    {
        #region ViewModel Prepwork
        #region Constructor
        private readonly MainViewModel _mvm;
        public SecondViewModel(MainViewModel mvm)
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

        private bool _tempVis;
        public bool TempVis
        {
            get { return _tempVis; }
            set { _tempVis = value; OnPropertyChanged("TempVis"); }
        }

        #endregion

        #region methods

        private void Constructor()
        {
            TempVis = false;
        }


        public void ToggleVis()
        {
            if (TempVis)
            {
                TempVis = false;
            }
            else
            {
                TempVis = true;
            }
        }
        #endregion
    }
}