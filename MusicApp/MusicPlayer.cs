using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicApp
{
    public partial class MusicPlayer : Form
    {
        SoundPlayer player;
        public MusicPlayer()
        {
            InitializeComponent();
            track_volume.Value = 50;
            lbl_volume.Text = "50%";
        }

        string[] paths, files;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void siticoneShapes1_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player2.URL = paths[track_list.SelectedIndex];
            Player2.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentlyPlaying form = new CurrentlyPlaying();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Explore form = new Explore();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Albums form = new Albums();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Playlist form = new Playlist();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help form = new Help();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Player2.Ctlcontrols.play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect= true;
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files= ofd.FileNames;
                paths= ofd.FileNames;
                for (int x=0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Player2.Ctlcontrols.pause();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            player = new SoundPlayer();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex>0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)Player2.Ctlcontrols.currentItem.duration;
                p_bar.Value=(int)Player2.Ctlcontrols.currentPosition;
                try
                {
                    lbl_Track_Start.Text = Player2.Ctlcontrols.currentPositionString;
                    lbl_Track_End.Text = Player2.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch
                {

                }
            }
        }

        private void lbl_volume_Scroll(object sender, EventArgs e)
        {
            Player2 .settings.volume = track_volume.Value;
            lbl_volume.Text = track_volume.Value.ToString() + "%";
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            Player2.Ctlcontrols.currentPosition = Player2.currentMedia.duration * e.X / p_bar.Width;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Player2.Ctlcontrols.stop();
            p_bar.Value= 0;
        }
    }
}