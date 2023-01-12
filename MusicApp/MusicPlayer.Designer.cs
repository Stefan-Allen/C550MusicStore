namespace MusicApp
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.btn_preview = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.lbl_Track_Start = new System.Windows.Forms.Label();
            this.BtnSelectSongs = new System.Windows.Forms.Button();
            this.track_list = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Track_End = new System.Windows.Forms.Label();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.Player2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 450);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(35, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Playing...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(35, 377);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 29);
            this.button6.TabIndex = 8;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(35, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "Help";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(35, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Playlists";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(35, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Albums";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(35, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Explore";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Premium";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stefan Allen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MusicApp.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.lbl_volume);
            this.panel2.Controls.Add(this.track_volume);
            this.panel2.Controls.Add(this.btn_preview);
            this.panel2.Controls.Add(this.Next);
            this.panel2.Controls.Add(this.btn_stop);
            this.panel2.Controls.Add(this.btn_open);
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_pause);
            this.panel2.Controls.Add(this.btn_play);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(167, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 73);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_volume.Location = new System.Drawing.Point(537, 45);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(27, 13);
            this.lbl_volume.TabIndex = 15;
            this.lbl_volume.Text = "50%";
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(499, 13);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(104, 45);
            this.track_volume.TabIndex = 14;
            this.track_volume.Scroll += new System.EventHandler(this.lbl_volume_Scroll);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(52, 35);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 7;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(133, 35);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 6;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(376, 35);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(414, 6);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(37, 23);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "...";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.button10_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFileName.Location = new System.Drawing.Point(178, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(230, 27);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(95, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select File";
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(295, 35);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 1;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(214, 35);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button8_Click);
            // 
            // lbl_Track_Start
            // 
            this.lbl_Track_Start.AutoSize = true;
            this.lbl_Track_Start.ForeColor = System.Drawing.Color.Black;
            this.lbl_Track_Start.Location = new System.Drawing.Point(297, 105);
            this.lbl_Track_Start.Name = "lbl_Track_Start";
            this.lbl_Track_Start.Size = new System.Drawing.Size(34, 13);
            this.lbl_Track_Start.TabIndex = 14;
            this.lbl_Track_Start.Text = "00:00";
            // 
            // BtnSelectSongs
            // 
            this.BtnSelectSongs.Location = new System.Drawing.Point(695, 173);
            this.BtnSelectSongs.Name = "BtnSelectSongs";
            this.BtnSelectSongs.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectSongs.TabIndex = 12;
            this.BtnSelectSongs.Text = "Select Song";
            this.BtnSelectSongs.UseVisualStyleBackColor = true;
            this.BtnSelectSongs.Click += new System.EventHandler(this.BtnSelectSongs_Click);
            // 
            // track_list
            // 
            this.track_list.ForeColor = System.Drawing.Color.Black;
            this.track_list.FormattingEnabled = true;
            this.track_list.Location = new System.Drawing.Point(345, 237);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(443, 134);
            this.track_list.TabIndex = 13;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.ListBoxSongs_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(381, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(181, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Playing: ";
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(202, 352);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(443, 23);
            this.p_bar.TabIndex = 6;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Track_End
            // 
            this.lbl_Track_End.AutoSize = true;
            this.lbl_Track_End.ForeColor = System.Drawing.Color.Black;
            this.lbl_Track_End.Location = new System.Drawing.Point(378, 105);
            this.lbl_Track_End.Name = "lbl_Track_End";
            this.lbl_Track_End.Size = new System.Drawing.Size(34, 13);
            this.lbl_Track_End.TabIndex = 15;
            this.lbl_Track_End.Text = "00:00";
            // 
            // pic_art
            // 
            this.pic_art.Image = global::MusicApp.Properties.Resources.download__1__removebg_preview;
            this.pic_art.Location = new System.Drawing.Point(201, 227);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(138, 119);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 16;
            this.pic_art.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Player2.Enabled = true;
            this.Player2.Location = new System.Drawing.Point(167, 0);
            this.Player2.Name = "Player2";
            this.Player2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player2.OcxState")));
            this.Player2.Size = new System.Drawing.Size(633, 49);
            this.Player2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(167, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 49);
            this.panel3.TabIndex = 17;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.lbl_Track_End);
            this.Controls.Add(this.lbl_Track_Start);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.BtnSelectSongs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayer";
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSelectSongs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label lbl_Track_Start;
        private AxWMPLib.AxWindowsMediaPlayer Player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Track_End;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.Panel panel3;
    }
}