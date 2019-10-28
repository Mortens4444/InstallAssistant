using System.Windows;
using System.Windows.Media;

namespace ProductInstallerWpf
{
	public class BrightInstaller
	{
		public CornerRadius TopCorners => new CornerRadius(5, 5, 0, 0);

		public CornerRadius AllCorners => new CornerRadius(5, 5, 5, 5);

		public SolidColorBrush BackgroundColor => new SolidColorBrush(Colors.Silver);

		public SolidColorBrush TitleColor => new SolidColorBrush(Colors.SlateGray);

		public SolidColorBrush ContentBackColor => new SolidColorBrush(Colors.LightBlue);

		public SolidColorBrush FontColor => new SolidColorBrush(Colors.Black);

		public SolidColorBrush InverseFontColor => new SolidColorBrush(Colors.White);

		public SolidColorBrush ButtonBackgroundColor => new SolidColorBrush(Colors.LightGray);

		public SolidColorBrush DisabledButtonBackgroundColor => new SolidColorBrush(Colors.Gray);

		public SolidColorBrush DisabledButtonForegroundColor => new SolidColorBrush(Colors.DarkGray);
	}
}
