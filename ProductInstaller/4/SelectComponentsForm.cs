using System.Collections.Generic;
using System.Windows.Forms;
using InstallAssistant;
using InstallAssistant.Utils;

namespace ProductInstaller._4
{
	public partial class SelectComponentsForm : Form
    {
        public static InstallSequence InstallSequence;
        
        private readonly UserInterfaceBuilder userInterfaceBuilder = new UserInterfaceBuilder();

        public SelectComponentsForm(InstallSequence installSequence, HashSet<string> installerGroups)
        {
            InitializeComponent();

			InstallSequence = installSequence;
            foreach (var group in installerGroups)
            {
                ComboBox.Items.Add(group);
            }

			Lng.Translate(this);
			Text = Text.Replace(Constants.InstallerTitle, InstallerProperties.InstallerTitle);
			ComboBox.SelectedIndex = 0;
		}

        private void SelectComponentsForm_Load(object sender, System.EventArgs e)
        {
            userInterfaceBuilder.CreateUserInterface(LayoutPanel, InstallSequence);
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
			ExitIntent.Check();
		}

        private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            InstallationStrategy.SelectInstallers(Lng.Elem(Language.English, ComboBox.SelectedItem.ToString()), LayoutPanel.Controls);
        }

		private void SelectComponentsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK && DialogResult != DialogResult.No && DialogResult != DialogResult.None)
			{
				e.Cancel = true;
				ExitIntent.Check();
			}
		}
	}
}
