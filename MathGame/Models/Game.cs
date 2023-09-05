namespace MathGame.Models;

internal class Game
    {
        public GameType type { get; set; }
        public DateTime date{ get; set; }
        public int score { get; set; }
        public GameLevel level { get; set; }
    }

internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

internal enum GameLevel
    {
        Easy,
        Medium,
        Hard
    }
