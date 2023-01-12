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

namespace MusicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] paths, files;


        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\stefa\OneDrive\Documents\AirChat\AirChat\MusicPlayer\yt5s.io_-_Dan__Shay_Justin_Bieber_-_10000_Hours_Official_Music_Video_256_kbps.wav");
            splayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[ListBoxSongs.SelectedIndex];
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            MusicPlayer form = new MusicPlayer();
            form.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CurrentlyPlaying form = new CurrentlyPlaying();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Explore form = new Explore();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Albums form = new Albums();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Playlist form = new Playlist();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help form = new Help();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd= new OpenFileDialog();
            ofd.Multiselect = true;

            if(ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    ListBoxSongs.Items.Add(files[i]);
                }
            }
        }
    }
}

       
