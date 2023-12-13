using JWT_Tutorial.Models;

namespace JWT_Tutorial.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new() { Description = "A movie about a shark", Id = 1, Rating = 4.5, Title = "Jaws"
            },
            new() { Description = "A movie about a2 shark", Id = 2, Rating = 4.3, Title = "Jaws 2"
            },
            new() { Description = "A movie about a3 shark", Id = 3, Rating = 4.2, Title = "Jaws 3"
            },
            new() { Description = "A movie about a4 shark", Id = 4, Rating = 4.1, Title = "Jaws 4"
            },
            new() { Description = "A movie about a5 shark", Id = 5, Rating = 4.6, Title = "Jaws 5"
            },
        };
    }
}
