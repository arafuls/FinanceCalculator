using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCalculator.ViewModels
{
    public class FixedTermViewModel : Screen, INotifyPropertyChanged
    {
        private double _amount;
        private double _principal;
        private double _apr;
        private double _term;
        private List<string> _loantermCB;

        public double Amount
        {
            get { return _amount; }
            set
            {
                if (value != _amount)
                {
                    _amount = value;
                    NotifyOfPropertyChange();
                }
            }
        }

        public double Principal
        {
            get { return _principal; }
            set
            {
                if (value != _principal)
                {
                    _principal = value;
                    NotifyOfPropertyChange();
                }
            }
        }

        public double APR
        {
            get { return _apr; }
            set
            {
                if (value != _apr)
                {
                    _apr = value;
                    NotifyOfPropertyChange();
                }
            }
        }

        public double Term
        {
            get { return _term; }
            set
            {
                if (value != _term)
                {
                    _term = value;
                    NotifyOfPropertyChange();
                }
            }
        }

        public List<string> LoanTermCB
        {
            get { return _loantermCB; }
            set
            {
                if (value != _loantermCB)
                {
                    _loantermCB = value;
                    NotifyOfPropertyChange();
                }
            }
        }



        public FixedTermViewModel()
        {
            Amount = 0;
            Principal = 0;
            APR = 0;
            Term = 0;

            // Loan term options
            List<string> data = new List<string>();
            data.Add("Years");
            data.Add("Months");
            data.Add("Weeks");
            LoanTermCB = data;
        }
    }
}
