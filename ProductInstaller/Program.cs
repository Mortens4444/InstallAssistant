using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstallAssistant;
using InstallAssistant.Utils;
using ProductInstaller._1;
using ProductInstaller._2;
using ProductInstaller._3;
using ProductInstaller._4;
using ProductInstaller._5;
using ProductInstaller._6;
using ProductInstaller._7;

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
			new ExceptionCatcher(InstallerConstants.InstallerLogSubPath, true, true, true);
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
				var installSequence = InstallSequenceBuilder.Get();
				var prerequisitesForm = new PrerequisitesForm(installSequence.Installers);

				if (!prerequisitesForm.IsDisposed)
				{
					if ((dialogResult = prerequisitesForm.ShowDialog()) == DialogResult.No)
					{
						goto LanguageSelection;
					}

					if (dialogResult == DialogResult.OK)
					{
						foreach (var prerequisite in prerequisitesForm.Prerequisites)
						{
							prerequisite.Start();
						}
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

					    goto LanguageSelection;
					}

					if (dialogResult == DialogResult.OK)
					{
						LicenseAgreement:
						var licenseAgreementForm = new LicenseAgreementForm();
						if ((dialogResult = licenseAgreementForm.ShowDialog()) == DialogResult.No)
						{
							goto Welcome;
						}

						if (dialogResult == DialogResult.OK)
						{
							SelectComponents:
							var selectComponentsForm = new SelectComponentsForm(installSequence.Installers, installSequence.InstallerGroups);
							if ((dialogResult = selectComponentsForm.ShowDialog()) == DialogResult.No)
							{
								goto LicenseAgreement;
							}

							if (dialogResult == DialogResult.OK)
							{
								var startInstallForm = new StartInstallForm();
								if ((dialogResult = startInstallForm.ShowDialog()) == DialogResult.No)
								{
									goto SelectComponents;
								}

								if (dialogResult == DialogResult.OK)
								{
									var installationProgressForm = new InstallationProgressForm();

									Task.Factory.StartNew(() =>
									{
										SelectComponentsForm.InstallSequence.ExecuteEnabledInstallers();
									    installationProgressForm.Invoke(new Action(() => { installationProgressForm.Close(); }));
									});
									installationProgressForm.ShowDialog();

								    var installationFinishedForm = new InstallationFinishedForm();
								    installationFinishedForm.ShowDialog();
                                }
                            }
						}
					}
				}
		    }
		}
	}
}
