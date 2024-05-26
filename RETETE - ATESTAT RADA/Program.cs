using System;
using System.Windows.Forms;

namespace RETETE__ATESTAT_RADA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Asigurați-vă că `Form1` este în spațiul de nume corect
        }
    }
}
