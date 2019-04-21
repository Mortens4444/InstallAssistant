﻿using System;
using System.Windows.Forms;

namespace InstallAssistant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            Application.Run(mainForm);

            if (mainForm.DialogResult == DialogResult.OK)
            {
                MainForm.InstallSequence.ExecuteEnabledInstallers();
            }
        }
    }
}
