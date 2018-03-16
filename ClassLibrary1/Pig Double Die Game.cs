using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public class Pig_Double_Die_Game {
        private static Die dieOne = new Die();
        private static Die dieTwo = new Die();
        private static int[] faceValue = new int[2] { 0, 0 };
        private static int[] pointsTotal = new int[2] { 0, 0 };
        private static string[] playersName = new string[2] { "Player 1", "Player 2" };

        private static Die[] dice = new Die[2] { dieOne, dieTwo };

        private static int playerScore;
        private static int player;

        const int DIE_ONE = 0;
        const int DIE_TWO = 1;
        const int SCORE_VALUE_OF_TWO_FACEVALUE_ONE = 25;
        const int SCORE_MILTIPLIER = 2;
        const int MAX_SCORE = 100;

        /// <summary>
        /// Return the name of the player.
        /// </summary>
        /// <returns>The name of the player.</returns>
        private static string GetPlayerName() {
            return playersName[player];
        }
        /// <summary>
        /// Initialize all required variables for a new game.
        /// </summary>
        public static void SetUpGame() {
            for (int i = 0; i < dice.Length; i++) {
                faceValue[i] = dice[i].GetFaceValue();
            }
        }

        /// <summary>
        /// Play the game as the player.
        /// </summary>
        /// <returns>True if the player is Busted or false if they are free to have another turn.</returns>
        public static bool PlayGame() {
            int dieWithFaceValueOfOne = 0;

            for (int i = 0; i < dice.Length; i++) {
                dice[i].RollDie();
                faceValue[i] = GetFaceValue(i);

                if (faceValue[i] == 1) {
                    dieWithFaceValueOfOne++;
                } else {
                    playerScore += (faceValue[i] * SCORE_MILTIPLIER);
                    if (dieWithFaceValueOfOne ==  2) {
                        playerScore += SCORE_VALUE_OF_TWO_FACEVALUE_ONE;
                    }
                }
            }

            if (dieWithFaceValueOfOne == 1) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Determines if the play has won or not.
        /// </summary>
        /// <returns>True if the player has won, false if they have lost.</returns>
        public static bool HasWon() {
            int score = pointsTotal[player] + playerScore;
            if (score >= MAX_SCORE) {
                for (int i = 0; i < pointsTotal.Length; i++) {
                    pointsTotal[i] = 0;
                }
                playerScore = 0;
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Use a random algorithm to determine who goes first.
        /// </summary>
        /// <returns>Player name</returns>
        public static string GetFirstPlayersName() {
            Random r = new Random();
            int random = r.Next(0, 2);

            string first = random.ToString();

            player = random;
            return GetPlayerName();
        }

        /// <summary>
        /// Get the next player and reset all helper variables for the next turn.
        /// </summary>
        /// <returns>The name of the next player</returns>
        public static string GetNextPlayersName() {
            if (faceValue[DIE_ONE] != 1 && faceValue[DIE_TWO] != 1) { // IDENTIFIED AS HOLD AND NOT LOSS.
                SetScore();
            }
            if (GetPlayerName() == "Player 1") {
                player = 1;
                playerScore = 0;
                return "Player 2";
            } else {
                player = 0;
                playerScore = 0;
                return "Player 1";
            }
        }

        /// <summary>
        /// Store the final score in the playerScore array.
        /// </summary>
        private static void SetScore() {
            pointsTotal[player] += playerScore;
        }

        /// <summary>
        /// Get the total amount of points for a player.
        /// </summary>
        /// <param name="nameOfPlayer"></param>
        /// <returns>Total number of points for specified player</returns>
        public static int GetPointsTotal(string nameOfPlayer) {
            int index = Array.IndexOf(playersName, nameOfPlayer);
            return pointsTotal[index];
        }

        /// <summary>
        /// Get the face value of the die.
        /// </summary>
        /// <param name="who"></param>
        /// <returns>The face value of the identified die.</returns>
        public static int GetFaceValue(int who) {
            return dice[who].GetFaceValue();
        }

    }
}
