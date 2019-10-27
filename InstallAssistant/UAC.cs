using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;
using MessageBoxes;

namespace InstallAssistant
{
	public static class UAC
	{
		public static void Elevate()
		{
			var pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
			bool isInAdministratorRole = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
			if (!isInAdministratorRole)
			{
				var startInfo = new ProcessStartInfo
				{
					UseShellExecute = true,
					WorkingDirectory = Environment.CurrentDirectory,
					FileName = Application.ExecutablePath,
					Verb = "runas"
				};
				try
				{
					Process.Start(startInfo);
				}
				catch (Win32Exception ex)
				{
					ErrorBox.Show(ex);
				}
				finally
				{
					Environment.Exit(0);
				}
			}
		}
	}
}
