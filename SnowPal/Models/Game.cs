using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowPal.Models
{
    public class Game
    {
        // List of words for the game
        private readonly List<string> _wordList = new List<string> { "WINDOWS", "VIEW", "MODEL", "TASKBAR", "XAML", "CSHARP", "DEBUGGER", "GRID", "STACKPANEL", "RANDOM" };


        // Messages for winning and losing the game

        // Properties for the current game state
        public string CurrentWord { get; private set; }
        public char[] GuessedWord { get; private set; } = [];

        public Game()
        {
            StartNewGame();
        }

        // Starts a new game by selecting a random word and resetting the game state
        public void StartNewGame()
        {
            var random = new Random();
            CurrentWord = _wordList[random.Next(_wordList.Count)];
            GuessedWord = new string('_', CurrentWord.Length).ToCharArray();

        }

        // Plays the game by guessing a letter and checking the game status


        // Returns the current guessed word as a string with spaces between letters


        // Guesses a letter and updates the guessed word and incorrect guesses count


        // Checks the game status to determine if the game is won or lost


        // Returns a winning message based on the number of guesses left


        // Returns a random losing message
    }
}
