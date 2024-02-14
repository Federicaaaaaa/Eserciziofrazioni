using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eserciziofrazioni
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Maint()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new addiction());
        }

        static void Main()
        {
            Fraction f1 = new Fraction(5, 3);
            Fraction f2 = new Fraction(5, 3);
            Fraction f3 = null;

            if(f1 == f2)
            {
                Console.WriteLine("SONO UGUALI :))");
            }
            else
                Console.WriteLine("NON SONO UGUALI :((");

            

        }

    }
}
