using System;
using System.Linq;
using System.Collections.Generic;
using PROJECTNAME.Data;
using PROJECTNAME.Core.Models;

namespace PROJECTNAME.Business
{
    public class MovieService : IMovieService
    {
        private readonly PROJECTNAMEDbContext _db;

        public MovieService(PROJECTNAMEDbContext db) {
            _db = db;
        }

        public List<Movie> GetAll() {
            return _db.Movies.ToList();
        }

        public Movie Get(int Id) {
            return _db.Movies.Find(Id);
        }

        public Movie Get(string Name) {
            return _db.Movies.FirstOrDefault(movie => movie.Name == Name);
        }

        public void Add(Movie movie) {
            _db.Add(movie);
            _db.SaveChanges();
        }

        public void Delete(int Id) {
            var movieToDelete = _db.Movies.Find(Id);

            if (movieToDelete != null) {
                _db.Remove(movieToDelete);
            }
            throw new InvalidOperationException("no movies exists");
        }
    }
}
