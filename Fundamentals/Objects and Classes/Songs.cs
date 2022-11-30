using System;
using System.Collections.Generic;
using System.Data;

namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
                
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split('_', StringSplitOptions.RemoveEmptyEntries);

                string typeList = cmdArgs[0];
                string name = cmdArgs[1];
                string time = cmdArgs[2];

                Song song = new Song(typeList, name, time);

                songs.Add(song);
            }

            string command = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                Song currSong = songs[i];

                if (command == "all")
                {
                    Console.WriteLine(currSong.Name);
                }
                else if (command == currSong.TypeList)
                {
                    Console.WriteLine(currSong.Name);
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
