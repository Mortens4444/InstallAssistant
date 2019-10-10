using System;
using System.Windows.Forms;
using ProductInstaller._1;
using ProductInstaller._2;
using ProductInstaller._3;
using ProductInstaller._4;

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
		    if (languageSelectorForm.ShowDialog() == DialogResult.OK)
		    {
		        Welcome:
		        var welcomeForm = new WelcomeForm();
		        DialogResult dialogResult;
		        if ((dialogResult = welcomeForm.ShowDialog()) == DialogResult.No)
		        {
		            goto LanguageSelection;
		        }

		        if (dialogResult == DialogResult.OK)
		        {
		            var licenseAgreementForm = new LicenseAgreementForm();
		            if ((dialogResult = licenseAgreementForm.ShowDialog()) == DialogResult.No)
		            {
		                goto Welcome;
		            }

		            if (dialogResult == DialogResult.OK)
		            {
		                var componentsForm = new ComponentsForm();
		                if (componentsForm.ShowDialog() == DialogResult.OK)
		                {
		                    ComponentsForm.InstallSequence.ExecuteEnabledInstallers();
		                }
		            }
		        }
		    }
		}
	}
}
