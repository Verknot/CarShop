using CarShop.Domain.Entity.Enum;
using System;
using System.Collections.Generic;

#nullable disable

namespace CarShop.Domain.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descroptions { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public double Speed { get; set; }
        public DateTime DateCreate { get; set; }
        public TypeCar TypeCar { get; set; }
    }
}
