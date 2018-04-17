﻿using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

namespace ACMG.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public StorageFile SongFile { get; set; }
        public bool Selected { get; set; }
        public bool Used { get; set; }

        public BitmapImage AlbumCover;
    }
}
