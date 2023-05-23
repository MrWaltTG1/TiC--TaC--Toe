using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TiC__TaC__Toe
{
    public partial class Form1 : Form
    {
        string playerOne;
        string playerTwo;
        string currentPlayer;
        char playerOneSymbol;
        char playerTwoSymbol;
        Color playerOneColor = Color.Red;
        Color playerTwoColor = Color.Blue;
        private List<char> playerOneSquares = null;
        private List<char> playerTwoSquares = null;
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            playerOne = "Speler 1";
            playerTwo = "Speler 2";
            currentPlayer = "Speler 1";
            playerOneSymbol = 'O';
            playerTwoSymbol = 'X';

            lblSymbol1.Text = playerOneSymbol.ToString();
            lblSymbol2.Text = playerTwoSymbol.ToString();

            lblPlayerOne.Text = playerOne;
            lblPlayerTwo.Text = playerTwo;

            playerOneSquares = new List<char>();
            playerTwoSquares = new List<char>();
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
                    DoVictory(playerOne);
            if (playerTwoSquares.Count() > 2)
                if (GetVictory(playerTwoSquares))
                    DoVictory(playerTwo);
        }

        private void DoVictory(string player)
        {
            Close();
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
