using System.Diagnostics;

namespace BusinessLogic.HelpServices
{
    public static class OpenPDF
    {
        public static bool ShowPDF(string filename)
        {
            string filePath = $"Resources\\HelpPdfs\\{filename}.pdf";

            if (File.Exists(filePath))
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
