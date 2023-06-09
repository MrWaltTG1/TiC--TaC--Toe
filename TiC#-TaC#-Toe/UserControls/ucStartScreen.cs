﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TiC__TaC__Toe
{
    public partial class ucStartScreen : UserControl
    {
        formMainScreen mainScreen;
        Random random = new Random();
        public ucStartScreen(formMainScreen form1)
        {
            InitializeComponent();
            mainScreen = form1;
        }

        private void inputPlayer1_TextChanged(object sender, EventArgs e)
        {
            if (inputPlayer1.Text != "")
                lblExampleName1.Text = inputPlayer1.Text;
            else if (checkOne.Checked)
                lblExampleName1.Text = "CPU 1";
            else
                lblExampleName1.Text = "Player 1";
        }

        private void inputPlayer2_TextChanged(object sender, EventArgs e)
        {
            if (inputPlayer2.Text != "")
                lblExampleName2.Text = inputPlayer2.Text;
            else if (checkTwo.Checked)
                lblExampleName2.Text = "CPU 2";
            else
                lblExampleName2.Text = "Player 2";
        }

        private void ColorButton1_Click(object sender, EventArgs e)
        {
            PictureBox clickedBtn = sender as PictureBox;
            if (clickedBtn != null)
            {
                if (clickedBtn.BorderStyle == BorderStyle.Fixed3D)
                    return;

                var filteredItems = panel2.Controls.OfType<PictureBox>();
                // Turn old color's border back to default
                foreach (PictureBox btn in filteredItems)
                    if (btn.BackColor == lblExampleName1.ForeColor)
                        btn.BorderStyle = BorderStyle.FixedSingle;
                // Turn the new color's border into 3D
                clickedBtn.BorderStyle = BorderStyle.Fixed3D;
                // Turn the other player's color over to the new one
                var filteredItems2 = panel4.Controls.OfType<PictureBox>();
                foreach (PictureBox btn in filteredItems2)
                {
                    // Turn old color's border back to default
                    if (btn.BackColor == lblExampleName1.ForeColor)
                        btn.BorderStyle = BorderStyle.FixedSingle;
                    // Turn the new color's border into 3D
                    if (btn.BackColor == clickedBtn.BackColor)
                        btn.BorderStyle = BorderStyle.Fixed3D;
                }

                // Turn the example text and symbol into the right color
                lblExampleName1.ForeColor = clickedBtn.BackColor;
                lblExampleSymbol1.ForeColor = clickedBtn.BackColor;
            }
        }
        private void ColorButton2_Click(object sender, EventArgs e)
        {
            PictureBox clickedBtn = sender as PictureBox;
            if (clickedBtn != null)
            {
                if (clickedBtn.BorderStyle == BorderStyle.Fixed3D)
                    return;

                // Turn old color's border back to default
                var filteredItems2 = panel4.Controls.OfType<PictureBox>();
                foreach (PictureBox btn in filteredItems2)
                    if (btn.BackColor == lblExampleName2.ForeColor)
                        btn.BorderStyle = BorderStyle.FixedSingle;
                // Turn the new color's border into 3D
                clickedBtn.BorderStyle = BorderStyle.Fixed3D;

                // Turn the other player's color over to the new one
                var filteredItems = panel2.Controls.OfType<PictureBox>();
                foreach (PictureBox btn in filteredItems)
                {
                    // Turn old color's border back to default
                    if (btn.BackColor == lblExampleName2.ForeColor)
                        btn.BorderStyle = BorderStyle.FixedSingle;
                    // Turn the new color's border into 3D
                    if (btn.BackColor == clickedBtn.BackColor)
                        btn.BorderStyle = BorderStyle.Fixed3D;
                }

                // Turn the example text and symbol into the right color
                lblExampleName2.ForeColor = clickedBtn.BackColor;
                lblExampleSymbol2.ForeColor = clickedBtn.BackColor;
            }
        }


        private void SymbolButton1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.BorderStyle == BorderStyle.Fixed3D)
                    return;

                // Turn old label's border and color back to default
                var filteredItems1 = panel2.Controls.OfType<Label>();
                foreach (Label lbl in filteredItems1)
                    if (lbl.Text == lblExampleSymbol1.Text)
                    {
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.BackColor = Color.WhiteSmoke;
                    }
                // Turn the new color's border into 3D
                clickedLabel.BorderStyle = BorderStyle.Fixed3D;
                clickedLabel.BackColor = Color.LightGray;

                // Now the same for the other side
                // Turn old label's border and color back to default
                var filteredItems2 = panel4.Controls.OfType<Label>();
                foreach (Label lbl in filteredItems2)
                {
                    if (lbl.Text == lblExampleSymbol1.Text)
                    {
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.BackColor = Color.WhiteSmoke;
                    }
                    if (lbl.Text == clickedLabel.Text)
                    {
                        // Turn the new color's border into 3D
                        lbl.BorderStyle = BorderStyle.Fixed3D;
                        lbl.BackColor = Color.LightGray;
                    }
                }

                // Turn the example symbol into the right symbol
                lblExampleSymbol1.Text = clickedLabel.Text;

            }
        }

        private void SymbolButton2_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.BorderStyle == BorderStyle.Fixed3D)
                    return;

                // Turn old label's border and color back to default
                var filteredItems1 = panel4.Controls.OfType<Label>();
                foreach (Label lbl in filteredItems1)
                    if (lbl.Text == lblExampleSymbol2.Text)
                    {
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.BackColor = Color.WhiteSmoke;
                    }
                // Turn the new color's border into 3D
                clickedLabel.BorderStyle = BorderStyle.Fixed3D;
                clickedLabel.BackColor = Color.LightGray;

                // Now the same for the other side
                // Turn old label's border and color back to default
                var filteredItems2 = panel2.Controls.OfType<Label>();
                foreach (Label lbl in filteredItems2)
                {
                    if (lbl.Text == lblExampleSymbol2.Text)
                    {
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.BackColor = Color.WhiteSmoke;
                    }
                    if (lbl.Text == clickedLabel.Text)
                    {
                        // Turn the new color's border into 3D
                        lbl.BorderStyle = BorderStyle.Fixed3D;
                        lbl.BackColor = Color.LightGray;
                    }
                }

                // Turn the example symbol into the right symbol
                lblExampleSymbol2.Text = clickedLabel.Text;
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (checkOne.Checked)
                mainScreen.PlayerOne.ToggleCPU(lblPlayerOne.Text);
            else
                mainScreen.PlayerOne.ToggleCPU("off");
            mainScreen.PlayerOne.name = lblExampleName1.Text;
            mainScreen.PlayerOne.symbol = lblExampleSymbol1.Text.ToCharArray()[0];
            mainScreen.PlayerOne.color = lblExampleSymbol1.ForeColor;

            if (checkTwo.Checked)
                mainScreen.PlayerTwo.ToggleCPU(lblPlayerTwo.Text);
            else
                mainScreen.PlayerTwo.ToggleCPU("off");
            mainScreen.PlayerTwo.name = lblExampleName2.Text;
            mainScreen.PlayerTwo.symbol = lblExampleSymbol2.Text.ToCharArray()[0];
            mainScreen.PlayerTwo.color = lblExampleSymbol2.ForeColor;

            mainScreen.CurrentPlayer = null;
            mainScreen.StartNewRound();
            mainScreen.UpdateLabels();
            Parent.Controls.Remove(this);

        }

        private void checkTwo_CheckedChanged(object sender, EventArgs e)
        {
            inputPlayer2_TextChanged(sender, e);
            if (checkTwo.Checked)
            {
                lblPlayerTwo.BorderStyle = BorderStyle.FixedSingle;
                lblPlayerTwo.BackColor = SystemColors.ControlLight;
                lblPlayerTwo.Text = "Standard";
                lblPlayerTwo.Cursor = Cursors.Hand;
            }
            else
            {
                lblPlayerTwo.BorderStyle = BorderStyle.None;
                lblPlayerTwo.BackColor = SystemColors.Control;
                lblPlayerTwo.Text = "Player 2";
                lblPlayerTwo.Cursor = Cursors.Default;
            }
        }

        private void checkOne_CheckedChanged(object sender, EventArgs e)
        {
            inputPlayer1_TextChanged(sender, e);
            if (checkOne.Checked)
            {
                lblPlayerOne.BorderStyle = BorderStyle.FixedSingle;
                lblPlayerOne.BackColor = SystemColors.ControlLight;
                lblPlayerOne.Text = "Standard";
                lblPlayerOne.Cursor = Cursors.Hand;
            }
            else
            {
                lblPlayerOne.BorderStyle = BorderStyle.None;
                lblPlayerOne.BackColor = SystemColors.Control;
                lblPlayerOne.Text = "Player 1";
                lblPlayerOne.Cursor = Cursors.Default;
            }
        }

        private void btnRandomize1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            IEnumerable<Label> symbolList = panel2.Controls.OfType<Label>();
            int symbolIndex = random.Next(1, symbolList.Count());
            Label symbol = symbolList.ElementAt(symbolIndex);

            IEnumerable<PictureBox> colorList = panel2.Controls.OfType<PictureBox>();
            int colorIndex = random.Next(1, colorList.Count());
            PictureBox color = colorList.ElementAt(colorIndex);

            ColorButton1_Click(color, e);
            SymbolButton1_Click(symbol, e);
        }

        private void btnRandomize2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            IEnumerable<Label> symbolList = panel4.Controls.OfType<Label>();
            int symbolIndex = random.Next(1, symbolList.Count());
            Label symbol = symbolList.ElementAt(symbolIndex);

            IEnumerable<PictureBox> colorList = panel4.Controls.OfType<PictureBox>();
            int colorIndex = random.Next(1, colorList.Count());
            PictureBox color = colorList.ElementAt(colorIndex);

            ColorButton2_Click(color, e);
            SymbolButton2_Click(symbol, e);
        }

        private void DifficultyLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.Text == "Standard")
                    clickedLabel.Text = "Impossible";
                else if (clickedLabel.Text == "Impossible")
                    clickedLabel.Text = "Standard";
            }
        }
    }
}
