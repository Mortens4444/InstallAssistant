using System;
using System.Windows;
using System.Windows.Input;
using InstallAssistant;
using InstallAssistant.Utils;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace ProductInstallerWpf
{
	/// <summary>
	/// Interaction logic for LanguageSelector.xaml
	/// </summary>
	public partial class LanguageSelector : Window
	{
		public LanguageSelector()
		{
			InitializeComponent();

			var languages = Enum.GetValues(typeof(Language));
			foreach (var language in languages)
			{
				LvLanguages.Items.Add(new ListViewItem(language.ToString()));
			}

			WindowTitle.Text = WindowTitle.Text.TrimStart().Replace(InstallerConstants.InstallerTitle, InstallerProperties.InstallerTitle);
			LblWelcome.Text = LblWelcome.Text.Replace(InstallerConstants.ProductName, InstallerProperties.ProductName);
		}

		public LanguageSelector(object installerViewModel)
		{
			InitializeComponent();
			DataContext = installerViewModel;
		}

		public InstallerViewModel ViewModel => (InstallerViewModel)DataContext;

		private void Next_Click(object sender, RoutedEventArgs e)
		{
			var prerequisites = new Prerequisites(DataContext);
			prerequisites.Show();
			Close();
		}

		private void Cancel_Click(object sender, RoutedEventArgs e)
		{
			ExitIntent.Check();
		}

		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				DragMove();
			}
		}
	}
}
