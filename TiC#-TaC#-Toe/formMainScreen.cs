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

        public void UpdateLabels()
        {
            lblSymbol1.Text = PlayerOne.symbol.ToString();
            lblSymbol1.ForeColor = PlayerOne.color;
            lblSymbol2.Text = PlayerTwo.symbol.ToString();
            lblSymbol2.ForeColor = PlayerTwo.color;

            lblPlayerOne.Text = PlayerOne.name;
            lblPlayerOne.ForeColor = PlayerOne.color;
            lblPlayerTwo.Text = PlayerTwo.name;
            lblPlayerTwo.ForeColor = PlayerTwo.color;

            lblScore1.ForeColor = PlayerOne.color;
            lblScore1.Text = PlayerOne.score.ToString();
            lblScoreTwo.Text = PlayerTwo.score.ToString();
            lblScoreTwo.ForeColor = PlayerTwo.color;

            lblNextPlayer.Text = CurrentPlayer.name;
            lblNextPlayer.ForeColor = CurrentPlayer.color;
        }

        public void btnRestart_Click(object sender, EventArgs e)
        {
            bool fieldEmpty = true;
            foreach (Label label in tableLayoutPanel1.Controls)
            {
                if (label.ForeColor != label.BackColor)
                {
                    label.ForeColor = label.BackColor;
                    label.Text = "_";
                    fieldEmpty = false;
                }
            }
            playerOneSquares = new List<char>();
            playerTwoSquares = new List<char>();

            lblNextPlayer.Text = PlayerOne.name;
            lblNextPlayer.ForeColor = PlayerOne.color;

            CurrentPlayer = PlayerOne;

            if (fieldEmpty)
                PromptFullRestart();
        }
        public void PromptFullRestart()
        {
            Controls.Add(popup);
            popup.BringToFront();
            popup.Select();
            popup.Focus();
            popup.Location = new Point((Width / 2 - popup.Width / 2), (Height / 2 - popup.Height / 2));
        }

        private void Field_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == clickedLabel.BackColor)
                {
                    if (CurrentPlayer == PlayerOne)
                    {
                        clickedLabel.ForeColor = PlayerOne.color;
                        clickedLabel.Text = PlayerOne.symbol.ToString();
                        playerOneSquares.Add(clickedLabel.Name[clickedLabel.Name.Count() - 1]);
                        CurrentPlayer = PlayerTwo;
                    }
                    else if (CurrentPlayer == PlayerTwo)
                    {
                        clickedLabel.ForeColor = PlayerTwo.color;
                        clickedLabel.Text = PlayerTwo.symbol.ToString();
                        playerTwoSquares.Add(clickedLabel.Name[clickedLabel.Name.Count() - 1]);
                        CurrentPlayer = PlayerOne;
                    }
                    CheckWin();
                    lblNextPlayer.Text = CurrentPlayer.name;
                    lblNextPlayer.ForeColor = CurrentPlayer.color;
                }
            }
        }


        private void CheckWin()
        {
            playerOneSquares.Sort();
            playerTwoSquares.Sort();

            if (playerOneSquares.Count() > 2)
                if (GetVictory(playerOneSquares))
                {
                    DoVictory(PlayerOne);
                    PlayerTwo.ResetWinstreak();
                    return;
                }
            if (playerTwoSquares.Count() > 2)
                if (GetVictory(playerTwoSquares))
                {
                    DoVictory(PlayerTwo);
                    PlayerOne.ResetWinstreak();
                    return;
                }

            int i = 0;
            foreach (Label item in tableLayoutPanel1.Controls)
            {
                if (item.ForeColor == item.BackColor)
                    i++;
            }
            if (i == 0)
            {
                DoVictory(PlayerDraw);
                PlayerOne.ResetWinstreak();
                PlayerTwo.ResetWinstreak();
            }
        }

        private void DoVictory(Player player)
        {
            ucVictoryScreen victoryScreen = new ucVictoryScreen(this, player);
            Controls.Add(victoryScreen);
            victoryScreen.Location = tableLayoutPanel1.Location;
            victoryScreen.BringToFront();
            lblNextPlayer.Text = "";
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
            string key = e.KeyCode.ToString();
            if (key.Contains("NumPad") && tableLayoutPanel1.Enabled == true)
            {
                char number = key.Last();
                foreach (Label field in tableLayoutPanel1.Controls)
                {
                    char fieldNumber = field.Name.Last();
                    if (number == fieldNumber)
                    {
                        Field_Click(field, e);
                        break;
                    }
                }
            }
        }
    }
}
