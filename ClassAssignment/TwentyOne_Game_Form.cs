using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace ClassAssignment {
    public partial class TwentyOne_Game_Form : Form {

        const int DEALER = 0;
        const int PLAYER = 1;
        const int PLAYER_AND_DEALER = 2;
        const int MAX_NUMBER_OF_CARDS_ALLOWED = 8;

        public TwentyOne_Game_Form() {
            InitializeComponent();
        }
        /// <summary>
        /// Update all the dunamic values on the form.
        /// </summary>
        /// <param name="who"></param>
        private void UpdateDynamicValues(int who) {
            if (who == PLAYER) {
                int playerPointsTotal = TwentyOneGame.CalculateHandTotal(PLAYER);
                int acesWithValueOne = TwentyOneGame.GetNumOfUserAcesWithValueOne();

                playerPointsLabel.Text = (playerPointsTotal).ToString();
                acesWithValueOneTextbox.Text = (acesWithValueOne).ToString();

                DisplayGuiHand(TwentyOneGame.GetHand(PLAYER), playerTableLayoutPanel);
            } else if (who == DEALER) {
                int dealerPointsTotal = TwentyOneGame.CalculateHandTotal(DEALER);

                dealerPointsLabel.Text = (dealerPointsTotal).ToString();

                DisplayGuiHand(TwentyOneGame.GetHand(DEALER), dealerTableLayoutPanel);
            } else if (who == PLAYER_AND_DEALER) {
                int playerPointsTotal = TwentyOneGame.CalculateHandTotal(PLAYER);
                int acesWithValueOne = TwentyOneGame.GetNumOfUserAcesWithValueOne();
                int dealerPointsTotal = TwentyOneGame.CalculateHandTotal(DEALER);

                playerPointsLabel.Text = (playerPointsTotal).ToString();
                acesWithValueOneTextbox.Text = (acesWithValueOne).ToString();
                dealerPointsLabel.Text = (dealerPointsTotal).ToString();

                DisplayGuiHand(TwentyOneGame.GetHand(PLAYER), playerTableLayoutPanel);
                DisplayGuiHand(TwentyOneGame.GetHand(DEALER), dealerTableLayoutPanel);
            }
        }

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                //Lachlan Edwards - Ensures that Cards fit the frame on HighDPI screens.
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        /// <summary>
        /// Used for testing and left for reference.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testButton_Click(object sender, EventArgs e) {
            const int testNumOfCardsForDealer = 2;
            const int testNumOfCardsForPlayer = 8;
            CardPile testCardPile = new CardPile(true);
            testCardPile.Shuffle();
            Hand testHandForDealer = new Hand(testCardPile.DealCards(testNumOfCardsForDealer));
            Hand testHandForPlayer = new Hand(testCardPile.DealCards(testNumOfCardsForPlayer));
            DisplayGuiHand(testHandForDealer, dealerTableLayoutPanel);
            DisplayGuiHand(testHandForPlayer, playerTableLayoutPanel);
        }

        /// <summary>
        /// Enable all the GUI buttons for after a Deal.
        /// </summary>
        private void enableButtons() {
            dealerBustedLabel.Visible = false;
            playerBustedLabel.Visible = false;
            hitButton.Enabled = true;
            standButton.Enabled = true;
            cancelButton.Enabled = true;
        }

        /// <summary>
        /// Disable all the GUI buttons for after a turn.
        /// </summary>
        private void disableButtons() {
            hitButton.Enabled = false;
            standButton.Enabled = false;
        }

        /// <summary>
        /// Setup the game on click of the deal button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dealButton_Click(object sender, EventArgs e) {
            TwentyOneGame.SetUpGame();
            UpdateDynamicValues(PLAYER_AND_DEALER);

            enableButtons();
            dealButton.Enabled = false;
        }

        /// <summary>
        /// Play the game on click of the hit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitButton_Click(object sender, EventArgs e) {
            Card playerDeltCard = TwentyOneGame.DealOneCardTo(PLAYER);

            FaceValue faceValueOfDeltCard = playerDeltCard.GetFaceValue();
            if (faceValueOfDeltCard == FaceValue.Ace) {
                DialogResult messageBoxResult = ClassAssignment.Program.showYesNoMessageBox("Count Ace as 1?", "You got an Ace!");
                if (messageBoxResult == DialogResult.Yes) {
                    TwentyOneGame.IncrementNumOfUserAcesWithValueOne();
                }
            }

            checkPlayerBusted(PLAYER);
            UpdateDynamicValues(PLAYER);
            checkExceedMaximumCards(PLAYER);

        }

        /// <summary>
        /// Check to see if the player is going to exceed 9 cards in their hand and prevent them from doing so.
        /// </summary>
        /// <param name="who"></param>
        private void checkExceedMaximumCards(int who) {
            if (who == PLAYER) {
                int amountOfPlayerCardsInHand = TwentyOneGame.GetHand(PLAYER).GetCount();
                if (amountOfPlayerCardsInHand >= MAX_NUMBER_OF_CARDS_ALLOWED) {
                    hitButton.Enabled = false;
                }
            } else if (who == DEALER) {
                int amountOfDealerCardsInHand = TwentyOneGame.GetHand(DEALER).GetCount();
                if (amountOfDealerCardsInHand >= MAX_NUMBER_OF_CARDS_ALLOWED) {
                    promptNextGame();
                }
            }
        }

        /// <summary>
        /// Check if the player has been busted.
        /// </summary>
        /// <param name="who"></param>
        private void checkPlayerBusted(int who) {
            if (who == PLAYER) {
                int playerPointsTotal = TwentyOneGame.CalculateHandTotal(PLAYER);
                if (playerPointsTotal > 21) {
                    disableButtons();
                    playerBustedLabel.Visible = true;
                    playDealersTurn();
                }
            } else if (who == DEALER) {
                int dealerPointsTotal = TwentyOneGame.CalculateHandTotal(DEALER);
                if (dealerPointsTotal > 21) {
                    dealerBustedLabel.Visible = true;
                }
            }
        }

        /// <summary>
        /// Display the number of games won at the end of a game and reset a new round.
        /// </summary>
        private void promptNextGame() {
            playerGamesWonTextbox.Text = (TwentyOneGame.GetNumOfGamesWon(PLAYER)).ToString();
            dealerGamesWonTextBox.Text = (TwentyOneGame.GetNumOfGamesWon(DEALER)).ToString();
            dealButton.Enabled = true;
        }

        /// <summary>
        /// Play the dealers turn
        /// </summary>
        private void playDealersTurn() {           
            TwentyOneGame.PlayForDealer();

            checkPlayerBusted(DEALER);
            UpdateDynamicValues(DEALER);
            checkExceedMaximumCards(DEALER);
            promptNextGame();
        }

        /// <summary>
        /// Pass the turn over to the dealer when a user decides to stand. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standButton_Click(object sender, EventArgs e) {
            playDealersTurn();
            disableButtons();
        }

        /// <summary>
        /// Present the user with the results when they decide to cancel the game and close the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e) {
            int dealerGamesWon = TwentyOneGame.GetNumOfGamesWon(DEALER);
            int playerGamesWon = TwentyOneGame.GetNumOfGamesWon(PLAYER);

            if (dealerGamesWon > playerGamesWon) {
                Program.showOKMessageBox("House won. Better luck next time.");
            } else if (playerGamesWon > dealerGamesWon) {
                Program.showOKMessageBox("You won! Well done.");
            } else {
                Program.showOKMessageBox("It was a draw!");
            }
            TwentyOneGame.ResetTotals();
            this.Close();
        }
    }
}
