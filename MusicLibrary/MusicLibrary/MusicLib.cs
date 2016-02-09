using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
/*I appologize for the code being messy... I had enough trouble figuring out how to correctly use DOM that
 I couldnt spend more time making the actual C# code neater and cleaner. For instance, Im positive there are better
 ways to validate my entries than using so many nessed if-esle statements, but it was the best I could do after figuring
 out how to correctly use DOM
 
 I had an issue with my document Load, where if I tried to load the XML document in the MusicLib_Load method then 
 it would only load the first artist instead of all of them from the XML document. It was exactly
 the same code im using in the readXMLFileToolStripMenuItem_Click event, nut acted differently. So I set it so the
 use has to load the XML file through the 'file' menu. 
 */
namespace MusicLibrary
{
    public partial class MusicLib : Form
    {
        public MusicLib()
        {InitializeComponent();}
        //Setting the file path for the xml file
        string docPath = Application.StartupPath + "/MusicLibrary.xml";
        //Creating Instance of the XMLDocument
        XmlDocument musicXML = new XmlDocument();
        bool insert;
        bool modify;

        private void MusicLib_Load(object sender, EventArgs e)
        {
            insert = false;
            modify = false;
            musicXML.Load(docPath);
            artistGroupBox.Enabled = false;
            albumGroupBox.Enabled = false;
            songGroupBox.Enabled = false;

            //Genres grabbed from popular general genres from Wikipedia
            genreComboBox.Items.Insert(0, "-Genres-");
            genreComboBox.Items.Insert(1, "African");
            genreComboBox.Items.Insert(2, "Avant-Garde");
            genreComboBox.Items.Insert(3, "Blues");
            genreComboBox.Items.Insert(4, "Latin American");
            genreComboBox.Items.Insert(5, "Comedy");
            genreComboBox.Items.Insert(6, "Asian");
            genreComboBox.Items.Insert(7, "Easy Listening");
            genreComboBox.Items.Insert(8, "Electronic");
            genreComboBox.Items.Insert(9, "Folk");
            genreComboBox.Items.Insert(10, "Jazz");
            genreComboBox.Items.Insert(11, "Pop");
            genreComboBox.Items.Insert(12, "R&B");
            genreComboBox.Items.Insert(13, "Rock");
            genreComboBox.Items.Insert(14, "Ska");
            //Set the combobox to display "-Genres-
            genreComboBox.SelectedIndex = 0;
            //Inserting rating values
            ratingComboBox.Items.Insert(0,"-Rating-");
            ratingComboBox.Items.Insert(1, "1");
            ratingComboBox.Items.Insert(2, "2");
            ratingComboBox.Items.Insert(3, "3");
            ratingComboBox.Items.Insert(4, "4");
            ratingComboBox.Items.Insert(5, "5");
            //Set the combobox to display "-Rating-
            ratingComboBox.SelectedIndex = 0;
        }
        //Load XML document
        private void readXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            artistsListBox.Items.Clear();
            reset();
            musicXML.Load(docPath);
            foreach (XmlNode artist in musicXML.DocumentElement)
            {
                string ArtistName = artist.Attributes["name"].Value;
                artistsListBox.Items.Add(ArtistName);
            }
        }

        //Save File
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {musicXML.Save(docPath);}

        //closes the form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        //Selected Index Changes
        //Artist
        private void artistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int artistIndex = artistsListBox.SelectedIndex;
            //there must be an artist selected to display anything in albums
            if (artistIndex != -1)
            {
                songsListBox.Items.Clear();
                albumsListBox.Items.Clear();
                XmlNodeList artist = musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes;
                foreach (XmlNode album in artist)
                {
                    string AlbumName = album.Attributes["name"].Value;
                    string genre = album.ChildNodes[2].InnerText;
                    string dt = album.ChildNodes[1].InnerText;
                    albumsListBox.Items.Add(AlbumName + "\tGenre: " + genre + "\tRelease Date: " + dt);
                }
            }
            else {
                albumsListBox.Items.Clear();
            }
        }
        //Album
        private void albumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int artistIndex = artistsListBox.SelectedIndex;
            int albumIndex = albumsListBox.SelectedIndex;
            if (albumsListBox.SelectedIndex != -1)
            {
                songsListBox.Items.Clear();
                XmlNodeList songs = musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes[albumIndex].ChildNodes[0].ChildNodes;
                foreach (XmlNode song in songs)
                {
                    string songName = song.ChildNodes[0].InnerText;
                    string songDur = song.ChildNodes[1].InnerText;
                    string songRate = song.ChildNodes[2].Attributes["stars"].Value;
                    string songCount = song.Attributes["number"].Value;
                    songsListBox.Items.Add("#" + songCount + "\tDuration: " + songDur + "\tRating: " + songRate + "\tTitle: " + songName);
                }
            }
            else {
                songsListBox.Items.Clear();
            }
        }

        //Insert Items, Enable Controls
        //artist
        private void insertArtistToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            artistGroupBox.Enabled = true;
            insert = true;
        }
        //album
        private void insertAlbumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(artistsListBox.SelectedIndex >=0){
                albumGroupBox.Enabled = true;
                insert = true;
            }
        }
        //song
        private void insertSongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (artistsListBox.SelectedIndex >= 0 && albumsListBox.SelectedIndex >=0)
            {
                songGroupBox.Enabled = true;
                insert = true;
            }
        }

        //modify  Items, enable controls
        //artist
        private void artistToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            modify = true;
            artistGroupBox.Enabled = true;
        }

        //album
        private void albumToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            modify = true;
            albumGroupBox.Enabled = true;
        }
        //song
        private void songToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            modify = true;
        }

        //Adding/Modifying Values
        //Artist
        private void submitArtistButton_Click(object sender, EventArgs e)
        {
            //IF WE'RE INSERTING
            if (insert == true)
            {
                //create a new artist element
                string an = artistTextBox.Text;
                if (artistTextBox.Text == "")
                {
                    an = "Unknown Artist";
                }
                else {
                    an = artistTextBox.Text;
                }
                    //Create artist Element
                    XmlNode artistNode = musicXML.CreateElement("artist");
                    //Create Attribute
                    artistNode.Attributes.Append(musicXML.CreateAttribute("name"));
                    //Set Attribute Value
                    artistNode.Attributes[0].Value = an;
                    //Add element to Document
                    musicXML.DocumentElement.AppendChild(artistNode);
                    //Add to the the Artist's listBox
                    artistsListBox.Items.Add(an);
                    //disables groupbox again after sumbitting

            }

            //IF WE'RE MODIFYING
            if(modify==true){
                //artist must be selected to modify
                if(artistsListBox.SelectedIndex>=0){
                    int artistIndex = artistsListBox.SelectedIndex;
                    XmlNode artistNode = musicXML.DocumentElement.ChildNodes[artistIndex];
                    //Must have a value
                    if (artistTextBox.Text != "")
                    {
                        ((XmlElement)artistNode).SetAttribute("name", artistTextBox.Text);
                        //reload's artist checkedListBox
                        artistsListBox.Items.Clear();
                        foreach (XmlNode artist in musicXML.DocumentElement)
                        {
                            string ArtistName = artist.Attributes["name"].Value;
                            artistsListBox.Items.Add(ArtistName);
                        }
                    }
                    else {
                        MessageBox.Show("Please enter a new name for your artist","Error");
                    }
                }
            }
            //disables/resets controls so no more inserts or edits can occur
            clear();
            artistGroupBox.Enabled = false;
            insert = false;
            modify = false;            
        }

        //Album
        private void albumSubmitButton_Click(object sender, EventArgs e){
            int artistIndex = artistsListBox.SelectedIndex;
            int albumIndex = albumsListBox.SelectedIndex;
            string dt = releaseDatePicker.Value.ToString("dd/MM/yyyy");
            string an = albumTextBox.Text;  if (an == ""){an = "Unknown Album";}

            //INSERTTING
            if (insert == true)
            {
                if (artistIndex >= 0)
                {        

                    if (genreComboBox.SelectedIndex >0 && dt != null)
                    {
                        //Create album element
                        XmlNode albumNode = musicXML.CreateElement("album");
                        //create name attribute
                        albumNode.Attributes.Append(musicXML.CreateAttribute("name"));
                        //set attribute value
                        albumNode.Attributes[0].Value = an;

                        //Create elements of Album
                        XmlNode songsNode = musicXML.CreateElement("songs");
                        XmlNode releaseNode = musicXML.CreateElement("releaseDate");
                        XmlNode genreNode = musicXML.CreateElement("genre");

                        releaseNode.InnerText = dt;

                        genreNode.InnerText = genreComboBox.Text;

                        //Add the elements to Album Node
                        albumNode.AppendChild(songsNode);
                        albumNode.AppendChild(releaseNode);
                        albumNode.AppendChild(genreNode);

                        musicXML.DocumentElement.ChildNodes[artistIndex].AppendChild(albumNode);
                        
                        /*string genre = musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes.ChildNodes[2].InnerText;
                        albumsListBox.Items.Add(an + "\t" + genre);*/
                        songsListBox.Items.Clear();
                        albumsListBox.Items.Clear();
                        XmlNodeList artist = musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes;
                        foreach (XmlNode album in artist)
                        {
                            string AlbumName = album.Attributes["name"].Value;
                            string genre = album.ChildNodes[2].InnerText;
                            albumsListBox.Items.Add(AlbumName + "\tGenre: " + genre + "\tRelease Date: " + dt);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Album Must have a name, genre and Release Date", "Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Must select an artist to add an album to", "Error!");
                }
            }
            //MODIFYING
            if (modify == true) {
                if (artistsListBox.SelectedIndex >=0 && albumsListBox.SelectedIndex >=0)
                {
                    if (an != "" && genreComboBox.SelectedIndex > 0 && dt != null)
                    {
                        XmlNodeList artist = musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes;
                        XmlNode albumNode = musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes[albumIndex];
                        ((XmlElement)albumNode).SetAttribute("name", an);
                        musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes[albumIndex].ChildNodes[1].InnerText = dt;
                        musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes[albumIndex].ChildNodes[2].InnerText = genreComboBox.Text;
                        albumsListBox.Items.Clear();
                        foreach (XmlNode album in artist)
                        {
                            string AlbumName = album.Attributes["name"].Value;
                            string genre = album.ChildNodes[2].InnerText;
                            albumsListBox.Items.Add(AlbumName + "\tGenre: " + genre + "\tRelease Date: " + dt);
                        }
                    }
                    else { MessageBox.Show("Album Must have a name, genre and Release Date", "Error!");}
                }
                else
                { MessageBox.Show("Must select an artist to add an album to", "Error!");}
            }
            albumGroupBox.Enabled = false;
            insert = false;
            modify = false;
            clear();
        }
        //song
        private void songSubmitButton_Click(object sender, EventArgs e)
        {
            int artistIndex = artistsListBox.SelectedIndex;
            int albumIndex = albumsListBox.SelectedIndex;

            //IF WE'RE INSERTING
            if (insert == true)
            {
                if (artistIndex >= 0 && albumIndex >= 0)
                {
                    
                    string sn = songTitleTextBox.Text;
                    string dur = durTextBox.Text;
                    TimeSpan t = new TimeSpan();
                    string num = trackNumberTextBox.Text;
                    int number = 0;
                    if (TimeSpan.TryParse(dur, out t))
                    {
                        if (int.TryParse(num, out number))
                        {
                            if (sn != "" && number >= 0 && ratingComboBox.SelectedIndex > 0 &&
                                durTextBox.Text != "" && songTitleTextBox.Text != "")
                            {
                                //creating song node
                                XmlNode songNode = musicXML.CreateElement("song");
                                //creating and appending attribut to song node
                                songNode.Attributes.Append(musicXML.CreateAttribute("number"));
                                //set attribute value
                                songNode.Attributes[0].Value = num;

                                XmlNode durNode = musicXML.CreateElement("duration");
                                XmlNode titleNode = musicXML.CreateElement("title");

                                //Assign Values
                                durNode.InnerText = durTextBox.Text;
                                titleNode.InnerText = songTitleTextBox.Text;

                                //Creating Rating Node, Stars Attribute and setting its value
                                XmlNode rateNode = musicXML.CreateElement("rating");
                                rateNode.Attributes.Append(musicXML.CreateAttribute("stars"));
                                rateNode.Attributes[0].Value = ratingComboBox.Text;

                                //Adding elements to song
                                songNode.AppendChild(titleNode);
                                songNode.AppendChild(durNode);
                                songNode.AppendChild(rateNode);
                                //Adding to the document
                                musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes[albumIndex].ChildNodes[0].AppendChild(songNode);


                                XmlNodeList songs = musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes[albumIndex].ChildNodes[0].ChildNodes;
                                songsListBox.Items.Clear();
                                foreach (XmlNode song in songs)
                                {
                                    string songName = song.ChildNodes[0].InnerText;
                                    string songDur = song.ChildNodes[1].InnerText;
                                    string songRate = song.ChildNodes[2].Attributes["stars"].Value;
                                    string songCount = song.Attributes["number"].Value;
                                    songsListBox.Items.Add("#" + songCount + "\tDuration: " + songDur + "\tRating: " + songRate + "\tTitle: " + songName);
                                }
                            }
                        }
                        else {
                            MessageBox.Show("Track Number must be a Number","Error");
                        }

                    }
                    else {
                        MessageBox.Show("Duration must be in time format '01:01' , '05:37', '1:04:22', ect.","Error");
                    }
                }
                else {
                    MessageBox.Show("Please make sure you have an Artist and Album Selected","Error!");
                }
            }
            songGroupBox.Enabled = false;
            insert = false;
            modify = false;
            clear();
        }

        //reset the form
        private void reset() {
            clear();
            insert = false;
            modify = false;
            artistGroupBox.Enabled = false;
            albumGroupBox.Enabled = false;
            songGroupBox.Enabled = false;
            songsListBox.Items.Clear();
            albumsListBox.Items.Clear();
        }
        //clears the controls for editing/adding data
        private void clear() {
            artistTextBox.Clear();
            albumTextBox.Clear();
            releaseDatePicker.Value = DateTime.Today;
            genreComboBox.SelectedIndex = 0;
            songTitleTextBox.Clear();
            trackNumberTextBox.Clear();
            durTextBox.Clear();
            ratingComboBox.SelectedIndex = 0;
        }

        //cancel Button
        private void resetButton_Click(object sender, EventArgs e)
        { reset(); }

        //Delete Methods
        //artist
        private void deleteArtist(int i) {
            musicXML.DocumentElement.RemoveChild(musicXML.DocumentElement.ChildNodes[i]);
        }
        //album
        private void deleteAlbum(int i) {
            int artistIndex = artistsListBox.SelectedIndex;
            musicXML.DocumentElement.ChildNodes[artistIndex].RemoveChild(
                musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes[i]);
        }

        //song
        private void deleteSong(int i) { 
            int artistIndex = artistsListBox.SelectedIndex;
            int albumIndex = albumsListBox.SelectedIndex;
            musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes[albumIndex].ChildNodes[0].RemoveChild(
                musicXML.DocumentElement.ChildNodes[artistIndex].ChildNodes[albumIndex].ChildNodes[0].ChildNodes[i]);
        }

        //Delete ToolStrip Clicks
        //Artist
        private void deleteArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int artistIndex = artistsListBox.SelectedIndex;
            if (artistIndex != -1)
            {
                deleteArtist(artistIndex);
                artistsListBox.Items.RemoveAt(artistIndex);
                albumsListBox.Items.Clear();
                songsListBox.Items.Clear();
            }
        }
        //Album
        private void deleteAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int albumIndex = albumsListBox.SelectedIndex;
            if(albumIndex != -1){
                deleteAlbum(albumIndex);
                albumsListBox.Items.RemoveAt(albumIndex);
                songsListBox.Items.Clear();
            }
        }
        //song
        private void deleteSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int songIndex = songsListBox.SelectedIndex;
            if (songIndex != -1) {
                deleteSong(songIndex);
                songsListBox.Items.RemoveAt(songIndex);
            }
        }

        private void helpDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to your Music Libary, A handy tool to keep trak of your favorate "+
            "artist and albums. In this program you will be able to add, modify and delete any Arist, album and song." +
            "\n\n To begin, click 'File' and load the XML document. This is where the information for "+
            "each artist, album and song is kept!" +
            
            "\n\n Once loaded you can begin adding artists by selecting 'Edit' and choosing 'Insert' and "+
            "then selecting which item youd like to add! To insert an album, make sure you have an artist selected "+
            " and to insert a song please make sure you have the proper album selected! The same rules apply for "+
            "Modify and Delete, you need to have the appropriate artist/album/song selected before you can interact "+
            "with it.","Help");
        }


    }
}
