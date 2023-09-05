using MathGame.Models;

namespace MathGame;
internal class Menu
    {
        internal void GameMenu()
        {
            GameEngine gameEngine = new();
            bool gameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"Which game do you want to play? Choose 
                    V for Veiwing game history
                    A for Addition
                    S for Subtraction
                    M for Multiplication
                    D for Division
                    Q to Quit");

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "V":
                        Helpers.ViewGameHistory();
                        break;
                    case "A":
                        gameEngine.AdditionGame(GameType.Addition);
                        break;
                    case "S":
                        gameEngine.SubtractionGame(GameType.Subtraction);
                        break;
                    case "M":
                        gameEngine.MultiplicationGame(GameType.Multiplication);
                        break;
                    case "D":
                        gameEngine.DivisionGame(GameType.Division);
                        break;
                    case "Q":
                        Console.WriteLine("GoodBye!");
                        gameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            } while (gameOn);
        }
    }