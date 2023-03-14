using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LoginForm loginForm = new LoginForm();
            ControlForm controlForm = new ControlForm();
            while (true)
            {
                if (controlForm.isSignOut)
                {
                    Application.Run(loginForm);
                }
                if (loginForm.isAllowToAccess)
                {
                    Application.Run(controlForm);
                    controlForm.isSignOut = false;
                }
            }
            
        }
    }
}
