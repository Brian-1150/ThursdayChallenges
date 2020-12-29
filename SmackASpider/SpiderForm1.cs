using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmackASpider {
    public partial class SpiderForm1 : Form {
        Random random = new Random();
            Label label;
        Label click;
        int points;

        public SpiderForm1() {
            InitializeComponent();
            GameTimer.Start();
            AssignSpiderToSquare();

        }

        private void AssignSpiderToSquare() {
            while (GameTimer.Enabled) {
                int randomNumber = random.Next(0, tableLayoutPanel1.Controls.Count);
                if (tableLayoutPanel1.Controls[randomNumber] is Label)
                    label = (Label)tableLayoutPanel1.Controls[randomNumber];
                else return;
                label.ForeColor = Color.Black;
                timer1.Start();
            }

        }

        private void afterTicks(object sender, EventArgs e) {
            timer1.Stop();
            label.ForeColor = label.BackColor;
        }

        private void label1_Click(object sender, EventArgs e) {
            click = sender as Label;
            if (click.ForeColor == Color.Black)
                points++;
        }

        private void EndGame(object sender, EventArgs e) {
            GameTimer.Stop();
            MessageBox.Show($"Your score is {points}");
        }
    }
}
