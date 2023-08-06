using CarShop.Domain.Entity;
using CarShop.Domain.Response;
using CarShop.Domain.ViewModel.Account;
using CarShop.Domain.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Service.Interfaces
{
    public interface IProfileService 
    {
        Task<BaseResponse<Profile>> Save(ProfileViewModel model);

        Task<BaseResponse<ProfileViewModel>> GetProfile(string id);


    }
}
