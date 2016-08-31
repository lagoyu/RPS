using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class frmRPS : Form
    {
        frmHelp help;
        // Constants declared here so they can be found and modified easily
        // and outside of the methods so that they are accessible to all methods

        // Using Constants for integers representing rock, paper and scissors
        // makes code clearer and helps the programmer avoid confusion
        const int ROCK = 0, PAPER = 1, SCISSORS = 2;
        
        // This delay constant is used for the length of reading time before next round. in milliseconds
        const int RESULT_DELAY = 2000;
        
        // Milliseconds delay between new computer random choices. The choices are always displayed, so you could try
        // increasing this to see if you can choose based on what the computer is thinking or reducing it to
        // see how fast the code can update the screen!
        const int ROTATOR_INTERVAL = 200;
 

        // Use this line to create a a 'Random' number generator which is hard to predict
        // Comment it out if you want to try  a fixed seed (see below)
        // Random rnd = new Random();

        // To produce an identical computer choice sequence every time
        // uncomment the following two lines and comment out the version above
        const int SEED = 1;
        Random rnd = new Random(SEED);

        // Declare a class-level variable. 
        // It's accessible (in scope) for all methods within this form (class)
        int intComputerChose; 
        
        public frmRPS()
        {
            InitializeComponent();
        }

        //*******************
        //  Event Handlers
        //*******************

        private void frmRPS_Load(object sender, EventArgs e)
        {
            // This event handler is triggered when the form is first loaded. 
            // It can be created by double clicking on the form background

            // Initialise timer intervals from constants
            tmrChoiceRotator.Interval = ROTATOR_INTERVAL;
            tmrReadingDelay.Interval = RESULT_DELAY;

            // Go into the stste where a user is choosing using buttons and computer is
            // choosing at random
            UserIsChoosing();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            // This event handler is triggered when user clicks the Rock button

            // Call method to set up controls for the state in which result of user input is being checked
            UserHasChosen();
            
            // Display image based for what the user chose
            picUser.Image = Properties.Resources.Rock;

            // Select an action based on what computer chose compared with Rock
            switch (intComputerChose)
            {
                case ROCK: 
                    Draw();
                    break;
                case SCISSORS:
                    UserWin();
                    break;
                case PAPER:
                    CompWin();
                    break;
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            // This event handler is triggered when user clicks the paper button

            // Call method to set up controls for the state in which result of user input is being checked
            UserHasChosen();

            // Display the image based on what the user chose
            picUser.Image = Properties.Resources.Paper;

            // Select an action based on what computer chose compared with Paper
            switch (intComputerChose)
            {
                case ROCK:
                    UserWin();
                    break;
                case SCISSORS:
                    CompWin();
                    break;
                case PAPER:
                    Draw();
                    break;
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            // This event handler is triggered when user clicks the Rock button

            // Call method to set up controls for the state in which result of user input is being checked
            UserHasChosen();

            // Display the image based on what the user chose
            picUser.Image = Properties.Resources.Scissors;

            // Select an action based on what computer chose compared with Scissors
            switch (intComputerChose)
            {
                case ROCK:
                    CompWin();
                    break;
                case SCISSORS:
                    Draw();
                    break;
                case PAPER:
                    UserWin();
                    break;
            }
        }

        private void tmrChoiceRotator_Tick(object sender, EventArgs e)
        {
            // This event handler is triggered at its specified Interval while tmrChoiceRotator is running
            // it picks a new random choice for the computer 
            // and displays images for user and computer to represent both thinking

            // intComputerChoice was declared at class level because it needs to be
            // remembered between calls to this method and visible within other methods
            // rnd.Next(3) uses the random number generator to give a value between 0 and 2
            intComputerChose = rnd.Next(3);

            // display a picture corresponding to the computer's current active choice
            switch (intComputerChose)
            {
                case ROCK:
                    picComp.Image = RockPaperScissors.Properties.Resources.Rock;
                    break;
                case SCISSORS:
                    picComp.Image = RockPaperScissors.Properties.Resources.Scissors;
                    break;
                case PAPER:
                    picComp.Image = RockPaperScissors.Properties.Resources.Paper;
                    break;
            }

            // intUserShow is a local variable declared here since it is not used elsewhere
            int intUserShow = rnd.Next(3);
            switch (intUserShow)
            {
                case ROCK:
                    picUser.Image = RockPaperScissors.Properties.Resources.Rock;
                    break;
                case SCISSORS:
                    picUser.Image = RockPaperScissors.Properties.Resources.Scissors;
                    break;
                case PAPER:
                    picUser.Image = RockPaperScissors.Properties.Resources.Paper;
                    break;
            }

        }

        private void tmrReadingDelay_Tick(object sender, EventArgs e)
        {
            // This event-handler runs after the user has had sufficient time to read last result. 
            // It begins the next round

            // Reading delay is complete, so disable this timer
            tmrReadingDelay.Enabled = false;

            // Call user method to set up controls for the UserIsChoosing state
            UserIsChoosing();

        }

        //***********************
        // User created methods
        //***********************

        private void CompWin()
        {
            // This method is called from button event-handlers to execute actions for a computer win 
            lblMessages.Text = "I Win!";
            lblMessages.BackColor = Color.LightPink;

            // convert current computer score label text to an integer
            // add one to it
            // convert back to a string and store back in label
            lblCompScore.Text = Convert.ToString( Convert.ToInt32(lblCompScore.Text) + 1 );
        }

        private void UserWin()
        {
            // This method is called from button event-handlers to execute actions for a user win 
            lblMessages.Text = "You Win!";
            lblMessages.BackColor = Color.LightGreen;

            // convert current user score label text to an integer 
            // add one to it
            // convert back to a string and store back in label
            lblUserScore.Text = Convert.ToString( Convert.ToInt32(lblUserScore.Text) + 1);
        }

        private void Draw()
        {
            // This method is called from button event-handlers to execute actions for a draw 
            lblMessages.Text = "No Winner";
            lblMessages.BackColor = Color.BurlyWood;
        }

        
        private void UserIsChoosing()
        {
            // This sets up conditions for user and computer to make their choices
            // It is called when the form first loads and also when each round is complete
            // and the user has had time to review the results of that round.

            //Enable choice buttons
            grpButtons.Enabled = true;

            //Enable the timer which keeps the computer making new choices on every tick
            tmrChoiceRotator.Enabled = true;

            // Change background colour to give a visual cue that choices are running
            this.BackColor = Color.LightGreen;

            // Tell the user what to do next
            lblMessages.Text = "It's time to choose...";
            lblMessages.BackColor = Color.LightYellow;

            // Move control focus off buttons so none is highlighted
            lblMessages.Focus();
        }
        
        private void UserHasChosen()
        {
            // This sets up conditions for user to see results of their choice
            // It is called as soon as a player clicks a button just before the
            // results of the round are determined and displayed in the message label
            // and score board.
            
            // Stop the timer which keeps the computer making choices
            tmrChoiceRotator.Enabled = false;

            // Change background colour to give a visual cue that choices are paused
            this.BackColor = Color.LightCyan;

            // Disable choice buttons
            grpButtons.Enabled = false;

            // Start the timer that gives user enough time to read the results
            tmrReadingDelay.Enabled = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (help == null)
            {
                help = new frmHelp();
            }
            help.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
       
    }

}
