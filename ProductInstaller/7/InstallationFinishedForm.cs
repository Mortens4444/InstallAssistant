using System;
using System.Windows.Forms;
using InstallAssistant;

namespace ProductInstaller._7
{
	public partial class InstallationFinishedForm : Form
	{
		public InstallationFinishedForm()
		{
			InitializeComponent();
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
