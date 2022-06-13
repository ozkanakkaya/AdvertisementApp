using Ozkky.AdvertisementApp.Common;
using Ozkky.AdvertisementApp.Common.Enums;
using Ozkky.AdvertisementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozkky.AdvertisementApp.Business.Interfaces
{
    public interface IAdvertisementAppUserService
    {
        Task<IResponse<AdvertisementAppUserCreateDto>> CreateAsync(AdvertisementAppUserCreateDto dto);

        Task<List<AdvertisementAppUserListDto>> GetList(AdvertisementAppUserStatusType type);
    }
}
