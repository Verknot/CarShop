using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Repositories
{
    public class ProfileRepository : IBaseRepository<Profile>
    {
        private readonly ApplicationDbContext db;
        private readonly ApplicationDbContext _db;

        public ProfileRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public  async Task Create(Profile entity)
        {
          await  _db.Profiles.AddAsync(entity);
           await _db.SaveChangesAsync();
        }

        public async Task Delete(Profile enity)
        {
             _db.Profiles.Remove(enity);
           await _db.SaveChangesAsync();
        }

        public IQueryable<Profile> GetAll()
        {
            return _db.Profiles;
        }

        public async Task<Profile> Update(Profile entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
