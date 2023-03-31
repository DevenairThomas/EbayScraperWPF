using EbayScraperWPF.CommandEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EbayScraperWPF.ViewModel
{
    public class ItemAnalyticsViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        private PythonScriptRunner ScriptRunner;

        private string scriptPath = @"C:\Users\deven\Software_Development\Python Programs\EbayProject\EbayfinderBot.py";
        private string pythonExecutablePath = @"C:\Users\deven\AppData\Local\Programs\Python\Python310\python.exe";
        public ItemAnalyticsViewModel()
        {
            CurrentViewModel = this;
            ScriptRunner = new PythonScriptRunner();
            DispatchItemCommand = new RelayCommand(() => RunPythonScript());
        }

        public ICommand DispatchItemCommand { get; set; }

        private void RunPythonScript()
        {
            ScriptRunner.PathToPythonEXE = pythonExecutablePath;
            ScriptRunner.PathToPythonScript = scriptPath;
            ScriptRunner.RunPythonScript();
        }
    }
}
