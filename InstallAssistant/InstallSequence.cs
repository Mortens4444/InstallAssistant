using InstallAssistant.InstallSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
					MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				}
            }
        }
    }
}
