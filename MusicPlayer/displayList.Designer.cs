namespace MusicPlayer
{
    partial class displayList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(displayList));
            this.SelectSongs = new System.Windows.Forms.CheckedListBox();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.newPlayList = new System.Windows.Forms.ListBox();
            this.btnRedirect = new System.Windows.Forms.Button();
            this.newListBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectSongs
            // 
            this.SelectSongs.FormattingEnabled = true;
            this.SelectSongs.Location = new System.Drawing.Point(43, 132);
            this.SelectSongs.Name = "SelectSongs";
            this.SelectSongs.Size = new System.Drawing.Size(228, 257);
            this.SelectSongs.TabIndex = 0;
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.ForeColor = System.Drawing.Color.White;
            this.lblHeader2.Location = new System.Drawing.Point(310, 12);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(134, 28);
            this.lblHeader2.TabIndex = 1;
            this.lblHeader2.Text = "MUSIC LIST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.lblHeader2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 62);
            this.panel1.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(657, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(45, 36);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // newPlayList
            // 
            this.newPlayList.FormattingEnabled = true;
            this.newPlayList.ItemHeight = 20;
            this.newPlayList.Location = new System.Drawing.Point(432, 132);
            this.newPlayList.Name = "newPlayList";
            this.newPlayList.Size = new System.Drawing.Size(228, 244);
            this.newPlayList.TabIndex = 3;
            // 
            // btnRedirect
            // 
            this.btnRedirect.BackColor = System.Drawing.Color.Plum;
            this.btnRedirect.FlatAppearance.BorderSize = 0;
            this.btnRedirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedirect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedirect.ForeColor = System.Drawing.Color.White;
            this.btnRedirect.Location = new System.Drawing.Point(462, 381);
            this.btnRedirect.Name = "btnRedirect";
            this.btnRedirect.Size = new System.Drawing.Size(168, 38);
            this.btnRedirect.TabIndex = 10;
            this.btnRedirect.Text = "Go Back";
            this.btnRedirect.UseVisualStyleBackColor = false;
            this.btnRedirect.Click += new System.EventHandler(this.btnRedirect_Click);
            // 
            // newListBtn
            // 
            this.newListBtn.BackColor = System.Drawing.Color.Plum;
            this.newListBtn.FlatAppearance.BorderSize = 0;
            this.newListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newListBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newListBtn.ForeColor = System.Drawing.Color.White;
            this.newListBtn.Location = new System.Drawing.Point(73, 381);
            this.newListBtn.Name = "newListBtn";
            this.newListBtn.Size = new System.Drawing.Size(168, 38);
            this.newListBtn.TabIndex = 11;
            this.newListBtn.Text = "New List";
            this.newListBtn.UseVisualStyleBackColor = false;
            this.newListBtn.Click += new System.EventHandler(this.newListBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.addBtn.Location = new System.Drawing.Point(302, 233);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(98, 40);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(454, 100);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(176, 26);
            this.txtPlaylistName.TabIndex = 13;
            this.txtPlaylistName.Enter += new System.EventHandler(this.txtPlaylistName_Enter);
            this.txtPlaylistName.Leave += new System.EventHandler(this.txtPlaylistName_Leave);
            // 
            // displayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(713, 486);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.newListBtn);
            this.Controls.Add(this.btnRedirect);
            this.Controls.Add(this.newPlayList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SelectSongs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "displayList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "displayList";
            this.Load += new System.EventHandler(this.displayList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox SelectSongs;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox newPlayList;
        private System.Windows.Forms.Button btnRedirect;
        private System.Windows.Forms.Button newListBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        public System.Windows.Forms.TextBox txtPlaylistName;
    }
}