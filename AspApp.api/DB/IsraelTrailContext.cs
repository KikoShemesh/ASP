using AspApp.api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AspApp.api.DB
{
    public class IsraelTrailContext : DbContext
    {
        public IsraelTrailContext(DbContextOptions<IsraelTrailContext> options) : base(options)
        {

        }

        public DbSet<Segment> Segment { get; set; }  //Db set - create a segment table in the DB 
        public DbSet<Road> Roads { get; set; }  
        public DbSet<Difficulty> Difficalty { get; set; }  
    }
}
