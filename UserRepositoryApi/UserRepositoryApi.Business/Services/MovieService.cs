using System;
using System.Linq;
using System.Collections.Generic;
using UserRepositoryApi.Data;
using UserRepositoryApi.Core.Models;
using UserRepositoryApi.Business.Interfaces;

namespace UserRepositoryApi.Business.Services
{
    public class MovieService : IMovieService
    {
        private readonly UserRepositoryApiDbContext _db;

        public MovieService(UserRepositoryApiDbContext db) {
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
