using CSCore.Streams.Effects;
using System;
using System.Windows.Forms;

namespace VibesAudio
{
    public partial class EQ : Form
    {
        private Equalizer _equalizer;
        public EQ(Equalizer equalizer)
        {
            InitializeComponent();
            _equalizer = equalizer;
        }

        private void EQ_Load(object sender, EventArgs e)
        {
            EqualizerFilter filter;
            //Для каждого элемента в панели проводим проверку
            foreach (Control contr in panel1.Controls)
            {
                if (contr is TrackBar && _equalizer != null) //Если эквалайзер не пуст, т.е. хотя бы 1 трек запускался и контрол это tracKbar
                {
                    var trackBar = contr as TrackBar; //считаем, что контрол это trackBar
                    filter = _equalizer.SampleFilters[Int32.Parse((string)trackBar.Tag)]; //получаем значения фильтра эквалайзера по тегу трекбара
                    trackBar.Value = (int)filter.AverageGainDB; //получаем значение децибел, которое было прибавлено в конкретный фильтр
                }
                if (contr is Label && contr.Tag != null) //если контрол это текст и у контрола был таг (каждый нужный label подвязан к trackBar через tag)
                {
                    foreach (Control contr1 in panel1.Controls)//ищем трекбар с таким же тегом
                    {
                        if (contr1 is TrackBar)
                        {
                            var trackbar = contr1 as TrackBar;
                            if (trackbar.Tag == contr.Tag)
                            {
                                contr.Text = trackbar.Value.ToString() + " dB";//записываем значение с трекбара в label
                            }
                        }
                    }
                }
            }
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            if (_equalizer != null && trackbar != null)
            {
                //double perc = (trackbar.Value / (double)trackbar.Maximum);
                var value = (float)(trackbar.Value);

                //the tag of the trackbar contains the index of the filter
                int filterIndex = int.Parse((string)trackbar.Tag);
                EqualizerFilter filter = _equalizer.SampleFilters[filterIndex];
                filter.AverageGainDB = value;
            }
            foreach (Control contr in panel1.Controls)
            {
                if (contr is Label)
                {
                    if (contr.Tag == trackbar.Tag)
                    {
                        contr.Text = trackbar.Value.ToString() + " dB";
                    }
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control contr in panel1.Controls)
            {
                if (contr is TrackBar) //Если эквалайзер не пуст, т.е. хотя бы 1 трек запускался и контрол это tracKbar
                {
                    var trackBar = contr as TrackBar; //считаем, что контрол это trackBar
                    trackBar.Value = 0; //получаем значение децибел, которое было прибавлено в конкретный фильтр
                }
                if (contr is Label && contr.Tag != null) //если контрол это текст и у контрола был таг (каждый нужный label подвязан к trackBar через tag)
                {
                    foreach (Control contr1 in panel1.Controls)//ищем трекбар с таким же тегом
                    {
                        if (contr1 is TrackBar)
                        {
                            var trackbar = contr1 as TrackBar;
                            if (trackbar.Tag == contr.Tag)
                            {
                                contr.Text = trackbar.Value.ToString() + " dB";//записываем значение с трекбара в label
                            }
                        }
                    }
                }
            }
        }
    }
}
