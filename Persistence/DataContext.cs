
using Microsoft.EntityFrameworkCore;
using Domain;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
         
        }
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Value>()
            .HasData(
                new Value {Id =1, Values = "Som"},
                new Value {Id =2, Values = "Vidu"},
                new Value {Id =3, Values = "Sapna"}
            );
        }

    }
}
