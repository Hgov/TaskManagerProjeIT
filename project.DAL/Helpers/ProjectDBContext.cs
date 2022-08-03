using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Domain;

namespace Project.DAL.Helpers
{
    public class ProjectDBContext: DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
