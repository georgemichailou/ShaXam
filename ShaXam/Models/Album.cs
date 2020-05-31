using System;
using System.Collections.Generic;

namespace ShaXam.Models
{
    public class Album
    {
        public string songImg { get; set; }

        public string singerName { get; set; }

        public string songTitle { get; set; }
    }

    public class Chart
    {
        public string chartName { get; set; }

        public List<Album> chartAlbums { get; set; }
    }
}
