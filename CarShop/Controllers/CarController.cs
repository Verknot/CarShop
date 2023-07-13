using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using CarShop.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var responce = await _carService.GetCars();
            return View(responce.Data);
        } 
        
        [HttpGet]
        public async Task<IActionResult> GetCarById(int id)
        {
            var responce = await _carService.GetCarById(id);
            return View(responce.Data);
        }




    }
}
