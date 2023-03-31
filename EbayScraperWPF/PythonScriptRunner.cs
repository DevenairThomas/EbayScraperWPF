using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayScraperWPF
{
    public class PythonScriptRunner
    {
        public PythonScriptRunner() { }

        private string _PathToPythonScript;
        private string _PathToPythonEXE;
        private string _Arguments;


        public void RunPythonScript()
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = _PathToPythonEXE;
            start.Arguments = _Arguments;
            start.UseShellExecute = false;
            start.CreateNoWindow = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            using (Process process = Process.Start(start))
            {
                string result = process.StandardOutput.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(result);
                //System.Write(result);
            }
        }
        public void appendArgumentString(string argument)
        {
            Arguments += $"\"{argument}\"";
        }
        public string Arguments
        {
            get { return _Arguments; }
            set { _Arguments = value; }
        }

        public string PathToPythonScript
        {
            get { return _PathToPythonScript; }
            set
            {
                _PathToPythonScript = value;
                Arguments = $"\"{_PathToPythonScript}\"";
            }
        }

        public string PathToPythonEXE
        {
            get { return _PathToPythonEXE; }
            set { _PathToPythonEXE = value; }
        }
    }
}
