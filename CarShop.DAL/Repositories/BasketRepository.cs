using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Repositories
{
    public class BasketRepository : IBaseRepository<Basket>
    {
        private readonly ApplicationDbContext _db;

        public BasketRepository(ApplicationDbContext db)
        {
            _db = db;   
        }

        public async Task Create(Basket entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Basket enity)
        {
            _db.Remove(enity);
            await _db.SaveChangesAsync();

        }

        public IQueryable<Basket> GetAll()
        {
            return _db.Baskets;
        }

        public async Task<Basket> Update(Basket entity)
        {
             _db.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
