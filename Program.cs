using MusicPlayerApp;

class Program
{
    static void Main(string[] args)
    {
        Playlist playlist = new Playlist();

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add Song");
            Console.WriteLine("2. Remove Song");
            Console.WriteLine("3. Shuffle Playlist");
            Console.WriteLine("4. Sort Playlist by Title");
            Console.WriteLine("5. Sort Playlist by Artist");
            Console.WriteLine("6. Play Playlist");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter song title:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter artist:");
                    string artist = Console.ReadLine();
                    Console.WriteLine("Enter duration (hh:mm:ss):");
                    TimeSpan duration = TimeSpan.Parse(Console.ReadLine());
                    playlist.AddSong(new Song(title, artist, duration));
                    break;
                case "2":
                    Console.WriteLine("Enter song title to remove:");
                    string titleToRemove = Console.ReadLine();
                    playlist.RemoveSong(titleToRemove);
                    break;
                case "3":
                    playlist.Shuffle();
                    Console.WriteLine("Playlist shuffled.");
                    break;
                case "4":
                    playlist.SortByTitle();
                    Console.WriteLine("Playlist sorted by title.");
                    break;
                case "5":
                    playlist.SortByTitle();
                    Console.WriteLine("Playlist sorted by Artist.");
                    break;
                case "6":
                    Console.WriteLine("Playing playlist:");
                    playlist.Play();
                    break;
                case "7":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
