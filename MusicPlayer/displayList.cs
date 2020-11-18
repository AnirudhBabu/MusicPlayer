using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class displayList : Form
    {
        //used by multiple classes, hence declared as class field
        private List<string> songAddress = new List<string>();

        public displayList()
        {
            InitializeComponent();
        }

        //Updates main form and redirects to it
        private void btnRedirect_Click(object sender, EventArgs e)
        {
            if (txtPlaylistName.Text == "" || txtPlaylistName.Text == "Playlist name")
            {
                MessageBox.Show("Please enter a valid playlist Name", "Invalid Name");
                return;
            }
            else
            {
                List<string> filenames = new List<string>();
                string fileAddress = "";
                for (int i = 0; i < newPlayList.Items.Count; ++i)
                {
                    fileAddress = songAddress[i];
                    filenames.Add(fileAddress.Substring(fileAddress.LastIndexOf('\\') + 1));
                    File.Copy(fileAddress, @"PlayList\" + filenames[i], true);
                }
                PlayList newlyCreated = new PlayList(filenames, txtPlaylistName.Text);
                Program.musicplayer.playListItems_Refresh(sender);
            }

            this.Hide();
            Program.musicplayer.Show();
            newPlayList.Items.Clear();
            SelectSongs.Items.Clear();
            txtPlaylistName.Clear();
        }
      
        private void newListBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "All Supported Audio |*.mp3;*wma | MP3s |*.mp3 |WMAs|*.wma";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] Selected = ofd.FileNames;
                    songAddress.AddRange(Selected);
                    foreach (string address in Selected)
                    {
                        SelectSongs.Items.Add(address.Substring(address.LastIndexOf("\\") + 1));
                    }                    
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            newPlayList.Items.Clear();
            foreach (Object item in SelectSongs.CheckedItems)
            {
                newPlayList.Items.Add(item);
            }
        }
        
        private void displayList_Load(object sender, EventArgs e)
        {
            txtPlaylistName.Text = "Playlist name";
            txtPlaylistName.ForeColor = Color.Gray;
        }

        private void txtPlaylistName_Enter(object sender, EventArgs e)
        {
            TextBox sent = (TextBox)sender;
            if (sent.Text == "Playlist name")
            {
                sent.Text = "";
                txtPlaylistName.ForeColor = Color.Black;
            }
        }
        private void txtPlaylistName_Leave(object sender, EventArgs e)
        {
            if (txtPlaylistName.Text == "")
            {
                txtPlaylistName.Text = "Playlist name";
                txtPlaylistName.ForeColor = Color.Gray;
            }
        }

        //Exit app
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
