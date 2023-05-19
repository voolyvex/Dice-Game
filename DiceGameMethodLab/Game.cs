using System;

namespace DiceGameMethodLab
{
    internal class Game
    {
        // Member Variables
        private int playerOneScore;
        private int playerTwoScore;
        private Random rand;

        // Constructor
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            rand = new Random();
        }

        // Member Methods
        public int RollDice(int numberOfSides)
        {
            while (numberOfSides == 0)
            {
                Console.WriteLine("Please choose a dice with more than zero sides!");
                numberOfSides = ChooseNumberOfSides();
            }

            return rand.Next(1, numberOfSides + 1);
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Dice War game!");
        }

        public int ChooseNumberOfSides()
        {
            Console.WriteLine("Enter the number of sides for the dice: ");
            string numSides = Console.ReadLine();
            return Int32.Parse(numSides);
        }

        public void CompareRolls(int playerOneRoll, int playerTwoRoll)
        {
            if (playerOneRoll > playerTwoRoll)
            {
                playerOneScore++;
            }
            else if (playerOneRoll < playerTwoRoll)
            {
                playerTwoScore++;
            }
        }

        public void DisplayWinner(string winner)
        {
            Console.WriteLine($"{winner} is the winner!");
        }

        public void PlayMultipleRounds(int numberOfRounds, int numberOfSides)
        {
            for (int round = 1; round <= numberOfRounds; round++)
            {
                Console.WriteLine($"Round {round}");
                Console.WriteLine("Press any key to roll the dice...");
                Console.ReadKey();
                Console.WriteLine();

                int playerOneRoll = RollDice(numberOfSides);
                int playerTwoRoll = RollDice(numberOfSides);

                Console.WriteLine($"Player One rolled: {playerOneRoll}");
                Console.WriteLine($"Player Two rolled: {playerTwoRoll}");
                Console.WriteLine();

                CompareRolls(playerOneRoll, playerTwoRoll);

                Console.WriteLine($"Player One Score: {playerOneScore}");
                Console.WriteLine($"Player Two Score: {playerTwoScore}");
                Console.WriteLine();
            }
        }

        public void RunGame()
        {
            DisplayWelcome();

            int numberOfSides = ChooseNumberOfSides();
            int targetScore = 3;
            string winner = "";

            Console.WriteLine("Enter the number of rounds to play: ");
            int numberOfRounds = Int32.Parse(Console.ReadLine());

            PlayMultipleRounds(numberOfRounds, numberOfSides);

            if (playerOneScore >= targetScore)
            {
                winner = "Player One";
            }
            else
            {
                winner = "Player Two";
            }

            DisplayWinner(winner);

            Console.WriteLine("Do you want to play again? (Y/N)");
            string playAgain = Console.ReadLine();

            if (playAgain.ToUpper() == "Y")
            {
                playerOneScore = 0;
                playerTwoScore = 0;
                RunGame();
            }
            else
            {
                Console.WriteLine("Thank you for playing!");
            }
        }
    }
}