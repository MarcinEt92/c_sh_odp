using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_01_01_Delegates_WF
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // C#1.0
            //button.Click += new EventHandler(LogPlainEvent);
            //button.KeyPress += new KeyPressEventHandler(LogKeyEvent);
            //button.MouseClick += new MouseEventHandler(LogMouseEvent);

            Application.Run(new Form1());
        }
    }
}
