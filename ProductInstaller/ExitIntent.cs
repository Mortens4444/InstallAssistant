using System;
using System.Windows.Forms;
using Mtf.Languages;

namespace ProductInstaller
{
	public static class ExitIntent
	{
		public static void Check()
		{
			if (ConfirmBox.Show(Lng.Elem("Are you sure you want to exit? This will interrupt the setup progress.")) == DialogResult.Yes)
			{
				Environment.Exit(1);
			}
		}
	}
}
