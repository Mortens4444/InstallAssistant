using System.Reflection;
using System.Windows.Forms;
using InstallAssistant.Utils;
using InstallAssistant;
using System.IO;
using System.Drawing.Printing;
using System;
using System.Drawing;

namespace ProductInstaller._3
{
	public partial class LicenseAgreementForm : Form
	{
		private readonly ResourceProvider resourceProvider = new ResourceProvider();

		public LicenseAgreementForm()
		{
			InitializeComponent();
			Lng.Translate(this);
			Text = Text.Replace(InstallerConstants.InstallerTitle, InstallerProperties.InstallerTitle);

			var assembly = Assembly.GetCallingAssembly();
			var licenseFileStream = resourceProvider.GetResourceByShortName(assembly, "LicenseAgreement.rtf");
			RtbLicenseAgreement.LoadFile(licenseFileStream, RichTextBoxStreamType.RichText);
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}

		private void BtnPrint_Click(object sender, EventArgs e)
		{
			printDialog.Document = new PrintDocument();
			printDialog.Document.PrintPage += Document_PrintPage;
			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				printDialog.Document.Print();
			}
		}

		private void Document_PrintPage(object sender, PrintPageEventArgs e)
		{
			var reader = new StringReader(RtbLicenseAgreement.Text);
			var count = 0;
			var printFont = RtbLicenseAgreement.Font;

			using (var printBrush = new SolidBrush(Color.Black))
			{
				var linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

				string line = null;
				while (count < linesPerPage && ((line = reader.ReadLine()) != null))
				{
					var y = e.MarginBounds.Top + (count * printFont.GetHeight(e.Graphics));
					e.Graphics.DrawString(line, printFont, printBrush, e.MarginBounds.Left, y, new StringFormat());
					count++;
				}

				e.HasMorePages = line != null;
			}
		}

		private void ChkAcceptTerms_CheckedChanged(object sender, EventArgs e)
		{
			BtnNext.Enabled = ChkAcceptTerms.Checked;
		}

		private void LicenseAgreementForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK && DialogResult != DialogResult.No && DialogResult != DialogResult.None)
			{
				e.Cancel = true;
				ExitIntent.Check();
			}
		}
	}
}
