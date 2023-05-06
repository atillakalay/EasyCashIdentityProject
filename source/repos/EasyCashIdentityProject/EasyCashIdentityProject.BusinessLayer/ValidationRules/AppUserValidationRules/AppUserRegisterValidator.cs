using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDtos>
    {

        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.")
                .MaximumLength(50).WithMessage("Lütfen an fazla 50 karekter girişi yapınız.")
                .MinimumLength(10).WithMessage("Lütfen minimum 10 karekter girişi yapınız.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez.");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez.")
                .EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");

            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.")
                .Equal(x => x.Password).WithMessage("Parolalarınız eşleşmiyor.");
        }

    }
}
