using System.IO;
using System.Reflection;
using InstallAssistant.Utils;

namespace InstallAssistant.InstallSource
{
	class InstallFromEmbeddedResource : Installer
    {
		private readonly ResourceProvider resourceProvider = new ResourceProvider();
		private readonly string resourceName;

        public InstallFromEmbeddedResource(string installerName, string semicolonSeparatedGroups, string resourceName)
            : base(installerName, semicolonSeparatedGroups) => this.resourceName = resourceName;

        public override void Start()
        {
			var assembly = Assembly.GetExecutingAssembly();
			var fullResourceName = resourceProvider.GetFullName(assembly, resourceName);
			var installerStream = resourceProvider.GetResourceByFullName(assembly, fullResourceName);
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
