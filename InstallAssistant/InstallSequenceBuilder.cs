using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using InstallAssistant.InstallSource;
using InstallAssistant.Options;

namespace InstallAssistant
{
	public static class InstallSequenceBuilder
    {
        private static readonly string InstallerPath = Path.Combine(Application.StartupPath, "Installers");

        public static (InstallSequence Installers, HashSet<string> InstallerGroups) Get(string settingsFileName)
		{
            var settings = SettingsProvider.Get(settingsFileName);
            var installerGroups = new HashSet<string>();
            var result = new InstallSequence();

            foreach (var (Type, Name, Source, Enabled, SemicolonSeparatedGroups) in settings.Installers)
            {
                var groups = SemicolonSeparatedGroups.Split(';');
                foreach (var group in groups)
                {
                    installerGroups.Add(group);
                }

                switch (Type)
                {
                    case InstallerType.FromDisk:
                        result.Add(new InstallFromDisk(Name, SemicolonSeparatedGroups, Source));
                        break;
                    case InstallerType.FromEmbeddedResource:
                        result.Add(new InstallFromEmbeddedResource(Name, SemicolonSeparatedGroups, Source));
                        break;
                    case InstallerType.FromInternet:
                        result.Add(new InstallFromInternet(Name, SemicolonSeparatedGroups, Source));
                        break;
                }
                result[result.Count - 1].Enabled = Enabled;
            }
            return (result, installerGroups);
        }
    }
}
