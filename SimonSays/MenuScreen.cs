using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;
using System.Threading;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {

        //SoundPlayer menuMusic = new SoundPlayer(Properties.Resources.nineshopsept);

        public MenuScreen()
        {
            InitializeComponent();

            //menuMusic.Play();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //TODO: remove this screen and start the GameScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();

            f.Controls.Add(gs);
            gs.Focus();



        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: end the application
            Application.Exit();
        }
    }
}
