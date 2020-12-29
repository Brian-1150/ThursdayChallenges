using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
           
            Console.SetWindowSize(50, 5);
            Console.SetWindowPosition(44, 3);
            Console.SetCursorPosition(0, 0);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MemoryForm1());
        }
    }
}
