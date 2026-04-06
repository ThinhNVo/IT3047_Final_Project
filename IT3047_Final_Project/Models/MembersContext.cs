using Microsoft.EntityFrameworkCore;

namespace IT3047_Final_Project.Models
{
    public class MembersContext : DbContext
    {
        public MembersContext(DbContextOptions<MembersContext> options) : base(options)
        {
        }
        public DbSet<Members> Members { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
    }
}
