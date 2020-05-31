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
    public partial class AddSongs : Form
    {
        public AddSongs()
        {
            InitializeComponent();
        }

        private void songBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.songBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicDataBaseDataSet1);

        }

        private void AddSongs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicDataBaseDataSet1.Song' table. You can move, or remove it, as needed.
            this.songTableAdapter.Fill(this.musicDataBaseDataSet1.Song);
            playlistname.Text = Form2.playlist;

        }

        private void songDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PlaylistServiceReference1.Service1Client client = new PlaylistServiceReference1.Service1Client();
          bool r= client.AddToPlaylistWithName(playlistname.Text,musicDataBaseDataSet1.Song.Rows[e.RowIndex].Field<int>("Id"));
            if (r == true)
            {
                MessageBox.Show("Added!");
            }else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
