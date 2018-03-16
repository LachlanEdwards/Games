using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public class Pig_Single_Die_Game {
        private static Die die = new Die();
        private static int faceValue;
        private static int[] pointsTotal = new int[2] { 0,0 };
        private static string[] playersName = new string[2] {"Player 1", "Player 2" };

        private static int playerScore;
        private static int player;

        /// <summary>
        /// Helper variable to return a players name based on their index.
        /// </summary>
        /// <returns>Players name</returns>
        private static string GetPlayerName() {
            return playersName[player];
        }

        /// <summary>
        /// Initialize variables for the start of a new round.
        /// </summary>
        public static void SetUpGame() {
            faceValue = die.GetFaceValue();
        }

        /// <summary>
        /// Roll the dice and determine the outcome of the match.
        /// </summary>
        /// <returns>True if the player lost, false if they can take another turn.</returns>
        public static bool PlayGame() {
            die.RollDie();
            faceValue = GetFaceValue();
            if (faceValue > 1) {
                playerScore += faceValue;
                return false;
            } else {
                return true;
            }
        }

        /// <summary>
        /// Determines if the palyer has won and reset all helper variables.
        /// </summary>
        /// <returns>True if the player has won, false if the player has lost.</returns>
        public static bool HasWon() {
            int score = pointsTotal[player] + playerScore;
            if (score >= 100) {
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
        /// Determine the name of the first player using a random algorithm. 
        /// </summary>
        /// <returns>Player name</returns>
        public static string GetFirstPlayersName() {
            Random r = new Random();
            int random = r.Next(0,2);

            string first = random.ToString();

            player = random;
            return GetPlayerName();
        }

        /// <summary>
        /// Get the name of the next palyer, based on the current player.
        /// </summary>
        /// <returns>Player name</returns>
        public static string GetNextPlayersName() {
            if (faceValue != 1) { // IDENTIFIED AS HOLD AND NOT LOSS.
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
        /// Store the final score in the pointsTotal array.
        /// </summary>
        private static void SetScore() {
            pointsTotal[player] += playerScore;
        }

        /// <summary>
        /// Get the total number of points a user has.
        /// </summary>
        /// <param name="nameOfPlayer"></param>
        /// <returns>Points a user has</returns>
        public static int GetPointsTotal(string nameOfPlayer) {
            int index = Array.IndexOf(playersName ,nameOfPlayer);
            return pointsTotal[index];
        }

        /// <summary>
        /// Get the face value of the current die. 
        /// </summary>
        /// <returns>Face value of die.</returns>
        public static int GetFaceValue() {
            return die.GetFaceValue();
        }

    }
}
