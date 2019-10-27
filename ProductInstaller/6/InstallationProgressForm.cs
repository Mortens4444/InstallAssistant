using System;
using System.Windows.Forms;
using InstallAssistant;

namespace ProductInstaller._6
{
    public sealed partial class InstallationProgressForm : Form
	{
		public InstallationProgressForm()
		{
			InitializeComponent();
		    Lng.Translate(this);
		    Text = Text.Replace(Constants.InstallerTitle, InstallerProperties.InstallerTitle);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
