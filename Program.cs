using System;
using System.Windows.Forms;

namespace Stend_cnt
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());//FormBackgroundWorker
                                         Application.Run(new FormBackgroundWorker());//
           //  Application.Run(new FormSerialPort());// FormSerialPort
        }
    }
}
