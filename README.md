# Dice War Game

This C# repository contains a simple dice war game implemented using classes and methods. The game allows two players to roll dice and compete against each other to reach a score of 3 and win the game.

## How to Play

1. The game starts with a welcome message displayed on the console.
2. Players take turns rolling the dice by calling the `RollDice()` method. The number of sides on the dice is chosen at the beginning of the game.
3. The rolls of both players are compared using the `CompareRolls()` method, and the score of the player with the higher roll is increased.
4. The game continues until one player reaches a score of 3, at which point the winner is declared using the `DisplayWinner()` method.

To run the game, simply call the `RunGame()` method in the `Game` class. The main loop within `RunGame()` allows for multiple rounds of play until there is a winner.

## Purpose

This project serves as an exercise to demonstrate the usage of classes, methods, and basic game logic in C#. It provides a foundation for understanding object-oriented programming concepts and can be expanded upon to create more complex games.

Feel free to explore the code, modify it, and further enhance your C# programming skills while enjoying the dice war game.

