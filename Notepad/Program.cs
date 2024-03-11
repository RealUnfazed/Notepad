using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists("AlirezaPlus.dll")) { MessageBox.Show("Necessary file 'AlirezaPlus.dll' missing! Try reinstalling software!", "MODULE NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Notepad());
        }
    }
}
