using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicket
{
    public class Movie
    {
        private int id;
        private string name;
        private string type;
        private List<Movie> _movies;

        public Movie()
        {
        }

        public Movie(List<Movie> movies)
        {
            _movies = movies;
        }

        public Movie createMovie(int id, string name, string type)
        {
            var movie = new Movie()
            {
                id = id,
                name = name,
                type = type
            };
            _movies.Add(movie);

            return movie;
        }

        public List<Movie> fetchMovies()
        {
            return _movies;
        }

        public Movie fetchMovie(int movieid)
        {
         
            return _movies.First(x => x.id == movieid);
        }
        
        public Ticket bookMovie(int userid, int movieid)
        {
            var movie = _movies.First(m => m.id == movieid);
            
            if (movie == null)
            {
                throw new Exception("Movie not found");
            }

            var ticket = new Ticket()
            {
                user_id = userid,
                movie_id = movieid,
                reference = Ticket.GenerateReference()
            };
            return ticket;
        }
        
    }
}