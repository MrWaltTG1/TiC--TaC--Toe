using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TiC__TaC__Toe
{
    public partial class formMainScreen : Form
    {
        public string playerOne;
        public string playerTwo;
        public string currentPlayer;
        public char playerOneSymbol;
        public char playerTwoSymbol;
        public Color playerOneColor = Color.Red;
        public Color playerTwoColor = Color.Blue;
        private List<char> playerOneSquares = null;
        private List<char> playerTwoSquares = null;
        
        public formMainScreen()
        {
            InitializeComponent();
            
            Start();
        }

        private void Start()
        {
            startScreen startScreen = new startScreen(this);
            startScreen.Location = tableLayoutPanel1.Location;
            Controls.Add(startScreen);
            startScreen.BringToFront();

            playerOneSquares = new List<char>();
            playerTwoSquares = new List<char>();
        }

        public void UpdateLabels()
        {
            lblSymbol1.Text = playerOneSymbol.ToString();
            lblSymbol1.ForeColor = playerOneColor;
            lblSymbol2.Text = playerTwoSymbol.ToString();
            lblSymbol2.ForeColor = playerTwoColor;

            lblPlayerOne.Text = playerOne;
            lblPlayerOne.ForeColor = playerOneColor;
            lblPlayerTwo.Text = playerTwo;
            lblPlayerTwo.ForeColor = playerTwoColor;

            lblScore1.ForeColor = playerOneColor;
            lblScoreTwo.ForeColor = playerTwoColor;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            foreach (Label label in tableLayoutPanel1.Controls)
            {
                label.ForeColor = label.BackColor;
                label.Text = "_";
                playerOneSquares = new List<char>();
                playerTwoSquares = new List<char>();
            }
        }

        private void Field_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == clickedLabel.BackColor)
                {
                    if (currentPlayer == playerOne)
                    {
                        clickedLabel.ForeColor = playerOneColor;
                        clickedLabel.Text = playerOneSymbol.ToString();
                        playerOneSquares.Add(clickedLabel.Name[clickedLabel.Name.Count() - 1]);
                        currentPlayer = playerTwo;
                    }
                    else if (currentPlayer == playerTwo)
                    {
                        clickedLabel.ForeColor = playerTwoColor;
                        clickedLabel.Text = playerTwoSymbol.ToString();
                        playerTwoSquares.Add(clickedLabel.Name[clickedLabel.Name.Count() - 1]);
                        currentPlayer = playerOne;
                    }
                    CheckWin();
                }
            }
        }


        private void CheckWin()
        {
            playerOneSquares.Sort();
            playerTwoSquares.Sort();

            if (playerOneSquares.Count() > 2)
                if (GetVictory(playerOneSquares))
                    DoVictory(playerOne, playerOneColor);
            if (playerTwoSquares.Count() > 2)
                if (GetVictory(playerTwoSquares))
                    DoVictory(playerTwo, playerTwoColor);

            int i = 0;
            foreach (Label item in tableLayoutPanel1.Controls)
            {
                if (item.ForeColor == item.BackColor)
                    i++;
            }
            if (i == 0)
                DoVictory("draw", Color.Black);
        }

        private void DoVictory(string player, Color color)
        {
            ucVictoryScreen victoryScreen = new ucVictoryScreen(player, color, this);
            Controls.Add(victoryScreen);
            victoryScreen.Location = tableLayoutPanel1.Location;
            victoryScreen.BringToFront();
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
    }
}
