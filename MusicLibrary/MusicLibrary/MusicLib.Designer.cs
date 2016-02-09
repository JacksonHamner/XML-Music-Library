namespace MusicLibrary
{
    partial class MusicLib
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
            this.artistsListBox = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertArtistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertAlbumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSongToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumsListBox = new System.Windows.Forms.CheckedListBox();
            this.songsListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.songTitleTextBox = new System.Windows.Forms.TextBox();
            this.songSubmitButton = new System.Windows.Forms.Button();
            this.artistGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.submitArtistButton = new System.Windows.Forms.Button();
            this.albumGroupBox = new System.Windows.Forms.GroupBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.releaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.albumSubmitButton = new System.Windows.Forms.Button();
            this.songGroupBox = new System.Windows.Forms.GroupBox();
            this.trackNumberTextBox = new System.Windows.Forms.TextBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.durTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.artistGroupBox.SuspendLayout();
            this.albumGroupBox.SuspendLayout();
            this.songGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // artistsListBox
            // 
            this.artistsListBox.FormattingEnabled = true;
            this.artistsListBox.Location = new System.Drawing.Point(12, 47);
            this.artistsListBox.Name = "artistsListBox";
            this.artistsListBox.Size = new System.Drawing.Size(482, 64);
            this.artistsListBox.TabIndex = 0;
            this.artistsListBox.SelectedIndexChanged += new System.EventHandler(this.artistsListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readXMLFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readXMLFileToolStripMenuItem
            // 
            this.readXMLFileToolStripMenuItem.Name = "readXMLFileToolStripMenuItem";
            this.readXMLFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.readXMLFileToolStripMenuItem.Text = "Read XML File";
            this.readXMLFileToolStripMenuItem.Click += new System.EventHandler(this.readXMLFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteEntryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertArtistToolStripMenuItem1,
            this.insertAlbumToolStripMenuItem1,
            this.insertSongToolStripMenuItem1});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // insertArtistToolStripMenuItem1
            // 
            this.insertArtistToolStripMenuItem1.Name = "insertArtistToolStripMenuItem1";
            this.insertArtistToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.insertArtistToolStripMenuItem1.Text = "Artist";
            this.insertArtistToolStripMenuItem1.Click += new System.EventHandler(this.insertArtistToolStripMenuItem1_Click_1);
            // 
            // insertAlbumToolStripMenuItem1
            // 
            this.insertAlbumToolStripMenuItem1.Name = "insertAlbumToolStripMenuItem1";
            this.insertAlbumToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.insertAlbumToolStripMenuItem1.Text = "Album";
            this.insertAlbumToolStripMenuItem1.Click += new System.EventHandler(this.insertAlbumToolStripMenuItem1_Click);
            // 
            // insertSongToolStripMenuItem1
            // 
            this.insertSongToolStripMenuItem1.Name = "insertSongToolStripMenuItem1";
            this.insertSongToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.insertSongToolStripMenuItem1.Text = "Song";
            this.insertSongToolStripMenuItem1.Click += new System.EventHandler(this.insertSongToolStripMenuItem1_Click);
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteArtistToolStripMenuItem,
            this.deleteAlbumToolStripMenuItem,
            this.deleteSongToolStripMenuItem});
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete";
            // 
            // deleteArtistToolStripMenuItem
            // 
            this.deleteArtistToolStripMenuItem.Name = "deleteArtistToolStripMenuItem";
            this.deleteArtistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteArtistToolStripMenuItem.Text = "Artist";
            this.deleteArtistToolStripMenuItem.Click += new System.EventHandler(this.deleteArtistToolStripMenuItem_Click);
            // 
            // deleteAlbumToolStripMenuItem
            // 
            this.deleteAlbumToolStripMenuItem.Name = "deleteAlbumToolStripMenuItem";
            this.deleteAlbumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteAlbumToolStripMenuItem.Text = "Album";
            this.deleteAlbumToolStripMenuItem.Click += new System.EventHandler(this.deleteAlbumToolStripMenuItem_Click);
            // 
            // deleteSongToolStripMenuItem
            // 
            this.deleteSongToolStripMenuItem.Name = "deleteSongToolStripMenuItem";
            this.deleteSongToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteSongToolStripMenuItem.Text = "Song";
            this.deleteSongToolStripMenuItem.Click += new System.EventHandler(this.deleteSongToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistToolStripMenuItem2,
            this.albumToolStripMenuItem2,
            this.songToolStripMenuItem2});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem1.Text = "Modify";
            // 
            // artistToolStripMenuItem2
            // 
            this.artistToolStripMenuItem2.Name = "artistToolStripMenuItem2";
            this.artistToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.artistToolStripMenuItem2.Text = "Artist";
            this.artistToolStripMenuItem2.Click += new System.EventHandler(this.artistToolStripMenuItem2_Click);
            // 
            // albumToolStripMenuItem2
            // 
            this.albumToolStripMenuItem2.Name = "albumToolStripMenuItem2";
            this.albumToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.albumToolStripMenuItem2.Text = "Album";
            this.albumToolStripMenuItem2.Click += new System.EventHandler(this.albumToolStripMenuItem2_Click);
            // 
            // songToolStripMenuItem2
            // 
            this.songToolStripMenuItem2.Name = "songToolStripMenuItem2";
            this.songToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.songToolStripMenuItem2.Text = "Song";
            this.songToolStripMenuItem2.Click += new System.EventHandler(this.songToolStripMenuItem2_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpDocumentsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpDocumentsToolStripMenuItem
            // 
            this.helpDocumentsToolStripMenuItem.Name = "helpDocumentsToolStripMenuItem";
            this.helpDocumentsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.helpDocumentsToolStripMenuItem.Text = "Help Documents";
            this.helpDocumentsToolStripMenuItem.Click += new System.EventHandler(this.helpDocumentsToolStripMenuItem_Click);
            // 
            // albumsListBox
            // 
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.Location = new System.Drawing.Point(12, 132);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(482, 64);
            this.albumsListBox.TabIndex = 15;
            this.albumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // songsListBox
            // 
            this.songsListBox.FormattingEnabled = true;
            this.songsListBox.Location = new System.Drawing.Point(12, 222);
            this.songsListBox.Name = "songsListBox";
            this.songsListBox.Size = new System.Drawing.Size(482, 109);
            this.songsListBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Title";
            // 
            // songTitleTextBox
            // 
            this.songTitleTextBox.Location = new System.Drawing.Point(44, 19);
            this.songTitleTextBox.Name = "songTitleTextBox";
            this.songTitleTextBox.Size = new System.Drawing.Size(168, 20);
            this.songTitleTextBox.TabIndex = 32;
            // 
            // songSubmitButton
            // 
            this.songSubmitButton.Location = new System.Drawing.Point(165, 66);
            this.songSubmitButton.Name = "songSubmitButton";
            this.songSubmitButton.Size = new System.Drawing.Size(47, 20);
            this.songSubmitButton.TabIndex = 31;
            this.songSubmitButton.Text = "Sumbit";
            this.songSubmitButton.UseVisualStyleBackColor = true;
            this.songSubmitButton.Click += new System.EventHandler(this.songSubmitButton_Click);
            // 
            // artistGroupBox
            // 
            this.artistGroupBox.Controls.Add(this.label1);
            this.artistGroupBox.Controls.Add(this.artistTextBox);
            this.artistGroupBox.Controls.Add(this.submitArtistButton);
            this.artistGroupBox.Location = new System.Drawing.Point(500, 29);
            this.artistGroupBox.Name = "artistGroupBox";
            this.artistGroupBox.Size = new System.Drawing.Size(222, 49);
            this.artistGroupBox.TabIndex = 36;
            this.artistGroupBox.TabStop = false;
            this.artistGroupBox.Text = "Artist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name";
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(52, 19);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(100, 20);
            this.artistTextBox.TabIndex = 28;
            // 
            // submitArtistButton
            // 
            this.submitArtistButton.Location = new System.Drawing.Point(165, 19);
            this.submitArtistButton.Name = "submitArtistButton";
            this.submitArtistButton.Size = new System.Drawing.Size(49, 20);
            this.submitArtistButton.TabIndex = 27;
            this.submitArtistButton.Text = "Submit";
            this.submitArtistButton.UseVisualStyleBackColor = true;
            this.submitArtistButton.Click += new System.EventHandler(this.submitArtistButton_Click);
            // 
            // albumGroupBox
            // 
            this.albumGroupBox.Controls.Add(this.genreLabel);
            this.albumGroupBox.Controls.Add(this.genreComboBox);
            this.albumGroupBox.Controls.Add(this.label5);
            this.albumGroupBox.Controls.Add(this.label4);
            this.albumGroupBox.Controls.Add(this.releaseDatePicker);
            this.albumGroupBox.Controls.Add(this.albumTextBox);
            this.albumGroupBox.Controls.Add(this.albumSubmitButton);
            this.albumGroupBox.Location = new System.Drawing.Point(500, 98);
            this.albumGroupBox.Name = "albumGroupBox";
            this.albumGroupBox.Size = new System.Drawing.Size(222, 95);
            this.albumGroupBox.TabIndex = 37;
            this.albumGroupBox.TabStop = false;
            this.albumGroupBox.Text = "Album";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(6, 65);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 43;
            this.genreLabel.Text = "Genre";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(81, 65);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(78, 21);
            this.genreComboBox.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Release Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Name";
            // 
            // releaseDatePicker
            // 
            this.releaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.releaseDatePicker.Location = new System.Drawing.Point(81, 42);
            this.releaseDatePicker.Name = "releaseDatePicker";
            this.releaseDatePicker.Size = new System.Drawing.Size(133, 20);
            this.releaseDatePicker.TabIndex = 39;
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(81, 19);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(133, 20);
            this.albumTextBox.TabIndex = 38;
            // 
            // albumSubmitButton
            // 
            this.albumSubmitButton.Location = new System.Drawing.Point(165, 69);
            this.albumSubmitButton.Name = "albumSubmitButton";
            this.albumSubmitButton.Size = new System.Drawing.Size(49, 20);
            this.albumSubmitButton.TabIndex = 37;
            this.albumSubmitButton.Text = "Submit";
            this.albumSubmitButton.UseVisualStyleBackColor = true;
            this.albumSubmitButton.Click += new System.EventHandler(this.albumSubmitButton_Click);
            // 
            // songGroupBox
            // 
            this.songGroupBox.Controls.Add(this.trackNumberTextBox);
            this.songGroupBox.Controls.Add(this.ratingComboBox);
            this.songGroupBox.Controls.Add(this.label10);
            this.songGroupBox.Controls.Add(this.durTextBox);
            this.songGroupBox.Controls.Add(this.label6);
            this.songGroupBox.Controls.Add(this.songSubmitButton);
            this.songGroupBox.Controls.Add(this.label3);
            this.songGroupBox.Controls.Add(this.songTitleTextBox);
            this.songGroupBox.Location = new System.Drawing.Point(500, 204);
            this.songGroupBox.Name = "songGroupBox";
            this.songGroupBox.Size = new System.Drawing.Size(222, 92);
            this.songGroupBox.TabIndex = 38;
            this.songGroupBox.TabStop = false;
            this.songGroupBox.Text = "Song";
            // 
            // trackNumberTextBox
            // 
            this.trackNumberTextBox.Location = new System.Drawing.Point(92, 42);
            this.trackNumberTextBox.Name = "trackNumberTextBox";
            this.trackNumberTextBox.Size = new System.Drawing.Size(24, 20);
            this.trackNumberTextBox.TabIndex = 43;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(14, 65);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(138, 21);
            this.ratingComboBox.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Track Number";
            // 
            // durTextBox
            // 
            this.durTextBox.Location = new System.Drawing.Point(170, 42);
            this.durTextBox.Name = "durTextBox";
            this.durTextBox.Size = new System.Drawing.Size(44, 20);
            this.durTextBox.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Duration";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(595, 308);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(127, 23);
            this.resetButton.TabIndex = 39;
            this.resetButton.Text = "Cancel Insert/modify";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Artists";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Albums";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Songs";
            // 
            // MusicLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 342);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.songGroupBox);
            this.Controls.Add(this.albumGroupBox);
            this.Controls.Add(this.artistGroupBox);
            this.Controls.Add(this.songsListBox);
            this.Controls.Add(this.albumsListBox);
            this.Controls.Add(this.artistsListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MusicLib";
            this.Text = "Music Library";
            this.Load += new System.EventHandler(this.MusicLib_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.artistGroupBox.ResumeLayout(false);
            this.artistGroupBox.PerformLayout();
            this.albumGroupBox.ResumeLayout(false);
            this.albumGroupBox.PerformLayout();
            this.songGroupBox.ResumeLayout(false);
            this.songGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox artistsListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox albumsListBox;
        private System.Windows.Forms.CheckedListBox songsListBox;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox albumGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker releaseDatePicker;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.Button albumSubmitButton;
        private System.Windows.Forms.GroupBox artistGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Button submitArtistButton;
        private System.Windows.Forms.TextBox songTitleTextBox;
        private System.Windows.Forms.Button songSubmitButton;
        private System.Windows.Forms.GroupBox songGroupBox;
        private System.Windows.Forms.TextBox durTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem readXMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertArtistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertAlbumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertSongToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ToolStripMenuItem helpDocumentsToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.TextBox trackNumberTextBox;
        private System.Windows.Forms.Label label10;
    }
}

