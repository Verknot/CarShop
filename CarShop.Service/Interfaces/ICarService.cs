using CarShop.Domain.Entity;
using CarShop.Domain.Response;
using CarShop.Domain.ViewModel.Car;
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

        Task<IBaseResponse<Car>> GetCarByName(string name);

        Task<IBaseResponse<bool>> DeleteCar(int id);

        Task<IBaseResponse<CarViewModel>> CreateCar(CarViewModel car);

        Task<IBaseResponse<Car>> Edit(int id, CarViewModel car);










    }
}
