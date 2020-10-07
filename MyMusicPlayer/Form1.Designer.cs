namespace MyMusicPlayer
{
    partial class musicPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musicPlayerForm));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.songPathBox = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.browseDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(-2, -41);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(645, 231);
            this.player.TabIndex = 0;
            // 
            // songPathBox
            // 
            this.songPathBox.BackColor = System.Drawing.Color.PowderBlue;
            this.songPathBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songPathBox.Location = new System.Drawing.Point(-2, 158);
            this.songPathBox.Multiline = true;
            this.songPathBox.Name = "songPathBox";
            this.songPathBox.ReadOnly = true;
            this.songPathBox.Size = new System.Drawing.Size(111, 32);
            this.songPathBox.TabIndex = 7;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.Turquoise;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browse.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(12, 203);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(97, 34);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(492, 203);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(97, 34);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.PaleTurquoise;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stop.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(362, 203);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(97, 34);
            this.stop.TabIndex = 4;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.LightBlue;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pause.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.Location = new System.Drawing.Point(245, 203);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(97, 34);
            this.pause.TabIndex = 5;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.LightSkyBlue;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(128, 203);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(97, 34);
            this.play.TabIndex = 6;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // browseDialog
            // 
            this.browseDialog.FileName = "Browse";
            this.browseDialog.Multiselect = true;
            this.browseDialog.ReadOnlyChecked = true;
            // 
            // musicPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(640, 242);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.songPathBox);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "musicPlayerForm";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TextBox songPathBox;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.OpenFileDialog browseDialog;
    }
}

