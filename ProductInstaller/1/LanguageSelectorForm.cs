using System;
using System.Windows.Forms;
using Mtf.Languages;
using Mtf.Languages.Utils;

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
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}

		private void LvLanguages_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LvLanguages.SelectedItems.Count > 0)
			{
				var language = (Language)Enum.Parse(typeof(Language), LvLanguages.SelectedItems[0].Text, true);
				TranslationCore.Language = language;
			}
		}
	}
}
