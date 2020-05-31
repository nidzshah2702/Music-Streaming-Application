using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMusicStore
{
    public partial class Form2 : Form
    {
        public static string playlist;
        public static int playlistid;
        private MusicPlayer mp3Player;
        List<Panel> listOfPanels = new List<Panel>();
        int previndex = 0;
        Song selected=null;
        bool playing;
        NewPlaylist np;
        public Form2()
        {
            InitializeComponent();
            label2.Text = "Welcome "+LoginInfo.Name;
            mp3Player = new MusicPlayer();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicDataBaseDataSet11.Playlist' table. You can move, or remove it, as needed.
            //this.playlistTableAdapter.Fill(this.musicDataBaseDataSet11.Playlist);
            // TODO: This line of code loads data into the 'musicDataBaseDataSet11.Song' table. You can move, or remove it, as needed.
            this.songTableAdapter.Fill(this.musicDataBaseDataSet11.Song);
            this.playlistTableAdapter.FillByUserId(this.musicDataBaseDataSet11.Playlist, LoginInfo.Id);

            //dataGridView1.DataSource = Song.ViewSongs();
            listOfPanels.Add(panel1);
            listOfPanels.Add(panel2);
            listOfPanels.Add(panel3);
            listOfPanels.Add(panel4);
            listOfPanels.Add(panel5);
            listOfPanels.Add(panel6);
            listOfPanels[0].BringToFront();
     

        }

     

        private void songBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.songBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicDataBaseDataSet11);

        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }

       

        private void fillByTitleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.songTableAdapter.FillByTitle(this.musicDataBaseDataSet11.Song, Title.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void SearchSongs_Click(object sender, EventArgs e)
        {
     
            this.songTableAdapter.Fill(this.musicDataBaseDataSet11.Song);
            listOfPanels[0].BringToFront();
        }

        private void musicplayer_Click(object sender, EventArgs e)
        {
           
            listOfPanels[1].BringToFront();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files| *.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                    MessageBox.Show(ofd.FileName);
                }
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            mp3Player.stop();
        }

        private void songDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  MessageBox.Show(musicDataBaseDataSet11.Song.Rows[e.RowIndex].Field<String>("FilePath"));
            selected = new Song();

              var s= musicDataBaseDataSet11.Song.Rows[e.RowIndex];
          
            singers.Text = selected.Artists=s.Field<String>("Singers");
            songname.Text =selected.Title= s.Field<String>("Title");
            selected.FilePath = s.Field<String>("FilePath");
           language.Text= selected.Language = s.Field<String>("Language");
            var id = s.Field<int>("Album");
            selected.setAlbum(id);
            listOfPanels[2].BringToFront();
            previndex = 0;
            albumImage.ImageLocation = selected.Album.AlbumImage;
            album.Text = selected.Album.AlbumName;
                
        }

        

        private void playsong_Click(object sender, EventArgs e)
        {
            if (playing == true)
            {
                axWindowsMediaPlayer1.close();
               // mp3Player.close();
            }
            
              //  MessageBox.Show(selected.FilePath);
                nowplaying.Text = selected.Title+"................";
            axWindowsMediaPlayer1.URL = selected.FilePath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
               // mp3Player.open(selected.FilePath);
               // mp3Player.play();
                play.BorderStyle = BorderStyle.FixedSingle;
            //  MessageBox.Show("I am playing");
            songImage.ImageLocation = selected.Album.AlbumImage;
            playing = true;

            
           panel2.BringToFront();
           
        }

        private void fillByTitleToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.songTableAdapter.FillByTitle(this.musicDataBaseDataSet11.Song, Title.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void addtoplaylist_Click(object sender, EventArgs e)
        {

        }

        private void YourLibrary_Click(object sender, EventArgs e)
        {
            this.playlistTableAdapter.FillByUserId(this.musicDataBaseDataSet11.Playlist, LoginInfo.Id);
            playlistname.Text = "";
            listOfPanels[3].BringToFront();

        }

        private void fillByUserIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.playlistTableAdapter.FillByUserId(this.musicDataBaseDataSet11.Playlist, ((int)(System.Convert.ChangeType(useridToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.playlistTableAdapter.FillByName(this.musicDataBaseDataSet11.Playlist, new System.Nullable<int>(((int)(System.Convert.ChangeType(playlistname.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNameAndIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.playlistTableAdapter.FillByNameAndId(this.musicDataBaseDataSet11.Playlist, playlistname.Text, LoginInfo.Id);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void createplaylist_Click(object sender, EventArgs e)
        {
            np = new NewPlaylist();
            np.Show();
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.playlistTableAdapter.FillByUserId(this.musicDataBaseDataSet11.Playlist, LoginInfo.Id);
        }

        private void fillByPlaylistIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.songTableAdapter.FillByPlaylistId(this.musicDataBaseDataSet11.Song, ((int)(System.Convert.ChangeType(playlistidToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void playlistDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            playlist = musicDataBaseDataSet11.Playlist.Rows[e.RowIndex].Field<String>("name");
            playlistid= musicDataBaseDataSet11.Playlist.Rows[e.RowIndex].Field<int>("Id");
            this.songTableAdapter.FillByPlaylistId(this.musicDataBaseDataSet11.Song, playlistid);
            viewPlaylist.Text = playlist;
            listOfPanels[4].BringToFront();

        }

        private void addsongs_Click(object sender, EventArgs e)
        {
            AddSongs ad = new AddSongs();
            ad.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.songTableAdapter.FillByPlaylistId(this.musicDataBaseDataSet11.Song, playlistid);

        }

        private void songDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = new Song();

            var s = musicDataBaseDataSet11.Song.Rows[e.RowIndex];

            singers.Text = selected.Artists = s.Field<String>("Singers");
            songname.Text = selected.Title = s.Field<String>("Title");
            selected.FilePath = s.Field<String>("FilePath");
            language.Text = selected.Language = s.Field<String>("Language");
            var id = s.Field<int>("Album");
            selected.setAlbum(id);
            if (playing == true)
            {
                mp3Player.close();
            }

            //  MessageBox.Show(selected.FilePath);
            nowplaying.Text = selected.Title + "................";
            // mp3Player.open(selected.FilePath);
            //  mp3Player.play();
            axWindowsMediaPlayer1.URL = selected.FilePath;
            play.BorderStyle = BorderStyle.FixedSingle;
            //  MessageBox.Show("I am playing");
            songImage.ImageLocation = selected.Album.AlbumImage;
            playing = true;


            panel2.BringToFront();

        }

        private void yourprofile_Click(object sender, EventArgs e)
        {
            UserServiceReference.Service1Client client = new UserServiceReference.Service1Client();
            UserServiceReference.UserDetails u = client.GetDetails(LoginInfo.Id);
            email.Text = u.email;
            contactno.Text = u.contactno;
            username.Text = u.name;
            subscription.Text = u.subscription;
            listOfPanels[5].BringToFront();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            LoginInfo.Name = username.Text;
            UserServiceReference.Service1Client client = new UserServiceReference.Service1Client();
            client.UpdateProfile(LoginInfo.Id, username.Text, contactno.Text);
            MessageBox.Show("Updated");
            edit.Visible = false;
            Cancel.Visible = false;
            username.ReadOnly = true;
            contactno.ReadOnly = true;
            subscription.ReadOnly = true;

        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            edit.Visible = true;
            username.ReadOnly = false;
           // email.ReadOnly = false;
            contactno.ReadOnly = false;
            subscription.ReadOnly = false;
            Cancel.Visible = true;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Cancel.Visible = false;
            username.ReadOnly = true;
            contactno.ReadOnly = true;
            subscription.ReadOnly = true;
            edit.Visible = false;

        }

        private void deletePlaylist_Click(object sender, EventArgs e)
        {
            PlaylistServiceReference1.Service1Client client = new PlaylistServiceReference1.Service1Client();
            bool i = client.DeletePlaylist(playlistid);
            if (i == true)
            {
                MessageBox.Show("Deleted");
                this.playlistTableAdapter.FillByUserId(this.musicDataBaseDataSet11.Playlist, LoginInfo.Id);
                playlistname.Text = "";
                listOfPanels[3].BringToFront();

            }else
            {
                MessageBox.Show("Error occured. Try again");
            }
        }
    }
}
