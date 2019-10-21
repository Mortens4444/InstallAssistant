using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using InstallAssistant;
using InstallAssistant.Utils;
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
		static void Main(string[] args)
		{
			new ExceptionCatcher(Assembly.GetExecutingAssembly().GetName().Name, true, true, true);
#if !DEBUG
			UAC.Elevate();
#endif
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

		    LanguageSelection:
			var languageSelectorForm = new LanguageSelectorForm();
		    if (languageSelectorForm.ShowDialog() == DialogResult.OK)
		    {
				DialogResult dialogResult;

				Prerequisites:
				var settingsFile = args == null || args.Length == 0 ? "settings.json" : args[0];
				var installSequence = InstallSequenceBuilder.Get(settingsFile);
				var prerequisitesForm = new PrerequisitesForm(installSequence.Installers);

				if (!prerequisitesForm.IsDisposed)
				{
					if ((dialogResult = prerequisitesForm.ShowDialog()) == DialogResult.No)
					{
						goto LanguageSelection;
					}
				}
				else
				{
					dialogResult = prerequisitesForm.DialogResult;
				}

				if (dialogResult == DialogResult.OK)
				{
					Welcome:
					var welcomeForm = new WelcomeForm();
					if ((dialogResult = welcomeForm.ShowDialog()) == DialogResult.No)
					{
						if (!prerequisitesForm.IsDisposed)
						{
							goto Prerequisites;
						}
						else
						{
							goto LanguageSelection;
						}
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
							var componentsForm = new SelectComponentsForm(installSequence.Installers, installSequence.InstallerGroups);
							if (componentsForm.ShowDialog() == DialogResult.OK)
							{
								SelectComponentsForm.InstallSequence.ExecuteEnabledInstallers();
							}
						}
					}
				}
		    }
		}
	}
}
