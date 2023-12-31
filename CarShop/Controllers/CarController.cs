﻿using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using CarShop.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShop.Domain.Entity.Enum;
using Microsoft.AspNetCore.Authorization;
using CarShop.Domain.ViewModel.Car;
using System.IO;
using Microsoft.VisualBasic;

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
            var responce =  _carService.GetCars();
            if (responce.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return  View(responce.Data);
            }

            return RedirectToAction("Error");
        } 
        
        [HttpGet]
        public async Task<IActionResult> GetCarById(int id)
        {
            var responce = await _carService.GetCar(id);
            if (responce.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(responce.Data);
            }

            return RedirectToAction("Error");
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {

            var responce = await _carService.DeleteCar(id);
            if(responce.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("GetCars");
            }

            return RedirectToAction("Error");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Save(int id)
        {
            if  (id == 0)
            {
                return View();
            }
             
            var responce = await _carService.GetCar(id);
            
            if (responce.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(responce.Data);
            }

            return RedirectToAction("Error");
        }

        [HttpPost]
        public async Task<IActionResult> Save(CarViewModel model, byte[] image)
        {
            if (ModelState.IsValid)
            {
                if(model.Id == 0)
                {
                    byte[] imageData;
                    using (var binaryReader = new BinaryReader(model.Avatar.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)model.Avatar.Length);
                    }

                     
                    await _carService.Create(model, image);
                }
                else
                {
                    await _carService.Edit(model.Id, model);
                }
            }


            return RedirectToAction("GetCars");
        }


        public async Task<IActionResult> Get(int id)
        {
            var responce = await _carService.GetCar(id);
            return View(responce.Data);
        }


        [HttpPost]
        public JsonResult GetTypes()
        {
            var types = _carService.GetTypes();
            return Json(types.Data);
        }
    }
}
