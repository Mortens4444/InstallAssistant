using System.Windows;
using System.Windows.Input;
using InstallAssistant;

namespace ProductInstallerWpf
{
	/// <summary>
	/// Interaction logic for StartInstall.xaml
	/// </summary>
	public partial class StartInstall : Window
	{
		public StartInstall(object installerViewModel)
		{
			InitializeComponent();
			DataContext = installerViewModel;

			//Lng.Translate(this);
		}

		private void Install_Click(object sender, RoutedEventArgs e)
		{
			var installationProgress = new InstallationProgress(DataContext);
			installationProgress.Show();
			Close();
		}

		private void Cancel_Click(object sender, RoutedEventArgs e)
		{
			ExitIntent.Check();
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
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
