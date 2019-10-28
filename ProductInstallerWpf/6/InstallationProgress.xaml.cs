using System.Windows;
using System.Windows.Input;
using InstallAssistant;

namespace ProductInstallerWpf
{
	/// <summary>
	/// Interaction logic for InstallationProgress.xaml
	/// </summary>
	public partial class InstallationProgress : Window
	{
		public InstallationProgress(object installerViewModel)
		{
			InitializeComponent();
			DataContext = installerViewModel;

			//Lng.Translate(this);
		}

		private void Next_Click(object sender, RoutedEventArgs e)
		{
			//var selectComponents = new SelectComponents(DataContext);
			//selectComponents.Show();
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
