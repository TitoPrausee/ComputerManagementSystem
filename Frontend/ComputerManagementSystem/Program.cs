﻿using System;
using System.Windows.Forms;
using ComputerManagementSystem; // Füge den Namespace hinzu

namespace ComputerManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new homeStatus());
        }
    }
}