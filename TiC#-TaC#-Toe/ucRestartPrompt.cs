using System;
using System.Windows.Forms;

namespace TiC__TaC__Toe
{
    public partial class ucRestartPrompt : UserControl
    {
        formMainScreen mainScreen;
        public ucRestartPrompt(formMainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainScreen.PlayerOne.ResetScore();
            mainScreen.PlayerTwo.ResetScore();
            mainScreen.UpdateLabels();
            Close(sender, e);
            mainScreen.Start();
        }

        private void Close(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
