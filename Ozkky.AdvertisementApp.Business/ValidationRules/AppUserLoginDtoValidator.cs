using FluentValidation;
using Ozkky.AdvertisementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozkky.AdvertisementApp.Business.ValidationRules
{
    public class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen kullanıcı adını giriniz.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Lütfen parolanızı giriniz.");
        }
    }
}
