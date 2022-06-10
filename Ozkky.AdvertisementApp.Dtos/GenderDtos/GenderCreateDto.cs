using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ozkky.AdvertisementApp.Dtos.Interfaces;

namespace Ozkky.AdvertisementApp.Dtos
{
    public class GenderCreateDto : IDto
    {
        public string Definition { get; set; }
    }
}
