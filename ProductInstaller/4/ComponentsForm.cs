using System.Windows.Forms;
using InstallAssistant;
using Mtf.Languages;
using Mtf.Languages.Utils;

namespace ProductInstaller
{
	public partial class ComponentsForm : Form
    {
        public static InstallSequence InstallSequence;
        
        private readonly UserInterfaceBuilder userInterfaceBuilder = new UserInterfaceBuilder();

        public ComponentsForm()
        {
            InitializeComponent();
            var installSequence = InstallSequenceBuilder.Get();
            InstallSequence = installSequence.Installers;
            foreach (var group in installSequence.InstallerGroups)
            {
                ComboBox.Items.Add(group);
            }
			ComboBox.SelectedIndex = 0;

			Lng.Translate(this);
		}

        private void MainForm_Load(object sender, System.EventArgs e)
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
    }
}
