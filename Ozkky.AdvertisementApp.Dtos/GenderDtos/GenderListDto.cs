﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ozkky.AdvertisementApp.Dtos.Interfaces;

namespace Ozkky.AdvertisementApp.Dtos
{
    public class GenderListDto : IDto
    {
        public int Id { get; set; }

        public string Definition { get; set; }
    }
}
