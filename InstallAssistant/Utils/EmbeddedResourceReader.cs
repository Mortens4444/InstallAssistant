using System.IO;
using System.Reflection;

namespace InstallAssistant.Utils
{
    class EmbeddedResourceReader
    {
        public string GetContent(Assembly assembly, string resourceName)
        {
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
