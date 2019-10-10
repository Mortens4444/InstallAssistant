using System;
using System.Windows.Forms;
using Enums;
using MessageBoxes;
using Mtf.Languages;

namespace ProductInstaller
{
	public static class ExitIntent
	{
		public static void Check()
		{
			BaseBox.Yes = Lng.Elem("Yes");
			BaseBox.No = Lng.Elem("No");
			if (ConfirmBox.Show(Lng.Elem("Confirmation"), Lng.Elem("Are you sure you want to exit? This will interrupt the setup progress."), Decide.No) == DialogResult.Yes)
			{
				Environment.Exit(1);
			}
		}
	}
}
