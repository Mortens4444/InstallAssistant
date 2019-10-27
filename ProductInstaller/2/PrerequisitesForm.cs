using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InstallAssistant;
using InstallAssistant.InstallSource;

namespace ProductInstaller._2
{
	public partial class PrerequisitesForm : Form
	{
		public IEnumerable<Installer> Prerequisites { get; private set; }

		public PrerequisitesForm(InstallSequence installers)
		{
			Prerequisites = installers.Where(installer => installer.Enabled && installer.InstallerType == InstallerType.Prerequisite);
			if (!Prerequisites.Any())
			{
				DialogResult = DialogResult.OK;
				Close();
			}

			InitializeComponent();
			
			foreach (var prerequisite in Prerequisites)
			{
				LvPrerequisites.Items.Add(new ListViewItem(prerequisite.ToString()));
			}

			Lng.Translate(this);
			Text = Text.Replace(InstallerConstants.InstallerTitle, InstallerProperties.InstallerTitle);
			LblWelcome.Text = LblWelcome.Text.Replace(InstallerConstants.ProductName, InstallerProperties.ProductName);
			LblChooseLanguage.Text = LblChooseLanguage.Text.Replace(InstallerConstants.ProductName, InstallerProperties.ProductName);
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}

		private void PrerequisitesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK && DialogResult != DialogResult.No && DialogResult != DialogResult.None)
			{
				e.Cancel = true;
				ExitIntent.Check();
			}
		}
	}
}
