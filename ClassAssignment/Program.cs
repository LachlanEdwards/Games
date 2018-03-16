using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignment {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new GamesForm());
        }
        /// <summary>
        /// DRY way to call a yesNoMessageBox.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        /// <returns></returns>
        public static DialogResult showYesNoMessageBox(string message, string caption) {
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }
        /// <summary>
        /// DRY way to call a OKMessageBox 
        /// </summary>
        /// <param name="message"></param>
        public static void showOKMessageBox(string message) {
            DialogResult result = MessageBox.Show(message, null, MessageBoxButtons.OK);
        }
    }
}
