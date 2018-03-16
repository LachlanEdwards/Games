using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public class TwentyOneGame {
        private static CardPile cardPile = new CardPile(true);
        private static Hand[] hands;
        private static int[] totalPoints;
        private static int[] numofGamesWon = new int[2] { 0, 0 };
        private static int numOfUserAcesWithValueOne;

        private static FaceValue sessionFaceValue;

        /// <summary>
        /// Calculate the player points, taking into account any aces counted as 1 or 11.
        /// </summary>
        /// <param name="faceValue"></param>
        /// <param name="who"></param>
        /// <returns>Value of the card</returns>
        private static int calculatePlayerPoints(FaceValue faceValue, int who) {
            const int NUMBER_OF_STARTING_CARDS = 2;
            if (faceValue <= FaceValue.Ten) {
                int intFaceValue = (int)faceValue;
                return (intFaceValue + 2);
            } else if (faceValue > FaceValue.Ten && faceValue < FaceValue.Ace) {
                const int FACE_CARD_VALUE = 10;
                return FACE_CARD_VALUE;
            } else if (faceValue == FaceValue.Ace) {
                const int ACE_CARD_VALUE = 11;
                return ACE_CARD_VALUE;         
            } else {
                return -1;
            }
        }
        
        /// <summary>
        /// Add the faceValue of a card to the playerpoints.
        /// </summary>
        /// <param name="who"></param>
        /// <param name="faceValue"></param>
        private static void addPlayerPoints(int who, FaceValue faceValue) {
            int intFaceValue = calculatePlayerPoints(faceValue, who);
            totalPoints[who] += intFaceValue;
        }

        /// <summary>
        /// Failsafe incase cardPile runs out of cards.
        /// </summary>
        private static void ensurePlayableCardPile() {
            const int MINIMUM_AMOUNT_OF_CARDS_REQUIRED = 2;
            int cardPileCount = cardPile.GetCount();
            if (cardPileCount < MINIMUM_AMOUNT_OF_CARDS_REQUIRED) {
                cardPile = new CardPile(true);
            }
        }

        /// <summary>
        /// Determine the winner of the match.
        /// </summary>
        private static void decideWinner() {
            int playerTotalPoints = CalculateHandTotal(PLAYER);
            int dealerTotalPoints = CalculateHandTotal(DEALER);
            if (playerTotalPoints > dealerTotalPoints && playerTotalPoints <= MAX_SCORE) {
                numofGamesWon[PLAYER] += 1;
            } else if (dealerTotalPoints > playerTotalPoints && dealerTotalPoints <= MAX_SCORE) {
                numofGamesWon[DEALER] += 1;
            } else if ((playerTotalPoints == dealerTotalPoints) || (playerTotalPoints >= MAX_SCORE && dealerTotalPoints > MAX_SCORE)) {
                //draw
            } else if (playerTotalPoints >= MAX_SCORE) {
                numofGamesWon[DEALER] += 1;
            } else if (dealerTotalPoints >= MAX_SCORE) {
                numofGamesWon[PLAYER] += 1;
            } 
        }

        const int DEALER = 0;
        const int PLAYER = 1;
        const int MAX_NUMBER_OF_HOLDABLE_CARDS = 9;
        const int MAX_SCORE = 21;

        /// <summary>
        /// Setup the game for a new round.
        /// </summary>
        public static void SetUpGame() {

            ensurePlayableCardPile();

            const int dealNumOfCardsForAll = 2;

            numOfUserAcesWithValueOne = 0;
            hands = new Hand[2];
            totalPoints = new int[2];

            cardPile.Shuffle();

            List<Card> setUpDealCardsForDealer = cardPile.DealCards(dealNumOfCardsForAll);
            List<Card> setUpCardsForPlayer = cardPile.DealCards(dealNumOfCardsForAll);

            hands[DEALER] = new Hand(setUpDealCardsForDealer);
            hands[PLAYER] = new Hand(setUpCardsForPlayer);


            foreach (Card card in setUpDealCardsForDealer) {
                FaceValue cardFaceValue = card.GetFaceValue();
                addPlayerPoints(DEALER, cardFaceValue);
            }
            foreach (Card card in setUpCardsForPlayer) {
                FaceValue cardFaceValue = card.GetFaceValue();
                addPlayerPoints(PLAYER, cardFaceValue);
                if (card.GetFaceValue() == FaceValue.Ace) {
                    IncrementNumOfUserAcesWithValueOne();
                }
            }

            ensurePlayableCardPile();

        }

        /// <summary>
        /// Return the hand of who.
        /// </summary>
        /// <param name="who"></param>
        /// <returns>The hand of who</returns>
        public static Hand GetHand(int who) {
            return hands[who];
        }

        /// <summary>
        /// Algorithm to play for the dealers turn. The dealer is programmed to make logical choices to a certain point, where it uses the Random type to make a decision. (Without this random decision, the dealer can be programmed to never be busted).
        /// </summary>
        public static void PlayForDealer() {
            int dealerPoints = CalculateHandTotal(DEALER);
            int playerPoints = CalculateHandTotal(PLAYER);
            int deltFaceValue = calculatePlayerPoints(sessionFaceValue, DEALER);
            if (dealerPoints < 17 && GetHand(DEALER).GetCount() < 8 && playerPoints <= MAX_SCORE) {
                DealOneCardTo(DEALER);
                dealerPoints = CalculateHandTotal(DEALER);
                for (int i = dealerPoints; i < MAX_SCORE; i += deltFaceValue) {
                    dealerPoints = CalculateHandTotal(DEALER);
                    int differenceDealerPoints = (MAX_SCORE - dealerPoints);
                    if (GetHand(DEALER).GetCount() < 8) {
                        Random random = new Random();
                        int randomValue = random.Next(1, 3);
                        if (randomValue == 1) {
                            DealOneCardTo(DEALER); 
                        }
                    }
                }
            }
            decideWinner();
        }

        /// <summary>
        /// Get the number of games who has won.
        /// </summary>
        /// <param name="who"></param>
        /// <returns>Number of games who has won</returns>
        public static int GetNumOfGamesWon(int who) {
            return numofGamesWon[who];
        }

        /// <summary>
        /// Deal a single card to who.
        /// </summary>
        /// <param name="who"></param>
        /// <returns>The Card that has been delt to who.</returns>
        public static Card DealOneCardTo(int who) {
            ensurePlayableCardPile();
            Card deltCard = cardPile.DealOneCard();

            sessionFaceValue = deltCard.GetFaceValue();
            addPlayerPoints(who, sessionFaceValue);

            hands[who].Add(deltCard);
            return deltCard;
        }

        /// <summary>
        /// Simply incremement the number of aces with the value one.
        /// </summary>
        public static void IncrementNumOfUserAcesWithValueOne() {
            numOfUserAcesWithValueOne++;
        }
        /// <summary>
        /// Simply get the number of aces with the value one.
        /// </summary>
        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne;
        }

        /// <summary>
        /// Calculate the total points in the hand, removing points from the Total Point Count for any number of Aces counted as 1's and not 11's.
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int CalculateHandTotal(int who) {
            int presentCardWithFaceValueAce = GetNumOfUserAcesWithValueOne();
            const int FACE_VALUE_OF_ACE_MINUS_ONE = 10;

            int playerPoints = totalPoints[who];
            int pointsToBeDeducted = presentCardWithFaceValueAce * FACE_VALUE_OF_ACE_MINUS_ONE;
            int calculatedTotalPoints = (playerPoints - pointsToBeDeducted);
            return calculatedTotalPoints;
        }

        public static void ResetTotals() {
            totalPoints[0] = 0;
            totalPoints[1] = 0;
            hands = null;
            numofGamesWon[0] = 0;
            numofGamesWon[1] = 0;
            numOfUserAcesWithValueOne = 0;
        }
    }
}
