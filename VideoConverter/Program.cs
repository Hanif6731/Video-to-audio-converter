using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace VideoConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static MetroThemeStyle apptheme = MetroThemeStyle.Default;
        public static MetroColorStyle appStyle = MetroColorStyle.Default;
       // public static 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
