using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using SnowPal.Models;

namespace SnowPal
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly Game _game;


        // Properties bound to the UI
        [ObservableProperty]
        public partial string WordDisplay { get; set; }


        // Constructor initializes the game and letters
        public MainViewModel()
        {
            _game = new Game();
            StartNewGame();
        }

        // Starts a new game and updates the properties
        public void StartNewGame()
        {

            UpdateProperties();
        }

        // Command executed when a letter is guessed


        // Ends the game, disables letters, and shows the end game message


        // Command executed when the popup close button is clicked


        // Shows the end game message in a popup


        // Updates the properties bound to the UI
        private void UpdateProperties()
        {
            WordDisplay = string.Join(" ", _game.GuessedWord);


        }

        // Enables or disables the letter buttons


    }
}
