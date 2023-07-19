using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Repositories
{
    public class CarRepository : IBaseRepository<Car>
    {
        private readonly ApplicationDbContext db;

        public CarRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<bool> Create(Car entity)
        {
            await db.Car.AddAsync(entity);
            await db.SaveChangesAsync();



            return true;
        }

        public async Task<bool> Delete(Car enity)
        {

            db.Car.Remove(enity);
            await db.SaveChangesAsync();

            return true;
        }

        public IQueryable<Car> GetAllCars()
        {
            return db.Car;
        }


        public Task<List<Car>> Select()
        {
            return db.Car.ToListAsync();
        }

        public async Task<Car> Update(Car entity)
        {
            db.Update(entity);
            await db.SaveChangesAsync();

            return entity;
        }
    }
}
