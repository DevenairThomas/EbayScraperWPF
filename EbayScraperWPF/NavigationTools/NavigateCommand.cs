
using System;
using System.Windows.Input;
using EbayScraperWPF.ViewModel;

namespace EbayScraperWPF.NavigationTools
{
    
    public class NavigateCommand<TViewModel> : NavigateCommandBase
        where TViewModel : ViewModelBase
    {
        private readonly NavigateViewModels navigationView;
        private readonly Func<TViewModel> viewModelFactory;
        public NavigateCommand(NavigateViewModels navigateView, Func<TViewModel> viewModelFactory)
        {
            this.navigationView = navigateView;
            this.viewModelFactory = viewModelFactory;
        }
        public void Navigate()
        {
            navigationView.CurrentViewModel = viewModelFactory();
        }
        public override void Execute(object parameter)
        {
            navigationView.CurrentViewModel = viewModelFactory();
        }
    }

    public abstract class NavigateCommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter) => true;

        public abstract void Execute(object parameter);

        protected void OnCanExecutechanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
