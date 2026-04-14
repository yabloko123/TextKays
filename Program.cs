using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validator_Vertyachikh
{
    /// <summary>
    /// by ryzenvpn/vertyachikh: служебный класс точки входа, с которого начинается запуск приложения.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// by ryzenvpn/vertyachikh: включает стандартные настройки WinForms и открывает главную форму Form1.
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
