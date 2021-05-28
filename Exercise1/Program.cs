using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            // 2.1.3
            var songs = new Song[] {
                new Song("Let it be","The Beatles",243),
                new Song("Bones","Galantis",206),
                new Song("Body to Body","MikePerry",180)

            };
            PrintSongs(songs);
        
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach(var song in songs) {
                Console.WriteLine("{0},{1},{2:m\\:ss}",song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
