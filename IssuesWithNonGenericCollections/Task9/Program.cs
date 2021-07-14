using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  *****\n");
            UseListMusicCollection();
            Console.WriteLine();
            /*UseGenericList();*/

            Console.ReadLine();
        }

        static void UseListMusicCollection()
        {
            Console.WriteLine("***** Custom List Music Collection *****\n");
            ListMusicCollection listMusic = new ListMusicCollection();
            listMusic.AddListMusic(new ListMusic("What Lovers Do", "Maroon 5"));
            listMusic.AddListMusic(new ListMusic("Cradles", "Sub Urban"));
            listMusic.AddListMusic(new ListMusic("Attention", "Charlie Puth"));
            listMusic.AddListMusic(new ListMusic("Once Upon A Time", "Max Oazo ft. Moonessa"));


            foreach (ListMusic p in listMusic)
                Console.WriteLine(p);
        }
    }
}
