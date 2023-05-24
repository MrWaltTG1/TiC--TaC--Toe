using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiC__TaC__Toe
{
    public partial class ucVictoryScreen : UserControl
    {
        bool startAnim = false;
        Point startPos;
        formMainScreen MainScreen;
        Player player;
        public ucVictoryScreen(formMainScreen mainScreen, Player player)
        {
            InitializeComponent();
            lblWinner.Text = player.name;
            lblWinner.ForeColor = player.color;
            MainScreen = mainScreen;
            startPos = lblScoreOld.Location;
            lblScoreOld.Text = player.score.ToString();
            lblScoreNew.Text = (player.score +1).ToString();
            lblWinstreakScore.Text = (player.winstreak+1).ToString();
            lblWinstreakScore.ForeColor = player.color;
            
            this.player = player;

            if (player.name == "Draw")
            {
                label1.Text = "It's a";
                lblWinstreak.Visible = false;
                lblWinstreakScore.Visible = false;
            }
            else
            {
                label1.Text = "And the winner is:";
                lblWinstreak.Visible = true;
                lblWinstreakScore.Visible = true;
                player.IncreaseScore();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.name != "Draw")
            {
                startAnim = true;
                Timer thisTimer = sender as Timer;
                thisTimer.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Timer thisTimer = sender as Timer;
            if (startAnim == true)
                if (lblScoreNew.Location.Y <= startPos.Y)
                {
                    lblScoreOld.Location = new Point(
                        lblScoreOld.Location.X,
                        lblScoreOld.Location.Y + 4
                     );
                    lblScoreNew.Location = new Point(
                        lblScoreNew.Location.X,
                        lblScoreNew.Location.Y + 4
                     );
                }
                else
                    thisTimer.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainScreen.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScreen.btnRestart_Click(sender, e);
            MainScreen.Controls.Remove(this);
        }
    }
}
