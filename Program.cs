using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_Ice_Task_3_ST10072500_Priya
{
    public static class Program
    {
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


// References
// https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
// https://stackoverflow.com/questions/9725510/how-to-store-data-in-a-net-windows-application
// https://stackoverflow.com/questions/42021980/how-to-update-form-after-it-has-started
