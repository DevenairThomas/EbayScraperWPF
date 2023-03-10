using EbayScraperWPF.Views;
using System;
using System.Windows.Input;

namespace EbayScraperWPF.ViewModel
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #region Private Members
        private Action mAction;
        private Action<object> mActionParam;

        #endregion

        public RelayCommand(Action action)
        {
            mAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mAction();
        }
    }
    public class RelayCommandParam : ICommand
    {
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #region Private Members
        private Action<object> mActionParam;
        #endregion

        public RelayCommandParam(Action<object> action)
        {
            mActionParam = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mActionParam(parameter);
        }
    }
}
