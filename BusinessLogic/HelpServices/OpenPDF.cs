using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.HelpServices
{
    public static class OpenPDF
    {
        public static bool ShowPDF(string filename)
        {
            string filePath = $"Resources\\HelpPdfs\\{filename}.pdf";
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = Path.Combine(baseDirectory, filePath);


            if (File.Exists(fullPath))
            {
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
