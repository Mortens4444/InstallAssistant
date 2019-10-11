using System;
using System.Windows.Forms;
using InstallAssistant;
using InstallAssistant.Utils;

namespace ProductInstaller._1
{
	public partial class LanguageSelectorForm : Form
	{
		public LanguageSelectorForm()
		{
			InitializeComponent();

			var languages = Enum.GetValues(typeof(Language));
			foreach (var language in languages)
			{
				LvLanguages.Items.Add(new ListViewItem(language.ToString()));
			}

		    LblWelcome.Text = LblWelcome.Text.Replace("{0}", InstallerProperties.ProductName);
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
	}
}
