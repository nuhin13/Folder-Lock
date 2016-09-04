using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Folder_Lock_os_());

            Folder_Lock_os_ f = new Folder_Lock_os_();
            if (args.Length > 0)
                f.pathkey = args[0];
            Application.Run(f);
        }
    }
}
