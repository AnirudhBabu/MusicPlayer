using System.Collections.Generic;
using WMPLib;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text.Encodings.Web;

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


        //PARAMETER-LESS CONSTRUCTOR
        public PlayList()
        {

        }
        //CONSTRUCTOR
        public PlayList(List<string> filenames, string Name = "newPlayList")
        {
            //Adds song Name and song Address to songs
            foreach (string songName in filenames)
            {
                songs.Add(songName, @"Playlist\" + songName);
            }
            songAddresses = songs.Values;
            songNames = songs.Keys;
            PlayListSongs.Add(songNames.ToList());

            //initialises new playlist
            currentPlayList = wmpPlayLists.newPlaylist(Name);
            PlaylistNames.AddLast(Name);

            //initialises new media objects using songAddress and adds them to the playlist
            foreach (string songAddress in songAddresses)
            {
                media = player.newMedia(songAddress);
                currentPlayList.appendItem(media);
            }
            PlayLists.Add(this);

            //Updating all data to the Datastore, i.e., PlayListNames.json & PlayListSongs.json
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string playListNamesSerial = JsonSerializer.Serialize(PlaylistNames, options);
            File.WriteAllText(@"PlayListNames.json", playListNamesSerial);

            string songNamesSerial = JsonSerializer.Serialize(PlayListSongs, options);
            File.WriteAllText(@"PlayListSongs.json", songNamesSerial);
        }

        //Plays all songs in a playlist
        public void PlaySongs(Form1 sender)
        {
            player.currentPlaylist = currentPlayList;
            player.controls.play();
            sender.playButton.Hide();
            sender.pauseButton.Show();
        }
    }

    //Class for extension method to LinkedList
    public static class LinkedListExt
    {
        //Generic extension method used to add the functionality of finding index for LinkedList
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
