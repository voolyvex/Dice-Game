using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameMethodLab
{
    internal class Game
    {
        //Member Variables
        int playerOneScore;
        int playerTwoScore;
        Random rand;

        //Constructor
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            rand = new Random();
        }

        //Member Methods
        public int RollDice(int numberOfSides)
        {
            if (numberOfSides == 0)
            {
                Console.WriteLine("Please find a dice with more than zero sides!");
                this.RunGame();
            }
            return rand.Next(numberOfSides);
        }

        public void DisplayWelcome()
        {
            
            Console.WriteLine("Welcome to the Dice War game!");
        }


        public int ChooseNumberOfSides()
        {
            //This method should prompt the user to enter the number of sides,
            //capture user input and return it after converting it to an integer.
            //This method only needs to be called once in RunGame(), but the returned
            //value should be captured as a variable that will be passed into the
            //RollDice() method each time it's called.
            Console.WriteLine("Enter the size of dice to use: ");
            string numSides = Console.ReadLine(); 
            return Int32.Parse(numSides);
            
        }


        public void CompareRolls(int playerOneRoll, int playerTwoRoll)
        {
            //This method should compare the two parameter values, then increase the
            //score of whoever's roll is higher
            //For example, if playerOneRoll is 5 and playerTwoRoll is 2,
            //playerOneScore should be increased by 1.




        }


        public void DisplayWinner()
        {
            //This method should print a message declaring the winner of the game,
            //ie, the first player who reaches a score of 3



        }


        public void RunGame()
        {
            //This is the main method that is called in the Program when you press Start
            //Call your other methods inside this method
            //You should incorporate a loop to allow for rounds of play
            //to continue until there is a winner


            DisplayWelcome();

            ChooseNumberOfSides();





        }
    }
}
