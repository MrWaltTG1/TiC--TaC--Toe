using System;
using System.Collections.Generic;
using System.Drawing;

namespace TiC__TaC__Toe
{
    public class Player
    {
        public string name;
        public Color color;
        public int score = 0;
        public char symbol;
        public int winstreak = 0;
        private Random random = new Random();
        public int CPU = 0;
        public List<char> takenSquares = new List<char> { };
        public Player(char symbol, Color color, string name)
        {
            this.symbol = symbol;
            this.name = name;
            this.color = color;
        }
        public void IncreaseScore()
        {
            score++;
            winstreak++;
        }
        public void ResetScore()
        {
            score = 0;
            winstreak = 0;
        }
        public void ResetWinstreak()
        {
            winstreak = 0;
        }

        public void ToggleCPU(string difficulty = "off")
        {
            if (difficulty == "Standard")
                CPU = 1;
            else if (difficulty == "Impossible")
                CPU = 2;
            else
                CPU = 0;
        }
    }
}
