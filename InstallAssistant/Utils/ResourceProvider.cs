using System.IO;
using System.Linq;
using System.Reflection;

namespace InstallAssistant.Utils
{
	public class ResourceProvider
	{
		public string GetFullName(Assembly assembly, string resourceName)
		{
			string folderName = $"{assembly.GetName().Name}.Resources";
			return assembly.GetManifestResourceNames()
				.FirstOrDefault(r => r.StartsWith(folderName) && r.EndsWith(resourceName));
		}

		public Stream GetResourceByShortName(Assembly assembly, string fullResourceShortName)
		{
			var fullResourceFullName = GetFullName(assembly, fullResourceShortName);
			return GetResourceByFullName(assembly, fullResourceFullName);
		}

		public Stream GetResourceByFullName(Assembly assembly, string fullResourceFullName)
		{
			return assembly.GetManifestResourceStream(fullResourceFullName);
		}
	}
}
