using System.Windows.Forms;
using Mtf.Languages;

namespace ProductInstaller._3
{
	public partial class LicenseAgreementForm : Form
	{
		public LicenseAgreementForm()
		{
			InitializeComponent();
			Lng.Translate(this);

			RtbLicenseAgreement.LoadFile(@".\LicenseAgreement.rtf");
		}

		private void BtnCancel_Click(object sender, System.EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
