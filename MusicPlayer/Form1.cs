using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using WMPLib;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public static WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        private PlayList currObj;

        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }
        private void importMusicButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                ofd.Filter = "All Supported Audio |*.mp3;*wma | MP3s |*.mp3 |WMAs|*.wma";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    wplayer.settings.autoStart = false;
                    wplayer.URL = ofd.FileName;
                }
            }
        }

        public void playButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
            playButton.Hide();
            pauseButton.Show();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fastForwardButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.fastForward();
        }

        private void fastReverseButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.fastReverse();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.pause();
            pauseButton.Hide();
            playButton.Show();
        }

        private void btnRedirect_Click(object sender, EventArgs e)
        {
            Program.playlist.Show();
            Program.musicplayer.Hide();
        }

        private void playListItems_DoubleClick(object sender, EventArgs e)
        {
            playListItems.Hide();

            ListBox sent = (ListBox)sender;
            List<string> playListNames = new List<string>();
            try
            {
                playListNames = PlayList.PlaylistNames.ToList();                
            }
            catch (NullReferenceException n)
            {
                return;
            }
            PlayList currPlayList = PlayList.PlayLists[PlayList.PlaylistNames.IndexOf(playListNames[sent.SelectedIndex])];
            currObj = PlayList.PlayLists[PlayList.PlaylistNames.IndexOf(playListNames[sent.SelectedIndex])];

            List<ListBox> songNameLists = new List<ListBox>();
            for (int i = 0; i < playListItems.Items.Count; ++i)
            {
                songNameLists.Add(new ListBox());

                TabPage myTabPage = new TabPage();
                tbCtlSongs.TabPages.Add(myTabPage);

                tbCtlSongs.TabPages[i].Controls.Add(songNameLists[i]);
            }
            for(int i = 0; i < tbCtlSongs.TabPages.Count; ++i)
            {
                tbCtlSongs.TabPages[i].Click += new EventHandler(this.tabPage_Click);
                tbCtlSongs.TabPages[i].Text = playListNames[i];

                if (tbCtlSongs.TabPages[i].Text == sent.GetItemText(sent.SelectedItem))
                {
                    tbCtlSongs.SelectedTab = tbCtlSongs.TabPages[i];
                }
                             
            }
            tbCtlSongs.Show();
            for (int i = 0; i < PlayList.PlayLists.Count; ++i)
            {
                songNameLists[i].Items.AddRange(PlayList.PlayLists[i].songNames.ToArray());
                songNameLists[i].DoubleClick += new EventHandler(this.songsList_DoubleClick);
                songNameLists[i].Size = tbCtlSongs.TabPages[i].Size;
            }
            chkAutoPlay.Show();
            btnBack.Show();

            txtBListHeader.Text = "Tab view";
            txtBListHeader.ReadOnly = true;

            playListItems.Items.Clear();
            playListItems.Items.AddRange(PlayList.PlaylistNames.ToArray());
            chkAutoPlay.Checked = true;
            if (chkAutoPlay.Checked)
            {
                currObj.PlaySongs(this);
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string deserialNames = File.ReadAllText(@"PlayListNames.json");
            List<string> namesList = JsonSerializer.Deserialize<List<string>>(deserialNames);
                        
            string deserialSongs = File.ReadAllText(@"PlayListSongs.json");
            List<List<string>> songsList = JsonSerializer.Deserialize<List<List<string>>>(deserialSongs);
            PlayList playList1;
            for (int i = 0; i < namesList.Count; ++i)
            {
                playList1 = new PlayList(songsList[i], namesList[i]);
            }
            playListItems.Items.AddRange(PlayList.PlaylistNames.ToArray());
            chkAutoPlay.Hide();
            tbCtlSongs.Hide();
            btnBack.Hide();
        }

        private void songsList_DoubleClick(object sender, EventArgs e)
        {
            //converts the sender to the needed type
            ListBox sent = (ListBox)sender;
            wplayer.URL = @"Playlist\" + sent.SelectedItem.ToString();
            wplayer.controls.play();
            playButton.Hide();
            pauseButton.Show();
        }

        private void chkAutoPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAutoPlay.Checked)
            {
                stopButton_Click(this, e);
                pauseButton_Click(this, e);
            }
            else
            {
                currObj = PlayList.PlayLists[PlayList.PlaylistNames.IndexOf(PlayList.PlaylistNames.ElementAt(tbCtlSongs.SelectedIndex))];
                currObj.PlaySongs(this);
            }
        }

        private void tabPage_Click(object sender, EventArgs e)
        {
            TabPage sent = (TabPage)sender;
            
            PlayList currPlayList = PlayList.PlayLists[PlayList.PlaylistNames.IndexOf(sent.Text)];
            sent.Select();
            wplayer.currentPlaylist = currPlayList.currentPlayList;
            wplayer.controls.play();
            playButton.Hide();
            pauseButton.Show();
        }
        public void playListItems_Refresh(object sender)
        {
            TextBox sent = (TextBox)sender;
            playListItems.Items.Add(sent.Text);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Hide();
            tbCtlSongs.Hide();
            txtBListHeader.Text = "Playlists";
            playListItems.Show();
            foreach(TabPage tabPage in tbCtlSongs.TabPages)
            {
                tbCtlSongs.TabPages.Remove(tabPage);
            }
            stopButton_Click(sender, e);
        }
    }
}
