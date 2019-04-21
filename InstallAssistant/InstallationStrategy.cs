using InstallAssistant.InstallSource;
using System.Linq;
using System.Windows.Forms;

namespace InstallAssistant
{
    public class InstallationStrategy
    {
        public static void SelectInstallers(string installerGroup, TableLayoutControlCollection controls)
        {
            foreach (var control in controls)
            {
                if (control is CheckBox checkBox)
                {
                    var installer = checkBox.Tag as Installer;
                    checkBox.Checked = installer.Groups.Contains(installerGroup);
                }
            }
        }
    }
}
