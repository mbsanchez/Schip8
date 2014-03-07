using System;
using System.Windows.Forms;

namespace Schip
{
    class Programa
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SuperChip8View());
        }
    }
}
