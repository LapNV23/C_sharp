using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    class ListMusic
    {
        public string Song { get; set; }
        public string Singer { get; set; }

        public ListMusic() { }
        public ListMusic(string song, string singer)
        {
            Song = song;
            Singer = singer;
        }

        public override string ToString()
        {
            return $"Song: {Song}, Singer: {Singer}";
        }
    }
}
