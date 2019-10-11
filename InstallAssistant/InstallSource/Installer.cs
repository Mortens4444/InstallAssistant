using System;
using System.IO;
using InstallAssistant.Utils;

namespace InstallAssistant.InstallSource
{
	public abstract class Installer
    {
        public Installer(string installerName, string semicolonSeparatedGroups)
        {
            Name = installerName;
            Groups = semicolonSeparatedGroups.Split(';');
        }

        public bool Enabled { get; set; } = true;

        public string Name { get; }

        public string[] Groups { get;  }

        public abstract void Start();

        protected static void Start(string installerPath)
        {
            var starter = new Starter();
            if (installerPath.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
            {
                starter.Start(installerPath);
            }
            else if (installerPath.EndsWith(".msi", StringComparison.OrdinalIgnoreCase))
            {
                starter.Start("msiexec", $"/i \"{installerPath}\" /L*V \"{CreateTempFilename(installerPath)}.log\"");
            }
        }

        protected static string CreateTempFilename(string filenameHolder)
        {
            return Path.Combine(Path.GetTempPath(), Path.GetFileName(filenameHolder));
        }
    }
}
