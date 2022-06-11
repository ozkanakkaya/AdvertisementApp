using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ozkky.AdvertisementApp.UI.Models;

namespace Ozkky.AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        //[Obsolete]
        public UserCreateModelValidator()
        {
            //CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola alanı boş olamaz");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Parola min 3 karakter olmalıdır");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Parolalar eşleşmiyor");
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Ad alanı boş olamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş olamaz");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Kullanıcı min 3 karakter olmalıdır");
            RuleFor(x => new
            {
                x.Username,
                x.Firstname
            }).Must(x => CanNotFirstname(x.Username, x.Firstname)).WithMessage("kullanıcı adı, adınızı içeremez.").When(x => x.Username != null && x.Firstname != null);

            RuleFor(x => x.GenderId).NotEmpty().WithMessage("Cinsiyet seçimi zorunludur.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir e-posta adresi girilmelidir");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-posta alanı boş olamaz");

        }

        private bool CanNotFirstname(string username, string firstname)
        {
            return !username.Contains(firstname);
        }
    }
}
