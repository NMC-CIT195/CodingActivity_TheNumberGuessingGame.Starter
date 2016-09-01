using System;

namespace CodingActivity_TheNumberGuessingGame
{
    class Program
    {
        ///
        /// Declare game variables
        ///
        private const int MAX_NUMBER_OF_PLAYER_GUESSES = 4;
        private const int MAX_NUMBER_TO_GUESS = 10;

        private static int playersGuess;
        private static int numberToGuess;
        private static int roundNumber;
        private static int numberOfWins;
        private static int numberOfCurrentPlayerGuess;
        private static int[] numbersPlayerHasGuessed = new int[MAX_NUMBER_OF_PLAYER_GUESSES];

        private static bool playingGame;
        private static bool playingRound;
        private static bool numberGuessedCorrectly;

        /// <summary>
        /// Application's Main method
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //
            // Initialize new game
            //
            InitializeGame();

            //
            // Display the Welcome Screen with application Quit option
            //
            DisplayWelcomeScreen();

            //
            // Display the game rules
            //
            DisplayRulesScreen();

            //
            // Game loop
            // 
            while (playingGame)
            {
                //
                // Initialize new round
                //
                InitializeRound();

                //
                // Round loop
                // 
                while (playingRound)
                {
                    //
                    // Display the player guess screen and return the player's guess
                    //
                    playersGuess = DisplayGetPlayersGuessScreen();

                    //
                    // Evaluate the player's guess and provide the player feedback
                    //
                    DisplayPlayerGuessFeedback();

                    //
                    // Update round variables, process the results and provide player feedback
                    //
                    UpdateAndDisplayRoundStatus();
                }

                //
                // Round complete, display player stats and prompt to Continue/Quit
                //
                DisplayPlayerStats();
            }

            DisplayClosingScreen();
        }

        /// <summary>
        /// Initialize all game variables
        /// </summary>
        private static void InitializeGame()
        {
            playingGame = true;
        }

        /// <summary>
        /// Initialize all round variables and get number to guess
        /// </summary>
        private static void InitializeRound()
        {
            playingRound = true;
        }

        /// <summary>
        /// Display the opening screen and prompt to Continue/Quit
        /// </summary>
        private static void DisplayWelcomeScreen()
        {
            ConsoleKeyInfo playerKeyResponse;

            Console.Clear();

            Console.WriteLine("\n\n");
            Console.WriteLine("     Welcome to The Number Guessing Game");
            Console.WriteLine("        Laughing Leaf Productions");
            Console.WriteLine("\n\n");
            Console.WriteLine("      Press the (Enter) key to Play.");
            Console.WriteLine("       Press the (Esc) key to Quit.");

            playerKeyResponse = Console.ReadKey();

            //
            // Note: Console window closes immediately without displaying the closing screen.
            //
            if (playerKeyResponse.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Display the game rules
        /// </summary>
        private static void DisplayRulesScreen()
        {
            Console.Clear();

            Console.WriteLine("                The Number Guessing Game");
            Console.WriteLine("\n\n");
            Console.WriteLine("The computer will randomly select a number between 1 and 10.");
            Console.WriteLine("You will have four attempts to guess the number. After each");
            Console.WriteLine("guess the computer will indicate if you have guessed correctly");
            Console.WriteLine("or whether your guess is high or low.");
            Console.WriteLine("\n\n");
            Console.WriteLine("Press the any key to continue.");

            Console.ReadLine();
        }

        /// <summary>
        /// Prompt for and return the player's guess
        /// </summary>
        /// <returns></returns>
        private static int DisplayGetPlayersGuessScreen()
        {
            string playerResponse;
            int playerGuess;
            bool validResponse = false;

            //
            // Validate player's guess
            //
            while (!validResponse)
            {
                //
                // Clear screen and set header
                //
                DisplayReset();

                //
                // Put your code here
                Console.WriteLine("Player Guess Screen"); // Delete this
                // Remember to assign a value to playerGuess
                //

                DisplayContinueQuitPrompt();
            }
            return playersGuess;
        }

        /// <summary>
        /// Evaluate the player's guess and provide the player feedback
        /// </summary>
        private static void DisplayPlayerGuessFeedback()
        {

        }

        /// <summary>
        /// Update round status, process the results and provide player feedback
        /// </summary>
        private static void UpdateAndDisplayRoundStatus()
        {
            //
            // Player guessed correctly
            // 
            if (numberGuessedCorrectly)
            {
                //
                // Put your code here
                //
            }
            //
            // Player guessed incorrectly and has more guesses left
            // 
            else if (numberOfCurrentPlayerGuess < MAX_NUMBER_OF_PLAYER_GUESSES)
            {
                //
                // Put your code here
                //
            }
            //
            // Player guessed incorrectly and has no more guesses left
            // 
            else
            {
                //
                // Put your code here
                //
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Display the player's current stats and prompt to Continue/Quit
        /// </summary>
        private static void DisplayPlayerStats()
        {
            //
            // Put your code here
            Console.WriteLine("Player Stats Screen"); // Delete this
            //
        }

        /// <summary>
        /// Display the numbers already guessed
        /// </summary>
        private static void DisplayNumbersGuessed()
        {
            //
            // Put your code here
            //
        }

        /// <summary>
        /// Display the closing screen
        /// </summary>
        private static void DisplayClosingScreen()
        {
            //
            // Clear screen and set header
            //
            DisplayReset();

            Console.WriteLine("Thank you for playing our Number Guessing Game.\n");
            Console.WriteLine("          Laughing Leaf Productions.\n");
            Console.WriteLine("         Press the (Enter) key to Exit.");

            Console.ReadLine();

            Environment.Exit(0);
        }

        /// <summary>
        /// Generate and return a random number 
        /// </summary>
        /// <returns>random integer in desired range</returns>
        private static int GetNumberToGuess()
        {
            int numberToGuess = 0;

            //
            // Put your code here
            //

            return numberToGuess;
        }

        /// <summary>
        /// reset display to default size and colors including the header
        /// </summary>
        public static void DisplayReset()
        {
            Console.Clear();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.SetCursorPosition(15, 1);
            Console.WriteLine("   The Number Guessing Game   ");
            Console.WriteLine();

            Console.ResetColor();
            Console.WriteLine();
        }

        /// <summary>
        /// display the Continue/Quit prompt
        /// </summary>
        public static void DisplayContinueQuitPrompt()
        {
            Console.CursorVisible = false;

            Console.WriteLine();

            Console.WriteLine("Press any key to continue or press the ESC key to quit.");
            Console.WriteLine();
            ConsoleKeyInfo response = Console.ReadKey();

            //
            // Set flag if player chooses to quit
            //
            if (response.Key == ConsoleKey.Escape)
            {
                DisplayClosingScreen();
            }

            Console.CursorVisible = true;
        }
    }
}
