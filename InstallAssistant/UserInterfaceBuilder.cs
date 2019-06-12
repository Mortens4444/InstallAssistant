using InstallAssistant.InstallSource;
using System.Drawing;
using System.Windows.Forms;

namespace InstallAssistant
{
    class UserInterfaceBuilder
    {
        public void CreateUserInterface(TableLayoutPanel layoutPanel, InstallSequence installers)
        {
            layoutPanel.RowCount = installers.Count;
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            layoutPanel.Padding = new Padding(0, 0, vertScrollWidth, 0);

            int rowIndex = 0;
            foreach (var installer in installers)
            {
                var checkBox = new CheckBox
                {
                    Tag = installer,
                    Checked = installer.Enabled,
                    Text = installer.Name,
                    TextAlign = ContentAlignment.MiddleLeft,
					Width = 200
                };
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                layoutPanel.Controls.Add(checkBox, 0, rowIndex++);
                layoutPanel.RowStyles.Add(new RowStyle());
            }
            layoutPanel.Controls.Add(new Label(), 0, rowIndex);
        }

        private void CheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            var checkBox = sender as CheckBox;
            var installer = checkBox.Tag as Installer;
            installer.Enabled = checkBox.Checked;
        }
    }
}
