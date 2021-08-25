using UserRepositoryApi.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace UserRepositoryApi.Data {
    public class UserRepositoryApiDbContext : DbContext {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserFile> UserFiles { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }

        public UserRepositoryApiDbContext(DbContextOptions options) : base(options) { }
    }
}
