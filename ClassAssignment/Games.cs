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
    public partial class GamesForm : Form {
        /// <summary>
        /// Initialize the Game Form.
        /// </summary>
        public GamesForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Determine which option the user has selected, Dice Games or Card Games, and open the corresponding button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e) {
            if (diceGameRadioButton.Checked) {
                ClassAssignment.Which_Dice_Game diceGamesForm = new ClassAssignment.Which_Dice_Game();
                diceGamesForm.Show();
            } else if (cardGameRadioButton.Checked) {
                ClassAssignment.Which_Card_Game cardGamesForm = new ClassAssignment.Which_Card_Game();
                cardGamesForm.Show();
            }
        }
        /// <summary>
        /// Prompt the user to confirm when exiting the window.
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
        /// Enable the start button when a user selects an option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;
        }
    }
}
