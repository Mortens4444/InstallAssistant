using System;
using System.Windows.Forms;
using InstallAssistant;

namespace ProductInstaller._5
{
	public partial class StartInstallForm : Form
	{
		public StartInstallForm()
		{
			InitializeComponent();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
