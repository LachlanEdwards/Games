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
using Low_Level_Objects_Library;

namespace ClassAssignment {
    public partial class Pig_with_Two_Dice_Form : Form {

        int duration;

        //Reference for the die.
        private string[] dice = new string[2] { "dieOne", "dieTwo" };
        const int POINT_MULTIPLIER = 2;
        
        /// <summary>
        /// Initialize Pig with Two Dice Form
        /// </summary>
        public Pig_with_Two_Dice_Form() {
            InitializeComponent();
            Pig_Double_Die_Game.SetUpGame();
            pigLabelWhosTurnTo.Text = Pig_Double_Die_Game.GetFirstPlayersName();
            Pig_rollOrHoldLabel.Text = "Roll die";
            holdButton.Enabled = false;
        }

        /// <summary>
        /// Reset the game after a match.
        /// </summary>
        private void Reset() {
            playerOneTextBox.Text = (0).ToString();
            playerTwoTextBox.Text = (0).ToString();
            pigLabelWhosTurnTo.Text = Pig_Double_Die_Game.GetNextPlayersName();
            yesAnotherGameRadioButton.Checked = false;
            anotherGameGroupBox.Enabled = false;
            rollButton.Enabled = true;
        }

        /// <summary>
        /// Enable or disable buttons, based on true of false parameter, for the animation.
        /// </summary>
        /// <param name="enabled"></param>
        private void enableButtons(bool enabled) {
            if (enabled) {
                rollButton.Enabled = true;
                holdButton.Enabled = true;
            } else {
                rollButton.Enabled = false;
                holdButton.Enabled = false;
            }
        }

        /// <summary>
        /// Animate dice.
        /// </summary>
        private void animateDice() {
            enableButtons(false);
            duration = 0;
            timer1.Start();
        }

        //Display the dice images
        private void renderImage() {
            PictureBox[] pictureBoxes = new PictureBox[2] {pigPictureBox, pigPictureBox2};
            for (int i = 0; i < dice.Length; i++) {
                pictureBoxes[i].Image = Images.GetDieImage(Pig_Double_Die_Game.GetFaceValue(i));
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// Generate random dice images.
        /// </summary>
        private void randomDiceImages() {
            Random rnd = new Random();
            PictureBox[] pictureBoxes = new PictureBox[2] { pigPictureBox, pigPictureBox2 };
            for (int i = 0; i < dice.Length; i++) {
                int radnomValue = rnd.Next(1, 6);
                pictureBoxes[i].Image = Images.GetDieImage(radnomValue);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

       /// <summary>
       /// Animate dice when user rolls.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void rollButton_Click(object sender, EventArgs e) {
            animateDice();
        }

        /// <summary>
        /// Play the game when the dice animation is clicked and determine the outcome of the round. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playGame() {
            enableButtons(true);
            int points = Pig_Double_Die_Game.GetPointsTotal(pigLabelWhosTurnTo.Text);
            if (!Pig_Double_Die_Game.PlayGame()) {
                SetupRound();
                CountPoints();
            } else {
                SetupRound();
                UpdatePoints(points);
                Program.showOKMessageBox("Sorry, you've thrown a 1.\nYour turn is over.\nYour score reverts to " + points + ".");
                pigLabelWhosTurnTo.Text = Pig_Double_Die_Game.GetNextPlayersName();
            }

            if (Pig_Double_Die_Game.HasWon()) {
                WonGame();
            }
        }

        /// <summary>
        /// Count the points a player has in real time.
        /// </summary>
        private void CountPoints() {
            for (int i = 0; i < dice.Length; i++) {
                if (pigLabelWhosTurnTo.Text == "Player 1") {
                    playerOneTextBox.Text = (Int32.Parse(playerOneTextBox.Text) + Pig_Double_Die_Game.GetFaceValue(i) * POINT_MULTIPLIER).ToString();
                } else {
                    playerTwoTextBox.Text = (Int32.Parse(playerTwoTextBox.Text) + Pig_Double_Die_Game.GetFaceValue(i) * POINT_MULTIPLIER).ToString();
                }
            }
        }

        /// <summary>
        /// Update the points.
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
        /// Setup a new roud.
        /// </summary>
        private void SetupRound() {
            renderImage();
            Pig_rollOrHoldLabel.Text = "Roll or Hold";
            holdButton.Enabled = true;
        }

        /// <summary>
        /// Setup the form for when a player has won the game.
        /// </summary>
        private void WonGame() {
            Program.showOKMessageBox(pigLabelWhosTurnTo.Text + " has won!\nWell done.");
            rollButton.Enabled = false;
            holdButton.Enabled = false;
            anotherGameGroupBox.Enabled = true;
        }

        /// <summary>
        /// Get the next players turn when the hold button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void holdButton_Click(object sender, EventArgs e) {
            Pig_rollOrHoldLabel.Text = "Roll die";
            holdButton.Enabled = false;
            pigLabelWhosTurnTo.Text = Pig_Double_Die_Game.GetNextPlayersName();
        }

        /// <summary>
        /// Determine if the player wants to play another game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anotherGameRadioButton_Click(object sender, EventArgs e) {
            if (yesAnotherGameRadioButton.Checked) {
                Reset();
            } else if (noAnotherGameRadioButton.Checked) {
                this.Close();
            }
        }

        /// <summary>
        /// Animate the dice everytime the timer ticks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            duration++;
            if (duration < 11) {
                randomDiceImages();
            } else {
                timer1.Stop();
                playGame();
            }
        }
    }
}
