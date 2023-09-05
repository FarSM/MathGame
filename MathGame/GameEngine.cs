using MathGame.Models;
using static MathGame.Helpers;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(GameType gameType)
        {
            int levelChoice = LevelSelection(gameType);

            switch (levelChoice)
            {
                case 1:
                    AdditionGameLevel(GameLevel.Easy, 0, 100);
                    break;
                case 2:
                    AdditionGameLevel(GameLevel.Medium, 100, 1000);
                    break;
                case 3:
                    AdditionGameLevel(GameLevel.Hard, 1000, 10000);
                    break;
                default:
                    Console.WriteLine("Enter a level");
                    break;
            }

        }
        private void AdditionGameLevel(GameLevel level, int minNum, int maxNum)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"Addition game Level: {level}\n");
                Random random = new Random();
                int num1 = random.Next(minNum, maxNum);
                int num2 = random.Next(minNum, maxNum);
                Console.WriteLine($"{num1} + {num2} = ");
                var result = Console.ReadLine();
                result = Helpers.isValidResult(result);

                if (Int32.Parse(result) == num1 + num2)
                {
                    Console.WriteLine("You are right. Press any key to continue.\n");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong. Press any key to continue.\n");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine("Game Over! Score = " + score);
                    Console.WriteLine("Press any key to go to the main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddGames(score, GameType.Addition, level);
        }
        internal void SubtractionGame(GameType gameType)
        {
            int levelChoice = LevelSelection(gameType);

            switch (levelChoice)
            {
                case 1:
                    SubtractionGameLevel(GameLevel.Easy, 0, 100);
                    break;
                case 2:
                    SubtractionGameLevel(GameLevel.Medium, 100, 1000);
                    break;
                case 3:
                    SubtractionGameLevel(GameLevel.Hard, 1000, 10000);
                    break;
                default:
                    Console.WriteLine("Enter a level");
                    break;
            }

        }
        private void SubtractionGameLevel(GameLevel level, int minNum, int maxNum)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"Subtraction game level {level}\n");
                Random random = new Random();
                int num1 = random.Next(minNum, maxNum);
                int num2 = random.Next(num1);
                Console.WriteLine($"{num1} - {num2} = ");
                var result = Console.ReadLine();
                result = Helpers.isValidResult(result);
                if (Int32.Parse(result) == num1 - num2)
                {
                    Console.WriteLine("You are right. Press any key to continue.\n");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong. Press any key to continue.\n");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine("Game Over! Score = " + score);
                    Console.WriteLine("Press any key to go to the main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddGames(score, GameType.Subtraction, level);
        }
        internal void MultiplicationGame(GameType gameType)
        {
            int levelChoice = LevelSelection(gameType);

            switch (levelChoice)
            {
                case 1:
                    MultiplicationGameLevel(GameLevel.Easy, 0, 10);
                    break;
                case 2:
                    MultiplicationGameLevel(GameLevel.Medium, 10, 100);
                    break;
                case 3:
                    MultiplicationGameLevel(GameLevel.Hard, 100, 1000);
                    break;
                default:
                    Console.WriteLine("Enter a level");
                    break;
            }

        }
        private void MultiplicationGameLevel(GameLevel level, int minNum, int maxNum)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"Multiplication game level {level}\n");
                Random random = new Random();
                int num1 = random.Next(minNum, maxNum);
                int num2 = random.Next(minNum, maxNum);
                Console.WriteLine($"{num1} * {num2} = ");
                var result = Console.ReadLine();
                result = Helpers.isValidResult(result);
                if (Int32.Parse(result) == num1 * num2)
                {
                    Console.WriteLine("You are right. Press any key to continue.\n");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong. Press any key to continue.\n");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine("Game Over! Score = " + score);
                    Console.WriteLine("Press any key to go to the main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddGames(score, GameType.Multiplication, level);
        }
        internal void DivisionGame(GameType gameType)
        {
            int levelChoice = LevelSelection(gameType);

            switch (levelChoice)
            {
                case 1:
                    DivisionGameLevel(GameLevel.Easy, 0, 100);
                    break;
                case 2:
                    DivisionGameLevel(GameLevel.Medium, 100, 1000);
                    break;
                case 3:
                    DivisionGameLevel(GameLevel.Hard, 1000, 10000);
                    break;
                default:
                    Console.WriteLine("Enter a level");
                    break;
            }

        }
        private void DivisionGameLevel(GameLevel level, int minNum, int maxNum)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"Division game level {level}\n");
                Random random = new Random();
                int num1 = random.Next(minNum, maxNum);
                int num2 = random.Next(1, num1);
                while (num1 % num2 != 0)
                {
                    num1 = random.Next(minNum,maxNum);
                    num2 = random.Next(1, num1);
                }
                Console.WriteLine($"{num1} / {num2} = ");
                var result = Console.ReadLine();
                result = Helpers.isValidResult(result);
                if (Int32.Parse(result) == num1 / num2)
                {
                    Console.WriteLine("You are right. Press any key to continue.\n");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong. Press any key to continue.\n");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine("Game Over! Score = " + score);
                    Console.WriteLine("Press any key to go to the main menu");
                    Console.ReadLine();
                }

            }
            Helpers.AddGames(score, GameType.Division, level);
        }
       

    }
}
