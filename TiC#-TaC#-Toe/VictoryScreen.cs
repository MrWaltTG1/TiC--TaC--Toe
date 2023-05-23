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
        public ucVictoryScreen(string winner, Color color, formMainScreen mainScreen)
        {
            InitializeComponent();
            lblWinner.Text = winner;
            lblWinner.ForeColor = color;
            MainScreen = mainScreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startAnim = true;
            startPos = lblScoreOld.Location;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (startAnim == true)
                if (lblScoreNew.Location != startPos)
                {
                    lblScoreOld.Location = new Point(
                        lblScoreOld.Location.X,
                        lblScoreOld.Location.Y + 1
                     );
                    lblScoreNew.Location = new Point(
                        lblScoreNew.Location.X,
                        lblScoreNew.Location.Y + 1
                     );
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainScreen.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScreen.Controls.Remove(this);
        }
    }
}
