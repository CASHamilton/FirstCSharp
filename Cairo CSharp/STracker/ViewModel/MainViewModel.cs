using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using STracker.Model;

namespace Cario_CSharp.ViewModel
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
        private CalculatorViewModel _calculatorViewModel;
        public CalculatorViewModel CalculatorViewModel
        {
            get { return _calculatorViewModel; }
            set { _calculatorViewModel = value; OnPropertyChanged("CalculatorViewModel"); }
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

            //using (var ent = new dataEntities())
            //{
            //    var date = DateTime.Now.AddMonths(-5);
            //    var oldUsers = (from a in ent.User where a.lastLogin <= date select a).ToList();
            //    foreach(var i in oldUsers)
            //    {
            //        ent.User.Remove(i);
            //    }
            //    ent.SaveChanges();
            //}
        }

        public void Signup(string username, string password)
        {
            try
            {
                using (var ent = new dataEntities())
                {
                    var temp = (from a in ent.User where a.username == username select a).FirstOrDefault();
                    if(temp != null)
                    {
                        //show some alert saying this cant be done TODO
                        return;
                    }
                    else
                    {
                        var newUser = new User();
                        newUser.username = username;
                        newUser.password = password;
                        newUser.lastLogin = DateTime.Now;

                        ent.User.Add(newUser);
                        ent.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                //DO THIS LATER
            }
        }

        public void Login(string username, string password)
        {

        }
        #endregion
    }
}
