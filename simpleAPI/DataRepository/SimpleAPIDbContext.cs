using Microsoft.EntityFrameworkCore;
using simpleAPI.Models;

namespace simpleAPI.DataRepository
{
    public class SimpleAPIDbContext : DbContext
    {
        public SimpleAPIDbContext(DbContextOptions<SimpleAPIDbContext> opts)
        :base(opts)
        {        
            //Nothing in this Ctor
        }

        public DbSet<SimpleAPI> MyData{get;set;}
    }
}