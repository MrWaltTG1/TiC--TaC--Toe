using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TiC__TaC__Toe
{
    public class Player
    {
        public string name;
        public Color color;
        public int score = 0;
        public char symbol;
        public int winstreak = 0;
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
    }
}
