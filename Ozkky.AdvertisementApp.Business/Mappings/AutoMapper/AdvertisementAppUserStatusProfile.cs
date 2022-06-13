using AutoMapper;
using Ozkky.AdvertisementApp.Dtos;
using Ozkky.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozkky.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class AdvertisementAppUserStatusProfile : Profile
    {
        public AdvertisementAppUserStatusProfile()
        {
            CreateMap<AdvertisementAppUserStatus, AdvertisementAppUserStatusListDto>().ReverseMap();
        }
    }
}
