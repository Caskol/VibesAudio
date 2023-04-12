namespace VibesAudio
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sideBar = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonEqualizer = new System.Windows.Forms.Button();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCover = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.panelName = new System.Windows.Forms.Panel();
            this.labelNaming = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.labelVolume = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelMaxPos = new System.Windows.Forms.Label();
            this.labelCurrentPos = new System.Windows.Forms.Label();
            this.trackBarMusicPos = new System.Windows.Forms.TrackBar();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sideBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCover.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicPos)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.sideBar.BackColor = System.Drawing.Color.Silver;
            this.sideBar.Controls.Add(this.comboBox1);
            this.sideBar.Controls.Add(this.buttonEqualizer);
            this.sideBar.Controls.Add(this.buttonPlayer);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(200, 469);
            this.sideBar.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // buttonEqualizer
            // 
            this.buttonEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEqualizer.FlatAppearance.BorderSize = 0;
            this.buttonEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqualizer.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqualizer.Location = new System.Drawing.Point(0, 225);
            this.buttonEqualizer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEqualizer.Name = "buttonEqualizer";
            this.buttonEqualizer.Size = new System.Drawing.Size(200, 50);
            this.buttonEqualizer.TabIndex = 3;
            this.buttonEqualizer.Text = "Equalizer";
            this.buttonEqualizer.UseVisualStyleBackColor = true;
            this.buttonEqualizer.Click += new System.EventHandler(this.buttonEqualizer_Click);
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlayer.FlatAppearance.BorderSize = 0;
            this.buttonPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayer.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayer.Location = new System.Drawing.Point(0, 175);
            this.buttonPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(200, 50);
            this.buttonPlayer.TabIndex = 2;
            this.buttonPlayer.Text = "Player";
            this.buttonPlayer.UseVisualStyleBackColor = true;
            this.buttonPlayer.Click += new System.EventHandler(this.buttonPlayer_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 175);
            this.panel3.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Controls.Add(this.panelCover);
            this.panelMain.Controls.Add(this.panelName);
            this.panelMain.Controls.Add(this.panelNavigation);
            this.panelMain.Controls.Add(this.sideBar);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(789, 469);
            this.panelMain.TabIndex = 3;
            // 
            // panelCover
            // 
            this.panelCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCover.Controls.Add(this.panel2);
            this.panelCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCover.Location = new System.Drawing.Point(200, 0);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(589, 315);
            this.panelCover.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonExpand);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 315);
            this.panel2.TabIndex = 6;
            // 
            // buttonExpand
            // 
            this.buttonExpand.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExpand.FlatAppearance.BorderSize = 0;
            this.buttonExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExpand.ForeColor = System.Drawing.Color.White;
            this.buttonExpand.Location = new System.Drawing.Point(0, 0);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(30, 30);
            this.buttonExpand.TabIndex = 4;
            this.buttonExpand.Text = "<<";
            this.buttonExpand.UseVisualStyleBackColor = true;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.labelNaming);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelName.Location = new System.Drawing.Point(200, 315);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(589, 28);
            this.panelName.TabIndex = 8;
            // 
            // labelNaming
            // 
            this.labelNaming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNaming.Location = new System.Drawing.Point(0, 0);
            this.labelNaming.Margin = new System.Windows.Forms.Padding(0);
            this.labelNaming.Name = "labelNaming";
            this.labelNaming.Size = new System.Drawing.Size(589, 28);
            this.labelNaming.TabIndex = 0;
            this.labelNaming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.Transparent;
            this.panelNavigation.Controls.Add(this.buttonRepeat);
            this.panelNavigation.Controls.Add(this.labelVolume);
            this.panelNavigation.Controls.Add(this.trackBarVolume);
            this.panelNavigation.Controls.Add(this.labelMaxPos);
            this.panelNavigation.Controls.Add(this.labelCurrentPos);
            this.panelNavigation.Controls.Add(this.trackBarMusicPos);
            this.panelNavigation.Controls.Add(this.buttonStop);
            this.panelNavigation.Controls.Add(this.buttonMute);
            this.panelNavigation.Controls.Add(this.buttonPlayPause);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(200, 343);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(589, 126);
            this.panelNavigation.TabIndex = 3;
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRepeat.BackColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.BackgroundImage = global::VibesAudio.Properties.Resources.repeat;
            this.buttonRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRepeat.FlatAppearance.BorderSize = 0;
            this.buttonRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepeat.Location = new System.Drawing.Point(323, 58);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(30, 30);
            this.buttonRepeat.TabIndex = 14;
            this.buttonRepeat.UseVisualStyleBackColor = false;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVolume.Location = new System.Drawing.Point(516, 98);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(49, 25);
            this.labelVolume.TabIndex = 13;
            this.labelVolume.Text = "0";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolume.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBarVolume.Location = new System.Drawing.Point(494, 78);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(92, 45);
            this.trackBarVolume.TabIndex = 12;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // labelMaxPos
            // 
            this.labelMaxPos.AutoSize = true;
            this.labelMaxPos.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMaxPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxPos.Location = new System.Drawing.Point(573, 45);
            this.labelMaxPos.MaximumSize = new System.Drawing.Size(100, 30);
            this.labelMaxPos.Name = "labelMaxPos";
            this.labelMaxPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMaxPos.Size = new System.Drawing.Size(16, 17);
            this.labelMaxPos.TabIndex = 11;
            this.labelMaxPos.Text = "?";
            // 
            // labelCurrentPos
            // 
            this.labelCurrentPos.AutoSize = true;
            this.labelCurrentPos.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCurrentPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentPos.Location = new System.Drawing.Point(0, 45);
            this.labelCurrentPos.Name = "labelCurrentPos";
            this.labelCurrentPos.Size = new System.Drawing.Size(16, 17);
            this.labelCurrentPos.TabIndex = 10;
            this.labelCurrentPos.Text = "0";
            // 
            // trackBarMusicPos
            // 
            this.trackBarMusicPos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBarMusicPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarMusicPos.LargeChange = 0;
            this.trackBarMusicPos.Location = new System.Drawing.Point(0, 0);
            this.trackBarMusicPos.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarMusicPos.Maximum = 100;
            this.trackBarMusicPos.Name = "trackBarMusicPos";
            this.trackBarMusicPos.Size = new System.Drawing.Size(589, 45);
            this.trackBarMusicPos.TabIndex = 9;
            this.trackBarMusicPos.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarMusicPos.ValueChanged += new System.EventHandler(this.trackBarMusicPos_ValueChanged);
            this.trackBarMusicPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarMusicPos_MouseDown);
            this.trackBarMusicPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarMusicPos_MouseUp);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.BackgroundImage = global::VibesAudio.Properties.Resources.stop;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(231, 57);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(30, 30);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMute.BackgroundImage = global::VibesAudio.Properties.Resources.mute;
            this.buttonMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMute.FlatAppearance.BorderSize = 0;
            this.buttonMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMute.Location = new System.Drawing.Point(458, 75);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(30, 30);
            this.buttonMute.TabIndex = 3;
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlayPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayPause.BackgroundImage")));
            this.buttonPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlayPause.Enabled = false;
            this.buttonPlayPause.FlatAppearance.BorderSize = 0;
            this.buttonPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayPause.Location = new System.Drawing.Point(267, 48);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(50, 50);
            this.buttonPlayPause.TabIndex = 1;
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(789, 469);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "VibesAudio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.sideBar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelCover.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicPos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonEqualizer;
        private System.Windows.Forms.Button buttonPlayer;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelMaxPos;
        private System.Windows.Forms.Label labelCurrentPos;
        private System.Windows.Forms.TrackBar trackBarMusicPos;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Panel panelCover;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label labelNaming;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Button buttonRepeat;
    }
}

