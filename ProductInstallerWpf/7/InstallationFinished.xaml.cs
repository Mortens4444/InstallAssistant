using System.Windows;
using System.Windows.Input;
using InstallAssistant;

namespace ProductInstallerWpf
{
	/// <summary>
	/// Interaction logic for InstallationFinished.xaml
	/// </summary>
	public partial class InstallationFinished : Window
	{
		public InstallationFinished(object installerViewModel)
		{
			InitializeComponent();
			DataContext = installerViewModel;

			//Lng.Translate(this);
		}

		private void Finish_Click(object sender, RoutedEventArgs e)
		{
			Close();
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
