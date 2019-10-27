using System;
using System.Windows.Forms;
using InstallAssistant;

namespace ProductInstaller._6
{
	public partial class InstallationProgressForm : Form
	{
		public InstallationProgressForm()
		{
			InitializeComponent();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
