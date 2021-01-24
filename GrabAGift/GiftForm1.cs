using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAGift {
    public partial class GiftForm1 : Form {
        Random random = new Random();
        Label label;
        Label click;
        int points;
        SoundPlayer correctSound = new SoundPlayer(GrabAGift.Properties.Resources.button_1);
        SoundPlayer wrongSound = new SoundPlayer(GrabAGift.Properties.Resources.fart_01);



        public GiftForm1() {
            InitializeComponent();
            GameTimer.Start();
            AssignGiftToSquare();

        }

        private void AssignGiftToSquare() {

            int randomNumber = random.Next(0, tableLayoutPanel1.Controls.Count);
            if (tableLayoutPanel1.Controls[randomNumber] is Label)
                label = (Label)tableLayoutPanel1.Controls[randomNumber];
            else return;
            label.ForeColor = Color.Black;
            RandomTimer.Start();

        }

        private void MouseClick(object sender, EventArgs e) {
            click = sender as Label;
            if (click.ForeColor == Color.Black) {
                // SystemSounds.Exclamation.Play();
                correctSound.Play();
                // SystemSounds.Beep.Play();
                points++;
                label.ForeColor = label.BackColor;
            }
            else {
                wrongSound.Play();
                points--;
            }

        }

        private void GameTimer_Tick(object sender, EventArgs e) {
            GameTimer.Stop();
            MessageBox.Show($"Your score is {points}");
            Close();
        }

        private void RandomTimer_Tick(object sender, EventArgs e) {
            RandomTimer.Stop();
            label.ForeColor = label.BackColor;
            AssignGiftToSquare();
        }
    }
}
