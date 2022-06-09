using Ozkky.AdvertisementApp.Dtos.ProvidedServiceDtos;
using Ozkky.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozkky.AdvertisementApp.Business.Interfaces
{
    public interface IProvidedServiceService:IService<ProvidedServiceCreateDto,ProvidedServiceUpdateDto,ProvidedServiceListDto,ProvidedService>
    {
    }
}
