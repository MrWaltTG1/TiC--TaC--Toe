namespace TiC__TaC__Toe
{
    partial class ucVictoryScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScoreOld = new System.Windows.Forms.Label();
            this.lblScoreNew = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congratulations to:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblWinner.Location = new System.Drawing.Point(73, 80);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(304, 52);
            this.lblWinner.TabIndex = 1;
            this.lblWinner.Text = "player_name";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblScoreNew);
            this.panel1.Controls.Add(this.lblScoreOld);
            this.panel1.Location = new System.Drawing.Point(160, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 169);
            this.panel1.TabIndex = 2;
            // 
            // lblScoreOld
            // 
            this.lblScoreOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreOld.Location = new System.Drawing.Point(3, -2);
            this.lblScoreOld.Name = "lblScoreOld";
            this.lblScoreOld.Size = new System.Drawing.Size(120, 169);
            this.lblScoreOld.TabIndex = 0;
            this.lblScoreOld.Text = "0";
            this.lblScoreOld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreNew
            // 
            this.lblScoreNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNew.Location = new System.Drawing.Point(3, -169);
            this.lblScoreNew.Name = "lblScoreNew";
            this.lblScoreNew.Size = new System.Drawing.Size(120, 169);
            this.lblScoreNew.TabIndex = 1;
            this.lblScoreNew.Text = "0";
            this.lblScoreNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(222, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(79, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ucVictoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label1);
            this.Name = "ucVictoryScreen";
            this.Size = new System.Drawing.Size(456, 456);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScoreNew;
        private System.Windows.Forms.Label lblScoreOld;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
