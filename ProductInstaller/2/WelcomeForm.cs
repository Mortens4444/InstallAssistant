using System.Windows.Forms;
using InstallAssistant;

namespace ProductInstaller._2
{
	public partial class WelcomeForm : Form
	{
		public WelcomeForm()
		{
			InitializeComponent();
			Lng.Translate(this);
			Text = Text.Replace(Constants.InstallerTitle, InstallerProperties.InstallerTitle);
		}

		private void BtnCancel_Click(object sender, System.EventArgs e)
		{
			ExitIntent.Check();
		}

		private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK && DialogResult != DialogResult.No && DialogResult != DialogResult.None)
			{
				e.Cancel = true;
				ExitIntent.Check();
			}
		}
	}
}
