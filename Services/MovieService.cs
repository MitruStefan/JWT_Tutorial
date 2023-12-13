using JWT_Tutorial.Models;
using JWT_Tutorial.Repositories;

namespace JWT_Tutorial.Services
{
    public class MovieService : IMovieService
    {
        public Movie Create(Movie movie)
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            MovieRepository.Movies.Add(movie);

            return movie;
        }

        public Movie Get(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(movie => movie.Id == id);

            if(movie is null) return null;

            return movie;
        }

        public List<Movie> List()
        {
            var movies = MovieRepository.Movies;

            return movies;
        }

        public Movie Update(Movie movie)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(movie => movie.Id == movie.Id);

            if(oldMovie is null) return null;

            oldMovie.Title = movie.Title;
            oldMovie.Description = movie.Description;
            oldMovie.Rating = movie.Rating;

            return movie;
        }

        public bool Delete(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(movie => movie.Id == id);

            if(movie is null) return false;

            MovieRepository.Movies.Remove(movie);

            return true;
        }
    }
}
