using System.Collections.Generic;
using UserRepositoryApi.Core.Models;

namespace UserRepositoryApi.Business.Interfaces {
    public interface IMovieService {
        public List<Movie> GetAll();
        public Movie Get(int Id);
        public Movie Get(string Name);
        public void Add(Movie movie);
        public void Delete(int Id);
    }
}
