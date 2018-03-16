using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignment {
    public partial class Which_Card_Game : Form {
        public Which_Card_Game() {
            InitializeComponent();
        }
        /// <summary>
        /// Prompt the user to confirm they want to close the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e) {
            DialogResult messageBoxResult = ClassAssignment.Program.showYesNoMessageBox("Do you really want to quit?", "Quit?");
            if (messageBoxResult == DialogResult.Yes) {
                Form.ActiveForm.Close();
            }
        }
        /// <summary>
        /// Determine which card game the user wants to play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void whichCardGameComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (whichCardGameComboBox.SelectedIndex == 0) {
                Solitare_Form solitareForm = new Solitare_Form();
                solitareForm.Show();
            } else if (whichCardGameComboBox.SelectedIndex == 1) {
                TwentyOne_Game_Form twentyOneGameForm = new TwentyOne_Game_Form();
                twentyOneGameForm.Show();
            }
        }
    }
}
