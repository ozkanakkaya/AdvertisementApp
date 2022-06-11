using AutoMapper;
using Ozkky.AdvertisementApp.Dtos;
using Ozkky.AdvertisementApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozkky.AdvertisementApp.UI.Mappings.AutoMapper
{
    public class UserCreateModelProfile:Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>().ReverseMap();
        }
    }
}
