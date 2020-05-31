namespace OnlineMusicStore
{
    partial class ViewPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.musicDataBaseDataSet1 = new OnlineMusicStore.MusicDataBaseDataSet1();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songTableAdapter = new OnlineMusicStore.MusicDataBaseDataSet1TableAdapters.SongTableAdapter();
            this.tableAdapterManager = new OnlineMusicStore.MusicDataBaseDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // musicDataBaseDataSet1
            // 
            this.musicDataBaseDataSet1.DataSetName = "MusicDataBaseDataSet1";
            this.musicDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataMember = "Song";
            this.songBindingSource.DataSource = this.musicDataBaseDataSet1;
            // 
            // songTableAdapter
            // 
            this.songTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlaylistSongsTableAdapter = null;
            this.tableAdapterManager.PlaylistTableAdapter = null;
            this.tableAdapterManager.SongTableAdapter = this.songTableAdapter;
            this.tableAdapterManager.UpdateOrder = OnlineMusicStore.MusicDataBaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ViewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 558);
            this.Name = "ViewPlaylist";
            this.Text = "ViewPlaylist";
            this.Load += new System.EventHandler(this.ViewPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MusicDataBaseDataSet1 musicDataBaseDataSet1;
        private System.Windows.Forms.BindingSource songBindingSource;
        private MusicDataBaseDataSet1TableAdapters.SongTableAdapter songTableAdapter;
        private MusicDataBaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}