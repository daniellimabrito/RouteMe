using Microsoft.EntityFrameworkCore;
using RouteMe.API.Models;

namespace RouteMe.API.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users {get;set;}
        public DbSet<Photo> Photos {get; set;}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}