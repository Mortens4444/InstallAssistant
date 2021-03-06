﻿using System.Windows;
using System.Windows.Input;
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

		private void Next_Click(object sender, RoutedEventArgs e)
		{
			var licenseAgreement = new LicenseAgreement(DataContext);
			licenseAgreement.Show();
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
