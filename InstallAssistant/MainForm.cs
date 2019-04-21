using InstallAssistant.InstallSource;
using System.IO;
using System.Windows.Forms;

namespace InstallAssistant
{
    public partial class MainForm : Form
    {
        public static InstallSequence InstallSequence;
        
        private readonly UserInterfaceBuilder userInterfaceBuilder = new UserInterfaceBuilder();

        public MainForm()
        {
            InitializeComponent();
            var installSequence = InstallSequenceBuilder.Get();
            InstallSequence = installSequence.Installers;
            foreach (var group in installSequence.InstallerGroups)
            {
                ComboBox.Items.Add(group);
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            userInterfaceBuilder.CreateUserInterface(LayoutPanel, InstallSequence);
        }

        private void Close(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            InstallationStrategy.SelectInstallers(ComboBox.SelectedItem.ToString(), LayoutPanel.Controls);
        }
    }
}
