Requirements implemented
------------------------

1. 1. Buttons - Some of the buttons added include pauseButton, playButton, stopButton etc. (See Form1)
   2. Labels - Labels used include lblListHeader, lblHeader (See Form1)
   3. PictureBox - See Form1.cs for PictureBox used (picBoxMainImg) 
   4. TextBox - See txtBListHeader in Form1
   5. CheckBox - See chkAutoPlay in Form1
   6. TabControl - See tbCtlSongs in Form1

2. 1. ListBox - ListBoxes used include playListItems, songsList (see Form1)

3. 1. LinkedList - used in PlayList.cs (See playListNames)
   2. Dictionary - used in PlayList.cs (See songs)
   3. List - used in PlayList.cs (See PlayLists)

4. Second form - Newly created Playlist data is passed on to the main form

5. File data is read from - PlayListSongs.json & PlayListNames.json in "Location of extracted folder" + MusicPlayer\bin\Debug\(PlayListSongs.json/PlayListNames.json)

6. Technical difficulties
	1. Music play, pause, stop etc. using WMPLib (See Form1.cs & PlayList.cs)
	2. Playlist implementation using IWMPPlaylistCollection and IWMPPlaylist (See PlayList.cs)
	3. Creation of media objects using IWMPMedia (See PlayList.cs)
	4. Extension methods used for extending the functionality of LinkedList (See LinkedListEx class in PlayList.cs)

7. Custom generic method or class - The extension method used to implement the functionality of
									finding the index for a LinkedList is generic
									(See PlayList.cs)
