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
        //creating the control that plays, stops, pauses music
        public static WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        //declared as class variables as they are used in multiple methods
        private PlayList currObj;
        private List<ListBox> songNameLists;


        //CONSTRUCTOR
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            //Starts the app with the splashscreen set to display for 3000 ms = 3 s
            Application.Run(new SplashScreen());
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            //loading startup data from the corresponding files
            string deserialNames = File.ReadAllText(@"PlayListNames.json");
            List<string> namesList = JsonSerializer.Deserialize<List<string>>(deserialNames);

            string deserialSongs = File.ReadAllText(@"PlayListSongs.json");
            List<List<string>> songsList = JsonSerializer.Deserialize<List<List<string>>>(deserialSongs);

            PlayList playList1;
            //creates object as required from the read data
            for (int i = 0; i < namesList.Count; ++i)
            {
                playList1 = new PlayList(songsList[i], namesList[i]);
            }
            //adding playlist names to the 'Playlists' view
            playListItems.Items.AddRange(PlayList.PlaylistNames.ToArray());

            //Hidden as they are only needed in 'Tab' view
            chkAutoPlay.Hide();
            tbCtlSongs.Hide();
            btnBack.Hide();
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


        //MUSIC CONTROLS
        public void playButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
            playButton.Hide();
            pauseButton.Show();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            pauseButton.Hide();
            playButton.Show();
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

        //Redirects to the Second Form
        private void btnRedirect_Click(object sender, EventArgs e)
        {
            Program.playlist.Show();
            Program.musicplayer.Hide();
        }

        //ACTIVATION OF 'TAB' VIEW AND ADDITION OF TABPAGES, LISTBOXES IN TABPAGES
        //PROGRAMMATICALLY
        private void playListItems_DoubleClick(object sender, EventArgs e)
        {

            //Getting the names of playlists
            List<string> playListNames = new List<string>();

            //Catches exception when PlaylistNames is empty
            try
            {
                playListNames = PlayList.PlaylistNames.ToList();                
            }
            catch (NullReferenceException n)
            {
                return;
            }

            //Casting sender 'playListItems' to the appropriate type
            ListBox sent = (ListBox)sender;

            //gets the PlayList object to be referred to using the index of the selection
            //from playListItems
            int playListNum = sent.SelectedIndex;
            PlayList currPlayList = playListNum >= 0 ? PlayList.PlayLists[playListNum] : null;
            currObj = playListNum >= 0 ? PlayList.PlayLists[playListNum]: null;

            //initialises a list of listboxes to be added to the tabpages being created
            songNameLists = new List<ListBox>();

            //creates Tabpages and Listboxes to be added to those tabpages
            if(currObj != null)
            {

                //Hiding 'Playlists' view
                playListItems.Hide();
                for (int i = 0; i < playListItems.Items.Count; ++i)
                {
                    songNameLists.Add(new ListBox());

                    TabPage playListTab = new TabPage();
                    tbCtlSongs.TabPages.Add(playListTab);
                    tbCtlSongs.TabPages[i].Text = playListNames[i];

                    tbCtlSongs.TabPages[i].Controls.Add(songNameLists[i]);

                    //Determines the selected tab
                    if (tbCtlSongs.TabPages[i].Text == sent.GetItemText(sent.SelectedItem))
                    {
                        tbCtlSongs.SelectedTab = tbCtlSongs.TabPages[i];
                    }

                    //Adds songs to listboxes created
                    songNameLists[i].Items.AddRange(PlayList.PlayLists[i].songNames.ToArray());
                    songNameLists[i].DoubleClick += new EventHandler(this.songsList_DoubleClick);
                    songNameLists[i].Size = tbCtlSongs.TabPages[i].Size;
                }

                tbCtlSongs.Show();
                chkAutoPlay.Show();
                btnBack.Show();

                txtBListHeader.Text = "Tab view";
                txtBListHeader.ReadOnly = true;

                playListItems.Items.Clear();
                playListItems.Items.AddRange(PlayList.PlaylistNames.ToArray());

                //Plays songs in Playlist
                chkAutoPlay.Checked = true;
                if (chkAutoPlay.Checked)
                {
                    currObj.PlaySongs(this);
                }
            }
        }

        private void songsList_DoubleClick(object sender, EventArgs e)
        {
            //converts the sender to the needed type
            ListBox sent = (ListBox)sender;
            
            //Sets the address for the player based on the songName clicked
            wplayer.URL = @"Playlist\" + sent.SelectedItem.ToString();
            wplayer.controls.play();
            playButton.Hide();
            pauseButton.Show();
        }


        //CHANGES THE PLAYLIST TO BE PLAYED IF THE USER UNCHECKS AND CHECKS AUTOPLAY AFTER
        //CHANGING TO A DIFFERENT TAB
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

        //Adds the newly created playlist to 'Playlists' view
        public void playListItems_Refresh(object sender)
        {            
            playListItems.Items.Add(Program.playlist.txtPlaylistName.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Hide();
            chkAutoPlay.Hide();
            tbCtlSongs.Hide();
            txtBListHeader.Text = "Playlists";
            playListItems.Show();
            foreach(TabPage tabPage in tbCtlSongs.TabPages)
            {
                tbCtlSongs.TabPages.Remove(tabPage);
            }
            stopButton_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i;
            //If in 'PlayLists' view, delete Playlist
            if (playListItems.Visible)
            {
                i = playListItems.SelectedIndex;
                PlayList.PlayLists.Remove(PlayList.PlayLists.ElementAt(i));
                PlayList.PlayListSongs.Remove(PlayList.PlayListSongs.ElementAt(i));
                PlayList.PlaylistNames.Remove(playListItems.SelectedItem.ToString());
                playListItems.Items.Clear();
                playListItems.Items.AddRange(PlayList.PlaylistNames.ToArray());
            }
            //If in tab view, delete selected song from Playlist
            else if (tbCtlSongs.Visible)
            {
                i = tbCtlSongs.SelectedIndex;
                File.WriteAllText(@"selectedTabNum.txt", i.ToString());
                PlayList.PlayListSongs[i].Remove(songNameLists[i].SelectedItem.ToString());
                currObj.songs.Remove(songNameLists[i].SelectedItem.ToString());
                tbCtlSongs.SelectedTab.Controls.Remove(songNameLists[i]);
                songNameLists[i].Items.Clear();
                songNameLists[i].Items.AddRange(PlayList.PlayLists[i].songNames.ToArray());
                tbCtlSongs.SelectedTab.Controls.Add(songNameLists[i]);                
            }


            //Update data in datastore, i.e. PlayListNames.json & PlayListSongs.json
            LinkedList<string> PlaylistNames = PlayList.PlaylistNames;
            List<List<string>> PlayListSongs = PlayList.PlayListSongs;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string playListNamesSerial = JsonSerializer.Serialize(PlaylistNames, options);
            File.WriteAllText(@"PlayListNames.json", playListNamesSerial);

            string songNamesSerial = JsonSerializer.Serialize(PlayListSongs, options);
            File.WriteAllText(@"PlayListSongs.json", songNamesSerial);
        }


        //Exit App
        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
