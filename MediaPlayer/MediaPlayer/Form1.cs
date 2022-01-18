using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackvolu.Value = 50;
            lblvolume.Text = "50%";
        }
        string[] paths, files;
        

        private void tracklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[tracklist.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();

        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (tracklist.SelectedIndex < tracklist.Items.Count - 1)
            {
                tracklist.SelectedIndex = tracklist.SelectedIndex + 1;
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (tracklist.SelectedIndex >0)
            {
                tracklist.SelectedIndex = tracklist.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pbar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                pbar.Maximum = (int)player.Ctlcontrols.currentPosition;
                try
                {
                    lblstart.Text = player.Ctlcontrols.currentPositionString;
                    lblend.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch
                {

                }
            }
            
        }

        private void trackvolu_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackvolu.Value;
            lblvolume.Text = trackvolu.Value.ToString() + "%";
        }

        private void pbar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / pbar.Width;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for(int x = 0; x<files.Length; x++)
                {
                    tracklist.Items.Add(files[x]);
                }
            }
        }
    }
}
