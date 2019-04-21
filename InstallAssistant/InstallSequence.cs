using InstallAssistant.InstallSource;
using System.Collections.Generic;
using System.Linq;

namespace InstallAssistant
{
    public class InstallSequence : List<Installer>
    {
        public void ExecuteEnabledInstallers()
        {
            foreach (var installer in this.Where(installer => installer.Enabled))
            {
                installer.Start();
            }
        }
    }
}
