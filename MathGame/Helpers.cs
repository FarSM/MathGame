using MathGame.Models;
using System.Linq;

namespace MathGame;

internal class Helpers
    {
        static List<Game> games = new List<Game> {
        //new Game { date = DateTime.Now.AddDays(2), type = GameType.Addition, score = 5},
        //new Game { date = DateTime.Now.AddDays(3), type = GameType.Division, score = 4},
        //new Game { date = DateTime.Now.AddDays(4), type = GameType.Multiplication, score = 5},
        //new Game { date = DateTime.Now.AddDays(5), type = GameType.Subtraction, score = 3},
        //new Game { date = DateTime.Now.AddDays(6), type = GameType.Subtraction, score = 2},
        //new Game { date = DateTime.Now.AddDays(7), type = GameType.Addition, score = 1},
        //new Game { date = DateTime.Now.AddDays(8), type = GameType.Multiplication, score = 5},
        //new Game { date = DateTime.Now.AddDays(9), type = GameType.Addition, score = 5},
        //new Game { date = DateTime.Now.AddDays(10), type = GameType.Division, score = 0},
        //new Game { date = DateTime.Now.AddDays(11), type = GameType.Division, score = 0},
        //new Game { date = DateTime.Now.AddDays(12), type = GameType.Addition, score = 3},
        //new Game { date = DateTime.Now.AddDays(13), type = GameType.Multiplication, score = 2},
        //new Game { date = DateTime.Now.AddDays(14), type = GameType.Addition, score = 5},
        //new Game { date = DateTime.Now.AddDays(15), type = GameType.Multiplication, score = 2},
        //new Game { date = DateTime.Now.AddDays(16), type = GameType.Subtraction, score = 1},
    };

        internal static string isValidResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("An iteger value must be entered. Please try again.");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static void WelcomeMessage()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter your name.");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hello {name.Trim()}. Its {date.DayOfWeek}, {date}. Welcome to Math Game!!!\nPress any key to show the menu");
            Console.ReadLine();
        }

        internal static int LevelSelection(GameType gameType)
        {
            int choice;
            Console.Clear();
            Console.WriteLine($"{gameType} game selected!");
            Console.WriteLine(@$"Enter the difficulty level you want to play at. Choose
                                1 for Easy
                                2 for Medium
                                3 for Hard");

            return choice = Int32.Parse(Console.ReadLine());
        }

        internal static void ViewGameHistory()
        {
            //List<Game> gamesToPrint = games.Where(x => x.type == GameType.Division).ToList();
            //IEnumerable<Game> gamesToPrint = games.Where(x => x.type == GameType.Addition && x.date > new DateTime(2022, 09, 01)).OrderByDescending(x => x.score);
            Console.Clear();
            Console.WriteLine("\nGame History");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.date} : {game.type} : level {game.level} : {game.score}");
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("\nPress any key to go to the main menu");
            Console.ReadLine();

        }

        internal static void AddGames(int gamescore, GameType gameType, GameLevel gameLevel)
        {
            games.Add(new Game
            {
                type = gameType,
                score = gamescore,
                level = gameLevel,
                date = DateTime.Now
            });
        }
    }