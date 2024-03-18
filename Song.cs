using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    internal class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }

        public Song(string title, string artist, TimeSpan duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }
    }

    class Playlist
    {
        private List<Song> songs = new List<Song>();

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void RemoveSong(string title)
        {
            Song songToRemove = songs.FirstOrDefault(s => s.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (songToRemove != null)
            {
                songs.Remove(songToRemove);
                Console.WriteLine($"Song '{title}' removed from the playlist.");
            }
            else
            {
                Console.WriteLine($"Song '{title}' not found in the playlist.");
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            songs = songs.OrderBy(x => rand.Next()).ToList();
        }

        public void SortByTitle()
        {
            songs = songs.OrderBy(x => x.Title).ToList();
        }

        public void Play()
        {
            foreach (var song in songs)
            {
                Console.WriteLine($"Playing: {song.Title} - {song.Artist} [{song.Duration}]");
            }
        }

        public void SortByArtist()
        {
            songs = songs.OrderBy(x => x.Artist) .ToList();
        }

    }

}
