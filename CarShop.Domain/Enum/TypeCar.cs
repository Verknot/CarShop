using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarShop.Domain.Entity.Enum
{
    public enum TypeCar
    {
        [Display(Name = "Легковой Автомобиль")]
        PassengerCar = 0,
        [Display(Name = "Седан")]
        Sedan = 1,
        [Display(Name = "Хэтчбек")]
        HatchBack = 2,
        [Display(Name = "Минивен")]
        Minivan = 3,
        [Display(Name = "Спортивная машина")]
        SportCar = 4,
        [Display(Name = "Внедорожник")]
        Suv = 5,
    }
}
