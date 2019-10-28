using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProductInstallerWpf
{
	//public class InstallerViewModel : BrightInstaller, INotifyPropertyChanged
	public class InstallerViewModel : DarkInstaller, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
