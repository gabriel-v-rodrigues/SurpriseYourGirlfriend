using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SurpriseForGirlfriend
{

    public partial class Surprise : Form
    {
        public Surprise()
        {
            InitializeComponent();
            QuestionCount = 0;
            // INSERT First or Start Question here           !!!!!!!IMPORTANT
            box_question.Text = "Do you want to be my girlfriend?";
        }

        // Count for questions
        public static int QuestionCount { get; set; }

        // Where the questions are generated
        public static string Question() {
            string question = "";

            // Add questions adding cases to increment it (no need to change anything else)   !!!!!!!IMPORTANT
            switch (QuestionCount)
            {
                case 0: question = "Are you sure about this?"; break;
                case 1: question = "Once you go, there is no going back, ok?"; break;
                case 2: question = "Do you really want that much to be my GF?"; break;
                case 3: question = "Do you know that i really love you?"; break;
                case 4: question = "Last chance, do you really want to be my girlfriend?"; break;
            }

            // Increment and Return it
            QuestionCount++;
            return question;
        }


        public static int[] ReturnRandomPosition(System.Windows.Forms.Button button_yes, System.Windows.Forms.TextBox box_question)
        {
            // Window Size - 50px // IF YOU CHANGE THE WINDOW SIZE, ADJUST IT HERE  !!!!!!!IMPORTANT
            int wWidth = 450 - 50;
            int wHeight = 300 - 50;
            //
            Random rand = new Random();
            int[] pos = new int[2];
            int x = 0;
            int y = 0;
            bool notcollided = false;
            // Button Properties
            int buttonWidthStart = button_yes.Left;
            int buttonWidthEnd = button_yes.Left + button_yes.Size.Width;
            int buttonHeightStart = button_yes.Top;
            int buttonHeightEnd = button_yes.Top + button_yes.Size.Height;
            // Box Properties
            int boxWidthStart = box_question.Left;
            int boxWidthEnd = box_question.Left + box_question.Size.Width;
            int boxHeightStart = box_question.Top;
            int boxHeightEnd = box_question.Top + box_question.Size.Height;


            // Start Generating and checking collide
            while (notcollided == false)
            { 
                // Generate random number between 10 and the size of the window
                x = rand.Next(10,wWidth);
                y = rand.Next(10, wHeight);

                // Checking Collision with button
                if (!((x >= buttonWidthStart && x <= buttonWidthEnd) && (y >= buttonHeightStart && y <= buttonHeightEnd) ))
                {
                    // Checking Collision with box
                    if (!((x >= boxWidthStart && x <= boxWidthEnd) && (y >= boxHeightStart && y <= boxHeightEnd)))
                    {
                        notcollided = true;
                    }
                }

            }

            // Put generated numbers in array and return it
            pos[0] = x;
            pos[1] = y;
            return pos;
        }


        // When mouse hover the "no" button
        private void button_no_MouseEnter(object sender, EventArgs e)
        {
            //Generate the positions using the method
            int[] Pos = ReturnRandomPosition(button_yes, box_question);

            //Set it's position
            button_no.Location = new Point(Pos[0], Pos[1]);


        }

        // When pressing the "yes" button
        private void button_yes_Click(object sender, EventArgs e)
        {
            string question = Question();
            // if all questions have ended and returned nothing
            if (question == "")
            {
                //remove buttons
                button_no.Visible = false;
                button_yes.Visible = false;
                // Display this text as last           !!!!!!!IMPORTANT
                box_question.Text = "Ok, i am your boyfriend now :D";
            }
            // show question
            else { box_question.Text = question; }
        }
    }
}