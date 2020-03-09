using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCalculator.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            ShowHomeViewModel();
        }



        /// <summary>
        /// Set ActiveItem on xaml to desired view model 
        /// </summary>
        public void ShowHomeViewModel()
        {
            ActivateItem(new HomeViewModel());
        }

        public void ShowLoanViewModel()
        {
            ActivateItem(new LoanViewModel());
        }
    }
}
