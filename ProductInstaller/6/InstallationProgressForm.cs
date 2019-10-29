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
		    Text = Text.Replace(InstallerConstants.InstallerTitle, InstallerProperties.InstallerTitle);
		    LblPleaseWait.Text = LblPleaseWait.Text.Replace(InstallerConstants.ProductName, InstallerProperties.ProductName);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
