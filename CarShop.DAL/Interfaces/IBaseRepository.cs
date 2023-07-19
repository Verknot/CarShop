using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> Create(T entity);


        IQueryable<T> GetAllCars();

        Task<bool> Delete(T enity);

        Task<T> Update(T entity);

    }
}
