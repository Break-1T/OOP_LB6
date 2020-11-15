﻿using OOP_LB6_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace OOP_LB6_2.Classes
{
    public class MKV : IPlayable
    {
        public MKV(MainWindow main)
        {
            this.main = main;
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri(main.Player.Url, UriKind.RelativeOrAbsolute));
        }

        MainWindow main;
        MediaPlayer mediaPlayer;

        public void Pause()
        {
            mediaPlayer.Pause();
        }

        public void Play()
        {
            mediaPlayer.Play();
        }

        public void Stop()
        {
            mediaPlayer.Stop();
            mediaPlayer.Close();
        }
    }
}
