using System;
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
            if (difficulty == "Normal")
                CPU = 1;
            else if (difficulty == "Hard")
                CPU = 2;
            else
                CPU = 0;
        }

        public char ChooseNextMove()
        {
            if (CPU == 1)
                return ChooseNextMoveNormal();
            else if (CPU == 2)
                return ChooseNextMoveHard();
            else
                return ' ';
        }

        private char ChooseNextMoveNormal()
        {
            char nextField = (char)(random.Next(1, 9) + '0');
            return nextField;
        }

        private char ChooseNextMoveHard()
        {
            return '~';
        }
    }
}
