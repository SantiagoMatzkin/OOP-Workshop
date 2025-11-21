namespace Domain.Users
{
    using System;
    using System.Collections.Generic;
    using Domain.Media;

    public abstract class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string CPR { get; set; }
    }

    public class Borrower : User
    {
        public List<Media> BorrowedItems { get; set; } = new();

        public void Borrow(Media media)
        {
            if (!media.IsBorrowed)
            {
                BorrowedItems.Add(media);
                media.IsBorrowed = true;
                Console.WriteLine($"Borrowed {media.Title}");
            }
            else
            {
                Console.WriteLine("The item is already borrowed.");
            }
        }

        public void Return(Media media)
        {
            if (BorrowedItems.Remove(media))
            {
                media.IsBorrowed = false;
                Console.WriteLine($"Returned {media.Title}");
            }
        }
    }

    public class Employee : User
    {
        public void AddMedia(List<Media> medias, Media item)
        {
            medias.Add(item);
            Console.WriteLine($"Added {item.Title}");
        }
        public void RemoveMedia(List<Media> medias, Media item)
        {
            medias.Remove(item);
            Console.WriteLine($"Removed {item.Title}");
        }
    }

    public class Admin : Employee
    {
        public void ManageUser(List<User> users, User user)
        {
            Console.WriteLine($"Managing user {user.Name}");
        }
    }
}
