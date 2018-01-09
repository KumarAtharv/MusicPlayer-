using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    public partial class musicPlayerForm : Form
    {
        public musicPlayerForm()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (browseDialog.ShowDialog() == DialogResult.OK)
            {
                songPathBox.Text = browseDialog.FileName;
            }
            player.URL = songPathBox.Text;
        }

        private void play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
