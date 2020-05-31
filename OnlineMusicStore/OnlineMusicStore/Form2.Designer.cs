namespace OnlineMusicStore
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchSongs = new System.Windows.Forms.Button();
            this.YourLibrary = new System.Windows.Forms.Button();
            this.musicplayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.songDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicDataBaseDataSet11 = new OnlineMusicStore.MusicDataBaseDataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.musicDataBaseDataSet1 = new OnlineMusicStore.MusicDataBaseDataSet();
            this.songBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.songBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillByTitleToolStrip = new System.Windows.Forms.ToolStrip();
            this.titleToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.titleToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByTitleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.usersTableAdapter1 = new OnlineMusicStore.MusicDataBaseDataSetTableAdapters.UsersTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.nowplaying = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.songImage = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.language = new System.Windows.Forms.Label();
            this.addtoplaylist = new System.Windows.Forms.Button();
            this.album = new System.Windows.Forms.Label();
            this.singers = new System.Windows.Forms.Label();
            this.songname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.playsong = new System.Windows.Forms.PictureBox();
            this.albumImage = new System.Windows.Forms.PictureBox();
            this.fillByTitleToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.titleToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.titleToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByTitleToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.createplaylist = new System.Windows.Forms.Button();
            this.playlistDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchByName = new System.Windows.Forms.PictureBox();
            this.playlistname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByUserIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.useridToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.useridToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByUserIdToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.playlistnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.playlistnameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.songTableAdapter = new OnlineMusicStore.MusicDataBaseDataSet1TableAdapters.SongTableAdapter();
            this.tableAdapterManager = new OnlineMusicStore.MusicDataBaseDataSet1TableAdapters.TableAdapterManager();
            this.playlistTableAdapter = new OnlineMusicStore.MusicDataBaseDataSet1TableAdapters.PlaylistTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addsongs = new System.Windows.Forms.Button();
            this.songDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.viewPlaylist = new System.Windows.Forms.Label();
            this.fillByPlaylistIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.playlistidToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.playlistidToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByPlaylistIdToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yourprofile = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EditProfile = new System.Windows.Forms.Button();
            this.MyProfile = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contactno = new System.Windows.Forms.TextBox();
            this.subscription = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.deletePlaylist = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataBaseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingNavigator)).BeginInit();
            this.songBindingNavigator.SuspendLayout();
            this.fillByTitleToolStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumImage)).BeginInit();
            this.fillByTitleToolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByName)).BeginInit();
            this.fillByUserIdToolStrip.SuspendLayout();
            this.fillByNameToolStrip.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.fillByPlaylistIdToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel1.Controls.Add(this.yourprofile, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.musicplayer, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SearchSongs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.YourLibrary, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 396);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SearchSongs
            // 
            this.SearchSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSongs.Location = new System.Drawing.Point(3, 102);
            this.SearchSongs.Name = "SearchSongs";
            this.SearchSongs.Size = new System.Drawing.Size(269, 66);
            this.SearchSongs.TabIndex = 2;
            this.SearchSongs.Text = "Search Songs";
            this.SearchSongs.UseVisualStyleBackColor = true;
            this.SearchSongs.Click += new System.EventHandler(this.SearchSongs_Click);
            // 
            // YourLibrary
            // 
            this.YourLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourLibrary.ForeColor = System.Drawing.Color.Black;
            this.YourLibrary.Location = new System.Drawing.Point(3, 30);
            this.YourLibrary.Name = "YourLibrary";
            this.YourLibrary.Size = new System.Drawing.Size(269, 62);
            this.YourLibrary.TabIndex = 1;
            this.YourLibrary.Text = "Your Library";
            this.YourLibrary.UseVisualStyleBackColor = true;
            this.YourLibrary.Click += new System.EventHandler(this.YourLibrary_Click);
            // 
            // musicplayer
            // 
            this.musicplayer.Location = new System.Drawing.Point(3, 181);
            this.musicplayer.Name = "musicplayer";
            this.musicplayer.Size = new System.Drawing.Size(269, 66);
            this.musicplayer.TabIndex = 3;
            this.musicplayer.Text = "Music Player";
            this.musicplayer.UseVisualStyleBackColor = true;
            this.musicplayer.Click += new System.EventHandler(this.musicplayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(41, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.songDataGridView);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(319, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 521);
            this.panel1.TabIndex = 1;
            // 
            // songDataGridView
            // 
            this.songDataGridView.AllowUserToAddRows = false;
            this.songDataGridView.AllowUserToDeleteRows = false;
            this.songDataGridView.AutoGenerateColumns = false;
            this.songDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.songDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.songDataGridView.DataSource = this.songBindingSource;
            this.songDataGridView.Location = new System.Drawing.Point(20, 106);
            this.songDataGridView.Name = "songDataGridView";
            this.songDataGridView.ReadOnly = true;
            this.songDataGridView.RowTemplate.Height = 24;
            this.songDataGridView.Size = new System.Drawing.Size(540, 294);
            this.songDataGridView.TabIndex = 3;
            this.songDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songDataGridView_CellContentClick);
            this.songDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songDataGridView_CellContentClick);
            this.songDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Language";
            this.dataGridViewTextBoxColumn3.HeaderText = "Language";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Released_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Released_Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataMember = "Song";
            this.songBindingSource.DataSource = this.musicDataBaseDataSet11;
            // 
            // musicDataBaseDataSet11
            // 
            this.musicDataBaseDataSet11.DataSetName = "MusicDataBaseDataSet1";
            this.musicDataBaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 37);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.fillByTitleToolStripButton1_Click);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(20, 62);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(551, 30);
            this.Title.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(284, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search";
            // 
            // musicDataBaseDataSet1
            // 
            this.musicDataBaseDataSet1.DataSetName = "MusicDataBaseDataSet";
            this.musicDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songBindingNavigator
            // 
            this.songBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.songBindingNavigator.BindingSource = this.songBindingSource;
            this.songBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.songBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.songBindingNavigator.Dock = System.Windows.Forms.DockStyle.Right;
            this.songBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.songBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.songBindingNavigatorSaveItem});
            this.songBindingNavigator.Location = new System.Drawing.Point(983, 0);
            this.songBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.songBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.songBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.songBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.songBindingNavigator.Name = "songBindingNavigator";
            this.songBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.songBindingNavigator.Size = new System.Drawing.Size(53, 503);
            this.songBindingNavigator.TabIndex = 2;
            this.songBindingNavigator.Text = "bindingNavigator1";
            this.songBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(50, 6);
            // 
            // songBindingNavigatorSaveItem
            // 
            this.songBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.songBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("songBindingNavigatorSaveItem.Image")));
            this.songBindingNavigatorSaveItem.Name = "songBindingNavigatorSaveItem";
            this.songBindingNavigatorSaveItem.Size = new System.Drawing.Size(50, 24);
            this.songBindingNavigatorSaveItem.Text = "Save Data";
            this.songBindingNavigatorSaveItem.Click += new System.EventHandler(this.songBindingNavigatorSaveItem_Click);
            // 
            // fillByTitleToolStrip
            // 
            this.fillByTitleToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByTitleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripLabel,
            this.titleToolStripTextBox,
            this.fillByTitleToolStripButton});
            this.fillByTitleToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByTitleToolStrip.Name = "fillByTitleToolStrip";
            this.fillByTitleToolStrip.Size = new System.Drawing.Size(1036, 27);
            this.fillByTitleToolStrip.TabIndex = 3;
            this.fillByTitleToolStrip.Text = "fillByTitleToolStrip";
            this.fillByTitleToolStrip.Visible = false;
            // 
            // titleToolStripLabel
            // 
            this.titleToolStripLabel.Name = "titleToolStripLabel";
            this.titleToolStripLabel.Size = new System.Drawing.Size(41, 24);
            this.titleToolStripLabel.Text = "Title:";
            // 
            // titleToolStripTextBox
            // 
            this.titleToolStripTextBox.Name = "titleToolStripTextBox";
            this.titleToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByTitleToolStripButton
            // 
            this.fillByTitleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByTitleToolStripButton.Name = "fillByTitleToolStripButton";
            this.fillByTitleToolStripButton.Size = new System.Drawing.Size(77, 24);
            this.fillByTitleToolStripButton.Text = "FillByTitle";
            this.fillByTitleToolStripButton.Click += new System.EventHandler(this.fillByTitleToolStripButton_Click);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.nowplaying);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.stop);
            this.panel2.Controls.Add(this.play);
            this.panel2.Controls.Add(this.songImage);
            this.panel2.Location = new System.Drawing.Point(295, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 541);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nowplaying
            // 
            this.nowplaying.AutoSize = true;
            this.nowplaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowplaying.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nowplaying.Location = new System.Drawing.Point(277, 279);
            this.nowplaying.Name = "nowplaying";
            this.nowplaying.Size = new System.Drawing.Size(160, 25);
            this.nowplaying.TabIndex = 13;
            this.nowplaying.Text = "- - - - - - - - - - -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(129, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Now Playing:";
            // 
            // stop
            // 
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Location = new System.Drawing.Point(374, 405);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(41, 37);
            this.stop.TabIndex = 11;
            this.stop.TabStop = false;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // play
            // 
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(242, 392);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(68, 67);
            this.play.TabIndex = 8;
            this.play.TabStop = false;
            this.play.Visible = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // songImage
            // 
            this.songImage.Image = ((System.Drawing.Image)(resources.GetObject("songImage.Image")));
            this.songImage.Location = new System.Drawing.Point(227, 34);
            this.songImage.Name = "songImage";
            this.songImage.Size = new System.Drawing.Size(269, 226);
            this.songImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.songImage.TabIndex = 3;
            this.songImage.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.language);
            this.panel3.Controls.Add(this.addtoplaylist);
            this.panel3.Controls.Add(this.album);
            this.panel3.Controls.Add(this.singers);
            this.panel3.Controls.Add(this.songname);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.playsong);
            this.panel3.Controls.Add(this.albumImage);
            this.panel3.Location = new System.Drawing.Point(339, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 555);
            this.panel3.TabIndex = 5;
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.ForeColor = System.Drawing.Color.Snow;
            this.language.Location = new System.Drawing.Point(398, 288);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(52, 17);
            this.language.TabIndex = 18;
            this.language.Text = "label5";
            // 
            // addtoplaylist
            // 
            this.addtoplaylist.Location = new System.Drawing.Point(514, 54);
            this.addtoplaylist.Name = "addtoplaylist";
            this.addtoplaylist.Size = new System.Drawing.Size(125, 44);
            this.addtoplaylist.TabIndex = 17;
            this.addtoplaylist.Text = "Add To Playlist\r\n";
            this.addtoplaylist.UseVisualStyleBackColor = true;
            this.addtoplaylist.Click += new System.EventHandler(this.addtoplaylist_Click);
            // 
            // album
            // 
            this.album.AutoSize = true;
            this.album.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.album.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.album.Location = new System.Drawing.Point(234, 288);
            this.album.Name = "album";
            this.album.Size = new System.Drawing.Size(59, 20);
            this.album.TabIndex = 16;
            this.album.Text = "album";
            // 
            // singers
            // 
            this.singers.AutoSize = true;
            this.singers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.singers.Location = new System.Drawing.Point(299, 314);
            this.singers.Name = "singers";
            this.singers.Size = new System.Drawing.Size(79, 20);
            this.singers.TabIndex = 15;
            this.singers.Text = "Singers:";
            // 
            // songname
            // 
            this.songname.AutoSize = true;
            this.songname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.songname.Location = new System.Drawing.Point(233, 254);
            this.songname.Name = "songname";
            this.songname.Size = new System.Drawing.Size(160, 25);
            this.songname.TabIndex = 13;
            this.songname.Text = "- - - - - - - - - - -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(137, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Singers:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(464, 53);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 44);
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // playsong
            // 
            this.playsong.Image = ((System.Drawing.Image)(resources.GetObject("playsong.Image")));
            this.playsong.Location = new System.Drawing.Point(324, 387);
            this.playsong.Name = "playsong";
            this.playsong.Size = new System.Drawing.Size(96, 84);
            this.playsong.TabIndex = 8;
            this.playsong.TabStop = false;
            this.playsong.Click += new System.EventHandler(this.playsong_Click);
            // 
            // albumImage
            // 
            this.albumImage.Image = ((System.Drawing.Image)(resources.GetObject("albumImage.Image")));
            this.albumImage.Location = new System.Drawing.Point(206, 44);
            this.albumImage.Name = "albumImage";
            this.albumImage.Size = new System.Drawing.Size(220, 189);
            this.albumImage.TabIndex = 3;
            this.albumImage.TabStop = false;
            // 
            // fillByTitleToolStrip1
            // 
            this.fillByTitleToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByTitleToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripLabel1,
            this.titleToolStripTextBox1,
            this.fillByTitleToolStripButton1});
            this.fillByTitleToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByTitleToolStrip1.Name = "fillByTitleToolStrip1";
            this.fillByTitleToolStrip1.Size = new System.Drawing.Size(1045, 27);
            this.fillByTitleToolStrip1.TabIndex = 6;
            this.fillByTitleToolStrip1.Text = "fillByTitleToolStrip1";
            this.fillByTitleToolStrip1.Visible = false;
            // 
            // titleToolStripLabel1
            // 
            this.titleToolStripLabel1.Name = "titleToolStripLabel1";
            this.titleToolStripLabel1.Size = new System.Drawing.Size(41, 24);
            this.titleToolStripLabel1.Text = "Title:";
            // 
            // titleToolStripTextBox1
            // 
            this.titleToolStripTextBox1.Name = "titleToolStripTextBox1";
            this.titleToolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByTitleToolStripButton1
            // 
            this.fillByTitleToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByTitleToolStripButton1.Name = "fillByTitleToolStripButton1";
            this.fillByTitleToolStripButton1.Size = new System.Drawing.Size(77, 24);
            this.fillByTitleToolStripButton1.Text = "FillByTitle";
            this.fillByTitleToolStripButton1.Click += new System.EventHandler(this.fillByTitleToolStripButton1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.createplaylist);
            this.panel4.Controls.Add(this.playlistDataGridView);
            this.panel4.Controls.Add(this.searchByName);
            this.panel4.Controls.Add(this.playlistname);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(314, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(710, 518);
            this.panel4.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(526, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // createplaylist
            // 
            this.createplaylist.BackColor = System.Drawing.Color.Black;
            this.createplaylist.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createplaylist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createplaylist.Location = new System.Drawing.Point(20, 111);
            this.createplaylist.Name = "createplaylist";
            this.createplaylist.Size = new System.Drawing.Size(183, 36);
            this.createplaylist.TabIndex = 4;
            this.createplaylist.Text = "+ Create Playlist";
            this.createplaylist.UseVisualStyleBackColor = false;
            this.createplaylist.Click += new System.EventHandler(this.createplaylist_Click);
            // 
            // playlistDataGridView
            // 
            this.playlistDataGridView.AutoGenerateColumns = false;
            this.playlistDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playlistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.playlistDataGridView.DataSource = this.playlistBindingSource;
            this.playlistDataGridView.Location = new System.Drawing.Point(20, 164);
            this.playlistDataGridView.Name = "playlistDataGridView";
            this.playlistDataGridView.RowTemplate.Height = 24;
            this.playlistDataGridView.Size = new System.Drawing.Size(551, 220);
            this.playlistDataGridView.TabIndex = 3;
            this.playlistDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playlistDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 350;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Created on";
            this.dataGridViewTextBoxColumn8.HeaderText = "Created on";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // playlistBindingSource
            // 
            this.playlistBindingSource.DataMember = "Playlist";
            this.playlistBindingSource.DataSource = this.musicDataBaseDataSet11;
            // 
            // searchByName
            // 
            this.searchByName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchByName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchByName.Image = ((System.Drawing.Image)(resources.GetObject("searchByName.Image")));
            this.searchByName.Location = new System.Drawing.Point(611, 47);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(48, 37);
            this.searchByName.TabIndex = 2;
            this.searchByName.TabStop = false;
            this.searchByName.Click += new System.EventHandler(this.fillByNameAndIdToolStripButton_Click);
            // 
            // playlistname
            // 
            this.playlistname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistname.Location = new System.Drawing.Point(20, 63);
            this.playlistname.Name = "playlistname";
            this.playlistname.Size = new System.Drawing.Size(551, 30);
            this.playlistname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(281, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // fillByUserIdToolStrip
            // 
            this.fillByUserIdToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByUserIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useridToolStripLabel,
            this.useridToolStripTextBox,
            this.fillByUserIdToolStripButton});
            this.fillByUserIdToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByUserIdToolStrip.Name = "fillByUserIdToolStrip";
            this.fillByUserIdToolStrip.Size = new System.Drawing.Size(1733, 27);
            this.fillByUserIdToolStrip.TabIndex = 8;
            this.fillByUserIdToolStrip.Text = "fillByUserIdToolStrip";
            this.fillByUserIdToolStrip.Visible = false;
            // 
            // useridToolStripLabel
            // 
            this.useridToolStripLabel.Name = "useridToolStripLabel";
            this.useridToolStripLabel.Size = new System.Drawing.Size(52, 24);
            this.useridToolStripLabel.Text = "userid:";
            // 
            // useridToolStripTextBox
            // 
            this.useridToolStripTextBox.Name = "useridToolStripTextBox";
            this.useridToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByUserIdToolStripButton
            // 
            this.fillByUserIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByUserIdToolStripButton.Name = "fillByUserIdToolStripButton";
            this.fillByUserIdToolStripButton.Size = new System.Drawing.Size(90, 24);
            this.fillByUserIdToolStripButton.Text = "FillByUserId";
            this.fillByUserIdToolStripButton.Click += new System.EventHandler(this.fillByUserIdToolStripButton_Click);
            // 
            // fillByNameToolStrip
            // 
            this.fillByNameToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistnameToolStripLabel,
            this.playlistnameToolStripTextBox,
            this.fillByNameToolStripButton});
            this.fillByNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByNameToolStrip.Name = "fillByNameToolStrip";
            this.fillByNameToolStrip.Size = new System.Drawing.Size(1733, 27);
            this.fillByNameToolStrip.TabIndex = 9;
            this.fillByNameToolStrip.Text = "fillByNameToolStrip";
            this.fillByNameToolStrip.Visible = false;
            // 
            // playlistnameToolStripLabel
            // 
            this.playlistnameToolStripLabel.Name = "playlistnameToolStripLabel";
            this.playlistnameToolStripLabel.Size = new System.Drawing.Size(96, 24);
            this.playlistnameToolStripLabel.Text = "playlistname:";
            // 
            // playlistnameToolStripTextBox
            // 
            this.playlistnameToolStripTextBox.Name = "playlistnameToolStripTextBox";
            this.playlistnameToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByNameToolStripButton
            // 
            this.fillByNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNameToolStripButton.Name = "fillByNameToolStripButton";
            this.fillByNameToolStripButton.Size = new System.Drawing.Size(88, 24);
            this.fillByNameToolStripButton.Text = "FillByName";
            this.fillByNameToolStripButton.Click += new System.EventHandler(this.fillByNameToolStripButton_Click);
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
            // playlistTableAdapter
            // 
            this.playlistTableAdapter.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.deletePlaylist);
            this.panel5.Controls.Add(this.addsongs);
            this.panel5.Controls.Add(this.songDataGridView1);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.viewPlaylist);
            this.panel5.Location = new System.Drawing.Point(294, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(679, 499);
            this.panel5.TabIndex = 10;
            // 
            // addsongs
            // 
            this.addsongs.BackColor = System.Drawing.Color.Black;
            this.addsongs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addsongs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addsongs.Location = new System.Drawing.Point(29, 95);
            this.addsongs.Name = "addsongs";
            this.addsongs.Size = new System.Drawing.Size(183, 36);
            this.addsongs.TabIndex = 6;
            this.addsongs.Text = "+ Add Songs";
            this.addsongs.UseVisualStyleBackColor = false;
            this.addsongs.Click += new System.EventHandler(this.addsongs_Click);
            // 
            // songDataGridView1
            // 
            this.songDataGridView1.AutoGenerateColumns = false;
            this.songDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.songDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn1});
            this.songDataGridView1.DataSource = this.songBindingSource;
            this.songDataGridView1.Location = new System.Drawing.Point(29, 149);
            this.songDataGridView1.Name = "songDataGridView1";
            this.songDataGridView1.RowTemplate.Height = 24;
            this.songDataGridView1.Size = new System.Drawing.Size(596, 270);
            this.songDataGridView1.TabIndex = 5;
            this.songDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songDataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "Title";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Language";
            this.dataGridViewTextBoxColumn9.HeaderText = "Language";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Released_Date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Released_Date";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Singers";
            this.dataGridViewTextBoxColumn1.HeaderText = "Singers";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(571, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // viewPlaylist
            // 
            this.viewPlaylist.AutoSize = true;
            this.viewPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPlaylist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewPlaylist.Location = new System.Drawing.Point(277, 37);
            this.viewPlaylist.Name = "viewPlaylist";
            this.viewPlaylist.Size = new System.Drawing.Size(81, 25);
            this.viewPlaylist.TabIndex = 0;
            this.viewPlaylist.Text = "Playlist";
            // 
            // fillByPlaylistIdToolStrip
            // 
            this.fillByPlaylistIdToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByPlaylistIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistidToolStripLabel,
            this.playlistidToolStripTextBox,
            this.fillByPlaylistIdToolStripButton});
            this.fillByPlaylistIdToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByPlaylistIdToolStrip.Name = "fillByPlaylistIdToolStrip";
            this.fillByPlaylistIdToolStrip.Size = new System.Drawing.Size(1801, 27);
            this.fillByPlaylistIdToolStrip.TabIndex = 11;
            this.fillByPlaylistIdToolStrip.Text = "fillByPlaylistIdToolStrip";
            this.fillByPlaylistIdToolStrip.Visible = false;
            // 
            // playlistidToolStripLabel
            // 
            this.playlistidToolStripLabel.Name = "playlistidToolStripLabel";
            this.playlistidToolStripLabel.Size = new System.Drawing.Size(72, 24);
            this.playlistidToolStripLabel.Text = "playlistid:";
            // 
            // playlistidToolStripTextBox
            // 
            this.playlistidToolStripTextBox.Name = "playlistidToolStripTextBox";
            this.playlistidToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByPlaylistIdToolStripButton
            // 
            this.fillByPlaylistIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByPlaylistIdToolStripButton.Name = "fillByPlaylistIdToolStripButton";
            this.fillByPlaylistIdToolStripButton.Size = new System.Drawing.Size(107, 24);
            this.fillByPlaylistIdToolStripButton.Text = "FillByPlaylistId";
            this.fillByPlaylistIdToolStripButton.Click += new System.EventHandler(this.fillByPlaylistIdToolStripButton_Click);
            // 
            // yourprofile
            // 
            this.yourprofile.Location = new System.Drawing.Point(3, 261);
            this.yourprofile.Name = "yourprofile";
            this.yourprofile.Size = new System.Drawing.Size(269, 61);
            this.yourprofile.TabIndex = 7;
            this.yourprofile.Text = "Your Profile";
            this.yourprofile.UseVisualStyleBackColor = true;
            this.yourprofile.Click += new System.EventHandler(this.yourprofile_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(289, 135);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Cancel);
            this.panel6.Controls.Add(this.edit);
            this.panel6.Controls.Add(this.subscription);
            this.panel6.Controls.Add(this.contactno);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.email);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.username);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.EditProfile);
            this.panel6.Controls.Add(this.MyProfile);
            this.panel6.Location = new System.Drawing.Point(295, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(721, 559);
            this.panel6.TabIndex = 13;
            // 
            // EditProfile
            // 
            this.EditProfile.BackColor = System.Drawing.Color.Black;
            this.EditProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditProfile.Location = new System.Drawing.Point(57, 138);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(183, 36);
            this.EditProfile.TabIndex = 6;
            this.EditProfile.Text = "Edit Profile";
            this.EditProfile.UseVisualStyleBackColor = false;
            this.EditProfile.Click += new System.EventHandler(this.EditProfile_Click);
            // 
            // MyProfile
            // 
            this.MyProfile.AutoSize = true;
            this.MyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MyProfile.Location = new System.Drawing.Point(278, 66);
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(73, 25);
            this.MyProfile.TabIndex = 0;
            this.MyProfile.Text = "Profile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(61, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(198, 219);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(382, 22);
            this.username.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(61, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(201, 279);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(382, 22);
            this.email.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(52, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Contact No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(52, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Subscription";
            // 
            // contactno
            // 
            this.contactno.Location = new System.Drawing.Point(198, 340);
            this.contactno.Name = "contactno";
            this.contactno.ReadOnly = true;
            this.contactno.Size = new System.Drawing.Size(382, 22);
            this.contactno.TabIndex = 13;
            // 
            // subscription
            // 
            this.subscription.Location = new System.Drawing.Point(198, 392);
            this.subscription.Name = "subscription";
            this.subscription.ReadOnly = true;
            this.subscription.Size = new System.Drawing.Size(382, 22);
            this.subscription.TabIndex = 14;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(66, 441);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(137, 41);
            this.edit.TabIndex = 15;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Visible = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Crimson;
            this.Cancel.Location = new System.Drawing.Point(235, 441);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(127, 41);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(62, 322);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(602, 77);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            // 
            // deletePlaylist
            // 
            this.deletePlaylist.BackColor = System.Drawing.Color.Red;
            this.deletePlaylist.Location = new System.Drawing.Point(64, 425);
            this.deletePlaylist.Name = "deletePlaylist";
            this.deletePlaylist.Size = new System.Drawing.Size(75, 35);
            this.deletePlaylist.TabIndex = 7;
            this.deletePlaylist.Text = "Delete";
            this.deletePlaylist.UseVisualStyleBackColor = false;
            this.deletePlaylist.Click += new System.EventHandler(this.deletePlaylist_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1049, 663);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.fillByPlaylistIdToolStrip);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.fillByUserIdToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fillByTitleToolStrip1);
            this.Controls.Add(this.fillByNameToolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.songBindingNavigator);
            this.Controls.Add(this.fillByTitleToolStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataBaseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingNavigator)).EndInit();
            this.songBindingNavigator.ResumeLayout(false);
            this.songBindingNavigator.PerformLayout();
            this.fillByTitleToolStrip.ResumeLayout(false);
            this.fillByTitleToolStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumImage)).EndInit();
            this.fillByTitleToolStrip1.ResumeLayout(false);
            this.fillByTitleToolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByName)).EndInit();
            this.fillByUserIdToolStrip.ResumeLayout(false);
            this.fillByUserIdToolStrip.PerformLayout();
            this.fillByNameToolStrip.ResumeLayout(false);
            this.fillByNameToolStrip.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.fillByPlaylistIdToolStrip.ResumeLayout(false);
            this.fillByPlaylistIdToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchSongs;
        private System.Windows.Forms.Button YourLibrary;
        private System.Windows.Forms.Button musicplayer;
        private System.Windows.Forms.Panel panel1;
        private MusicDataBaseDataSet musicDataBaseDataSet1;
        private MusicDataBaseDataSet1 musicDataBaseDataSet11;
        private System.Windows.Forms.BindingSource songBindingSource;
        private MusicDataBaseDataSet1TableAdapters.SongTableAdapter songTableAdapter;
        private MusicDataBaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator songBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton songBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip fillByTitleToolStrip;
        private System.Windows.Forms.ToolStripLabel titleToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox titleToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByTitleToolStripButton;
        private MusicDataBaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox songImage;
        private System.Windows.Forms.Label nowplaying;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label singers;
        private System.Windows.Forms.Label songname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox playsong;
        private System.Windows.Forms.PictureBox albumImage;
        private System.Windows.Forms.Button addtoplaylist;
        private System.Windows.Forms.Label album;
        private System.Windows.Forms.DataGridView songDataGridView;
        private System.Windows.Forms.ToolStrip fillByTitleToolStrip1;
        private System.Windows.Forms.ToolStripLabel titleToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox titleToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByTitleToolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox searchByName;
        private System.Windows.Forms.TextBox playlistname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource playlistBindingSource;
        private MusicDataBaseDataSet1TableAdapters.PlaylistTableAdapter playlistTableAdapter;
        private System.Windows.Forms.Button createplaylist;
        private System.Windows.Forms.DataGridView playlistDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStrip fillByUserIdToolStrip;
        private System.Windows.Forms.ToolStripLabel useridToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox useridToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByUserIdToolStripButton;
        private System.Windows.Forms.ToolStrip fillByNameToolStrip;
        private System.Windows.Forms.ToolStripLabel playlistnameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox playlistnameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNameToolStripButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addsongs;
        private System.Windows.Forms.DataGridView songDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label viewPlaylist;
        private System.Windows.Forms.ToolStrip fillByPlaylistIdToolStrip;
        private System.Windows.Forms.ToolStripLabel playlistidToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox playlistidToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByPlaylistIdToolStripButton;
        private System.Windows.Forms.Button yourprofile;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox subscription;
        private System.Windows.Forms.TextBox contactno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditProfile;
        private System.Windows.Forms.Label MyProfile;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Cancel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button deletePlaylist;
    }
}