using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamFinale
{
    public partial class ExamForm : Form
    {

        //preference 
        const int Board_SIZE_X = 450;
        const int Board_SIZE_Y = 450;

        const int BALL_DISTANCE_JUMP = 10;

        const int IMAGE_SIZE_X = 60;
        const int IMAGE_SIZE_Y = 60;

        const int MOVE_RIGHT = 1;
        const int MOVE_LEFT = 2;
        const int MOVE_UP = 3;
        const int MOVE_DOWN = 4;


        // global
        int counter = 0;
        int moving_to; // ball moving direction key
        int current_x = 195;
        int current_y = 195; // ball current location





        public ExamForm()
        {
            InitializeComponent();

        }

        private void TextBoxNub_TextChanged(object sender, EventArgs e)
        {
            int textboxINT = CheckIfInt();

            if (textboxINT == 0 && TextBoxNub.Text == "0")
            {
                TextBoxLeb.Text = "zero";
            }


            if (textboxINT < 0)
            {
                TextBoxLeb.Text = "negative";
            }


            if (textboxINT > 0)
            {
                TextBoxLeb.Text = "positive";
            }

        }

        private int CheckIfInt() // check if the user insert a number 
        {
            int textboxINT;
            if (!int.TryParse(TextBoxNub.Text, out textboxINT))
            {
                TextBoxLeb.Text = "NaN";
            }


            return textboxINT;
        }

        private void progressBt_Click(object sender, EventArgs e)
        {
            if (timerProgress.Enabled == true)
            {
                
                timerProgress.Stop();
                progressBt.Text = "Start";
            }
            else
            {
                
                timerProgress.Start();
                progressBt.Text = "Stop";
            }
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            progresLeb.Text = counter.ToString();
            progressBar.Value = counter;

            counter++;
            if (counter >= 101)
            {
                timerProgress.Enabled = false;
                progressBt.Enabled = false;
            }

        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

            ballPbox.Location = new Point(current_x, current_y);
            BoardPn.Size = new Size(Board_SIZE_X, Board_SIZE_Y);





            this.KeyPreview = true;


            switch (moving_to)
            {
                case MOVE_RIGHT:
                    current_x = current_x + BALL_DISTANCE_JUMP;
                    ballPbox.Location = new Point(current_x, current_y);
                    break;
                case MOVE_LEFT:
                    current_x = current_x - BALL_DISTANCE_JUMP;
                    ballPbox.Location = new Point(current_x, current_y);
                    break;
                case MOVE_UP:
                    current_y = current_y - BALL_DISTANCE_JUMP;
                    ballPbox.Location = new Point(current_x, current_y);
                    break;
                case MOVE_DOWN:
                    current_y = current_y + BALL_DISTANCE_JUMP;
                    ballPbox.Location = new Point(current_x, current_y);
                    break;
            }
            if (current_x < 0 || current_y < 0 || current_y > Board_SIZE_Y - IMAGE_SIZE_Y || current_x > Board_SIZE_X - IMAGE_SIZE_X)
            {
                GameOver();

                return;
            }
        }
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.Left:
                    moving_to = MOVE_LEFT;
                    break;
                case Keys.Right:
                    moving_to = MOVE_RIGHT;
                    break;
                case Keys.Up:
                    moving_to = MOVE_UP;
                    break;
                case Keys.Down:
                    moving_to = MOVE_DOWN;
                    break;
            }          
        }

        private void upBt_Click(object sender, EventArgs e)
        {
            if (current_x < 0 || current_y < 0 || current_y > Board_SIZE_Y - IMAGE_SIZE_Y || current_x > Board_SIZE_X - IMAGE_SIZE_X)
            {
                GameOver();             
            }
            current_y = current_y - BALL_DISTANCE_JUMP;
            ballPbox.Location = new Point(current_x, current_y);
           
        }

        private void downBt_Click(object sender, EventArgs e)
        {
            if (current_x < 0 || current_y < 0 || current_y > Board_SIZE_Y - IMAGE_SIZE_Y || current_x > Board_SIZE_X - IMAGE_SIZE_X)
            {
                GameOver();

                return;
            }
            current_y = current_y + BALL_DISTANCE_JUMP;
            ballPbox.Location = new Point(current_x, current_y);
            return;
        }

        private void leftBt_Click(object sender, EventArgs e)
        {
            if (current_x < 0 || current_y < 0 || current_y > Board_SIZE_Y - IMAGE_SIZE_Y || current_x > Board_SIZE_X - IMAGE_SIZE_X)
            {
                GameOver();

                return;
            }
            current_x = current_x - BALL_DISTANCE_JUMP;
            ballPbox.Location = new Point(current_x, current_y);
            return;
        }

        private void rightBt_Click(object sender, EventArgs e)
        {
            if (current_x < 0 || current_y < 0 || current_y > Board_SIZE_Y - IMAGE_SIZE_Y || current_x > Board_SIZE_X - IMAGE_SIZE_X)
            {
                GameOver();

                return;
            }
            current_x = current_x + BALL_DISTANCE_JUMP;
            ballPbox.Location = new Point(current_x, current_y);
            return;
        }

        private void GameOver()
        {
            MessageBox.Show("your ball out of the line :)", "Game Over");
            ballPbox.Location = new Point(195, 195);
           current_x = 195;
           current_y = 195;
        }
    }
}
