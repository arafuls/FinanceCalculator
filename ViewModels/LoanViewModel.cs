using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCalculator.ViewModels
{
    public class LoanViewModel : Conductor<object>
    {
        public void ShowFixedTermViewModel()
        {
            ActivateItem(new FixedTermViewModel());
        }
    }
}
