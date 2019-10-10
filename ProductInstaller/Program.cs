using System;
using System.Windows.Forms;
using ProductInstaller._1;
using ProductInstaller._2;
using ProductInstaller._3;

namespace ProductInstaller
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			LanguageSelection:
			var languageSelectorForm = new LanguageSelectorForm();
			languageSelectorForm.ShowDialog();

			Welcome:
			var welcomeForm = new WelcomeForm();
			if (welcomeForm.ShowDialog() == DialogResult.No)
			{
				goto LanguageSelection;
			}

			var licenseAgreementForm = new LicenseAgreementForm();
			if (licenseAgreementForm.ShowDialog() == DialogResult.No)
			{
				goto Welcome;
			}

			var componentsForm = new ComponentsForm();
			if (componentsForm.ShowDialog() == DialogResult.OK)
			{
				ComponentsForm.InstallSequence.ExecuteEnabledInstallers();
			}
		}
	}
}
