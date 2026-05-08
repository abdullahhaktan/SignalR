using FluentValidation;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.ValidationRules.BookingValidations
{
    public class CreateMessageValidation : AbstractValidator<CreateMessageDto>
    {
        public CreateMessageValidation()
        {
            RuleFor(x => x.NameSurname)
                .NotEmpty().WithMessage("Ad soyad alanı boş geçilemez.")
                .MinimumLength(3).WithMessage("Ad soyad en az 3 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Ad soyad en fazla 50 karakter olabilir.");

            RuleFor(x => x.Mail)
                .NotEmpty().WithMessage("Mail alanı boş geçilemez.")
                .EmailAddress().WithMessage("Geçerli bir mail adresi giriniz.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Telefon alanı boş geçilemez.")
                .MinimumLength(10).WithMessage("Telefon numarası eksik.")
                .MaximumLength(15).WithMessage("Telefon numarası çok uzun.");

            RuleFor(x => x.Subject)
                .NotEmpty().WithMessage("Konu alanı boş geçilemez.")
                .MinimumLength(3).WithMessage("Konu en az 3 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Konu en fazla 100 karakter olabilir.");

            RuleFor(x => x.MessageContent)
                .NotEmpty().WithMessage("Mesaj alanı boş geçilemez.")
                .MinimumLength(10).WithMessage("Mesaj en az 10 karakter olmalıdır.")
                .MaximumLength(500).WithMessage("Mesaj en fazla 500 karakter olabilir.");
        }
    }
}
