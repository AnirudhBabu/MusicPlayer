using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using WMPLib;
using System.Web.Script.Serialization;

namespace MusicPlayer
{
    public partial class displayList : Form
    {
        public displayList()
        {
            InitializeComponent();
        }

        private void btnRedirect_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.musicplayer.Show();
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
                    SelectSongs.Items.AddRange(Selected);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            newPlayList.Items.Clear();
            foreach (Object item in SelectSongs.CheckedItems)
            {
                newPlayList.Items.Add(item);
            }
        }
        private void txtPlaylistName_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtPlaylistName.Text == "")
                {
                    MessageBox.Show("Please enter a valid playlist Name", "Invalid Name");
                }
                else
                {
                    List<string> filenames = new List<string>();
                    string fileAddress = "";
                    for(int i = 0; i < newPlayList.Items.Count; ++i)
                    {
                        fileAddress = newPlayList.GetItemText(newPlayList.Items[i]);
                        filenames.Add(fileAddress.Substring(fileAddress.LastIndexOf('\\') + 1));
                        File.Copy(fileAddress, @"PlayList\" + filenames[i], true);
                    }
                    PlayList newlyCreated = new PlayList(filenames, txtPlaylistName.Text);
                    Program.musicplayer.playListItems_Refresh(sender);
                }
            }
               
        }
    }
}
