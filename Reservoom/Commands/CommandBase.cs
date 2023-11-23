using NLog;
using System;
using System.Windows.Input;

namespace Reservoom.Commands
{
    public abstract class CommandBase : ICommand
    {
        protected static readonly Logger _log = LogManager.GetLogger("TestApplication");

        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }

        public abstract void Execute(object? parameter);

        protected void OnCanExecutedChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
