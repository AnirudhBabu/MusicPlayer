using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            //Sets size of splashscreen to size of background image and re-centers splash screen
            ClientSize = BackgroundImage.Size;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {           
            //determines location of loadingBar and loadingMessage based on new screen size
            loadingBar.Location = new Point((BackgroundImage.Width / 2) - 85, BackgroundImage.Height - 30);
            loadingMessage.Location = new Point((BackgroundImage.Width / 2) - 35, BackgroundImage.Height - 50);
        }
    }
}
