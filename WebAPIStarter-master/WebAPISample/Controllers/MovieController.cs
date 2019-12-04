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

        List<Movie> movies = new List<Movie>();
        public MovieController()
        {
           movies = context.Movies.ToList();
        }
        // GET api/values
        
     
        public IEnumerable<Movie> Get()
        {
            //var movies = context.Movies.ToArray();
            // Retrieve all movies from db logic
            
            return movies;
        }

        // GET api/values/5
        public Movie Get(int id)
        {
            //string movie = context.Movies.Where(m => m.MovieId == id).Single().ToString();
            // Retrieve movie by id from db logic
            return movies[id];
        }

        // POST api/values
        public void Post([FromBody]Movie movie)
        {
            movies.Add(movie);
            // Create movie in db logic
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Movie movie)
        {

            movies[id] = movie;
            // Update movie in db logic
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            movies.RemoveAt(id);
            // Delete movie from db logic
        }
    }

}