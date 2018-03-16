using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;

namespace ClassAssignment {
    public partial class Pig_Game_Form : Form {
        /// <summary>
        /// Initialize the Pig Game Form.
        /// </summary>
        public Pig_Game_Form() {
            InitializeComponent();
            Pig_Single_Die_Game.SetUpGame();
            pigLabelWhosTurnTo.Text = Pig_Single_Die_Game.GetFirstPlayersName();
            Pig_rollOrHoldLabel.Text = "Roll die";
            holdButton.Enabled = false;
        }
        /// <summary>
        /// Reset the form for a new game.
        /// </summary>
        private void Reset() {
            playerOneTextBox.Text = (0).ToString();
            playerTwoTextBox.Text = (0).ToString();
            pigLabelWhosTurnTo.Text = Pig_Single_Die_Game.GetNextPlayersName();
            yesAnotherGameRadioButton.Checked = false;
            anotherGameGroupBox.Enabled = false;
            rollButton.Enabled = true;
        }
        /// <summary>
        /// Render the die images.
        /// </summary>
        private void renderImage() {
            pigPictureBox.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());
            pigPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        /// <summary>
        /// Call the PlayGame function and determine the outcome of the round. Allow another turn if player did not roll a 1 or call the next player if player did roll a 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollButton_Click(object sender, EventArgs e) {
            int points = Pig_Single_Die_Game.GetPointsTotal(pigLabelWhosTurnTo.Text);
            if (!Pig_Single_Die_Game.PlayGame()) {
                SetupRound();
                CountPoints();
            } else {
                SetupRound();
                UpdatePoints(points);
                Program.showOKMessageBox("Sorry, you've thrown a 1.\nYour turn is over.\nYour score reverts to " + points + ".");
                pigLabelWhosTurnTo.Text = Pig_Single_Die_Game.GetNextPlayersName();
            }

            if (Pig_Single_Die_Game.HasWon()) {
                WonGame();
            }

        }
        /// <summary>
        /// Count the points in real time as player rolls the die.
        /// </summary>
        private void CountPoints() {
            if (pigLabelWhosTurnTo.Text == "Player 1") {
                playerOneTextBox.Text = (Int32.Parse(playerOneTextBox.Text) + Pig_Single_Die_Game.GetFaceValue()).ToString();
            } else {
                playerTwoTextBox.Text = (Int32.Parse(playerTwoTextBox.Text) + Pig_Single_Die_Game.GetFaceValue()).ToString();
            }
        }
        /// <summary>
        /// Update the player points.
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        private string UpdatePoints(int points) {
            string stringPoints = (points).ToString();
            if (pigLabelWhosTurnTo.Text == "Player 1") {
                playerOneTextBox.Text = stringPoints;
                return stringPoints;
            } else {
                playerTwoTextBox.Text = stringPoints;
                return stringPoints;
            }
        }
        /// <summary>
        /// Get ready for the upcoming round.
        /// </summary>
        private void SetupRound() {
            renderImage();
            Pig_rollOrHoldLabel.Text = "Roll or Hold";
            holdButton.Enabled = true;
        }
        /// <summary>
        /// Performs necessary functions if player has won the game.
        /// </summary>
        private void WonGame() {
            Program.showOKMessageBox(pigLabelWhosTurnTo.Text + " has won!\nWell done.");
            rollButton.Enabled = false;
            holdButton.Enabled = false;
            anotherGameGroupBox.Enabled = true;
        }
        /// <summary>
        /// On player hold, continue the game as the next player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void holdButton_Click(object sender, EventArgs e) {
            Pig_rollOrHoldLabel.Text = "Roll die";
            holdButton.Enabled = false;
            pigLabelWhosTurnTo.Text = Pig_Single_Die_Game.GetNextPlayersName();
        }
        /// <summary>
        /// Determine if the user would like to play another game or not, and if not close the window. If so, call the function to setup a new match.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anotherGameRadioButton_Click(object sender, EventArgs e) {
            if(yesAnotherGameRadioButton.Checked) {
                Reset();
            } else if (noAnotherGameRadioButton.Checked) {
                this.Close();
            }
        }
    }
}
