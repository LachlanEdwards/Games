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
    public partial class Which_Dice_Game : Form {
        public Which_Dice_Game() {
            InitializeComponent();
        }

        private void DiceGames_Load(object sender, EventArgs e) {

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
        /// Determine which Dice Game the user wants to play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_Click(object sender, EventArgs e) {
            if(singleDiePigRadioButton.Checked) {
                Pig_Game_Form pigGameForm = new Pig_Game_Form();
                pigGameForm.Show();
            } else if (twoDicePigRadioButton.Checked) {
                Pig_with_Two_Dice_Form pigWithTwoDiceForm = new Pig_with_Two_Dice_Form();
                pigWithTwoDiceForm.Show();
            }
        }
    }
}
