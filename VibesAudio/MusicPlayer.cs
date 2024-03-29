﻿using CSCore;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;
using CSCore.Streams.Effects;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace VibesAudio
{
    public class MusicPlayer : Component
    {
        private ISoundOut _soundOut;
        private IWaveSource _waveSource;
        private Equalizer _equalizer;

        public event EventHandler<PlaybackStoppedEventArgs> PlaybackStopped;
        public PlaybackState PlaybackState
        {
            get
            {
                if (_soundOut != null)
                    return _soundOut.PlaybackState;
                return PlaybackState.Stopped;
            }
        }
        public IEnumerable<MMDevice> EnumerateWasapiDevices()
        {
            using (MMDeviceEnumerator enumerator = new MMDeviceEnumerator())
            {
                return enumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active);
            }
        }
        public static MMDevice GetDefaultSoundDevice()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                return enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            }
        }
        public static MMDevice GetSoundDevice(string id)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                return enumerator.GetDevice(id);
            }
        }
        public ISoundOut getSoundOut()
        {
            return _soundOut;
        }
        public TimeSpan Position
        {
            get
            {
                if (_waveSource != null)
                    return _waveSource.GetPosition();
                return TimeSpan.Zero;
            }
            set
            {
                _waveSource?.SetPosition(value);
            }
        }

        public TimeSpan Length
        {
            get
            {
                if (_waveSource != null)
                    return _waveSource.GetLength();
                return TimeSpan.Zero;
            }
        }

        public int Volume
        {
            get
            {
                if (_soundOut != null)
                    return Math.Min(100, Math.Max((int)(_soundOut.Volume * 100), 0));
                return 100;
            }
            set
            {
                if (_soundOut != null)
                {
                    _soundOut.Volume = Math.Min(1.0f, Math.Max(value / 100f, 0f));
                }
            }
        }

        public void Open(string filename, MMDevice device)
        {
            CleanupPlayback();

            _waveSource =
                CodecFactory.Instance.GetCodec(filename)
                    .ToSampleSource()
                    .ToStereo()
                    .ChangeSampleRate(48000)
                    .AppendSource(Equalizer.Create10BandEqualizer, out _equalizer)
                    .ToWaveSource();
            _soundOut = new WasapiOut() { Latency = 100, Device = device };
            _soundOut.Initialize(_waveSource);
            if (PlaybackStopped != null) _soundOut.Stopped += PlaybackStopped;
        }

        public void Play()
        {
            _soundOut?.Play();
        }
        public Equalizer GetEqualizer()
        {
            return _equalizer;
        }
        public void Pause()
        {
            _soundOut?.Pause();
        }

        public void Stop()
        {
            if (_soundOut != null)
            {
                _soundOut.Stop();
                _waveSource.SetPosition(TimeSpan.Zero);
            }

        }

        private void CleanupPlayback()
        {
            if (_soundOut != null)
            {
                _soundOut.Dispose();
                _soundOut = null;
            }
            if (_waveSource != null)
            {
                _waveSource.Dispose();
                _waveSource = null;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _equalizer?.Dispose();
            CleanupPlayback();
        }
    }
}
