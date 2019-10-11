using System;
using System.Collections.Generic;
using System.Linq;
using InstallAssistant.InstallSource;
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
					ErrorBox.Show(ex);
				}
            }
        }
    }
}
