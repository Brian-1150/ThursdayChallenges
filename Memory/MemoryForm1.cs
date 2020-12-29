using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory {
    public partial class MemoryForm1 : Form {
        Random random = new Random();
        Form f = new MessageForm();
        List<string> pics = new List<string>() { "L", "O", "p", "b", "e", "J",
            "N", "Y", "L", "O", "p", "b", "e", "J", "N", "Y" };  //these will be like clipart images with webdings font

        Label firstClick;
        Label secondClick;
        int count = 10;
        int CorrectGuesses = 0;
        
        
        
        public MemoryForm1() {
            InitializeComponent();
            AssignPicsToSquares();  //calls method to initialize game
            MessageBox.Show("You begin with ten guesses and one is used for every wrong guess.  You must complete" +
                "the game before you run out of guesses.");
            StartPosition = FormStartPosition.Manual;
            Location = new Point(500, 55);
        }

        
        private void AssignPicsToSquares() { // this method is used to randomly assign values to the squares for the beginning of the game
            Label label;
            int randomNumber;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++) {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else continue;  //just to confirm we are on an actual label and break out if not
                randomNumber = random.Next(0, pics.Count);  //creates a random number in the range of how many squares we have
                label.Text = pics[randomNumber];
                pics.RemoveAt(randomNumber); //to use every item from the list once only
            }
        }

        private void click(object sender, EventArgs e) {

            if (firstClick != null && secondClick != null) //prevents a third choice by returning if both clicks have already been made
                return;
            Label clickedLabel = sender as Label; //as keyword trys to convert sender to label, else clickedLabel will be null
            if (clickedLabel == null)
                return;
            if (clickedLabel.ForeColor == Color.Black)
                return;  // prevents user from clicking square that is already showing

            if (firstClick == null) { //so we know that this is the first click
                firstClick = clickedLabel;
                firstClick.ForeColor = Color.Black; //to reveal the image
                return;
            }
            secondClick = clickedLabel; //if statement not needed because it already checked for first click
            secondClick.ForeColor = Color.Black;

            if (firstClick.Text == secondClick.Text) {// this will leave these images as black so they show as a correct match for the rest of the game
                firstClick = null;
                secondClick = null;
                CorrectGuesses++;
                if (CorrectGuesses == 8) {
                    MessageBox.Show("Congratulations! You win");
                    Close();
                }
            } else
            timer1.Start();//starts timer after 2 choices have been made
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timer1.Stop(); //stop timer because the 1000 miliseconds have elapsed
            firstClick.ForeColor = Color.Green; //resets to be invisible again
            secondClick.ForeColor = Color.Green;
            count--;
            if (count == 0) {

                MessageBox.Show("Sorry!  You lose!");
                Close();
            }

            else  // AutoClosingMessageBox.Show($"You have {count} guesses remaining", "Status", 1500);

                Console.WriteLine($"You have {count} guesses remaining");

            firstClick = null;
            secondClick = null;
        }

        public class AutoClosingMessageBox {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout) {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout) {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state) {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void MemoryForm1_Load(object sender, EventArgs e) {

        }
    }

       
    }
