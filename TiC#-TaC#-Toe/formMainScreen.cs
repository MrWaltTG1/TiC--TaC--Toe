using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TiC__TaC__Toe
{
    public partial class formMainScreen : Form
    {
        public Player PlayerOne = new Player('O', Color.Red, "Player 1");
        public Player PlayerTwo = new Player('X', Color.Blue, "Player 2");
        public Player PlayerDraw = new Player('~', Color.Black, "Draw");
        public Player CurrentPlayer;
        private List<char> playerOneSquares = null;
        private List<char> playerTwoSquares = null;
        private ucRestartPrompt popup;
        public ucStartScreen startScreen;
        private Label loadedField;
        private bool disableClick = false;
        private Random random = new Random();

        public formMainScreen()
        {
            InitializeComponent();
            startScreen = new ucStartScreen(this);
            startScreen.Location = tableLayoutPanel1.Location;
            popup = new ucRestartPrompt(this);
            Start();
        }

        public void Start()
        {
            Controls.Add(startScreen);
            startScreen.BringToFront();

            playerOneSquares = new List<char>();
            playerTwoSquares = new List<char>();
        }
        public void StartNewRound()
        {
            // If there is no current player selected then select player 1
            // Else select the other one
            if (CurrentPlayer == PlayerOne)
                CurrentPlayer = PlayerTwo;
            else if (CurrentPlayer == PlayerTwo)
                CurrentPlayer = PlayerOne;
            else
                CurrentPlayer = PlayerOne;

            // Update the Next player Label
            lblNextPlayer.Text = CurrentPlayer.name;
            lblNextPlayer.ForeColor = CurrentPlayer.color;

            // If a CPU is playing make it select a square
            if (CurrentPlayer.CPU > 0)
            {
                CPUMove();
            }
        }

        private void CPUMove()
        {
            // Start the timer
            timer1.Enabled = true;
            // Disable clicking on a square
            disableClick = true; ;
            int attempts = 0;
            while (loadedField == null)
            {
                // ChooseNextMove returns either a random field or a '~'
                // '~' enables an optimal guess given from Hard CPU's
                char fieldChar = CurrentPlayer.ChooseNextMove();
                if (fieldChar == '~')
                {
                    loadedField = DoHardMove();
                }
                else
                {
                    // Check whether the randomized char is able to be placed
                    Label field = GetField(fieldChar);
                    if (field.ForeColor == field.BackColor)
                    {
                        loadedField = field;
                    }
                }

                // Stop the loop if a field has been succesfully loaded or there have been too many attempts.
                attempts++;
                if (attempts > 30)
                    break;
            }
        }

        private void WaitOnCPUPick()
        {
            // After the timer has gone off disable itself and reenable clicking
            timer1.Enabled = false;
            disableClick = false;
            // If there is a field loaded into memory then 'Click' on it and clear the memory
            if (loadedField != null)
            {
                Field_Click(loadedField, EventArgs.Empty);
                loadedField = null;
            }
        }

        // All winnable combinations
        char[] NWE = { '7', '8', '9' };
        char[] NWSE = { '7', '5', '3' };
        char[] NWS = { '7', '4', '1' };
        char[] WE = { '4', '5', '6' };
        char[] NS = { '2', '5', '8' };
        char[] SWE = { '1', '2', '3' };
        char[] SWNE = { '1', '5', '9' };
        char[] NES = { '9', '6', '3' };

        private Label DoHardMove()
        {
            char move = '0';
            int attempts = 0;

            IEnumerable<char> unavailableSquares =
                from Label label in tableLayoutPanel1.Controls
                where label.Text != "_"
                select label.Name.Last();
            IEnumerable<char> availableSquares =
                from Label label in tableLayoutPanel1.Controls
                where label.Text == "_"
                select label.Name.Last();

            // Enumerate through the CurrentPlayer first to see if it can win
            // If it cant cycle through the other player to see if it can block an opp
            // (It cycles through it self a second time but eh)
            Player[] playerList = { CurrentPlayer, PlayerOne, PlayerTwo };
            do
            {
                // First check if you can complete a row or block an opps row
                List<char[]> Directions = new List<char[]> { NWE, NWSE, NWS, WE, NS, SWE, SWNE, NES };
                foreach (var player in playerList)
                {
                    foreach (char[] direction in Directions)
                    {
                        // Complete a row
                        // check if there exists 2 out of 3 adjacent fields in its taken squares
                        if (direction.Except(player.takenSquares).Count() == 1)
                        {
                            move = Funqtions.GetRemainingItem(direction, player.takenSquares);
                            // If the square is not available reset to '0'
                            if (unavailableSquares.Contains(move))
                                move = '0';
                            else
                                // this breaks both for loops
                                break;
                        }
                    }
                    // If the square is not available reset to '0'
                    if (move != '0')
                        break;
                }

                // Split the option tree into whether it goes first or second
                // Player One should try and get 3 corners first
                // Player Two should get the middle option into a side option if player one has selected a corner
                List<char> cornerList = new List<char> { '1', '3', '7', '9' };
                if (CurrentPlayer == PlayerOne && move == '0')
                {
                    // Get a random available corner if there has been no move selected yet.
                    // Check if there are still available corner squares
                    if (!Funqtions.ContainsAllItems(unavailableSquares, cornerList))
                    {
                        IEnumerable<char> choiceList = Funqtions.GetRemainingItems(cornerList, unavailableSquares);
                        // Pick a random available corner
                        int index = random.Next(choiceList.Count());
                        move = choiceList.ElementAt(index);
                    }
                }
                
                else if (CurrentPlayer == PlayerTwo && move == '0')
                {
                    if (unavailableSquares.Except(cornerList) != unavailableSquares)
                    {
                        move = '5';
                        if (unavailableSquares.Contains(move))
                        {
                            IEnumerable<char> uncornerList = availableSquares.Except(cornerList);
                            int index = random.Next(uncornerList.Count());
                            if (uncornerList.Count() > 0)
                                move = uncornerList.ElementAt(index);
                            else
                                move = '0';
                        }
                        if (move != '0')
                            break;
                    }
                }

                // If there is no optimal play choose at random
                if (move == '0')
                {
                    int index = random.Next(availableSquares.Count());
                    move = availableSquares.ElementAt(index);
                }

                // If it cant find a field to choose just break and return null
                attempts++;
                if (attempts > 10)
                    break;
            } while (!(move.CompareTo('0') > 0) && !(move.CompareTo('9') <= 0)); // If the char 'move' is between fields 1 & 9 break

            Label field = GetField(move);
            if (field != null)
                return field;
            return null;
        }

        public void UpdateLabels()
        {
            // Update the sidebar symbols and their colors
            lblSymbol1.Text = PlayerOne.symbol.ToString();
            lblSymbol1.ForeColor = PlayerOne.color;
            lblSymbol2.Text = PlayerTwo.symbol.ToString();
            lblSymbol2.ForeColor = PlayerTwo.color;
            // Update the sidebar texts and their colors
            lblPlayerOne.Text = PlayerOne.name;
            lblPlayerOne.ForeColor = PlayerOne.color;
            lblPlayerTwo.Text = PlayerTwo.name;
            lblPlayerTwo.ForeColor = PlayerTwo.color;
            // Update the sidebar scores and their colors
            lblScore1.ForeColor = PlayerOne.color;
            lblScore1.Text = PlayerOne.score.ToString();
            lblScoreTwo.Text = PlayerTwo.score.ToString();
            lblScoreTwo.ForeColor = PlayerTwo.color;

            // Update the 'Next player: ' Label next to it
            if (CurrentPlayer != null)
            {
                lblNextPlayer.Text = CurrentPlayer.name;
                lblNextPlayer.ForeColor = CurrentPlayer.color;
            }
        }

        public void Restart(object sender, EventArgs e)
        {
            bool fieldEmpty = true;
            // Reset all squares back to default
            foreach (Label label in tableLayoutPanel1.Controls)
            {
                if (label.ForeColor != label.BackColor)
                {
                    label.ForeColor = label.BackColor;
                    label.Text = "_";
                    // if all squares are empty and this does not get called then prompt a full restart
                    fieldEmpty = false;
                }
            }
            // Reset each players taken squares
            PlayerOne.takenSquares = new List<char>();
            PlayerTwo.takenSquares = new List<char>();

            // Reset the CurrentPlayer
            CurrentPlayer = null;
            
            if (fieldEmpty)
                PromptFullRestart();
            else
                // Start a new round
                StartNewRound();
        }
        public void PromptFullRestart()
        {
            // Add the popup to the Controls and bring it to the front, select and focus it
            Controls.Add(popup);
            popup.BringToFront();
            popup.Select();
            popup.Focus();
            // Center the popup
            popup.Location = new Point((Width / 2 - popup.Width / 2), (Height / 2 - popup.Height / 2));
        }

        public void Field_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null && disableClick == false)
            {
                // Check if the label is in its default state
                if (clickedLabel.ForeColor == clickedLabel.BackColor)
                {
                    // update the label to the current players color and symbol
                    clickedLabel.ForeColor = CurrentPlayer.color;
                    clickedLabel.Text = CurrentPlayer.symbol.ToString();
                    // add the square to the player's taken square list
                    CurrentPlayer.takenSquares.Add(clickedLabel.Name[clickedLabel.Name.Count() - 1]);

                    // Check to see if a player has won/drawn and create a Control if one has
                    // If no Control was created, and therefore noone has won/drawn yet, then start a new round
                    int controlCount = Controls.Count;
                    CheckWin();
                    if (controlCount == Controls.Count)
                        StartNewRound();
                }
            }
        }
        /// <summary>
        ///     Turn a char between 1 and 9 to its corresponding square/field
        /// </summary>
        /// <param name="fieldChar"></param>
        /// <returns>A Label in tableLayoutPanel1</returns>
        private Label GetField(char fieldChar)
        {
            foreach (Label field in tableLayoutPanel1.Controls)
            {
                char fieldNumber = field.Name.Last();
                if (fieldChar == fieldNumber)
                    return field;
            }
            return null;
        }

        private void CheckWin()
        {
            // Sort the Lists numerically
            PlayerOne.takenSquares.Sort();
            PlayerTwo.takenSquares.Sort();

            // Check both players to see if they won
            if (PlayerOne.takenSquares.Count() > 2)
                if (GetVictory(PlayerOne.takenSquares))
                {
                    DoVictory(PlayerOne);
                    PlayerTwo.ResetWinstreak();
                    return;
                }
            if (PlayerTwo.takenSquares.Count() > 2)
                if (GetVictory(PlayerTwo.takenSquares))
                {
                    DoVictory(PlayerTwo);
                    PlayerOne.ResetWinstreak();
                    return;
                }

            // If there are no empty squares/fields left then create a draw.
            int i = 0;
            foreach (Label label in tableLayoutPanel1.Controls)
                if (label.ForeColor == label.BackColor)
                    i++;

            if (i == 0)
            {
                DoVictory(PlayerDraw);
                PlayerOne.ResetWinstreak();
                PlayerTwo.ResetWinstreak();
            }
        }

        private void DoVictory(Player player)
        {
            // Create a new Victory Screen, add it to the Controls and bring it to the front
            ucVictoryScreen victoryScreen = new ucVictoryScreen(this, player);
            Controls.Add(victoryScreen);
            victoryScreen.Location = tableLayoutPanel1.Location;
            victoryScreen.BringToFront();

            // Reset the Label showing the next playing player
            lblNextPlayer.Text = "";
            // Update the side bar score
            lblScore1.Text = PlayerOne.score.ToString();
            lblScoreTwo.Text = PlayerTwo.score.ToString();
        }

        private bool GetVictory(List<char> squares)
        {
            foreach (char indexer in squares)
            {
                int i = indexer - '0';
                // List is sorted and the lowest possible start number is 7
                if (i > 7)
                    break;

                // Increment the i by one twice and see if the list contains them
                // If all numbers are in the list give the victory to the player
                if (i == 1 || i == 4 || i == 7)
                {
                    if (squares.Contains((char)(indexer + 1)) && squares.Contains((char)(indexer + 2)))
                        return true;
                }
                // Increment the i by 3 twice and see if the list contains them
                // If all the numbers are in the list give the victory to the player
                if (i == 1 || i == 2 || i == 3)
                {
                    if (squares.Contains((char)(indexer + 3)) && squares.Contains((char)(indexer + 6)))
                        return true;
                }
                // Check the other 2 victory conditions
                // 1-5-9
                if (squares.Contains('1') && squares.Contains('5') && squares.Contains('9'))
                    return true;
                // 3-5-7
                if (squares.Contains('3') && squares.Contains('5') && squares.Contains('7'))
                    return true;
            }
            return false;
        }

        private void formMainScreen_ControlAdded(object sender, ControlEventArgs e)
        {
            btnRestart.Enabled = false;
            tableLayoutPanel1.Enabled = false;
        }

        private void formMainScreen_ControlRemoved(object sender, ControlEventArgs e)
        {
            btnRestart.Enabled = true;
            tableLayoutPanel1.Enabled = true;
        }

        private void formMainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            // If a numpad key is pressed try and 'Click' the corresponding field
            string key = e.KeyCode.ToString();
            if (key.Contains("NumPad") && tableLayoutPanel1.Enabled == true)
            {
                // NumPad keys' number are the last character in the string ex: 'NumPad9'
                char number = key.Last();
                Label field = GetField(number);
                if (field != null)
                    Field_Click(field, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WaitOnCPUPick();
        }
    }
    public static class Funqtions // Or whatever
    {
        public static bool ContainsAllItems<T>(this IEnumerable<T> a, IEnumerable<T> b)
        {
            return !b.Except(a).Any();
        }

        public static T GetRemainingItem<T>(this IEnumerable<T> a, IEnumerable<T> b)
        {
            if (a.Except(b).Count() == 1)
                return a.Except(b).First();
            return default;
        }

        public static IEnumerable<T> GetRemainingItems<T>(this IEnumerable<T> a, IEnumerable<T> b)
        {
            return a.Except(b);
        }
    }
}
