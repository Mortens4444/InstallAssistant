using System;
using System.Collections.Generic;
using System.Linq;
using InstallAssistant.InstallSource;
using InstallAssistant.Utils;
using MessageBoxes;

namespace InstallAssistant
{
	public class InstallSequence : List<Installer>
    {
        public void ExecuteEnabledInstallers()
        {
            foreach (var installer in this.Where(installer => installer.Enabled))
            {
				try
				{
	                installer.Start();
				}
				catch (Exception ex)
				{
				    var fileLogger = new FileLogger($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{InstallerConstants.InstallerLogSubPath}");
                    fileLogger.Log(ex);

                    ErrorBox.Show(ex);
				}
            }
        }
    }
}
