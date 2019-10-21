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

            foreach (var (InstallationSource, InstallerType, Name, Source, Enabled, SemicolonSeparatedGroups) in settings.Installers)
            {
				if (InstallerType != InstallerType.Normal)
				{
					continue;
				}

                var groups = SemicolonSeparatedGroups.Split(';');
                foreach (var group in groups)
                {
                    installerGroups.Add(group);
                }

                switch (InstallationSource)
                {
                    case InstallationSource.FromDisk:
                        result.Add(new InstallFromDisk(Name, SemicolonSeparatedGroups, Source));
                        break;
                    case InstallationSource.FromEmbeddedResource:
                        result.Add(new InstallFromEmbeddedResource(Name, SemicolonSeparatedGroups, Source));
                        break;
                    case InstallationSource.FromInternet:
                        result.Add(new InstallFromInternet(Name, SemicolonSeparatedGroups, Source));
                        break;
                }
				result[result.Count - 1].InstallerType = InstallerType;
				result[result.Count - 1].Enabled = Enabled;
            }
            return (result, installerGroups);
        }
    }
}
