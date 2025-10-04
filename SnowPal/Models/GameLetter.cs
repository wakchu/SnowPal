using CommunityToolkit.Mvvm.ComponentModel;

namespace SnowPal.Models
{
    /// <summary>
    /// Represents a letter in the game.
    /// </summary>
    public partial class GameLetter : ObservableObject
    {
        public char Character { get; set; }

        [ObservableProperty]
        private bool isAvailable;

        public GameLetter(char character)
        {
            Character = character;
            IsAvailable = true;
        }
    }
}
