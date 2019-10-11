using System.Diagnostics;

namespace InstallAssistant.Utils
{
    class Starter
    {
        public void Start(string installerPath, string arguments = null)
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
    }
}
