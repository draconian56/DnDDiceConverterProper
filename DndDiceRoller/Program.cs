using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndDiceRoller {
    static class Program {
        /// <summary>
        /// This is a dice roller for the game Dungeons and Dragons
        /// and it is my aim to offer a number of features that
        /// make it a useful tool for DnD player.
        /// 
        /// Aydan Hardidge 
        /// May 2017
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
