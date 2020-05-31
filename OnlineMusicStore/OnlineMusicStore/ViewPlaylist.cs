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
    public partial class ViewPlaylist : Form
    {
        public ViewPlaylist()
        {
            InitializeComponent();
        }

        private void songBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.songBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicDataBaseDataSet1);

        }

        private void songBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.songBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicDataBaseDataSet1);

        }

        private void ViewPlaylist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicDataBaseDataSet1.Song' table. You can move, or remove it, as needed.
            this.songTableAdapter.Fill(this.musicDataBaseDataSet1.Song);

        }
    }
}
