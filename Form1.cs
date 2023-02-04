using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SurpriseForGirlfriend
{

    public partial class Surprise : Form
    {
        public Surprise()
        {
            InitializeComponent();
            Choice = 0;
        }

        public static int Choice { get; set; }


        public static int[] ReturnRandomPosition(System.Windows.Forms.Button button_yes, System.Windows.Forms.TextBox box_question)
        {
            Random rand = new Random();
            // Window Size - 50px 
            int wWidth = 450 - 50;
            int wHeight = 300 - 50;
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
                //Generate random number between 10 and the size of the window
                x = rand.Next(10,wWidth);
                y = rand.Next(10, wHeight);

                //Checking Collision with button
                if (!((x >= buttonWidthStart && x <= buttonWidthEnd) && (y >= buttonHeightStart && y <= buttonHeightEnd) ))
                {
                    // Checking Collision with box
                    if (!((x >= boxWidthStart && x <= boxWidthEnd) && (y >= boxHeightStart && y <= boxHeightEnd)))
                    {
                        notcollided = true;
                    }
                }

            }

            //Put generated numbers in array and return it
            pos[0] = x;
            pos[1] = y;
            return pos;
        }


        //When mouse hover the "no" button
        private void button_no_MouseEnter(object sender, EventArgs e)
        {
            int[] Pos = ReturnRandomPosition(button_yes, box_question);

            button_no.Location = new Point(Pos[0], Pos[1]);


        }
    }
}