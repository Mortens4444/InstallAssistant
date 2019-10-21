using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInstaller._5
{
	public partial class StartInstallForm : Form
	{
		public StartInstallForm()
		{
			InitializeComponent();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
