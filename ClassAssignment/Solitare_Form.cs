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
    public partial class Solitare_Form : Form {
        private Card currentlySelectedCard;
        private bool currentlyPlayingCard = false;
        private bool currentlyPlayingAceCard = false;
        private FaceValue[] faceValueOfCards = new FaceValue[13] { FaceValue.Ace, FaceValue.Two, FaceValue.Three, FaceValue.Four, FaceValue.Five, FaceValue.Six, FaceValue.Seven, FaceValue.Eight, FaceValue.Nine, FaceValue.Ten, FaceValue.Jack, FaceValue.Queen, FaceValue.King };

        public Solitare_Form() {
            InitializeComponent();
            Solitare_Game.SetupGame();
            PopulateTableau();
            DrawCardForDiscardPile();
        }
        /// <summary>
        /// Display all cards in Tableau.
        /// </summary>
        private void PopulateTableau() {
            TableLayoutPanel[] tableauLayoutPanels = ReturnTableLayoutPanels();
            Hand[] tableaus = Solitare_Game.GetTableaus();
            for (int i = 0; i < tableauLayoutPanels.Length; i++) {
                DisplayGuiHand(tableaus[i], tableauLayoutPanels[i]);
            } 
        }
        /// <summary>
        /// Display Draw Pile
        /// </summary>
        /// <param name="card"></param>
        private void DisplayDrawPile(Card card) {
            drawPilePictureBox.Image = Images.GetBackOfCardImage();
            discardPilePictureBox.Image = Images.GetCardImage(card);
            // tell the PictureBox which Card object it has the picture of.
            discardPilePictureBox.Tag = card;

        }
        /// <summary>
        /// Return a List of the TableLayoutPanels in the form.
        /// </summary>
        /// <returns>List of the TableLayoutPanels in the form.</returns>
        private TableLayoutPanel[] ReturnTableLayoutPanels() {
            TableLayoutPanel[] tableauLayoutPanels = new TableLayoutPanel[7] {tableau1TableLayoutPanel, tableau2TableLayoutPanel, tableau3TableLayoutPanel, tableau4TableLayoutPanel, tableau5TableLayoutPanel, tableau6TableLayoutPanel, tableau7TableLayoutPanel};
            return tableauLayoutPanels;
        }
        /// <summary>
        /// Returns a List of the Suit Pile PictureBoxes in the form.
        /// </summary>
        /// <returns>List of the Suit Pile PictureBoxes in the form.</returns>
        private PictureBox[] ReturnSuitPilePictureBoxes() {
            PictureBox[] suitPilePictureBoxes = new PictureBox[4] { suitPile1PictureBox, suitPile2PictureBox, suitPile3PictureBox, suitPile4PixtureBox };
            return suitPilePictureBoxes;
        }
        /// <summary>
        /// Removes a card from the Tableau
        /// </summary>
        /// <param name="clickedCard"></param>
        private void RemoveCardsFromTableau(Card clickedCard) {
            TableLayoutPanel[] tableLayoutPanels = ReturnTableLayoutPanels();
            Hand[] tableaus = Solitare_Game.GetTableaus();
            for (int i = 0; i < tableLayoutPanels.Length; i++) {
                foreach (Card card in tableaus[i]) {
                    if (card == clickedCard) {
                        tableaus[i].Remove(clickedCard);
                        DisplayGuiHand(tableaus[i], tableLayoutPanels[i]);
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// Checks if the player has won. UNABLE TO CHECK FOR STALEMATE.
        /// </summary>
        private void CheckIfWon() {
            Hand[] suitPiles = Solitare_Game.GetSuitPiles();
            bool hasWon = false;
            foreach (Hand hand in suitPiles) {
                if (hand.GetCount() == 13) {
                    hasWon = true;
                } else {
                    hasWon = false;
                    break;
                }
            }
            if (hasWon) {
                MessageBox.Show("Congratulations! You've won the game of Solitare. Reselect the Soliate Game in the Card Games menu to replay.");
                this.Close();
            }
        }
        /// <summary>
        /// Determine the conditions of the game and try to move the card appropriately. 
        /// </summary>
        /// <param name="clickedCard"></param>
        /// <param name="source"></param>
        private void TryToPlayCard(Card clickedCard, PictureBox source) {
            FaceValue facevalueOfClickedCard = clickedCard.GetFaceValue();
            Hand[] suitPiles = Solitare_Game.GetSuitPiles();
            PictureBox[] suitPilePictureBoxes = ReturnSuitPilePictureBoxes();
            Hand discardPile = Solitare_Game.GetDiscardPile();
            Hand drawPile = Solitare_Game.GetDrawPile();
           
            if (facevalueOfClickedCard == FaceValue.Ace) {
                EvaluatePlayingAce(clickedCard, source, suitPiles, suitPilePictureBoxes, discardPile, drawPile);
            } else if (facevalueOfClickedCard == FaceValue.King) {
                EvaluatePlayingKing(clickedCard, source);
            } else {
                EvaluatePlayingRegularCard(clickedCard, source, discardPile);
            }

            // Add code to do something with the clicked card.   
        }
        /// <summary>
        /// Try to play a Regular Playing Card (not a King or an Ace)
        /// </summary>
        /// <param name="clickedCard"></param>
        /// <param name="source"></param>
        /// <param name="discardPile"></param>
        private void EvaluatePlayingRegularCard(Card clickedCard, PictureBox source, Hand discardPile) {
            if (source.Name.Contains("suitPile")) {
                Hand[] suitPiles = Solitare_Game.GetSuitPiles();
                Hand drawPile = Solitare_Game.GetDrawPile();
                PictureBox[] suitPilePictureBoxes = ReturnSuitPilePictureBoxes();
                for (int i = 0; i < suitPiles.Length; i++) {
                    int currentlySelectedCardIntegerValue = ReturnIntegerValueOfCard(currentlySelectedCard);
                    int clickedCardIntegerValue = ReturnIntegerValueOfCard(clickedCard);
                    if (((currentlySelectedCardIntegerValue == (clickedCardIntegerValue + 1)) && (currentlySelectedCard.GetSuit() == clickedCard.GetSuit()))) {
                        if (suitPiles[i] != null) {
                            foreach (Card card in suitPiles[i]) {
                                if (card == clickedCard) {
                                    suitPiles[i].Add(currentlySelectedCard);
                                    suitPilePictureBoxes[i].Image = Images.GetCardImage(currentlySelectedCard);
                                    suitPilePictureBoxes[i].Tag = currentlySelectedCard;
                                    if (discardPile.Contains(currentlySelectedCard)) {
                                        discardPile.Remove(clickedCard);
                                        drawPile.Remove(clickedCard);
                                        DrawCardForDiscardPile();
                                    } else {
                                        SortCardsOnTableau(clickedCard, source);
                                    }
                                    break;
                                }
                            }
                            SortCardsOnTableau(clickedCard, source);
                            CheckIfWon();
                        }
                    } else {
                        CannotPlay();
                        break;
                    }
                }
            } else if (currentlyPlayingCard && source.Name == "discardPilePictureBox") {
                CannotPlay();
            } else if (!currentlyPlayingCard) {
                currentlyPlayingCard = true;
                currentlySelectedCard = clickedCard;
            } else if (currentlyPlayingCard) {
                int currentlySelectedCardIntegerValue = ReturnIntegerValueOfCard(currentlySelectedCard);
                int clickedCardIntegerValue = ReturnIntegerValueOfCard(clickedCard);
                if (((currentlySelectedCardIntegerValue == (clickedCardIntegerValue - 1)) && (currentlySelectedCard.GetColour() != clickedCard.GetColour()))) {
                    if (discardPile.Contains(currentlySelectedCard)) {
                        discardPile.Remove(currentlySelectedCard);
                        DrawCardForDiscardPile();
                        SortCardsOnTableau(clickedCard, source);
                    } else {
                        SortCardsOnTableau(clickedCard, source);
                    }

                } else {
                    CannotPlay();
                }
            }
        }
        /// <summary>
        /// Try to play a King while checking for the special conditions that a King may be of.
        /// </summary>
        /// <param name="clickedCard"></param>
        /// <param name="source"></param>

        private void EvaluatePlayingKing(Card clickedCard, PictureBox source) {
            TableLayoutPanel[] tableLayoutPanels = ReturnTableLayoutPanels();
            Hand[] tablaus = Solitare_Game.GetTableaus();
            int currentlySelectedCardIntegerValue = ReturnIntegerValueOfCard(currentlySelectedCard);
            int clickedCardIntegerValue = ReturnIntegerValueOfCard(clickedCard);
            Hand discardPile = Solitare_Game.GetDiscardPile();
            Hand[] suitPiles = Solitare_Game.GetSuitPiles();
            Hand drawPile = Solitare_Game.GetDrawPile();
            PictureBox[] suitPilePictureBoxes = ReturnSuitPilePictureBoxes();
            for (int i = 0; i < tableLayoutPanels.Length; i++) {
                if (tableLayoutPanels[i].Controls.Count == 0 && !currentlyPlayingCard) {
                    tablaus[i].Add(clickedCard);
                    DisplayGuiHand(tablaus[i], tableLayoutPanels[i]);
                    DrawCardForDiscardPile();
                    break;
                } else if (source.Name.Contains("suitPile")) {
                    for (int ii = 0; ii < suitPiles.Length; i++) {
                        if (((currentlySelectedCardIntegerValue == (clickedCardIntegerValue + 1)) && (currentlySelectedCard.GetSuit() == clickedCard.GetSuit()))) {
                            if (suitPiles[ii] != null) {
                                foreach (Card card in suitPiles[i]) {
                                    if (card == clickedCard) {
                                        suitPiles[ii].Add(currentlySelectedCard);
                                        suitPilePictureBoxes[ii].Image = Images.GetCardImage(currentlySelectedCard);
                                        suitPilePictureBoxes[ii].Tag = currentlySelectedCard;
                                        if (discardPile.Contains(currentlySelectedCard)) {
                                            discardPile.Remove(clickedCard);
                                            drawPile.Remove(clickedCard);
                                            DrawCardForDiscardPile();
                                        } else {
                                            SortCardsOnTableau(clickedCard, source);
                                        }
                                        break;
                                    }
                                }
                                SortCardsOnTableau(clickedCard, source);
                                CheckIfWon();
                            }
                        } else {
                            CannotPlay();
                            break;
                        }
                    }
                } else if (((currentlySelectedCardIntegerValue == (clickedCardIntegerValue - 1)) && (currentlySelectedCard.GetColour() != clickedCard.GetColour()))) {
                    if (discardPile.Contains(currentlySelectedCard)) {
                        discardPile.Remove(currentlySelectedCard);
                        DrawCardForDiscardPile();
                        SortCardsOnTableau(clickedCard, source);
                    } else {
                        SortCardsOnTableau(clickedCard, source);
                    }

                } else {
                    CannotPlay();
                }
            }
        }
        /// <summary>
        /// Try to play an Ace while checking for the special conditions that an Ace may be of.
        /// </summary>
        /// <param name="clickedCard"></param>
        /// <param name="source"></param>
        /// <param name="suitPiles"></param>
        /// <param name="suitPilePictureBoxes"></param>
        /// <param name="discardPile"></param>
        /// <param name="drawPile"></param>

        private void EvaluatePlayingAce(Card clickedCard, PictureBox source, Hand[] suitPiles, PictureBox[] suitPilePictureBoxes, Hand discardPile, Hand drawPile) {
            currentlyPlayingAceCard = true;
            for (int i = 0; i < suitPiles.Length; i++) {
                //If Ace is in DiscardPile
            if (source.Name.Contains("suitPile")) {
                int currentlySelectedCardIntegerValue = ReturnIntegerValueOfCard(currentlySelectedCard);
                int clickedCardIntegerValue = ReturnIntegerValueOfCard(clickedCard);
                if (((currentlySelectedCardIntegerValue == (clickedCardIntegerValue + 1)) && (currentlySelectedCard.GetSuit() == clickedCard.GetSuit()))) {
                    if (suitPiles[i] != null) {
                        foreach (Card card in suitPiles[i]) {
                            if (card == clickedCard) {
                                suitPiles[i].Add(currentlySelectedCard);
                                suitPilePictureBoxes[i].Image = Images.GetCardImage(currentlySelectedCard);
                                suitPilePictureBoxes[i].Tag = currentlySelectedCard;
                                if (discardPile.Contains(currentlySelectedCard)) {
                                    discardPile.Remove(clickedCard);
                                    drawPile.Remove(clickedCard);
                                    DrawCardForDiscardPile();
                                } else {
                                    SortCardsOnTableau(clickedCard, source);
                                }
                                break;
                            }
                        }
                        SortCardsOnTableau(clickedCard, source);
                        CheckIfWon();
                    }
                } else {
                    CannotPlay();
                    break;
                }
            }else if (suitPilePictureBoxes[i].Image == null && !currentlyPlayingCard && !(source.Name.Contains("suitPile"))) {
                    Solitare_Game.AddCardToSuitPile(i, clickedCard);
                    suitPilePictureBoxes[i].Image = Images.GetCardImage(clickedCard);
                    suitPilePictureBoxes[i].Tag = clickedCard;
                    currentlyPlayingAceCard = false;
                    if (source.Name == "discardPilePictureBox") {
                        discardPile.Remove(clickedCard);
                        drawPile.Remove(clickedCard);
                        DrawCardForDiscardPile();
                    } else if (!(source.Name.Contains("suitPile"))) {
                        RemoveCardsFromTableau(clickedCard);
                        SortCardsOnTableau(clickedCard, source);
                    }
                    break;
                }
            }
        }
        /// <summary>
        /// Display a warning to the user, notifying them their move was invalid.
        /// </summary>
        private void CannotPlay() {
            MessageBox.Show("ERROR: Invalid Move. Cannot place this card onto that card.");
            currentlyPlayingCard = false;
        }
        
        /// <summary>
        /// Move vards on the Tableau in respect to the current move the player is making or has made.
        /// </summary>
        /// <param name="clickedCard"></param>
        /// <param name="source"></param>

        private void SortCardsOnTableau(Card clickedCard, PictureBox source) {
            TableLayoutPanel[] tableLayoutPanels = ReturnTableLayoutPanels();
            Hand[] tableaus = Solitare_Game.GetTableaus();
            int indexOne = -1;
            int indexTwo = -1;
            for (int i = 0; i < tableaus.Length; i++) {
                foreach (Card card in tableaus[i]) {
                    if (currentlySelectedCard == card) {
                        indexOne = i;
                        DisplayGuiHand(tableaus[i], tableLayoutPanels[i]);
                        currentlyPlayingCard = false;
                    } else if (clickedCard == card) {
                        indexTwo = i;
                        DisplayGuiHand(tableaus[i], tableLayoutPanels[i]);
                        currentlyPlayingCard = false;
                    }
                }
            }
            if (indexTwo != -1 && !(source.Name.Contains("suitPile"))) {
                tableaus[indexTwo].Add(currentlySelectedCard);
                DisplayGuiHand(tableaus[indexTwo], tableLayoutPanels[indexTwo]);
            } else if (indexOne != -1) {
                tableaus[indexOne].Remove(currentlySelectedCard);
                DisplayGuiHand(tableaus[indexOne], tableLayoutPanels[indexOne]);
            }   
        }
        
        /// <summary>
        /// Return the integer value of a card, where an Ace is 0 and a King is 12. USED TO COMPARE THE VALUE OF CARDS.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>

        private int ReturnIntegerValueOfCard(Card card) {
            int index = 0;
            for (int i = 0; i < faceValueOfCards.Length; i++) {
                if (faceValueOfCards[i] == card.GetFaceValue()) {
                    index = i;
                }
            }
            return index;
        }/// <summary>

        private void pictureBox_Click(object sender, EventArgs e) {
            // which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            // get a reference to the card 

            Card clickedCard = (Card)clickedPictureBox.Tag; 

            if (clickedCard != null) {
                TryToPlayCard(clickedCard, clickedPictureBox);
            }
        }
        /// <summary>
        /// Reload the interface, fetching any changes in tableau piles.
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="tableLayoutPanel"></param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            TableLayoutPanel[] tableLayoutPanels = ReturnTableLayoutPanels();
            int amountOfCards = (Array.IndexOf(tableLayoutPanels, tableLayoutPanel) + 1);
            int iteration = 0;
            if (hand.GetCount() > 0) {
                foreach (Card card in hand) {
                    int amountOfCardsInHand = hand.GetCount();
                    iteration++;
                    // Construct a PictureBox object.
                    PictureBox pictureBox = new PictureBox();
                    //Lachlan Edwards - Ensures that Cards fit the frame on HighDPI screens.
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    // Set the PictureBox to use all of its space
                    pictureBox.Dock = DockStyle.Fill;
                    // Remove spacing around the PictureBox. (Default is 3 pixels.)
                    pictureBox.Margin = new Padding(0);
                    if ((iteration >= amountOfCards) || (amountOfCardsInHand < amountOfCards && iteration == amountOfCardsInHand)) {
                        pictureBox.Image = Images.GetCardImage(card);
                        // set event-handler for Click on this PictureBox.
                        pictureBox.Click += new EventHandler(pictureBox_Click);
                        // tell the PictureBox which Card object it has the picture of.
                        pictureBox.Tag = card;
                    } else {
                        pictureBox.Image = Images.GetBackOfCardImage();
                        pictureBox.Tag = card;
                    }
                    // Add the PictureBox object to the tableLayoutPanel.
                    tableLayoutPanel.Controls.Add(pictureBox);
                }
            }
        }

        private void drawPilePictureBox_Click(object sender, EventArgs e) {
            DrawCardForDiscardPile();
        }
        /// <summary>
        /// Draw a card from the Draw Pile and place it in the Discard Pile.
        /// </summary>
        private void DrawCardForDiscardPile() {
            Hand drawPile = Solitare_Game.GetDrawPile();
            if (drawPile.GetCount() > 1) {
                Card card = Solitare_Game.DrawCard();
                Solitare_Game.AddCardToDiscardPile(card);
                DisplayDrawPile(card);
            } else if (drawPile.GetCount() == 1) {
                Card card = Solitare_Game.DrawCard();
                Solitare_Game.AddCardToDiscardPile(card);
                DisplayDrawPile(card);
                drawPilePictureBox.Image = null;
            } else if (drawPile.GetCount() == 0) {
                Solitare_Game.ResetDrawDiscardPiles();
                Card card = Solitare_Game.DrawCard();
                Solitare_Game.AddCardToDiscardPile(card);
                DisplayDrawPile(card);
            }
            currentlyPlayingCard = false;
        }
    }
}
