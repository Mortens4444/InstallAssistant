using Newtonsoft.Json;
using System.IO;

namespace InstallAssistant.Options
{
    static class SettingsProvider
    {
        private static readonly string SettingsFileName = "settings.json";

        internal static Settings Get()
        {
            var reader = new Reader();

            if (!File.Exists(SettingsFileName))
            {
                var creator = new FileCreator();
                var result = new Settings();
                creator.CreateNewFile(SettingsFileName, result.ToString());
                return result;
            }

            var fileContent = reader.GetFileContent(SettingsFileName);
            return JsonConvert.DeserializeObject<Settings>(fileContent);
        }
    }
}
