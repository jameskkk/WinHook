using System;
using System.Windows.Forms;

namespace GlobalMouseKeyboardHookDemo
{
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestFormStatic());
            //Application.Run(new TestFormComponent());
        }
    }
}