namespace Domain.Media
{
    using Domain.Interfaces;

    public abstract class Media : IDownloadable, IRatable
    {
        public string Title { get; set; }
        public bool IsBorrowed { get; set; }
        public int? Rating { get; set; }

        public virtual void Download()
        {
            Console.WriteLine($"Downloading {Title}");
        }

        public virtual void Rate(int rating)
        {
            Rating = rating;
            Console.WriteLine($"Rated {Title} as {rating}");
        }
    }

    public class Ebook : Media
    {
        public string Author { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
    }

    public class Movie : Media
    {
        public string Director { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }
        public int Duration { get; set; } // minutos
    }

    public class Song : Media
    {
        public string Composer { get; set; }
        public string Singer { get; set; }
        public string Genre { get; set; }
        public string FileType { get; set; }
        public int Duration { get; set; } // segundos
        public string Language { get; set; }
    }

    public class Videogame : Media
    {
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Platform { get; set; }
    }

    public class App : Media
    {
        public string Version { get; set; }
        public string Publisher { get; set; }
        public string Platform { get; set; }
        public double FileSize { get; set; } // MB
    }

    public class Podcast : Media
    {
        public int Year { get; set; }
        public string Hosts { get; set; }
        public string Guests { get; set; }
        public int EpisodeNumber { get; set; }
        public string Language { get; set; }
    }

    public class Image : Media
    {
        public string Resolution { get; set; }
        public string FileFormat { get; set; }
        public double FileSize { get; set; } // MB
        public DateTime DateTaken { get; set; }
    }
}

