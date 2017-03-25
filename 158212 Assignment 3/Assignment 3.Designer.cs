namespace _158212_Assignment_3
{
    partial class RugbyForm
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
            this.GBTeam1 = new System.Windows.Forms.GroupBox();
            this.RadBtnIndia1 = new System.Windows.Forms.RadioButton();
            this.RadBtnAus1 = new System.Windows.Forms.RadioButton();
            this.RadBtnNZ1 = new System.Windows.Forms.RadioButton();
            this.GBTeam2 = new System.Windows.Forms.GroupBox();
            this.RadBtnIndia2 = new System.Windows.Forms.RadioButton();
            this.RadBtnNZ2 = new System.Windows.Forms.RadioButton();
            this.RadBtnAus2 = new System.Windows.Forms.RadioButton();
            this.PicBoxTeam1 = new System.Windows.Forms.PictureBox();
            this.PicBoxTeam2 = new System.Windows.Forms.PictureBox();
            this.VS = new System.Windows.Forms.Label();
            this.BtnTry1 = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.BtnConversion1 = new System.Windows.Forms.Button();
            this.BtnPenalty1 = new System.Windows.Forms.Button();
            this.BtnDropKick1 = new System.Windows.Forms.Button();
            this.BtnDropKick2 = new System.Windows.Forms.Button();
            this.BtnPenalty2 = new System.Windows.Forms.Button();
            this.BtnConversion2 = new System.Windows.Forms.Button();
            this.BtnTry2 = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.lblTimeToDisplay = new System.Windows.Forms.Label();
            this.ComBoxTeam1Players = new System.Windows.Forms.ComboBox();
            this.ComBoxTeam2Players = new System.Windows.Forms.ComboBox();
            this.TxtBDisplayStats = new System.Windows.Forms.TextBox();
            this.LblScore1 = new System.Windows.Forms.Label();
            this.LblScore2 = new System.Windows.Forms.Label();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnReset = new System.Windows.Forms.Button();
            this.GBTeam1.SuspendLayout();
            this.GBTeam2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxTeam2)).BeginInit();
            this.SuspendLayout();
            // 
            // GBTeam1
            // 
            this.GBTeam1.Controls.Add(this.RadBtnIndia1);
            this.GBTeam1.Controls.Add(this.RadBtnAus1);
            this.GBTeam1.Controls.Add(this.RadBtnNZ1);
            this.GBTeam1.Location = new System.Drawing.Point(84, 12);
            this.GBTeam1.Name = "GBTeam1";
            this.GBTeam1.Size = new System.Drawing.Size(105, 112);
            this.GBTeam1.TabIndex = 0;
            this.GBTeam1.TabStop = false;
            this.GBTeam1.Text = "Team One";
            // 
            // RadBtnIndia1
            // 
            this.RadBtnIndia1.AutoSize = true;
            this.RadBtnIndia1.Location = new System.Drawing.Point(6, 78);
            this.RadBtnIndia1.Name = "RadBtnIndia1";
            this.RadBtnIndia1.Size = new System.Drawing.Size(48, 17);
            this.RadBtnIndia1.TabIndex = 2;
            this.RadBtnIndia1.TabStop = true;
            this.RadBtnIndia1.Text = "India";
            this.RadBtnIndia1.UseVisualStyleBackColor = true;
            this.RadBtnIndia1.CheckedChanged += new System.EventHandler(this.RadBtnIndia1CheckedChanged);
            // 
            // RadBtnAus1
            // 
            this.RadBtnAus1.AutoSize = true;
            this.RadBtnAus1.Location = new System.Drawing.Point(6, 53);
            this.RadBtnAus1.Name = "RadBtnAus1";
            this.RadBtnAus1.Size = new System.Drawing.Size(65, 17);
            this.RadBtnAus1.TabIndex = 1;
            this.RadBtnAus1.TabStop = true;
            this.RadBtnAus1.Text = "Australia";
            this.RadBtnAus1.UseVisualStyleBackColor = true;
            this.RadBtnAus1.CheckedChanged += new System.EventHandler(this.RadBtnAus1CheckedChanged);
            // 
            // RadBtnNZ1
            // 
            this.RadBtnNZ1.AutoCheck = false;
            this.RadBtnNZ1.AutoSize = true;
            this.RadBtnNZ1.Location = new System.Drawing.Point(6, 30);
            this.RadBtnNZ1.Name = "RadBtnNZ1";
            this.RadBtnNZ1.Size = new System.Drawing.Size(89, 17);
            this.RadBtnNZ1.TabIndex = 0;
            this.RadBtnNZ1.TabStop = true;
            this.RadBtnNZ1.Text = "New Zealand";
            this.RadBtnNZ1.UseVisualStyleBackColor = true;
            this.RadBtnNZ1.CheckedChanged += new System.EventHandler(this.RadBtnNZ1CheckedChanged);
            // 
            // GBTeam2
            // 
            this.GBTeam2.Controls.Add(this.RadBtnIndia2);
            this.GBTeam2.Controls.Add(this.RadBtnNZ2);
            this.GBTeam2.Controls.Add(this.RadBtnAus2);
            this.GBTeam2.Location = new System.Drawing.Point(469, 12);
            this.GBTeam2.Name = "GBTeam2";
            this.GBTeam2.Size = new System.Drawing.Size(110, 112);
            this.GBTeam2.TabIndex = 1;
            this.GBTeam2.TabStop = false;
            this.GBTeam2.Text = "Team Two";
            // 
            // RadBtnIndia2
            // 
            this.RadBtnIndia2.AutoSize = true;
            this.RadBtnIndia2.Location = new System.Drawing.Point(6, 78);
            this.RadBtnIndia2.Name = "RadBtnIndia2";
            this.RadBtnIndia2.Size = new System.Drawing.Size(48, 17);
            this.RadBtnIndia2.TabIndex = 5;
            this.RadBtnIndia2.TabStop = true;
            this.RadBtnIndia2.Text = "India";
            this.RadBtnIndia2.UseVisualStyleBackColor = true;
            this.RadBtnIndia2.CheckedChanged += new System.EventHandler(this.RadBtnIndia2CheckedChanged);
            // 
            // RadBtnNZ2
            // 
            this.RadBtnNZ2.AutoCheck = false;
            this.RadBtnNZ2.AutoSize = true;
            this.RadBtnNZ2.Location = new System.Drawing.Point(6, 30);
            this.RadBtnNZ2.Name = "RadBtnNZ2";
            this.RadBtnNZ2.Size = new System.Drawing.Size(89, 17);
            this.RadBtnNZ2.TabIndex = 3;
            this.RadBtnNZ2.TabStop = true;
            this.RadBtnNZ2.Text = "New Zealand";
            this.RadBtnNZ2.UseVisualStyleBackColor = true;
            this.RadBtnNZ2.CheckedChanged += new System.EventHandler(this.RadBtnNZ2CheckedChanged);
            // 
            // RadBtnAus2
            // 
            this.RadBtnAus2.AutoSize = true;
            this.RadBtnAus2.Location = new System.Drawing.Point(6, 53);
            this.RadBtnAus2.Name = "RadBtnAus2";
            this.RadBtnAus2.Size = new System.Drawing.Size(65, 17);
            this.RadBtnAus2.TabIndex = 4;
            this.RadBtnAus2.TabStop = true;
            this.RadBtnAus2.Text = "Australia";
            this.RadBtnAus2.UseVisualStyleBackColor = true;
            this.RadBtnAus2.CheckedChanged += new System.EventHandler(this.RadBtnAus2CheckedChanged);
            // 
            // PicBoxTeam1
            // 
            this.PicBoxTeam1.Location = new System.Drawing.Point(84, 130);
            this.PicBoxTeam1.Name = "PicBoxTeam1";
            this.PicBoxTeam1.Size = new System.Drawing.Size(195, 79);
            this.PicBoxTeam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxTeam1.TabIndex = 2;
            this.PicBoxTeam1.TabStop = false;
            // 
            // PicBoxTeam2
            // 
            this.PicBoxTeam2.Location = new System.Drawing.Point(382, 130);
            this.PicBoxTeam2.Name = "PicBoxTeam2";
            this.PicBoxTeam2.Size = new System.Drawing.Size(197, 79);
            this.PicBoxTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxTeam2.TabIndex = 3;
            this.PicBoxTeam2.TabStop = false;
            // 
            // VS
            // 
            this.VS.AutoSize = true;
            this.VS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VS.Location = new System.Drawing.Point(302, 42);
            this.VS.Name = "VS";
            this.VS.Size = new System.Drawing.Size(50, 31);
            this.VS.TabIndex = 4;
            this.VS.Text = "VS";
            // 
            // BtnTry1
            // 
            this.BtnTry1.Location = new System.Drawing.Point(84, 246);
            this.BtnTry1.Name = "BtnTry1";
            this.BtnTry1.Size = new System.Drawing.Size(81, 23);
            this.BtnTry1.TabIndex = 5;
            this.BtnTry1.Text = "Try";
            this.BtnTry1.UseVisualStyleBackColor = true;
            this.BtnTry1.Click += new System.EventHandler(this.BtnTry1_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(288, 211);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(85, 31);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score";
            // 
            // BtnConversion1
            // 
            this.BtnConversion1.Location = new System.Drawing.Point(84, 275);
            this.BtnConversion1.Name = "BtnConversion1";
            this.BtnConversion1.Size = new System.Drawing.Size(81, 23);
            this.BtnConversion1.TabIndex = 7;
            this.BtnConversion1.Text = "Conversion";
            this.BtnConversion1.UseVisualStyleBackColor = true;
            this.BtnConversion1.Click += new System.EventHandler(this.BtnConversion1_Click);
            // 
            // BtnPenalty1
            // 
            this.BtnPenalty1.Location = new System.Drawing.Point(84, 304);
            this.BtnPenalty1.Name = "BtnPenalty1";
            this.BtnPenalty1.Size = new System.Drawing.Size(81, 23);
            this.BtnPenalty1.TabIndex = 8;
            this.BtnPenalty1.Text = "Penalty";
            this.BtnPenalty1.UseVisualStyleBackColor = true;
            this.BtnPenalty1.Click += new System.EventHandler(this.BtnPenalty1_Click);
            // 
            // BtnDropKick1
            // 
            this.BtnDropKick1.Location = new System.Drawing.Point(84, 333);
            this.BtnDropKick1.Name = "BtnDropKick1";
            this.BtnDropKick1.Size = new System.Drawing.Size(81, 23);
            this.BtnDropKick1.TabIndex = 9;
            this.BtnDropKick1.Text = "Drop Kick";
            this.BtnDropKick1.UseVisualStyleBackColor = true;
            this.BtnDropKick1.Click += new System.EventHandler(this.BtnDropKick1_Click);
            // 
            // BtnDropKick2
            // 
            this.BtnDropKick2.Location = new System.Drawing.Point(498, 333);
            this.BtnDropKick2.Name = "BtnDropKick2";
            this.BtnDropKick2.Size = new System.Drawing.Size(81, 23);
            this.BtnDropKick2.TabIndex = 13;
            this.BtnDropKick2.Text = "Drop Kick";
            this.BtnDropKick2.UseVisualStyleBackColor = true;
            this.BtnDropKick2.Click += new System.EventHandler(this.BtnDropKick2_Click);
            // 
            // BtnPenalty2
            // 
            this.BtnPenalty2.Location = new System.Drawing.Point(498, 304);
            this.BtnPenalty2.Name = "BtnPenalty2";
            this.BtnPenalty2.Size = new System.Drawing.Size(81, 23);
            this.BtnPenalty2.TabIndex = 12;
            this.BtnPenalty2.Text = "Penalty";
            this.BtnPenalty2.UseVisualStyleBackColor = true;
            this.BtnPenalty2.Click += new System.EventHandler(this.BtnPenalty2_Click);
            // 
            // BtnConversion2
            // 
            this.BtnConversion2.Location = new System.Drawing.Point(498, 275);
            this.BtnConversion2.Name = "BtnConversion2";
            this.BtnConversion2.Size = new System.Drawing.Size(81, 23);
            this.BtnConversion2.TabIndex = 11;
            this.BtnConversion2.Text = "Conversion";
            this.BtnConversion2.UseVisualStyleBackColor = true;
            this.BtnConversion2.Click += new System.EventHandler(this.BtnConversion2_Click);
            // 
            // BtnTry2
            // 
            this.BtnTry2.Location = new System.Drawing.Point(498, 246);
            this.BtnTry2.Name = "BtnTry2";
            this.BtnTry2.Size = new System.Drawing.Size(81, 23);
            this.BtnTry2.TabIndex = 10;
            this.BtnTry2.Text = "Try";
            this.BtnTry2.UseVisualStyleBackColor = true;
            this.BtnTry2.Click += new System.EventHandler(this.BtnTry2_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(204, 333);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 14;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(294, 333);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(75, 23);
            this.BtnPause.TabIndex = 15;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(382, 333);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(75, 23);
            this.BtnEnd.TabIndex = 16;
            this.BtnEnd.Text = "End";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // lblTimeToDisplay
            // 
            this.lblTimeToDisplay.AutoSize = true;
            this.lblTimeToDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeToDisplay.Location = new System.Drawing.Point(252, 264);
            this.lblTimeToDisplay.Name = "lblTimeToDisplay";
            this.lblTimeToDisplay.Size = new System.Drawing.Size(162, 63);
            this.lblTimeToDisplay.TabIndex = 17;
            this.lblTimeToDisplay.Text = "00:00";
            // 
            // ComBoxTeam1Players
            // 
            this.ComBoxTeam1Players.FormattingEnabled = true;
            this.ComBoxTeam1Players.Location = new System.Drawing.Point(84, 379);
            this.ComBoxTeam1Players.Name = "ComBoxTeam1Players";
            this.ComBoxTeam1Players.Size = new System.Drawing.Size(121, 21);
            this.ComBoxTeam1Players.TabIndex = 18;
            this.ComBoxTeam1Players.Text = "Team 1 Players";
            this.ComBoxTeam1Players.SelectedIndexChanged += new System.EventHandler(this.ComBoxTeam1Players_SelectedIndexChanged);
            // 
            // ComBoxTeam2Players
            // 
            this.ComBoxTeam2Players.FormattingEnabled = true;
            this.ComBoxTeam2Players.Location = new System.Drawing.Point(458, 379);
            this.ComBoxTeam2Players.Name = "ComBoxTeam2Players";
            this.ComBoxTeam2Players.Size = new System.Drawing.Size(121, 21);
            this.ComBoxTeam2Players.TabIndex = 19;
            this.ComBoxTeam2Players.Text = "Team 2 Players";
            this.ComBoxTeam2Players.SelectedIndexChanged += new System.EventHandler(this.ComBoxTeam2Players_SelectedIndexChanged);
            // 
            // TxtBDisplayStats
            // 
            this.TxtBDisplayStats.Location = new System.Drawing.Point(84, 445);
            this.TxtBDisplayStats.Multiline = true;
            this.TxtBDisplayStats.Name = "TxtBDisplayStats";
            this.TxtBDisplayStats.Size = new System.Drawing.Size(495, 236);
            this.TxtBDisplayStats.TabIndex = 20;
            // 
            // LblScore1
            // 
            this.LblScore1.AutoSize = true;
            this.LblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore1.Location = new System.Drawing.Point(199, 233);
            this.LblScore1.Name = "LblScore1";
            this.LblScore1.Size = new System.Drawing.Size(29, 31);
            this.LblScore1.TabIndex = 21;
            this.LblScore1.Text = "0";
            // 
            // LblScore2
            // 
            this.LblScore2.AutoSize = true;
            this.LblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore2.Location = new System.Drawing.Point(433, 233);
            this.LblScore2.Name = "LblScore2";
            this.LblScore2.Size = new System.Drawing.Size(29, 31);
            this.LblScore2.TabIndex = 22;
            this.LblScore2.Text = "0";
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.AutoSize = true;
            this.LblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorMessage.Location = new System.Drawing.Point(155, 416);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.LblErrorMessage.TabIndex = 23;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(294, 377);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 24;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnResetClick);
            // 
            // RugbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 680);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.LblScore2);
            this.Controls.Add(this.LblScore1);
            this.Controls.Add(this.TxtBDisplayStats);
            this.Controls.Add(this.ComBoxTeam2Players);
            this.Controls.Add(this.ComBoxTeam1Players);
            this.Controls.Add(this.lblTimeToDisplay);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnDropKick2);
            this.Controls.Add(this.BtnPenalty2);
            this.Controls.Add(this.BtnConversion2);
            this.Controls.Add(this.BtnTry2);
            this.Controls.Add(this.BtnDropKick1);
            this.Controls.Add(this.BtnPenalty1);
            this.Controls.Add(this.BtnConversion1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.BtnTry1);
            this.Controls.Add(this.VS);
            this.Controls.Add(this.PicBoxTeam2);
            this.Controls.Add(this.PicBoxTeam1);
            this.Controls.Add(this.GBTeam2);
            this.Controls.Add(this.GBTeam1);
            this.Name = "RugbyForm";
            this.Text = "Rugby Match";
            this.Load += new System.EventHandler(this.RugbyForm_Load);
            this.GBTeam1.ResumeLayout(false);
            this.GBTeam1.PerformLayout();
            this.GBTeam2.ResumeLayout(false);
            this.GBTeam2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxTeam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBTeam1;
        private System.Windows.Forms.RadioButton RadBtnIndia1;
        private System.Windows.Forms.RadioButton RadBtnAus1;
        private System.Windows.Forms.RadioButton RadBtnNZ1;
        private System.Windows.Forms.GroupBox GBTeam2;
        private System.Windows.Forms.RadioButton RadBtnIndia2;
        private System.Windows.Forms.RadioButton RadBtnNZ2;
        private System.Windows.Forms.RadioButton RadBtnAus2;
        private System.Windows.Forms.PictureBox PicBoxTeam1;
        private System.Windows.Forms.PictureBox PicBoxTeam2;
        private System.Windows.Forms.Label VS;
        private System.Windows.Forms.Button BtnTry1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button BtnConversion1;
        private System.Windows.Forms.Button BtnPenalty1;
        private System.Windows.Forms.Button BtnDropKick1;
        private System.Windows.Forms.Button BtnDropKick2;
        private System.Windows.Forms.Button BtnPenalty2;
        private System.Windows.Forms.Button BtnConversion2;
        private System.Windows.Forms.Button BtnTry2;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Label lblTimeToDisplay;
        private System.Windows.Forms.ComboBox ComBoxTeam1Players;
        private System.Windows.Forms.ComboBox ComBoxTeam2Players;
        private System.Windows.Forms.TextBox TxtBDisplayStats;
        private System.Windows.Forms.Label LblScore1;
        private System.Windows.Forms.Label LblScore2;
        private System.Windows.Forms.Label LblErrorMessage;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button BtnReset;
    }
}

