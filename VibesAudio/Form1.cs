using CSCore.Codecs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VibesAudio
{
    public partial class Form1 : Form
    {
        private MusicPlayer _musicPlayer = new MusicPlayer();//создание объекта музыкального плеера
        //private readonly ObservableCollection<MMDevice> _devices = new ObservableCollection<MMDevice>();//создание списка устройств вывода
        (Dictionary<string, List<string>>, string) devices;
        private bool _isPlaying;//проверка на проигрывание аудио
        private bool _expanded = true; //проверка на раскрытие меню
        private bool muted = false;
        private int lastVolume;
        private bool stopUpdate;
        private int length; //переменная для хранения длительности трека в секундах
        int deviceIndexChanged = 0;
        private bool repeat = false;
        private string fileName;
        EQ equalizerWindow;
        public Form1()
        {
            InitializeComponent();
        }
        private void PlayOrPause()
        {
            if (_isPlaying)
            {
                _musicPlayer.Pause();
                buttonPlayPause.BackgroundImage = Properties.Resources.play;
                _isPlaying = false;
            }
            else
            {

                if (trackBarMusicPos.Value == length)
                {
                    _musicPlayer.Position = TimeSpan.Zero;
                    trackBarMusicPos.Value = 0;
                }
                _musicPlayer.Play();
                buttonPlayPause.BackgroundImage = Properties.Resources.pause;
                _isPlaying = true;
            }
        }
        private (Dictionary<string, List<string>>, string) GetAudioDevices()
        {
            var devices = new Dictionary<string, List<string>>();

            // Retrieve all active audio devices
            foreach (var dev in _musicPlayer.EnumerateWasapiDevices())
            {
                if (!devices.ContainsKey(dev.FriendlyName))
                {
                    devices.Add(dev.FriendlyName, new List<string>());
                }
                // Dictionary holds device's friendly names as keys and IDs as values
                devices[dev.FriendlyName].Add(dev.DeviceID.ToString());
            }

            // get the default audio endpoint
            string defaultDeviceName = MusicPlayer.GetDefaultSoundDevice().FriendlyName;
            return (devices, defaultDeviceName);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            devices = GetAudioDevices();
            foreach (var device in devices.Item1)
            {
                comboBox1.Items.Add(device.Key);
            }

            // Set the initial selected index based on the default audio endpoint
            comboBox1.SelectedIndex = comboBox1.FindStringExact(devices.Item2);

            labelVolume.Text = trackBarVolume.Value.ToString();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width < 600 || this.Size.Height < 500)
            {
                panel2.Visible = false;
                sideBar.Visible = false;
            }
            else if (_expanded && !(this.Size.Width < 600 || this.Size.Height < 500))
            {
                panel2.Visible = true;
                sideBar.Visible = true;
            }
            else if (!_expanded && !(this.Size.Width < 600 || this.Size.Height < 500))
            {
                panel2.Visible = true;
            }
            buttonPlayPause.Location = new Point(trackBarMusicPos.Width / 2 - buttonPlayPause.Width / 2, buttonPlayPause.Location.Y);
            buttonStop.Location = new Point(buttonPlayPause.Location.X - buttonStop.Width - 6, buttonStop.Location.Y);
            buttonRepeat.Location = new Point(buttonPlayPause.Location.X + buttonPlayPause.Width + 6, buttonStop.Location.Y);
            labelMaxPos.Location = new Point(trackBarMusicPos.Width - 50, labelMaxPos.Location.Y);
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            if (_expanded && !(this.Size.Width < 600 || this.Size.Height < 500))
            {
                _expanded = !_expanded;
                sideBar.Visible = false;
                buttonExpand.Text = ">>";
                _expanded = false;
                buttonPlayPause.Location = new Point(trackBarMusicPos.Width / 2 - buttonPlayPause.Width / 2, buttonPlayPause.Location.Y);
                buttonStop.Location = new Point(buttonPlayPause.Location.X - buttonStop.Width - 6, buttonStop.Location.Y);
                buttonRepeat.Location = new Point(buttonPlayPause.Location.X + buttonPlayPause.Width + 6, buttonStop.Location.Y);
            }
            else if (!(this.Size.Width < 600 || this.Size.Height < 500))
            {
                _expanded = !_expanded;
                sideBar.Visible = true;
                buttonExpand.Text = "<<";
                _expanded = true;
                buttonPlayPause.Location = new Point(trackBarMusicPos.Width / 2 - buttonPlayPause.Width / 2, buttonPlayPause.Location.Y);
                buttonStop.Location = new Point(buttonPlayPause.Location.X - buttonStop.Width - 6, buttonStop.Location.Y);
                buttonRepeat.Location = new Point(buttonPlayPause.Location.X + buttonPlayPause.Width + 6, buttonStop.Location.Y);
            }

        }

        private void buttonPlayPause_Click(object sender, EventArgs e)
        {
            PlayOrPause();
        }

        private void buttonPlayer_Click(object sender, EventArgs e)
        {

            equalizerWindow?.Close();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = CodecFactory.SupportedFilesFilterEn
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> deviceId;
                    fileName = openFileDialog.FileName;
                    string selectedDeviceName = comboBox1.SelectedItem.ToString();
                    if (devices.Item1.ContainsKey(selectedDeviceName))
                    {
                        deviceId = devices.Item1[selectedDeviceName];
                        if (deviceId.Count > 0)
                        {
                            // Set the default device to a new device based on its device ID 
                            var currentDevice = MusicPlayer.GetSoundDevice(deviceId.First());
                            _musicPlayer.Open(fileName, currentDevice); //открываем звуковую дорожку
                        }
                        labelNaming.Text = Path.GetFileName(fileName);
                        this.Text = "VibesAudio: " + Path.GetFileName(fileName);
                        try
                        {
                            TagLib.File file_TAG = TagLib.File.Create(fileName);
                            if (file_TAG.Tag.Pictures.Length >= 1)
                            {
                                var bin = (byte[])(file_TAG.Tag.Pictures[0].Data.Data);
                                Image image = Image.FromStream(new MemoryStream(bin));
                                panelCover.BackgroundImage = image;
                            }
                            else
                            {
                                panelCover.BackgroundImage = Properties.Resources.nocover;
                            }
                        }
                        catch (Exception ex) { MessageBox.Show("Возникла непредвиденная ошибка: " + ex.Message); }
                        if (!muted)
                            _musicPlayer.Volume = trackBarVolume.Value;
                        else
                            _musicPlayer.Volume = 0;
                        buttonPlayPause.BackgroundImage = Properties.Resources.pause;
                        buttonPlayPause.Enabled = true;
                        buttonStop.Enabled = true;
                        buttonPlayPause.BackgroundImage = Properties.Resources.pause;
                        buttonPlayPause.Enabled = true;
                        buttonStop.Enabled = true;
                        length = (int)_musicPlayer.Length.TotalSeconds;
                        _isPlaying = false;
                        PlayOrPause();
                        labelMaxPos.Text = length.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получается открыть файл: " + ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (trackBarMusicPos.Value == length && !repeat)
            {
                _isPlaying = false;
            }
            if (_isPlaying)
            {
                int position = (int)_musicPlayer.Position.TotalSeconds;
                int length = (int)_musicPlayer.Length.TotalSeconds;
                labelCurrentPos.Text = position.ToString();
                trackBarMusicPos.Maximum = length;
                trackBarMusicPos.Value = position;
                trackBarMusicPos.Enabled = true;
            }
            else
            {
                buttonPlayPause.BackgroundImage = Properties.Resources.play;
                trackBarMusicPos.Enabled = false;
            }
            if (trackBarMusicPos.Value == length && repeat)
            {
                _isPlaying = false;
                PlayOrPause();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _musicPlayer.Dispose();
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            if (muted)
            {
                _musicPlayer.Volume = lastVolume;
                buttonMute.BackgroundImage = Properties.Resources.mute;
                muted = false;
            }
            else
            {
                lastVolume = _musicPlayer.Volume;
                buttonMute.BackgroundImage = Properties.Resources.muteOn1;
                _musicPlayer.Volume = 0;
                muted = true;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _musicPlayer.Stop();
            _isPlaying = false;
            trackBarMusicPos.Value = 0;
            labelCurrentPos.Text = "0";
            buttonPlayPause.BackgroundImage = Properties.Resources.play;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            equalizerWindow?.Close();
            string[] fileData = (string[])e.Data.GetData(DataFormats.FileDrop); //Получаем информацию о файле при Drag & Drop
            try
            {
                List<string> deviceId;
                string selectedDeviceName = comboBox1.SelectedItem.ToString();
                if (devices.Item1.ContainsKey(selectedDeviceName))
                {
                    deviceId = devices.Item1[selectedDeviceName];
                    if (deviceId.Count > 0)
                    {
                        // Set the default device to a new device based on its device ID 
                        var currentDevice = MusicPlayer.GetSoundDevice(deviceId.First());
                        _musicPlayer.Open(fileData[0], currentDevice); //открываем звуковую дорожку
                    }
                }
                labelNaming.Text = Path.GetFileName(fileData[0]); //показ названия файла в главной панели
                this.Text = "VibesAudio: " + Path.GetFileName(fileData[0]);//показ названия файла в заголовке окна
                try
                {
                    TagLib.File file_TAG = TagLib.File.Create(fileData[0]);
                    if (file_TAG.Tag.Pictures.Length >= 1)
                    {
                        var bin = (byte[])(file_TAG.Tag.Pictures[0].Data.Data);
                        Image image = Image.FromStream(new MemoryStream(bin));
                        panelCover.BackgroundImage = image;
                    }
                    else
                    {
                        panelCover.BackgroundImage = Properties.Resources.nocover;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Возникла непредвиденная ошибка: " + ex.Message); }
                if (!muted)
                    _musicPlayer.Volume = trackBarVolume.Value;
                else
                    _musicPlayer.Volume = 0;
                buttonPlayPause.BackgroundImage = Properties.Resources.pause;
                buttonPlayPause.Enabled = true;
                buttonStop.Enabled = true;
                length = (int)_musicPlayer.Length.TotalSeconds;
                _isPlaying = false;
                PlayOrPause();
                labelMaxPos.Text = length.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open file: " + ex.Message);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void trackBarMusicPos_ValueChanged(object sender, EventArgs e)
        {
            if (stopUpdate)
            {
                //узнаем, на какой процент передвинулась каретка
                double perc = trackBarMusicPos.Value / (double)trackBarMusicPos.Maximum;
                //узнаем текущую позицию трека путем умножения процента на общую длительность трека
                TimeSpan position = TimeSpan.FromMilliseconds(_musicPlayer.Length.TotalMilliseconds * perc);
                _musicPlayer.Position = position;
            }
        }

        private void trackBarMusicPos_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                stopUpdate = false;
            _musicPlayer.Volume = trackBarVolume.Value;
        }

        private void trackBarMusicPos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                stopUpdate = true;
            _musicPlayer.Volume = 0;
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            muted = false;
            buttonMute.BackgroundImage = Properties.Resources.mute;
            labelVolume.Text = trackBarVolume.Value.ToString();
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            if (repeat)
                buttonRepeat.BackColor = Color.Transparent;
            else
                buttonRepeat.BackColor = Color.DarkGray;
            repeat = !repeat;
        }

        private void buttonEqualizer_Click(object sender, EventArgs e)
        {
            equalizerWindow = new EQ(_musicPlayer.GetEqualizer());
            equalizerWindow.Show();
        }
        private void comboBox1_Click(object sender, EventArgs e)
        {
            _musicPlayer.Volume = 0;
            _musicPlayer.Pause();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            deviceIndexChanged++;
            if (deviceIndexChanged > 2) // device index gets changed once before the form loads, so check for this.
            {
                List<string> deviceId;
                string selectedDeviceName = comboBox1.SelectedItem.ToString();

                if (devices.Item1.ContainsKey(selectedDeviceName))
                {
                    deviceId = devices.Item1[selectedDeviceName];

                    if (deviceId.Count > 0)
                    {
                        // Set the default device to a new device based on its device ID 
                        var newDefaultDevice = MusicPlayer.GetSoundDevice(deviceId.First());

                        // Get the current position 
                        TimeSpan currentPosition = _musicPlayer.Position;

                        _musicPlayer.Open(fileName, newDefaultDevice);
                        _musicPlayer.Position = currentPosition;
                        _musicPlayer.Volume = trackBarVolume.Value;
                        _musicPlayer.Play();
                        this.ActiveControl = null;
                    }
                }
                else
                {
                    MessageBox.Show("No device IDs found for selected device name.");
                }
            }
        }
    }
}
    

