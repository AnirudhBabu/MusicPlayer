using System.Collections.Generic;
using System.Collections;
using WMPLib;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Web.Script.Serialization;

namespace MusicPlayer
{
    public class PlayList
    {
        //reference to player in Form1 so that buttons can still be used
        public static WindowsMediaPlayer player = Form1.wplayer;

        //used to display names of playlists available in ListBox playListItems
        public static LinkedList<string> PlaylistNames = new LinkedList<string>();
        public static List<List<string>> PlayListSongs = new List<List<string>>();

        //used to refer to objects created so as to call the non-static method PlaySongs()
        public static List<PlayList> PlayLists = new List<PlayList>();

        //a list of playlists
        public static IWMPPlaylistCollection wmpPlayLists = player.playlistCollection;
        public IWMPPlaylist currentPlayList;
        public IWMPMedia media;

        //used to display names of songs in current playlist in ListBox songsList
        public Dictionary<string, string> songs = new Dictionary<string, string>();
        public Dictionary<string, string>.KeyCollection songNames;
        public Dictionary<string, string>.ValueCollection songAddresses;

        public PlayList()
        {

        }
        public PlayList(List<string> filenames, string Name = "newPlayList")
        {
            foreach (string songName in filenames)
            {
                songs.Add(songName, @"Playlist\" + songName);
            }
            songAddresses = songs.Values;
            songNames = songs.Keys;
            PlayListSongs.Add(songNames.ToList());

            currentPlayList = wmpPlayLists.newPlaylist(Name);
            PlaylistNames.AddLast(Name);
            foreach (string songAddress in songAddresses)
            {
                media = player.newMedia(songAddress);
                currentPlayList.appendItem(media);
            }
            PlayLists.Add(this);
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string playListNamesSerial = JsonSerializer.Serialize(PlaylistNames, options);
            File.WriteAllText(@"PlayListNames.json", playListNamesSerial);

            string songNamesSerial = JsonSerializer.Serialize(PlayListSongs, options);
            File.WriteAllText(@"PlayListSongs.json", songNamesSerial);

            string playListsSerial = JsonSerializer.Serialize(PlayLists, options);
            File.WriteAllText(@"Playlists.json", playListsSerial);
        }
        public void PlaySongs(Form1 sender)
        {
            player.currentPlaylist = currentPlayList;
            player.controls.play();
            sender.playButton.Hide();
            sender.pauseButton.Show();
        }
    }
    public static class LinkedListExt
    {
        public static int IndexOf<T>(this LinkedList<T> list, T item)
        {
            int count = 0;
            for (LinkedListNode<T> node = list.First; node != null; node = node.Next, count++)
            {
                if (item.Equals(node.Value))
                    return count;
            }
            return -1;
        }
    }
}
