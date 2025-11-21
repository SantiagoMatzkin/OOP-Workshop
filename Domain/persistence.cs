namespace Persistence
{
    using Domain.Media;
    using Domain.Users;

    public static class FileHandler
    {
        public static void SaveMedia(List<Media> mediaList, string filename)
        {
            // Serializar a CSV/JSON
        }
        public static List<Media> LoadMedia(string filename)
        {
            // Deserializar de CSV/JSON
            return new List<Media>();
        }
    }
}
