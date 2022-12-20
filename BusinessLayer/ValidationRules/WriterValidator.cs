using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules67
{
  public  class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Minimum 2 karakter giriniz");
            RuleFor(x => x.WriterName).MaximumLength(40).WithMessage("Maxsimum 50 karakter giriniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.WriterPassword).MinimumLength(2).WithMessage("Minimum 2 karakter giriniz");
            RuleFor(x => x.WriterPassword).MaximumLength(40).WithMessage("Maxsimum 40 karakter giriniz");
        }
    }
}
