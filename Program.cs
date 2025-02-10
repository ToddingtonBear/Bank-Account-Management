using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_Management
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
            DialogResult result;
            User loggedInUser = null;
            using (var loginForm = new LoginForm())
            {
                result = loginForm.ShowDialog();
                loggedInUser = loginForm.LoggedInUser;
            }
                
            if (result == DialogResult.OK)
            {
                Application.Run(new MainForm(loggedInUser));
            }

        }
    }
}
