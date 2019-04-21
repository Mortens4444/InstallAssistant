using System.IO;
using System.Linq;
using System.Reflection;

namespace InstallAssistant.InstallSource
{
    class InstallFromEmbeddedResource : Installer
    {
        private readonly string resourceName;

        public InstallFromEmbeddedResource(string installerName, string semicolonSeparatedGroups, string resourceName)
            : base(installerName, semicolonSeparatedGroups) => this.resourceName = resourceName;

        public override void Start()
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            string folderName = $"{executingAssembly.GetName().Name}.Resources";
            var fullResourceName = executingAssembly.GetManifestResourceNames()
                .FirstOrDefault(r => r.StartsWith(folderName) && r.EndsWith(resourceName));
            var installerStream = executingAssembly.GetManifestResourceStream(fullResourceName);
            WriteToTempFileAndExecute(fullResourceName, installerStream);
        }

        private void WriteToTempFileAndExecute(string fullResourceName, Stream installerStream)
        {
            var installerPath = CreateTempFilename(fullResourceName);

            try
            {
                using (var fs = File.OpenWrite(installerPath))
                {
                    installerStream.CopyTo(fs);
                }

                Start(installerPath);
            }
            finally
            {
                try
                {
                    File.Delete(installerPath);
                }
                catch { }
            }
        }
    }
}
