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

        public void ShowHomeViewModel()
        {
            ActivateItem(new HomeViewModel());
        }

        public void ShowAutoViewModel()
        {
            ActivateItem(new AutoLoanViewModel());
        }
    }
}
