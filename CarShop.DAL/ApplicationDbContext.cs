using CarShop.Domain.Entity;
using CarShop.Domain.Enum;
using CarShop.Domain.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Car> Car { get; set; }
        public DbSet<User> User { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
            
        }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                builder.HasData(new User{
                    Id = 1,
                    Name = "Alex",
                    Password = HashPasswordHelper.HashPassowrd("12345678"),
                    Role = Role.Admin


                });

                builder.ToTable("Users").HasKey(x => x.Id);

                builder.Property(x => x.Id).ValueGeneratedOnAdd();

                builder.Property(x => x.Name).HasMaxLength(64).IsRequired();
                builder.Property(x => x.Password).IsRequired();
            }
            
            );


        }


    }
}
