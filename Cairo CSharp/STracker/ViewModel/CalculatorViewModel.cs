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

namespace Cario_CSharp.ViewModel
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

        private string _row;
        public string Row
        {
            get { return _row; }
            set
            {
                if (_row.Length < 10)
                {
                    _row = value;
                }
                else
                {
                    Console.WriteLine("max row exeeded");
                }
                OnPropertyChanged("Row");
            }
        }

        private string _teaser;
        public string Teaser
        {
            get { return _teaser; }
            set
            {
                _teaser = value;
                OnPropertyChanged("Teaser");
            }
        }

        private string _operator;
        public string Operator
        {
            get { return _operator; }
            set
            {
                _operator = value;
                OnPropertyChanged("Operator");
            }
        }
        private string _lastOperation;
        public string LastOperation
        {
            get { return _lastOperation; }
            set
            {
                _lastOperation = value;
                OnPropertyChanged("LastOperation");
            }
        }

        private double _num1;
        public double Num1
        {
            get { return _num1; }
            set { _num1 = value; OnPropertyChanged("Num1"); }
        }

        #endregion

        #region methods

        private void Constructor()
        {
            _row = "";
            _teaser = "";

            //set num1 to 0
            Num1 = 0;
        }

        public void equalsClick()
        {
            //grab last operator
            if (Row != "" && Row != null)
            {
                LastOperation = Operator;

                switch (Operator)
                {
                    case "+":
                        LastOperation += Row;
                        Num1 += Convert.ToDouble(Row);
                        break;
                    case "-":
                        LastOperation += Row;
                        Num1 -= Convert.ToDouble(Row);
                        break;
                    case "*":
                        LastOperation += Row;
                        Num1 *= Convert.ToDouble(Row);
                        break;
                    case "/":
                        LastOperation += Row;
                        Num1 /= Convert.ToDouble(Row);
                        break;

                }

                Operator = "";
                Teaser = Num1.ToString();
                Num1 = 0;
                Row = "";
            }
            else
            {
                char op = LastOperation[0];
                var str = LastOperation;
                var size = str.Length;
                str = str.Substring(1, size - 1);

                double number = Convert.ToDouble(str);

                switch (op)
                {
                    case '+':
                        var temp = Convert.ToDouble(Teaser);
                        Teaser = (temp + number).ToString();

                        //empty row
                        Row = "";
                        break;
                    case '-':
                        var temp2 = Convert.ToDouble(Teaser);
                        Teaser = (temp2 - number).ToString();

                        break;
                    case '*':
                        var temp3 = Convert.ToDouble(Teaser);
                        Teaser = (temp3 * number).ToString();

                        //empty row
                        Row = "";

                        break;
                    case '/':
                        var temp4 = Convert.ToDouble(Teaser);
                        Teaser = (temp4 / number).ToString();

                        //empty row
                        Row = "";
                        break;
                }
            }
        }

        public void zeroBtnClick()
        {
            Row = Row + "0";
        }

        public void oneBtnClick()
        {
            Row = Row + "1";
        }
        public void twoBtnClick()
        {
            Row = Row + "2";
        }
        public void threeBtnClick()
        {
            Row = Row + "3";
        }
        public void fourBtnClick()
        {
            Row = Row + "4";
        }
        public void fiveBtnClick()
        {
            Row = Row + "5";
        }
        public void sixBtnClick()
        {
            Row = Row + "6";
        }
        public void sevenBtnClick()
        {
            Row = Row + "7";
        }
        public void eightBtnClick()
        {
            Row = Row + "8";
        }
        public void nineBtnClick()
        {
            Row = Row + "9";
        }

        public void additionClick()
        {
            Operator = "+";

            //save current string as number, add to row
            if (Row != "" && Row != null)
            {
                Num1 += Convert.ToDouble(Row);

                //take num1 and put it on top of row
                Teaser = Num1.ToString();

                //empty row
                Row = "";
            }

        }

        public void multiplicationClick()
        {
            Operator = "*";

            //save current string as number, add to row
            if (Row != "" && Row != null)
            {
                Num1 *= Convert.ToDouble(Row);

                //take num1 and put it on top of row
                Teaser = Num1.ToString();

                //empty row
                Row = "";
            }
        }
        public void subtractionClick()
        {
            Operator = "-";

            //save current string as number, add to row
            if (Row != "" && Row != null)
            {
                Num1 -= Convert.ToDouble(Row);

                //take num1 and put it on top of row
                Teaser = Num1.ToString();

                //empty row
                Row = "";
            }
            #endregion
        }
    }
}