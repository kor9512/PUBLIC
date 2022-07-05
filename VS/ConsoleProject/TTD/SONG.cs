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
            try { 
                  bool blrepeat = false;
                  //first에 저장된 name과 NextSong의 저장된 name이 동일하면?
           
                  if (System.Object.ReferenceEquals(this.NextSong.NextSong.name, name))
                 {
                   blrepeat = true;
                 }
            
                    return blrepeat;
            }
            catch (NullReferenceException e)
            {
                return false;
            }  
            //throw new InvalidOperationException("Waiting to be implemented.");
        }

        /*
        public static void Main(string[] args)
        {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");

            first.NextSong = second;
            first.NextSong = second;

            Console.WriteLine(first.IsRepeatingPlaylist());
            Console.WriteLine(second.IsRepeatingPlaylist());
        }
        */

    }
}
