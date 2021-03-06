﻿using System;
using System.Windows.Forms;
using InstallAssistant;

namespace ProductInstaller._5
{
    public sealed partial class StartInstallForm : Form
	{
		public StartInstallForm()
		{
			InitializeComponent();
		    Lng.Translate(this);
            Text = Text.Replace(InstallerConstants.InstallerTitle, InstallerProperties.InstallerTitle);
        }

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			ExitIntent.Check();
		}
	}
}
