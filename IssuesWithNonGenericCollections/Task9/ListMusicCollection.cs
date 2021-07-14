using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task9
{
    class ListMusicCollection : IEnumerable
    {
        private ArrayList arListMusic = new ArrayList();

        // Cast for caller.
        public ListMusic GetListMusic(int pos) => (ListMusic)arListMusic[pos];

        // Only insert Person types.
        public void AddListMusic(ListMusic p)
        { arListMusic.Add(p); }

        public void ClearListMusic()
        {
            arListMusic.Clear();
        }
        public int Count => arListMusic.Count;

        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator() => arListMusic.GetEnumerator();
    }
}
