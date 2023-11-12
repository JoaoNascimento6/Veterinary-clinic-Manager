using System;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VETcuida());
        }
    }
}
