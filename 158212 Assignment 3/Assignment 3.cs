using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _158212_Assignment_3
{
    public partial class RugbyForm : Form
    {
        public RugbyForm()
        {
            InitializeComponent();
        }
        //Kelly Pitts 09098321

        //Global variables
        private int teamChosenNumber1 = -1, teamChosenNumber2 = -1;
        private int try1 = 0, try2 = 0;
        private int conversion1 = 0, conversion2 = 0;
        private int penalty1 = 0, penalty2 = 0;
        private int dropKick1 = 0, dropKick2 = 0;
        private int scoreTotal1 = 0, scoreTotal2 = 0;
        private int second = 0, minute = 0;
        private string teamChosen1, teamChosen2;
        private string playerThatScored1, playerThatScored2;
        private string timeDisplay = "";
        private bool timerStarted = false;
        private bool gameEnded = false;
        private bool resetPressed = false;

        //Fuction to check that a player has been selected from the comboBox
        public bool ScoreValidation(int playerSelected)
        {
            if (playerSelected == -1)
            {
                LblErrorMessage.Text = "Please enter a valid Player from the drop down menu.";
                return true;
            }
            LblErrorMessage.Text = "";
            return false;
        }

        //Fuction to check that 2 teams have been selected
        public bool TeamNotSelected()
        {
            //if either teams have not been selected
            //user will be asked to select the teams.
            if (teamChosenNumber1 == -1 || teamChosenNumber2 == -1)
            {
                LblErrorMessage.Text = "Please select 2 teams.";
                return true;
            }
            LblErrorMessage.Text = "";
            return false;
        }

        //Fuction to check that the timer has been started
        private bool timerNotStarted()
        {
            //if timer has not started user will be asked to press start.
            if(!timerStarted)
            {
                LblErrorMessage.Text = "Please press start to start a game.";
                return true;
            }
            LblErrorMessage.Text = "";
            return false;
        }

        //Function to add NZ players to the comboBox
        public string NZTeam(ComboBox teamNZ)
        {
            teamNZ.Items.Clear();
            teamNZ.Items.Add("Dan Carter");
            teamNZ.Items.Add("Richie McCaw");
            teamNZ.Items.Add("Ma'a Nonu");
            return "NZL";
        }

        //Function to add Aus players to the comboBox
        public string AusTeam(ComboBox teamAus)
        {
            teamAus.Items.Clear();
            teamAus.Items.Add("Israel Folau");
            teamAus.Items.Add("David Pocock");
            teamAus.Items.Add("Quade Cooper");
            return "AUS";
        }

        //Function to add India players to the comboBox
        public string IndiaTeam(ComboBox teamIndia)
        {
            teamIndia.Items.Clear();
            teamIndia.Items.Add("Parvender Singh");
            teamIndia.Items.Add("Suresh Sajwan");
            teamIndia.Items.Add("Surinder Singh");
            return "India";
        }

        //Team 1 setup -----------------------------------------------------------------------
        private void RadBtnNZ1CheckedChanged(object sender, EventArgs e)
        {
            PicBoxTeam1.Image = Properties.Resources.NZ;
            teamChosenNumber1 = 0;
            teamChosen1 = NZTeam(ComBoxTeam1Players);
        }

        private void RadBtnAus1CheckedChanged(object sender, EventArgs e)
        {
            PicBoxTeam1.Image = Properties.Resources.AUS;
            teamChosenNumber1 = 1;
            teamChosen1 = AusTeam(ComBoxTeam1Players);
        }

        private void RadBtnIndia1CheckedChanged(object sender, EventArgs e)
        {
            PicBoxTeam1.Image = Properties.Resources.Indian;
            teamChosenNumber1 = 2;
            teamChosen1 = IndiaTeam(ComBoxTeam1Players);
        }

        //Team 2 setup -----------------------------------------------------
        private void RadBtnNZ2CheckedChanged(object sender, EventArgs e)
        {
            PicBoxTeam2.Image = Properties.Resources.NZ;
            teamChosenNumber2 = 0;
            teamChosen2 = NZTeam(ComBoxTeam2Players);
        }

        private void RadBtnAus2CheckedChanged(object sender, EventArgs e)
        {
            PicBoxTeam2.Image = Properties.Resources.AUS;
            teamChosenNumber2 = 1;
            teamChosen2 = AusTeam(ComBoxTeam2Players);
        }

        private void RadBtnIndia2CheckedChanged(object sender, EventArgs e)
        {
            PicBoxTeam2.Image = Properties.Resources.Indian;
            teamChosenNumber2 = 2;
            teamChosen2 = IndiaTeam(ComBoxTeam2Players);
        }

        //ComboBox for the first team.
        private void ComBoxTeam1Players_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking that both teams have been selected
            if (TeamNotSelected())
            {
                return;
            }
            playerThatScored1 = ComBoxTeam1Players.SelectedItem.ToString();
        }

        //ComboBox for the second team.
        private void ComBoxTeam2Players_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking that both teams have been selected
            if (TeamNotSelected())
            {
                return;
            }
            playerThatScored2 = ComBoxTeam2Players.SelectedItem.ToString();
        }

        //Function Checking validation
        public bool ValidationCheck(int team)
        {
            //Checking that a player has been selected
            if (ScoreValidation(team))
            {
                return true;
            }
            //Checking that the timer has started
            if (timerNotStarted())
            {
                return true;
            }
            return false;
        }

        public string DisplayTry(string team, string scoreType, string player)
        {
            return (team + " scored a " + scoreType +" at: " + timeDisplay + " by " + player + Environment.NewLine);
        }

        //team 1 buttons ------------------------------------------------------------------
        private void BtnTry1_Click(object sender, EventArgs e)
        {
            if (ValidationCheck(ComBoxTeam1Players.SelectedIndex))
            {
                return;
            }
            try1 += 1;
            scoreTotal1 += 5;
            TxtBDisplayStats.Text += DisplayTry(teamChosen1, "try", playerThatScored1);
            LblScore1.Text = scoreTotal1.ToString();
        }

        private void BtnConversion1_Click(object sender, EventArgs e)
        {
            if (ValidationCheck(ComBoxTeam1Players.SelectedIndex))
            {
                return;
            }
            conversion1 += 1;
            scoreTotal1 += 2;
            TxtBDisplayStats.Text += DisplayTry(teamChosen1, "conversion", playerThatScored1);
            LblScore1.Text = scoreTotal1.ToString();
        }

        private void BtnPenalty1_Click(object sender, EventArgs e)
        {
            if (ValidationCheck(ComBoxTeam1Players.SelectedIndex))
            {
                return;
            }
            penalty1 += 1;
            scoreTotal1 += 3;
            TxtBDisplayStats.Text += DisplayTry(teamChosen1, "penalty", playerThatScored1);
            LblScore1.Text = scoreTotal1.ToString();
        }

        private void BtnDropKick1_Click(object sender, EventArgs e)
        {
            if (ValidationCheck(ComBoxTeam1Players.SelectedIndex))
            {
                return;
            }
            dropKick1 += 1;
            scoreTotal1 += 3;
            TxtBDisplayStats.Text += DisplayTry(teamChosen1, "drop kick", playerThatScored1);
            LblScore1.Text = scoreTotal1.ToString();
        }

        //Team 2 buttons ------------------------------------------------------------------
        private void BtnTry2_Click(object sender, EventArgs e)
        {
            if (ValidationCheck(ComBoxTeam2Players.SelectedIndex))
            {
                return;
            }
            try2 += 1;
            scoreTotal2 += 5;
            TxtBDisplayStats.Text += DisplayTry(teamChosen2, "try", playerThatScored2);
            LblScore2.Text = scoreTotal2.ToString();
        }

        private void BtnConversion2_Click(object sender, EventArgs e)
        {
            if (ValidationCheck(ComBoxTeam2Players.SelectedIndex))
            {
                return;
            }
            conversion2 += 1;
            scoreTotal2 += 2;
            TxtBDisplayStats.Text += DisplayTry(teamChosen2, "conversion", playerThatScored2);
            LblScore2.Text = scoreTotal2.ToString();
        }

        private void BtnPenalty2_Click(object sender, EventArgs e)
        {
            if (ValidationCheck(ComBoxTeam2Players.SelectedIndex))
            {
                return;
            }
            penalty2 += 1;
            scoreTotal2 += 3;
            TxtBDisplayStats.Text += DisplayTry(teamChosen2, "penalty", playerThatScored2);
            LblScore2.Text = scoreTotal2.ToString();
        }

        private void BtnDropKick2_Click(object sender, EventArgs e)
        {
            if (ValidationCheck(ComBoxTeam2Players.SelectedIndex))
            {
                return;
            }
            dropKick2 += 1;
            scoreTotal2 += 3;
            TxtBDisplayStats.Text += DisplayTry(teamChosen2, "drop kick", playerThatScored2);
            LblScore2.Text = scoreTotal2.ToString();
        }

        //Game will start once Start button has been pressed
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //Making sure user presses reset to reset all values to original state
            //before continuing
            if (gameEnded && !resetPressed)
            {
                LblErrorMessage.Text = "Game has ended, press reset to start again";
                return;
            }
            //Checking that both teams have been selected
            if (TeamNotSelected())
            {
                return;
            }
            //Checking that the teams selected are not the same.
            if (teamChosenNumber1 == teamChosenNumber2)
            {
                LblErrorMessage.Text = "Please select 2 different teams";
                return;
            }
            timerStarted = true;
            gameEnded = false;
            GameTimer.Start();
        }

        //Fuction to pause the timer.
        //Once paused user cannot score any points (timeStarted has been set to false)
        private void BtnPause_Click(object sender, EventArgs e)
        {
            timerStarted = false;
            GameTimer.Stop();
        }

        private void MatchStats(int tri, int con, int pen, int dropk)
        {
            if (tri != 0)
            {
                TxtBDisplayStats.Text += "Tries: " + tri + Environment.NewLine;
            }
            if (con != 0)
            {
                TxtBDisplayStats.Text += "Conversions: " + con + Environment.NewLine;
            }
            if (pen != 0)
            {
                TxtBDisplayStats.Text += "Penalties: " + pen + Environment.NewLine;
            }
            if (dropk != 0)
            {
                TxtBDisplayStats.Text += "Drop Kicks: " + dropk + Environment.NewLine;
            }
        }

        //Fuction to end the game
        //Once 'end' button has been pressed the textBox will display the stats 
        //in order of the winning team
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            if (gameEnded)
            {
                return;
            }
            timerStarted = false;
            TxtBDisplayStats.Text += "===MATCH STATS===" + Environment.NewLine;
            if (scoreTotal1 > scoreTotal2)
            {
                TxtBDisplayStats.Text += "WINNER is: " + teamChosen1 + Environment.NewLine
                + teamChosen1 + " stats: " + Environment.NewLine;
                MatchStats(try1, conversion1, penalty1, dropKick1);
                TxtBDisplayStats.Text += teamChosen2 + " stats: " + Environment.NewLine;
                MatchStats(try2, conversion2, penalty2, dropKick2);

            } else if (scoreTotal2 > scoreTotal1)
            {
                TxtBDisplayStats.Text += "WINNER is: " + teamChosen2 + Environment.NewLine
                + teamChosen2 + " stats: " + Environment.NewLine;
                MatchStats(try2, conversion2, penalty2, dropKick2);
                TxtBDisplayStats.Text += teamChosen1 + " stats: " + Environment.NewLine;
                MatchStats(try1, conversion1, penalty1, dropKick1);
            }
            else
            {
                TxtBDisplayStats.Text += "The match is a tie!!" + Environment.NewLine
                + teamChosen1 + " stats: " + Environment.NewLine;
                MatchStats(try1, conversion1, penalty1, dropKick1);
                TxtBDisplayStats.Text += teamChosen2 + " stats: " + Environment.NewLine;
                MatchStats(try2, conversion2, penalty2, dropKick2);
            }
            gameEnded = true;
            GameTimer.Stop();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if(second < 60)
            {
                second += GameTimer.Interval / 1000;
            }
            if (second % 60 == 0)
            {
                minute += 1;
                second = 0;
            }
            timeDisplay = minute.ToString("D2") + ":" + second.ToString("D2");
            lblTimeToDisplay.Text = timeDisplay;
        }

        private void BtnResetClick(object sender, EventArgs e)
        {
            GameTimer.Stop();
            teamChosen1 = "";
            teamChosen2 = "";
            LblErrorMessage.Text = "";
            playerThatScored1 = "";
            playerThatScored2 = "";
            TxtBDisplayStats.Text = "";
            timeDisplay = "";
            ComBoxTeam1Players.Text = "Team 1 Players";
            ComBoxTeam2Players.Text = "Team 2 Players";
            LblScore1.Text = "0";
            LblScore2.Text = "0";
            lblTimeToDisplay.Text = "00:00";
            gameEnded = true;
            resetPressed = true;
            timerStarted = false;
            RadBtnNZ1.Checked = false;
            RadBtnNZ2.Checked = false;
            RadBtnAus1.Checked = false;
            RadBtnAus2.Checked = false;
            RadBtnIndia1.Checked = false;
            RadBtnIndia2.Checked = false;
            PicBoxTeam1.Image = null;
            PicBoxTeam2.Image = null;
            ComBoxTeam1Players.Items.Clear();
            ComBoxTeam2Players.Items.Clear();
            teamChosenNumber1 = -1;
            teamChosenNumber2 = -1;
            try1 = 0; try2 = 0;
            conversion1 = 0; conversion2 = 0;
            penalty1 = 0; penalty2 = 0;
            dropKick1 = 0; dropKick2 = 0;
            scoreTotal1 = 0; scoreTotal2 = 0;
            second = 0; minute = 0;
        }

        private void RugbyForm_Load(object sender, EventArgs e)
        {
            RadBtnNZ1.AutoCheck = true;
            RadBtnNZ2.AutoCheck = true;
        }
    }
}
