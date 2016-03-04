namespace YouLite
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
            this.playVid = new AxAXVLC.AxVLCPlugin2();
            this.label1 = new System.Windows.Forms.Label();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.currentlyPlaying = new System.Windows.Forms.Label();
            this.queue = new System.Windows.Forms.Button();
            this.playlist = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.playVid)).BeginInit();
            this.SuspendLayout();
            // 
            // playVid
            // 
            this.playVid.Enabled = true;
            this.playVid.Location = new System.Drawing.Point(12, 93);
            this.playVid.Name = "playVid";
            this.playVid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playVid.OcxState")));
            this.playVid.Size = new System.Drawing.Size(440, 216);
            this.playVid.TabIndex = 0;
            this.playVid.MediaPlayerEncounteredError += new System.EventHandler(this.playVid_MediaPlayerEncounteredError);
            this.playVid.MediaPlayerEndReached += new System.EventHandler(this.playVid_MediaPlayerEndReached);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Youtube URL:";
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(93, 12);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(277, 20);
            this.textUrl.TabIndex = 2;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(377, 10);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // currentlyPlaying
            // 
            this.currentlyPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlyPlaying.Location = new System.Drawing.Point(15, 52);
            this.currentlyPlaying.Name = "currentlyPlaying";
            this.currentlyPlaying.Size = new System.Drawing.Size(437, 38);
            this.currentlyPlaying.TabIndex = 4;
            this.currentlyPlaying.Text = "Currently Playing: Nothing :(";
            this.currentlyPlaying.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // queue
            // 
            this.queue.Location = new System.Drawing.Point(458, 10);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(75, 23);
            this.queue.TabIndex = 5;
            this.queue.Text = "Queue";
            this.queue.UseVisualStyleBackColor = true;
            this.queue.Click += new System.EventHandler(this.queue_Click);
            // 
            // playlist
            // 
            this.playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlist.FormattingEnabled = true;
            this.playlist.HorizontalScrollbar = true;
            this.playlist.ItemHeight = 20;
            this.playlist.Location = new System.Drawing.Point(458, 45);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(228, 264);
            this.playlist.TabIndex = 6;
            this.playlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playlist_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 321);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.queue);
            this.Controls.Add(this.currentlyPlaying);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playVid);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "YouLite";
            ((System.ComponentModel.ISupportInitialize)(this.playVid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 playVid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label currentlyPlaying;
        private System.Windows.Forms.Button queue;
        private System.Windows.Forms.ListBox playlist;
    }
}

