using System.Windows;
using InstallAssistant;

namespace ProductInstallerWpf
{
	/// <summary>
	/// Interaction logic for Prerequisites.xaml
	/// </summary>
	public partial class Prerequisites : Window
	{
		public Prerequisites(object installerViewModel)
		{
			InitializeComponent();
			DataContext = installerViewModel;

			//Lng.Translate(this);
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			((InstallerViewModel)DataContext).Label = "Yes2";
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			((InstallerViewModel)DataContext).Label = "No2";
		}
	}
}
