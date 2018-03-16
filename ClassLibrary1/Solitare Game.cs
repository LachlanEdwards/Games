using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public class Solitare_Game {
        private static CardPile cardPile;
        private static Hand drawPile;
        private static int drawPileIndex = 0;
        private static Hand discardPile;
        private static List<Card> cardPileCards;
        private static Hand[] suitPiles = new Hand[4];
        private static Hand[] tableaus = new Hand[7];
        public static void SetupGame() {
            cardPile = new CardPile(true);
            cardPile.Shuffle();
            suitPiles = new Hand[4];
            FillTableaus();
            FillCardPile();
        }
        /// <summary>
        /// Fill the Tableaus with Cards
        /// </summary>
        private static void FillTableaus() {
            const int LENGTH_OF_TABLEAUS_ARRAY = 7;
            for (int i = 0; i < LENGTH_OF_TABLEAUS_ARRAY; i++) {
                List<Card> tableauCards = cardPile.DealCards(i + 1);
                tableaus[i] = new Hand(tableauCards);
            }
        }
        /// <summary>
        /// Fill the Draw Pile with Cards
        /// </summary>
        private static void FillCardPile() {
            cardPileCards = cardPile.DealCards(cardPile.GetCount());
            drawPile = new Hand(cardPileCards);
        }
        /// <summary>
        /// Draw a card from the Draw Pile and place it in the Discard Pile.
        /// </summary>
        /// <returns>Drawn Card</returns>
        public static Card DrawCard() {
            int topmostCardInPile = drawPile.GetCount() - 1;
            return drawPile.GetCard(topmostCardInPile);
        }
        /// <summary>
        /// Returns the Draw Pile Hand object.
        /// </summary>
        /// <returns>Draw Pile Hand object.</returns>
        public static Hand GetDrawPile() {
            return drawPile;
        }
        /// <summary>
        /// Returns the Discard Pile Hand object.
        /// </summary>
        /// <returns>Discard Pile Hand object.</returns>
        public static Hand GetDiscardPile() {
            return discardPile;
        }
        /// <summary>
        /// Return a List of Suit Pile Hand objects.
        /// </summary>
        /// <returns>List of Suit Pile Hand objects.</returns>
        public static Hand[] GetSuitPiles() {
            return suitPiles;
        }
        /// <summary>
        /// Return a List of Tableau Hand objects.
        /// </summary>
        /// <returns>List of Tableau Hand objects.</returns>
        public static Hand[] GetTableaus() {
            return tableaus;
        }
        /// <summary>
        /// Add a card to the Suit Pile.
        /// </summary>
        /// <param name="suitPileIndex"></param>
        /// <param name="card"></param>
        public static void AddCardToSuitPile(int suitPileIndex, Card card) {
            if (suitPiles[suitPileIndex] == null) {
                List<Card> cards = new List<Card>();
                cards.Add(card);
                suitPiles[suitPileIndex] = new Hand(cards);
            } else {
                suitPiles[suitPileIndex].Add(card);
            }
        }
        /// <summary>
        /// Add a card to Tableau
        /// </summary>
        /// <param name="tableauIndex"></param>
        /// <param name="card"></param>
        public static void AddCardToTableau(int tableauIndex, Card card) {
            tableaus[tableauIndex].Add(card);
        }
        /// <summary>
        /// Remove a card from the Tableau
        /// </summary>
        /// <param name="tableauIndex"></param>
        /// <param name="card"></param>
        public static void RemoveCardFromTableau(int tableauIndex, Card card) {
            tableaus[tableauIndex].Remove(card);
        }
        /// <summary>
        /// Add a card to the Discard Pile.
        /// </summary>
        /// <param name="card"></param>
        public static void AddCardToDiscardPile(Card card) {
            drawPile.Remove(card);
            if (discardPile == null) {
                List<Card> cards = new List<Card>();
                cards.Add(card);
                discardPile = new Hand(cards);
            } else {
                discardPile.Add(card);
            }     
        }
        /// <summary>
        /// Remove all Cards from the Discard Pile and return them to the Draw Pile to resrt the deck.
        /// </summary>
        public static void ResetDrawDiscardPiles() {
            foreach (Card card in discardPile) {
                drawPile.Add(card);
            }
            discardPile = null;
        }
    }
}
