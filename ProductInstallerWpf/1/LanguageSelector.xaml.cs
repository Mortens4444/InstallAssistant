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
		private bool mouseClicked = false;
		private Point lastMousePosition = new Point();

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
			ViewModel.Label = "Next";
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
			mouseClicked = true;
			lastMousePosition = e.GetPosition(this);
			lastMousePosition.Y = Convert.ToInt16(this.Top) + lastMousePosition.Y;
			lastMousePosition.X = Convert.ToInt16(this.Left) + lastMousePosition.X;
		}

		private void Window_MouseUp(object sender, MouseButtonEventArgs e)
		{
			mouseClicked = false;
		}

		private void Window_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseClicked)
			{
				var MousePosition = e.GetPosition(this);
				var MousePositionAbs = new Point
				{
					X = Convert.ToInt16(Left) + MousePosition.X,
					Y = Convert.ToInt16(Top) + MousePosition.Y
				};
				Left += MousePositionAbs.X - lastMousePosition.X;
				Top += MousePositionAbs.Y - lastMousePosition.Y;
				lastMousePosition = MousePositionAbs;
			}
		}
	}
}
