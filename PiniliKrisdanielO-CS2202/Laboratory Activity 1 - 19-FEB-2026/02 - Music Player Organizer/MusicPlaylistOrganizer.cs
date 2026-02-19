using System;

namespace MusicPlaylistOrganizer
{
    class Song
    {
        private string title;
        private string artist;
        private double duration; 

        public Song()
        {
            title = "Unknown";
            artist = "Unknown";
            duration = 0.0;
        }

        public Song(string t, string a, double d)
        {
            title = string.IsNullOrWhiteSpace(t) ? "Unknown" : t;
            artist = string.IsNullOrWhiteSpace(a) ? "Unknown" : a;
            duration = d;
        }

        public void DisplaySong()
        {
            Console.WriteLine("{0,-20}  {1,-20}  {2,7:0.00}", title, artist, duration);
        }

        public double GetDuration()
        {
            return duration;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Songs to add: ");
            int n = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine();

            Song[] playlist = new Song[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Song #{0}", i + 1);

                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Artist: ");
                string artist = Console.ReadLine();

                Console.Write("Duration (minutes): ");
                string durInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(title) &&
                    string.IsNullOrWhiteSpace(artist) &&
                    string.IsNullOrWhiteSpace(durInput))
                {
                    playlist[i] = new Song();
                }
                else
                {
                    durInput = (durInput ?? "").Replace(',', '.');

                    double duration;
                    if (!double.TryParse(durInput, out duration))
                        duration = 0.0;

                    playlist[i] = new Song(title, artist, duration);
                }

                Console.WriteLine();
            }

            Console.WriteLine("=== || MY PLAYLIST || ===");
            Console.WriteLine("{0,-20}  {1,-20}  {2,7}", "Title", "Artist", "Time");
            Console.WriteLine(new string('-', 57));

            double total = 0.0;
            for (int i = 0; i < playlist.Length; i++)
            {
                playlist[i].DisplaySong();
                total += playlist[i].GetDuration();
            }

            double avg = (n == 0) ? 0.0 : total / n;

            Console.WriteLine();
            Console.WriteLine("Total Duration: {0:0.00} mins", total);
            Console.WriteLine("Average Duration: {0:0.00} mins", avg);
        }
    }
}
