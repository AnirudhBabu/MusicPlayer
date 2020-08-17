using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            ClientSize = BackgroundImage.Size;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {           
            loadingBar.Location = new Point((BackgroundImage.Width / 2) - 85, BackgroundImage.Height - 30);
            loadingMessage.Location = new Point((BackgroundImage.Width / 2) - 35, BackgroundImage.Height - 50);
        }
    }
}
