namespace Domain
{
    using System.Collections.Generic; // necesario para List<T>
    using Domain.Media;               // importa los tipos Media

    using Domain.Users;

    public class Library
    {
        public List<Media> MediaItems { get; set; } = new();
        public List<User> Users { get; set; } = new();

        public void AddUser(User user) => Users.Add(user);
        public void AddMedia(Media media) => MediaItems.Add(media);
    }
}


