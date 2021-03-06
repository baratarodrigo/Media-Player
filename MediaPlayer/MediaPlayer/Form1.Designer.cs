
namespace MediaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.tracklist = new System.Windows.Forms.ListBox();
            this.picart = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackvolu = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblvolume = new System.Windows.Forms.Label();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackvolu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnprev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprev.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprev.Location = new System.Drawing.Point(31, 420);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(129, 44);
            this.btnprev.TabIndex = 0;
            this.btnprev.Text = "Preview";
            this.btnprev.UseVisualStyleBackColor = false;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnext.Location = new System.Drawing.Point(166, 420);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(129, 44);
            this.btnnext.TabIndex = 1;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplay.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnplay.Location = new System.Drawing.Point(301, 420);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(129, 44);
            this.btnplay.TabIndex = 2;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnpause
            // 
            this.btnpause.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpause.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpause.Location = new System.Drawing.Point(436, 420);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(129, 44);
            this.btnpause.TabIndex = 3;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = false;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstop.Location = new System.Drawing.Point(571, 420);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(129, 44);
            this.btnstop.TabIndex = 4;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopen.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnopen.Location = new System.Drawing.Point(706, 420);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(304, 44);
            this.btnopen.TabIndex = 5;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(31, 387);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(979, 18);
            this.pbar.TabIndex = 6;
            this.pbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbar_MouseDown);
            // 
            // tracklist
            // 
            this.tracklist.BackColor = System.Drawing.SystemColors.GrayText;
            this.tracklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tracklist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tracklist.FormattingEnabled = true;
            this.tracklist.ItemHeight = 16;
            this.tracklist.Location = new System.Drawing.Point(267, 174);
            this.tracklist.Name = "tracklist";
            this.tracklist.Size = new System.Drawing.Size(727, 192);
            this.tracklist.TabIndex = 7;
            this.tracklist.SelectedIndexChanged += new System.EventHandler(this.tracklist_SelectedIndexChanged);
            // 
            // picart
            // 
            this.picart.Image = ((System.Drawing.Image)(resources.GetObject("picart.Image")));
            this.picart.Location = new System.Drawing.Point(31, 170);
            this.picart.Name = "picart";
            this.picart.Size = new System.Drawing.Size(230, 200);
            this.picart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picart.TabIndex = 8;
            this.picart.TabStop = false;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1056, 136);
            this.player.TabIndex = 9;
            // 
            // trackvolu
            // 
            this.trackvolu.Location = new System.Drawing.Point(1000, 174);
            this.trackvolu.Maximum = 100;
            this.trackvolu.Name = "trackvolu";
            this.trackvolu.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackvolu.Size = new System.Drawing.Size(56, 196);
            this.trackvolu.TabIndex = 10;
            this.trackvolu.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackvolu.Scroll += new System.EventHandler(this.trackvolu_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(995, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume";
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvolume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblvolume.Location = new System.Drawing.Point(995, 170);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(48, 17);
            this.lblvolume.TabIndex = 12;
            this.lblvolume.Text = "100%";
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Font = new System.Drawing.Font("Digital-7 Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblstart.Location = new System.Drawing.Point(42, 35);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(219, 80);
            this.lblstart.TabIndex = 13;
            this.lblstart.Text = "00:00";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Digital-7 Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblend.Location = new System.Drawing.Point(809, 35);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(219, 80);
            this.lblend.TabIndex = 14;
            this.lblend.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1056, 497);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackvolu);
            this.Controls.Add(this.player);
            this.Controls.Add(this.picart);
            this.Controls.Add(this.tracklist);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackvolu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.ListBox tracklist;
        private System.Windows.Forms.PictureBox picart;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar trackvolu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Timer timer1;
    }
}

