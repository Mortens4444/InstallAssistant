using System.Windows.Forms;
using Mtf.Languages;

namespace ProductInstaller
{
	public static class ConfirmBox
	{
		public static DialogResult Show(string message)
		{
			return Show(Lng.Elem("Confirmation"), message);
		}

		public static DialogResult Show(string title, string message)
		{
			return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
		}
	}
}
