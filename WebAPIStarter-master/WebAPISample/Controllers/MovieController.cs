using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    public class MovieController : ApiController
    {
        public ApplicationDbContext context = new ApplicationDbContext();

        // GET api/movie
        
     
        public IEnumerable<Movie> Get()
        {
            // Retrieve all movies from db logic 
            List<Movie> movies = context.Movies.ToList();          
                   
            return movies;
        }

        // GET api/values/5
        public Movie Get(int movieId)
        {
            Movie specificMovie = context.Movies.Where(m => m.MovieId == movieId).FirstOrDefault();
            // Retrieve movie by id from db logic
            return specificMovie;
        }

        // POST api/values
        public void Post([FromBody]Movie movie)
        {
            List<Movie> movies = context.Movies.ToList();
            movies.Add(movie);
            // Create movie in db logic
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Movie movie)
        {
            List<Movie> movies = context.Movies.ToList();
            movies[id] = movie;
            // Update movie in db logic
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            List<Movie> movies = context.Movies.ToList();
            movies.RemoveAt(id);
            // Delete movie from db logic
        }
    }

}