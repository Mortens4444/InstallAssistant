using System;
using System.Windows.Forms;
using InstallAssistant;
using InstallAssistant.Utils;

namespace ProductInstaller._1
{
	public sealed partial class LanguageSelectorForm : Form
	{
		public LanguageSelectorForm()
		{
			InitializeComponent();

			var languages = Enum.GetValues(typeof(Language));
			foreach (var language in languages)
			{
				LvLanguages.Items.Add(new ListViewItem(language.ToString()));
			}

		    Text = Text.Replace(Constants.InstallerTitle, InstallerProperties.InstallerTitle);
			LblWelcome.Text = LblWelcome.Text.Replace(Constants.ProductName, InstallerProperties.ProductName);
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}

		private void LvLanguages_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectLanguage();
		}

		private void LvLanguages_DoubleClick(object sender, EventArgs e)
		{
			SelectLanguage();
			BtnNext.PerformClick();
		}

		private void SelectLanguage()
		{
			if (LvLanguages.SelectedItems.Count == 1)
			{
				var language = (Language)Enum.Parse(typeof(Language), LvLanguages.SelectedItems[0].Text, true);
				TranslationCore.Language = language;
			}
		}

		private void LanguageSelectorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK)
			{
				e.Cancel = true;
				ExitIntent.Check();
			}
		}
	}
}
