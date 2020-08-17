namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picBoxMainImg = new System.Windows.Forms.PictureBox();
            this.importMusicButton = new System.Windows.Forms.Button();
            this.fastReverseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.fastForwardButton = new System.Windows.Forms.Button();
            this.playListItems = new System.Windows.Forms.ListBox();
            this.btnRedirect = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.txtBListHeader = new System.Windows.Forms.TextBox();
            this.chkAutoPlay = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbCtlSongs = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMainImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnX
            // 
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(593, 3);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 40);
            this.btnX.TabIndex = 10;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.x_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(247, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(177, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "MUSIC PLAYER";
            // 
            // picBoxMainImg
            // 
            this.picBoxMainImg.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMainImg.Image")));
            this.picBoxMainImg.Location = new System.Drawing.Point(103, 83);
            this.picBoxMainImg.Name = "picBoxMainImg";
            this.picBoxMainImg.Size = new System.Drawing.Size(319, 206);
            this.picBoxMainImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMainImg.TabIndex = 1;
            this.picBoxMainImg.TabStop = false;
            // 
            // importMusicButton
            // 
            this.importMusicButton.BackColor = System.Drawing.Color.Transparent;
            this.importMusicButton.FlatAppearance.BorderSize = 0;
            this.importMusicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importMusicButton.Image = ((System.Drawing.Image)(resources.GetObject("importMusicButton.Image")));
            this.importMusicButton.Location = new System.Drawing.Point(103, 292);
            this.importMusicButton.Name = "importMusicButton";
            this.importMusicButton.Size = new System.Drawing.Size(75, 57);
            this.importMusicButton.TabIndex = 2;
            this.importMusicButton.UseVisualStyleBackColor = false;
            this.importMusicButton.Click += new System.EventHandler(this.importMusicButton_Click);
            // 
            // fastReverseButton
            // 
            this.fastReverseButton.BackColor = System.Drawing.Color.Transparent;
            this.fastReverseButton.FlatAppearance.BorderSize = 0;
            this.fastReverseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastReverseButton.Image = ((System.Drawing.Image)(resources.GetObject("fastReverseButton.Image")));
            this.fastReverseButton.Location = new System.Drawing.Point(170, 295);
            this.fastReverseButton.Name = "fastReverseButton";
            this.fastReverseButton.Size = new System.Drawing.Size(52, 51);
            this.fastReverseButton.TabIndex = 3;
            this.fastReverseButton.UseVisualStyleBackColor = false;
            this.fastReverseButton.Click += new System.EventHandler(this.fastReverseButton_Click);
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(230, 295);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(49, 51);
            this.playButton.TabIndex = 4;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(351, 295);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(54, 53);
            this.stopButton.TabIndex = 6;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // fastForwardButton
            // 
            this.fastForwardButton.BackColor = System.Drawing.Color.Transparent;
            this.fastForwardButton.FlatAppearance.BorderSize = 0;
            this.fastForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("fastForwardButton.Image")));
            this.fastForwardButton.Location = new System.Drawing.Point(286, 295);
            this.fastForwardButton.Name = "fastForwardButton";
            this.fastForwardButton.Size = new System.Drawing.Size(59, 50);
            this.fastForwardButton.TabIndex = 7;
            this.fastForwardButton.UseVisualStyleBackColor = false;
            this.fastForwardButton.Click += new System.EventHandler(this.fastForwardButton_Click);
            // 
            // playListItems
            // 
            this.playListItems.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playListItems.FormattingEnabled = true;
            this.playListItems.ItemHeight = 23;
            this.playListItems.Location = new System.Drawing.Point(449, 110);
            this.playListItems.Name = "playListItems";
            this.playListItems.Size = new System.Drawing.Size(210, 211);
            this.playListItems.TabIndex = 8;
            this.playListItems.DoubleClick += new System.EventHandler(this.playListItems_DoubleClick);
            // 
            // btnRedirect
            // 
            this.btnRedirect.BackColor = System.Drawing.Color.Plum;
            this.btnRedirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedirect.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedirect.Location = new System.Drawing.Point(486, 327);
            this.btnRedirect.Name = "btnRedirect";
            this.btnRedirect.Size = new System.Drawing.Size(133, 38);
            this.btnRedirect.TabIndex = 9;
            this.btnRedirect.Text = "Create New";
            this.btnRedirect.UseVisualStyleBackColor = false;
            this.btnRedirect.Click += new System.EventHandler(this.btnRedirect_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.Location = new System.Drawing.Point(230, 295);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(49, 51);
            this.pauseButton.TabIndex = 10;
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // txtBListHeader
            // 
            this.txtBListHeader.BackColor = System.Drawing.SystemColors.Control;
            this.txtBListHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBListHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.txtBListHeader.Location = new System.Drawing.Point(449, 74);
            this.txtBListHeader.Name = "txtBListHeader";
            this.txtBListHeader.Size = new System.Drawing.Size(100, 30);
            this.txtBListHeader.TabIndex = 13;
            this.txtBListHeader.TabStop = false;
            this.txtBListHeader.Text = "Playlists";
            // 
            // chkAutoPlay
            // 
            this.chkAutoPlay.AutoSize = true;
            this.chkAutoPlay.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoPlay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.chkAutoPlay.Location = new System.Drawing.Point(489, 371);
            this.chkAutoPlay.Name = "chkAutoPlay";
            this.chkAutoPlay.Size = new System.Drawing.Size(125, 27);
            this.chkAutoPlay.TabIndex = 14;
            this.chkAutoPlay.Text = "AutoPlay";
            this.chkAutoPlay.UseVisualStyleBackColor = false;
            this.chkAutoPlay.CheckedChanged += new System.EventHandler(this.chkAutoPlay_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::MusicPlayer.Properties.Resources.btnBack;
            this.btnBack.Location = new System.Drawing.Point(626, 327);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 38);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbCtlSongs
            // 
            this.tbCtlSongs.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCtlSongs.Location = new System.Drawing.Point(450, 110);
            this.tbCtlSongs.Name = "tbCtlSongs";
            this.tbCtlSongs.SelectedIndex = 0;
            this.tbCtlSongs.Size = new System.Drawing.Size(210, 211);
            this.tbCtlSongs.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(671, 414);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkAutoPlay);
            this.Controls.Add(this.txtBListHeader);
            this.Controls.Add(this.playListItems);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.btnRedirect);
            this.Controls.Add(this.fastForwardButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.fastReverseButton);
            this.Controls.Add(this.importMusicButton);
            this.Controls.Add(this.picBoxMainImg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbCtlSongs);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMainImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picBoxMainImg;
        private System.Windows.Forms.Button importMusicButton;
        private System.Windows.Forms.Button fastReverseButton;
        public System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button fastForwardButton;
        private System.Windows.Forms.Button btnX;
        public System.Windows.Forms.ListBox playListItems;
        private System.Windows.Forms.Button btnRedirect;
        public System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TextBox txtBListHeader;
        private System.Windows.Forms.CheckBox chkAutoPlay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tbCtlSongs;
    }
}

