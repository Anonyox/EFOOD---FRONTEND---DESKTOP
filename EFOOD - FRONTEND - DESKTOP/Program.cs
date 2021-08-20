using EFOOD___FRONTEND___DESKTOP.Models.Login_Module.visions;
using System;
using System.Windows.Forms;

namespace EFOOD___FRONTEND___DESKTOP
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new logar_vision());
        }
    }
}
