using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LPLSystems.Services
{
    public interface IRelayCommand : ICommand
    {
        event EventHandler Executed;
        event EventHandler Executing;
    }
}
