using System;
using System.Collections.Generic;
using VirtualContacts;

namespace VirtialContacts
{

    internal static class Program
    {
        internal static MainForm mainForm = new MainForm();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(mainForm);
        }   
    }
}
