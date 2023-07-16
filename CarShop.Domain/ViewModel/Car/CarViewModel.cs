﻿using CarShop.Domain.Entity.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.ViewModel.Car
{
	public class CarViewModel
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descroptions { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public double Speed { get; set; }
        public DateTime DateCreate { get; set; }
        public string TypeCar { get; set; }

        public IFormFile Avatar { get; set; }
    }
}
