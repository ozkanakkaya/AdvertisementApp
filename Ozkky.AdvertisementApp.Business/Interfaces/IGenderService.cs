﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ozkky.AdvertisementApp.Dtos;
using Ozkky.AdvertisementApp.Entities;

namespace Ozkky.AdvertisementApp.Business.Interfaces
{
    public interface IGenderService : IService<GenderCreateDto,GenderUpdateDto,GenderListDto,Gender>
    {
    }
}
