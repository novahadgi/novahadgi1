using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР_4
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int number1;
        int number2;

        int minuend;
        int subtrahend;
        int multiplicand;
        int multiplier;
        int dividend;
        int divisor;

        int timeLeft;
        public Form1()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;

           
        }

        public void StartTheQuiz()
        {
            number1 = random.Next(51);
            number2= random.Next(51);

            plusLeftLalel.Text = number1.ToString();
            plusRightLabel.Text = number2.ToString();
            sum.Value = 0;

            minuend = random.Next(1, 101);
            subtrahend = random.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            different.Value = 0;

            multiplicand = random.Next(2, 11);
            multiplier = random.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            divisor = random.Next(2, 11);
            int temporaryQuotient = random.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 60;
            timeLabel.Text = "60 Секунд";
            timer1.Start();
          


        }
        private bool CheckTheAnswer()
        {
            if ((number1 + number1 == sum.Value)
                && (minuend - subtrahend == different.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }


            private void Form1_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(500, 400);
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(200, 30);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Ну ты и бот, не смог решить такой простой тест",
                                "Разработан Фарзиком");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " СЕКУНД";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "КОНЕЦ";
                MessageBox.Show("Красавчик, решил легкий тест Фарида");
                sum.Value = number1 + number2;
                different.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }

        }
        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

    }
}
