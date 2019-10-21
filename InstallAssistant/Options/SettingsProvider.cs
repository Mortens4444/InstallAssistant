using System.IO;
using InstallAssistant.InstallSource;
using Newtonsoft.Json;

namespace InstallAssistant.Options
{
	static class SettingsProvider
    {
        internal static Settings Get(string settingsFileName)
        {
            var reader = new Reader();

            if (!File.Exists(settingsFileName))
            {
                var creator = new FileCreator();
                var result = new Settings();
				result.Installers.Add((InstallationSource.FromDisk, InstallerType.Normal, "Disk installer", @"C:\Temp\Setup.exe", true, "All;From disk only"));
				result.Installers.Add((InstallationSource.FromEmbeddedResource, InstallerType.Normal, "Embedded resource installer", @"InstallAssistant\Resources\Setup.exe", true, "All;From embedded resource only"));
				result.Installers.Add((InstallationSource.FromInternet, InstallerType.Normal, "Internet installer", @"http:\\mycompany.com\Setup.exe", true, "All;From internet only"));
				creator.CreateNewFile(settingsFileName, result.ToString());
                return result;
            }

            var fileContent = reader.GetFileContent(settingsFileName);
            return JsonConvert.DeserializeObject<Settings>(fileContent);
        }
    }
}
