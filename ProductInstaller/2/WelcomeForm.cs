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
		}

		private void BtnCancel_Click(object sender, System.EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
