using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t Welcome to my Rock Paper Scissors Game \n");
            Console.WriteLine("Please select your play from the following choices ... \n" +
                "\n Rock" +
                "\n Paper" +
                "\n Scissors");

            string userChoice = "";                     //User selection
            Random rand = new Random();                 //Random number generator for CPU guess
            int cpuChoice = rand.Next(1, 4);            //CPU has 3 random guesses for rock paper scissors

            //This allows the user to input their selected choice
            Console.Write("\nYour selection: ");
            userChoice = Console.ReadLine().ToLower();

            //Evaluate CPU Response
            switch (cpuChoice)
            {
                //CPU plays Rock
                case 1:
                    //User choices and outcomes
                    switch (userChoice)
                    {
                        case "rock":
                            Console.WriteLine("CPU plays rock and you played rock \n" +
                                "Rock is equal to rock, it's a TIE!");
                            break;
                        case "paper":
                            Console.WriteLine("CPU plays rock and you played paper \n" +
                                "Paper beats rock, you WIN!");
                            break;
                        case "scissors":
                            Console.WriteLine("CPU plays rock and you played scissors \n" +
                                "Rock beats scissors, you LOSE!");
                            break;
                        default:
                            Console.WriteLine("Please choose a valid guess: Rock, paper, or scissors");
                            break;
                    }
                    break;

                //CPU plays Paper
                case 2:
                    //User choices and outcomes
                    switch (userChoice)
                    {
                        case "rock":
                            Console.WriteLine("CPU plays paper and you played rock \n" +
                                "Paper beats rock, you LOSE!");
                            break;
                        case "paper":
                            Console.WriteLine("CPU plays Paper and you played paper \n" +
                                "Paper equals paper, it's a TIE!");
                            break;
                        case "scissors":
                            Console.WriteLine("CPU plays paper and you played scissors \n" +
                                "Scissors beats paper, you WIN!");
                            break;
                        default:
                            Console.WriteLine("Please choose a valid guess: Rock, paper, or scissors");
                            break;
                    }
                    break;

                //CPU plays Scissors
                case 3:
                    //User choices and outcomes
                    switch (userChoice)
                    {
                        case "rock":
                            Console.WriteLine("CPU plays scissors and you played rock \n" +
                                "Rock beats scissors, you WIN!");
                            break;
                        case "paper":
                            Console.WriteLine("CPU plays scissors and you played paper \n" +
                                "Scissors beats paper, you LOSE");
                            break;
                        case "scissors":
                            Console.WriteLine("CPU plays scissors and you played scissors \n" +
                                "Scissors equals scissors, it's a TIE!");
                            break;
                        default:
                            Console.WriteLine("Please choose a valid guess: Rock, paper, or scissors");
                            break;
                    }
                    break;
            }

            Console.Write("\nPress any key to exit: ");
            Console.ReadKey();
        }
    }
}
