using CarShop.Domain.Entity;
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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          //  Database.EnsureDeleted();
           // Database.EnsureCreated();
            
        }

       



    }
}
