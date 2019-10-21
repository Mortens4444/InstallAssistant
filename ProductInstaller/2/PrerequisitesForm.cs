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
		public PrerequisitesForm(InstallSequence installers)
		{
			var prerequisites = installers.Where(installer => installer.Enabled && installer.InstallerType == InstallerType.Prerequisite);
			if (!prerequisites.Any())
			{
				DialogResult = DialogResult.OK;
				Close();
			}

			InitializeComponent();
			
			foreach (var prerequisite in prerequisites)
			{
				LvPrerequisites.Items.Add(new ListViewItem(prerequisite.ToString()));
			}

			Lng.Translate(this);
			Text = Text.Replace(Constants.InstallerTitle, InstallerProperties.InstallerTitle);
			LblWelcome.Text = LblWelcome.Text.Replace(Constants.ProductName, InstallerProperties.ProductName);
			LblChooseLanguage.Text = LblChooseLanguage.Text.Replace(Constants.ProductName, InstallerProperties.ProductName);
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
