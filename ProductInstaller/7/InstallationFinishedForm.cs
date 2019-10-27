using System;
using System.Windows.Forms;
using InstallAssistant;

namespace ProductInstaller._7
{
    public sealed partial class InstallationFinishedForm : Form
	{
		public InstallationFinishedForm()
		{
			InitializeComponent();
		    Lng.Translate(this);
		    Text = Text.Replace(Constants.InstallerTitle, InstallerProperties.InstallerTitle);
		}

        private void BtnExit_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
