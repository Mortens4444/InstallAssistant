using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProductInstallerWpf
{
	public class InstallerViewModel : INotifyPropertyChanged
	{
		public InstallerViewModel()
		{
			Label = "H3ll0";
		}

		private string label;
		public string Label
		{
			get => label;
			set
			{
				label = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
