namespace OnlineMusicStore
{
    partial class NewPlaylist
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
            this.createplaylist = new System.Windows.Forms.Button();
            this.playlistname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createplaylist
            // 
            this.createplaylist.BackColor = System.Drawing.SystemColors.Desktop;
            this.createplaylist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createplaylist.Location = new System.Drawing.Point(127, 141);
            this.createplaylist.Name = "createplaylist";
            this.createplaylist.Size = new System.Drawing.Size(102, 33);
            this.createplaylist.TabIndex = 0;
            this.createplaylist.Text = "Create";
            this.createplaylist.UseVisualStyleBackColor = false;
            this.createplaylist.Click += new System.EventHandler(this.createplaylist_Click);
            // 
            // playlistname
            // 
            this.playlistname.Location = new System.Drawing.Point(41, 94);
            this.playlistname.Name = "playlistname";
            this.playlistname.Size = new System.Drawing.Size(297, 22);
            this.playlistname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Give your playlist a name\r\n";
            // 
            // NewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(367, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playlistname);
            this.Controls.Add(this.createplaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewPlaylist";
            this.Text = "NewPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createplaylist;
        private System.Windows.Forms.TextBox playlistname;
        private System.Windows.Forms.Label label1;
    }
}