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
        //BaseResponse<Dictionary<int, string>> GetTypes();

        IBaseResponse<List<Car>> GetCars();

        Task<IBaseResponse<CarViewModel>> GetCar(long id);

        Task<BaseResponse<Dictionary<long, string>>> GetCar(string term);

        Task<IBaseResponse<Car>> Create(CarViewModel car, byte[] imageData);

        Task<IBaseResponse<bool>> DeleteCar(long id);

        Task<IBaseResponse<Car>> Edit(long id, CarViewModel model);

        public BaseResponse<Dictionary<int, string>> GetTypes();










    }
}
