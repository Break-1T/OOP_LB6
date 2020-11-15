using OOP_LB6_2.Classes;
using OOP_LB6_2.DialogBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_LB6_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public PlayerItem Player { get; set; }

        private void MenuItem_Open_OnClick(object sender, RoutedEventArgs e)
        {
            FileSelectionWindow fileSelection = new FileSelectionWindow(this) { Owner = this };
            fileSelection.Show();
        }

        private void MenuItem_Close_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            switch (Player.Type)
            {
                case ".mp3":
                    {
                        MP3 mp3 = new MP3(this);
                        mp3.Play();
                    }
                    break;
                case ".wav":
                    {
                        WAV wav = new WAV(this);
                        wav.Play();
                    }
                    break;
                case ".mkv":
                    break;
            }
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Record_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
