using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;
using SimonSays.Properties;
using System.Diagnostics;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create an int guess variable to track what part of the pattern the user is at
        public static Stopwatch myWatch = new StopWatch();

        int guess;


        SoundPlayer greenSound = new SoundPlayer(SimonSays.Properties.Resources.green);
        SoundPlayer redSound = new SoundPlayer(SimonSays.Properties.Resources.red);
        SoundPlayer blueSound = new SoundPlayer(SimonSays.Properties.Resources.blue);
        SoundPlayer yellowSound = new SoundPlayer(SimonSays.Properties.Resources.yellow);
        SoundPlayer mistakeSound = new SoundPlayer(SimonSays.Properties.Resources.mistake);

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(5, 5, 100, 100);
            Region buttonRegion = new Region(circlePath);

            //greenButton.Region = buttonRegion;

            //Matrix transformMatrix = new Matrix();
            //transformMatrix.RotateAt(90, new PointF(25, 25));

            //buttonRegion.Transform(transformMatrix);
            //greenButton.Region = buttonRegion;

            //Circle Buttons :]
            greenButton.Region = new Region(circlePath);
            yellowButton.Region = new Region(circlePath);
            blueButton.Region = new Region(circlePath);
            redButton.Region = new Region(circlePath);



            //TODO: clear the pattern list from form1
            Form1.pattern.Clear();
            //TODO: refresh
            Refresh();
            //TODO: pause for a bit
            Thread.Sleep(250);
            //Refresh timer
            //Form1.timer = 0;
            //TODO: run ComputerTurn()

            ComputerTurn();
        }

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list. Each number represents a button. For example, 0 may be green, 1 may be blue, etc.
            Random randGen = new Random();

            Form1.pattern.Add(randGen.Next(0, 4));
           

            Thread.Sleep(250);

            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.pattern.Count; i++)
            {

            


                if ( Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.Lime;
                    greenSound.Play();
                    Refresh();
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.ForestGreen;
                    Refresh();
                }
                else if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    redSound.Play();
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();

                }
                else if (Form1.pattern[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    yellowSound.Play();
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();

                }
                else if (Form1.pattern[i] == 3)
                {
                    blueButton.BackColor = Color.RoyalBlue;
                    blueSound.Play();
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();

                }

            }
            //TODO: set guess value back to 0
            guess = 0;
        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {

            //Colour = ForestGreen
            //TODO: is the value in the pattern list at index [guess] equal to a green?
            if (Form1.pattern[guess] == 0)
            {
                // change button color
                greenButton.BackColor = Color.Lime;
                // play sound
                Refresh();
                greenSound.Play();
                // refresh
                Refresh();
                // pause
                Thread.Sleep(250);
                // set button colour back to original
                greenButton.BackColor = Color.ForestGreen;
                // add one to the guess variable
                guess++;


            }
            else
            {
                GameOver();
            }

            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method
            // else call GameOver method
            CheckLose();

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            //Colour = DarkRed
            if (Form1.pattern[guess] == 1)
            {
                // change button color
                redButton.BackColor = Color.Red;
                Refresh();
                // play sound
                redSound.Play();
                // refresh
                Refresh();
                // pause
                Thread.Sleep(250);
                // set button colour back to original
                redButton.BackColor = Color.DarkRed;
                // add one to the guess variable
                guess++;


            }
            else
            {
                GameOver();
            }



            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method
            // else call GameOver method
            CheckLose();



        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            //Colour = GoldenRod
            if (Form1.pattern[guess] == 2)
            {
                // change button color
                yellowButton.BackColor = Color.Yellow;
                Refresh();
                // play sound
                yellowSound.Play();
                // refresh
                Refresh();
                // pause
                Thread.Sleep(250);
                // set button colour back to original
                yellowButton.BackColor = Color.Goldenrod;
                // add one to the guess variable
                Refresh();
                guess++;
            }
            else
            {
                GameOver();
            }
            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method
            // else call GameOver method
            CheckLose();
            
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            //Colour = DarkBlue
            if (Form1.pattern[guess] == 3)
            {
                // change button color
                blueButton.BackColor = Color.RoyalBlue;
                Refresh();
                // play sound
                blueSound.Play();
                // refresh
                Refresh();
                // pause
                Thread.Sleep(250);
                // set button colour back to original
                blueButton.BackColor = Color.DarkBlue;
                // add one to the guess variable
                guess++;
            }
            else
            {
                GameOver();
            }

            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method
            // else call GameOver method
            CheckLose();

        }

        public void GameOver()
        {
            //TODO: Play a game over sound
            mistakeSound.Play();
            //TODO: close this screen and open the GameOverScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen gos = new GameOverScreen();

            f.Controls.Add(gos);
            gos.Focus();

        }

        public void CheckLose()
        {
            if (guess == Form1.pattern.Count)
            {
                ComputerTurn();
            }
        }

        private void StopWatch_Tick(object sender, EventArgs e)
        {

        }


    }
}
