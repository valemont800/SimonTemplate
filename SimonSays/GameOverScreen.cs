using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //TODO: show the length of the pattern
            for(int i = 0; i < Form1.pattern.Count(); i++)
            {
                lengthLabel.Text = $"{Form1.pattern.Count()}";
            }

            //finalTimeLabel.Text = $"{Form1.timer}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //TODO: close this screen and open the MenuScreen
            Form f = FindForm();
            f.Controls.Remove(this);

            MenuScreen ms = new MenuScreen();

            f.Controls.Add(ms);
            ms.Focus();
        }

        private void lengthLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
