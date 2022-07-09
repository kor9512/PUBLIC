using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class Song
    {
        private string name;
        public Song NextSong { get; set; } 

        public Song(string name)
        {
            this.name = name;
        }

        public bool IsRepeatingPlaylist()
        {
            HashSet<Song> playList = new HashSet<Song>() { this };
            Song song = this.NextSong;
            //Song 클래스에 song이란 변수를 만들어서 
            // NPE가 발생하지 않고 NULL값을 처리할 수 있다.
            while (song != null)
            {
                if (playList.Contains(song))
                {
                    return true;
                }
                else
                {
                    playList.Add(song);
                    song = song.NextSong;
                }
            }
            return false;
        }
        /*
        public static void Main(string[] args)
        {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");
            Song thirth = new Song("Eye of the lion");
            //Song fourth = new Song("BEST");
            //Song fifth = new Song("BEST_TWO");
            
            //fourth.NextSong = fifth;
            first.NextSong = second;
            second.NextSong = thirth;
            thirth.NextSong = first;
            

            //Console.WriteLine(fifth.IsRepeatingPlaylist());
            //Console.WriteLine(fourth.IsRepeatingPlaylist());
            Console.WriteLine(first.IsRepeatingPlaylist());
            Console.WriteLine(second.IsRepeatingPlaylist());
            Console.WriteLine(thirth.IsRepeatingPlaylist());

        }
        */

    }
}
