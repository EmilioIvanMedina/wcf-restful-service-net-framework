using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfRestfulService.DataContracts;

namespace WcfRestfulService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MovieSelector" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MovieSelector.svc or MovieSelector.svc.cs at the Solution Explorer and start debugging.
    public class MovieSelector : IMovieSelector
    {
        public Movie SelectMovie()
        {
            var movies = PopulateMovies();
            var pos = GetMovieValue();
            return movies.ToList()[pos];
        }

        private int GetMovieValue()
        {
            var random = new Random();   
            return random.Next(0, 4);
        }

        private IEnumerable<Movie> PopulateMovies()
        {
            var movies = new List<Movie>();

            movies.Add(new Movie { Description = "Documentary about War War II", Genre = "Documentary", Title = "World War II", Year = 2023});
            movies.Add(new Movie { Description = "Documentary about War War II", Genre = "Documentary", Title = "The Last days", Year = 1999});
            movies.Add(new Movie { Description = "Documentary about War War II", Genre = "Documentary", Title = "Five Came Back", Year = 2017});

            movies.Add(new Movie { Description = "Travel to space, appears non friendly aliens life form", Genre = "Action", Title = "Aliens", Year = 1986 });
            movies.Add(new Movie { Description = "The Joker traps Batman and Harvey Dent", Genre = "Action", Title = "The Dark Knight", Year = 2008 });

            return movies;
        }
    }
}
