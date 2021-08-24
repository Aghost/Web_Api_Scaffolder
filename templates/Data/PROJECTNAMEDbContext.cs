using PROJECTNAME.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace PROJECTNAME.Data {
    public class PROJECTNAMEDbContext : DbContext {
        public PROJECTNAMEDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<ITEM> ITEMs { get; set; }
        public virtual DbSet<CHILDITEM> CHILDITEMs { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }
}
