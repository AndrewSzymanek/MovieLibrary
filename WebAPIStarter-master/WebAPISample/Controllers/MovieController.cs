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

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            // Retrieve all movies from db logic 
            List<Movie> movies = context.Movies.ToList();
            return movies;
        }

        //GET api/values/5

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            // Retrieve movie by id from db logic
            Movie specificMovie = context.Movies.Where(m => m.MovieId == id).FirstOrDefault();         
            return Ok(specificMovie);
        }

        // POST api/values
        public void Post([FromBody]Movie movie)
        {
            context.Movies.Add(movie);
            context.SaveChanges();
            // Create movie in db logic
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Movie movie)
        {
            Movie movieToChange = context.Movies.Where(m => m.MovieId == id).SingleOrDefault();
            movieToChange = movie;
            context.SaveChanges();
            // Update movie in db logic
        }
    }
}