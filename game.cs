using System.Reflection.Metadata;
using System.Reflection.Emit;
using System.Collections.Concurrent;
using System.Data;
using System.CodeDom.Compiler;
using System.Security.Cryptography;
using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {  
            int guess = 0;
            int guessCount = 0;
            int guessLimit = 0;
            int numberOfGuessesLeft = 0;
            Random rnd = new Random();
            int easy = rnd.Next(1,11);
            int medium = rnd.Next(1,21);
            int hard = rnd.Next(1,51);
            string gameDifficulty = "";
            string playersName = "";
            bool outOfGuesses = false;

            Console.WriteLine("Welcome to the Numbering Guessing Game");
            Console.Write("Hello, what is your name? ");
            playersName = Console.ReadLine();
            Console.Write("Well " + playersName + " What difficulty would you like to play ? EASY,MEDIUM,HARD: ");
            gameDifficulty = Console.ReadLine();



            if(gameDifficulty == "EASY")
            {
                guessCount = 0;
                guessLimit = 6;
                
                while(guess != easy && !outOfGuesses)
                {
                    if(guessCount < guessLimit)
                    {
                        Console.WriteLine("You are to guess a number between 1 and 10");
                        Console.Write("Enter guess: ");
                        guess = int.Parse(Console.ReadLine());
                        guessCount++;
                        numberOfGuessesLeft = (guessLimit - guessCount);
                        Console.Write("That was wrong");
                        Console.WriteLine(" You have " + numberOfGuessesLeft + "left");
                    }
                    else
                    {
                        outOfGuesses = true;
                    }

                }
                if (outOfGuesses)
                {
                    Console.Write("You Lose!");
                }
                else
                {
                    Console.Write("You got it right");
                }
            }

            //program for medium difficulty
            else if (gameDifficulty == "MEDIUM")
            {
                guessCount = 0;
                guessLimit = 4;
                
                while(guess != medium && !outOfGuesses)
                {
                    if(guessCount < guessLimit)
                    {
                        Console.WriteLine("You are to guess a number between 1 and 20");
                        Console.Write("Enter guess: ");
                        guess = int.Parse(Console.ReadLine());
                        guessCount++;
                        numberOfGuessesLeft = (guessLimit - guessCount);
                        Console.Write("That was wrong");
                        Console.WriteLine(" You have " + numberOfGuessesLeft + "left");
                    }
                    else
                    {
                        outOfGuesses = true;
                    }

                }
                if (outOfGuesses)
                {
                    Console.Write("You Lose!");
                }
                else
                {
                    Console.Write("You got it right!");
                }
            }
            
            
            //program for hard difficulty
            else if (gameDifficulty == "HARD")
            {
                guessCount = 0;
                guessLimit = 3;
                
                while(guess != hard && !outOfGuesses)
                {
                    if(guessCount < guessLimit)
                    {
                        Console.WriteLine("You are to guess a number between 1 and 50");
                        Console.Write("Enter guess: ");
                        guess = int.Parse(Console.ReadLine());
                        guessCount++;
                        numberOfGuessesLeft = (guessLimit - guessCount);
                        Console.Write("That was wrong");
                        Console.WriteLine(" You have " + numberOfGuessesLeft + "left");
                    }
                    else
                    {
                        outOfGuesses = true;
                    }

                }
                if (outOfGuesses)
                {
                    Console.Write("You Lose!");
                }
                else
                {
                    Console.Write("You got it right!");
                }
            }
            else
            {
                Console.Write("Enter the right diffficulty");
                gameDifficulty = Console.ReadLine();
            }

        }
    }
}
