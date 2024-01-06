using lab1.Configuation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace lab1.Models.Context
{
    public class MyContext : DbContext
    {
        

        public MyContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Lab2_c5;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new ClientConfiguation());

           
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
