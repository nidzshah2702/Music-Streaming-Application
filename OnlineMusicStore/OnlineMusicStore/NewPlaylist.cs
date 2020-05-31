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
    public partial class NewPlaylist : Form
    {
        public NewPlaylist()
        {
            InitializeComponent();
        }

        private void createplaylist_Click(object sender, EventArgs e)
        {
            PlaylistServiceReference1.Service1Client client = new PlaylistServiceReference1.Service1Client();
            bool r = client.CreatePlaylist(LoginInfo.Id, playlistname.Text);
            if (r == true)
            {
                MessageBox.Show("PLaylist Created!");
                Form2.playlist = playlistname.Text;
               AddSongs ad = new AddSongs();
                ad.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("Some error occured. Try again!");

            }
           

        }

    }
}