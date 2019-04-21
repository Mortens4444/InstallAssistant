using System.Diagnostics;

namespace InstallAssistant.ProcessUtils
{
    class Starter
    {
        public void Start(string installerPath, string arguments = null)
        {
            try
            {
                var process = Process.Start(
                    new ProcessStartInfo
                    {
                        Arguments = arguments,
                        UseShellExecute = true,
                        FileName = installerPath
                    });
                process?.WaitForExit();
            }
            catch { }
        }
    }
}
