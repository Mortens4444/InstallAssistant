using System.Reflection;
using System.Windows.Forms;
using InstallAssistant.Utils;
using InstallAssistant;

namespace ProductInstaller._3
{
	public partial class LicenseAgreementForm : Form
	{
		private readonly ResourceProvider resourceProvider = new ResourceProvider();

		public LicenseAgreementForm()
		{
			InitializeComponent();
			Lng.Translate(this);

			var assembly = Assembly.GetCallingAssembly();
			var licenseFileStream = resourceProvider.GetResourceByShortName(assembly, "LicenseAgreement.rtf");
			RtbLicenseAgreement.LoadFile(licenseFileStream, RichTextBoxStreamType.RichText);
		}

		private void BtnCancel_Click(object sender, System.EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
