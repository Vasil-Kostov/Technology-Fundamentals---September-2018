namespace _04._Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> playList = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songData = Console.ReadLine()
                                    .Split('_');

                playList.Add(new Song(songData));

            }

            string typeToPrint = Console.ReadLine();

            PrintPlsylist(playList, typeToPrint);

        }

        private static void PrintPlsylist(List<Song> playList, string typeToPrint)
        {
            if (typeToPrint != "all")
            {
                foreach (var song in playList.Where(s => s.Type == typeToPrint))
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in playList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    class Song
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string[] songData)
        {
            string type = songData[0];
            string name = songData[1];
            string time = songData[2];

            this.Type = type;
            this.Name = name;
            this.Time = time;
        }
    }
}
