using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static SplashScreen splashscreen;
        public static displayList playlist;
        public static Form1 musicplayer;
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashscreen = new SplashScreen();
            splashscreen.Show();

            musicplayer = new Form1();
            musicplayer.Shown += musicplayer_Shown;

            playlist = new displayList();
            playlist.Hide();

            Application.Run(musicplayer);
        }

        private static void musicplayer_Shown(object sender, EventArgs e)
        {
            splashscreen.Hide();
        }
    }
}
