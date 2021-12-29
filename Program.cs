using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDNS_Updater
{
    static class Program
    {
        public static string externIP = string.Empty;
        public static string UpdUsrName = string.Empty;
        public static string UpdPWord = string.Empty;
        public static string URI = string.Empty;
        public static string AuthString = string.Empty;
        public static int Intervalsec = 0;
        public static int Intervalms = 0;
        public static int count = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
