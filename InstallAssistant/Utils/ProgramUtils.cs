using System;
using System.IO;
using Microsoft.Win32;

namespace InstallAssistant.Utils
{
	public class ProgramUtils
	{
		public bool IsInstalled(string applicationName)
		{
 			string subKeyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
			var registryViews = new RegistryView[] { RegistryView.Registry32, RegistryView.Registry64 };
			var registryHives = new RegistryHive[] { RegistryHive.LocalMachine, RegistryHive.CurrentUser };

			foreach (var registryHive in registryHives)
			{
				foreach (var registryView in registryViews)
				{
					var hklm = RegistryKey.OpenRemoteBaseKey(registryHive, Environment.MachineName, registryView);
					using (var key = hklm.OpenSubKey(subKeyName))
					{
						foreach (var subkeyName in key.GetSubKeyNames())
						{
							using (var subkey = key.OpenSubKey(subkeyName))
							{
								var appName = (string)subkey.GetValue("DisplayName") ?? Path.GetFileName(subkey.Name);
								if (String.Equals(appName, applicationName, StringComparison.InvariantCultureIgnoreCase))
								{
									return true;
								}
							}
						}
					}
				}
			}

			return false;
		}
	}
}
