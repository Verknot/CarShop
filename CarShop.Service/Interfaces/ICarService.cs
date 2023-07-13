using CarShop.Domain.Entity;
using CarShop.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Service.Interfaces
{
	public interface ICarService
	{
        Task<IBaseResponse<IEnumerable<Car>>> GetCars();

        Task<IBaseResponse<Car>> GetCarById(int id);







       
    }
}
