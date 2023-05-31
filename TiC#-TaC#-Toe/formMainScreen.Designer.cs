namespace TiC__TaC__Toe
{
    partial class formMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblNextPlayer = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSymbol1 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblScoreTwo = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSymbol2 = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblField3 = new System.Windows.Forms.Label();
            this.lblField2 = new System.Windows.Forms.Label();
            this.lblField1 = new System.Windows.Forms.Label();
            this.lblField6 = new System.Windows.Forms.Label();
            this.lblField5 = new System.Windows.Forms.Label();
            this.lblField4 = new System.Windows.Forms.Label();
            this.lblField9 = new System.Windows.Forms.Label();
            this.lblField8 = new System.Windows.Forms.Label();
            this.lblField7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(12, 9);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(75, 26);
            this.lblNext.TabIndex = 0;
            this.lblNext.Text = "Next : ";
            // 
            // lblNextPlayer
            // 
            this.lblNextPlayer.AutoSize = true;
            this.lblNextPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPlayer.Location = new System.Drawing.Point(80, 9);
            this.lblNextPlayer.Name = "lblNextPlayer";
            this.lblNextPlayer.Size = new System.Drawing.Size(0, 26);
            this.lblNextPlayer.TabIndex = 1;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(483, 470);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(185, 35);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.Restart);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.lblPlayerOne);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.lblScore1);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.lblScoreTwo);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.lblPlayerTwo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(483, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(185, 417);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerOne.Location = new System.Drawing.Point(3, 0);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(180, 23);
            this.lblPlayerOne.TabIndex = 0;
            this.lblPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.lblSymbol1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(176, 100);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblSymbol1
            // 
            this.lblSymbol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol1.ForeColor = System.Drawing.Color.Red;
            this.lblSymbol1.Location = new System.Drawing.Point(3, 0);
            this.lblSymbol1.Name = "lblSymbol1";
            this.lblSymbol1.Size = new System.Drawing.Size(173, 100);
            this.lblSymbol1.TabIndex = 0;
            this.lblSymbol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore1
            // 
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.Color.Red;
            this.lblScore1.Location = new System.Drawing.Point(3, 129);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(180, 23);
            this.lblScore1.TabIndex = 0;
            this.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label12.Location = new System.Drawing.Point(3, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "---";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreTwo
            // 
            this.lblScoreTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTwo.ForeColor = System.Drawing.Color.Blue;
            this.lblScoreTwo.Location = new System.Drawing.Point(3, 175);
            this.lblScoreTwo.Name = "lblScoreTwo";
            this.lblScoreTwo.Size = new System.Drawing.Size(180, 23);
            this.lblScoreTwo.TabIndex = 0;
            this.lblScoreTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.lblSymbol2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 201);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(176, 100);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // lblSymbol2
            // 
            this.lblSymbol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol2.ForeColor = System.Drawing.Color.Blue;
            this.lblSymbol2.Location = new System.Drawing.Point(3, 0);
            this.lblSymbol2.Name = "lblSymbol2";
            this.lblSymbol2.Size = new System.Drawing.Size(173, 100);
            this.lblSymbol2.TabIndex = 0;
            this.lblSymbol2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.ForeColor = System.Drawing.Color.Blue;
            this.lblPlayerTwo.Location = new System.Drawing.Point(3, 304);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(180, 23);
            this.lblPlayerTwo.TabIndex = 0;
            this.lblPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblField3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblField2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblField1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblField6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblField5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblField4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblField9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblField8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblField7, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblField3
            // 
            this.lblField3.AutoSize = true;
            this.lblField3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblField3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField3.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblField3.Location = new System.Drawing.Point(309, 306);
            this.lblField3.Name = "lblField3";
            this.lblField3.Size = new System.Drawing.Size(146, 152);
            this.lblField3.TabIndex = 0;
            this.lblField3.Text = "_";
            this.lblField3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField3.Click += new System.EventHandler(this.Field_Click);
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblField2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblField2.Location = new System.Drawing.Point(157, 306);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(144, 152);
            this.lblField2.TabIndex = 0;
            this.lblField2.Text = "_";
            this.lblField2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField2.Click += new System.EventHandler(this.Field_Click);
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblField1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblField1.Location = new System.Drawing.Point(5, 306);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(144, 152);
            this.lblField1.TabIndex = 0;
            this.lblField1.Text = "_";
            this.lblField1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField1.Click += new System.EventHandler(this.Field_Click);
            // 
            // lblField6
            // 
            this.lblField6.AutoSize = true;
            this.lblField6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblField6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField6.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblField6.Location = new System.Drawing.Point(309, 154);
            this.lblField6.Name = "lblField6";
            this.lblField6.Size = new System.Drawing.Size(146, 150);
            this.lblField6.TabIndex = 0;
            this.lblField6.Text = "_";
            this.lblField6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField6.Click += new System.EventHandler(this.Field_Click);
            // 
            // lblField5
            // 
            this.lblField5.AutoSize = true;
            this.lblField5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblField5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField5.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblField5.Location = new System.Drawing.Point(157, 154);
            this.lblField5.Name = "lblField5";
            this.lblField5.Size = new System.Drawing.Size(144, 150);
            this.lblField5.TabIndex = 0;
            this.lblField5.Text = "_";
            this.lblField5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField5.Click += new System.EventHandler(this.Field_Click);
            // 
            // lblField4
            // 
            this.lblField4.AutoSize = true;
            this.lblField4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblField4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField4.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblField4.Location = new System.Drawing.Point(5, 154);
            this.lblField4.Name = "lblField4";
            this.lblField4.Size = new System.Drawing.Size(144, 150);
            this.lblField4.TabIndex = 0;
            this.lblField4.Text = "_";
            this.lblField4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField4.Click += new System.EventHandler(this.Field_Click);
            // 
            // lblField9
            // 
            this.lblField9.AutoSize = true;
            this.lblField9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblField9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField9.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblField9.Location = new System.Drawing.Point(309, 2);
            this.lblField9.Name = "lblField9";
            this.lblField9.Size = new System.Drawing.Size(146, 150);
            this.lblField9.TabIndex = 0;
            this.lblField9.Text = "_";
            this.lblField9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField9.Click += new System.EventHandler(this.Field_Click);
            // 
            // lblField8
            // 
            this.lblField8.AutoSize = true;
            this.lblField8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblField8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField8.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblField8.Location = new System.Drawing.Point(157, 2);
            this.lblField8.Name = "lblField8";
            this.lblField8.Size = new System.Drawing.Size(144, 150);
            this.lblField8.TabIndex = 0;
            this.lblField8.Text = "_";
            this.lblField8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField8.Click += new System.EventHandler(this.Field_Click);
            // 
            // lblField7
            // 
            this.lblField7.AutoSize = true;
            this.lblField7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblField7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblField7.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblField7.Location = new System.Drawing.Point(5, 2);
            this.lblField7.Name = "lblField7";
            this.lblField7.Size = new System.Drawing.Size(144, 150);
            this.lblField7.TabIndex = 0;
            this.lblField7.Text = "_";
            this.lblField7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblField7.Click += new System.EventHandler(this.Field_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 528);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblNextPlayer);
            this.Controls.Add(this.lblNext);
            this.KeyPreview = true;
            this.Name = "formMainScreen";
            this.Text = "TiC# TaC# Toe";
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.formMainScreen_ControlAdded);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.formMainScreen_ControlRemoved);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formMainScreen_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblNextPlayer;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblSymbol1;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblScoreTwo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblSymbol2;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblField3;
        private System.Windows.Forms.Label lblField2;
        private System.Windows.Forms.Label lblField1;
        private System.Windows.Forms.Label lblField6;
        private System.Windows.Forms.Label lblField5;
        private System.Windows.Forms.Label lblField4;
        private System.Windows.Forms.Label lblField9;
        private System.Windows.Forms.Label lblField8;
        private System.Windows.Forms.Label lblField7;
        private System.Windows.Forms.Timer timer1;
    }
}

