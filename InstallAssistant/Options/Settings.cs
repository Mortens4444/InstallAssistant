using System.Collections.Generic;
using InstallAssistant.InstallSource;
using Newtonsoft.Json;

namespace InstallAssistant.Options
{
	class Settings
    {
        public List<(InstallationSource InstallationSource,
					 InstallerType InstallerType,
					 string Name,
                     string Source,
                     bool Enabled,
                     string SemicolonSeparatedGroups)>
            Installers { get; set; } = new List<(InstallationSource, InstallerType, string, string, bool, string)>();

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
