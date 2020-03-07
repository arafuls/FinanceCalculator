using Caliburn.Micro;
using FinanceCalculator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinanceCalculator
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }


        /*
        NAME
            protected override void OnStartup(object sender, StartupEventArgs e)

        PARAMETERS
            object sender       - A reference to the sender object.
            StartupEventArgs e  - A reference to any additional arguments.

        SUMMARY
            Customized OnStartup behavior by overriding the BootstrapperBase in
            CaliburnMicro.
        */
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
