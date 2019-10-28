using System.Windows;
using System.Windows.Media;

namespace ProductInstallerWpf
{
	public class DarkInstaller
	{
		public CornerRadius TopCorners => new CornerRadius(5, 5, 0, 0);

		public CornerRadius AllCorners => new CornerRadius(5, 5, 5, 5);

		public SolidColorBrush BackgroundColor => new SolidColorBrush(Colors.Black);

		public SolidColorBrush TitleColor => new SolidColorBrush(Colors.DarkSlateGray);

		public SolidColorBrush ContentBackColor => new SolidColorBrush(Colors.SlateGray);

		public SolidColorBrush FontColor => new SolidColorBrush(Colors.White);

		public SolidColorBrush InverseFontColor => new SolidColorBrush(Colors.Black);

		public SolidColorBrush ButtonBackgroundColor => new SolidColorBrush(Colors.DarkGray);

		public SolidColorBrush DisabledButtonBackgroundColor => new SolidColorBrush(Colors.Gray);

		public SolidColorBrush DisabledButtonForegroundColor => new SolidColorBrush(Colors.LightGray);

	}
}
