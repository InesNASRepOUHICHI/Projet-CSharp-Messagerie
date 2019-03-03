using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    namespace WpfProject.Commands
    {
        class RelayCommand : ICommand

        {
            private readonly Action actionToExecute;
            public RelayCommand(Action action)
            {
                actionToExecute = action;
            }
            public bool CanExecute(object parameter)
            {
                return true;
            }
            public event EventHandler CanExecuteChanged;
            public void Execute(object parameter)
            {
                actionToExecute();
            }


        }
    }
}