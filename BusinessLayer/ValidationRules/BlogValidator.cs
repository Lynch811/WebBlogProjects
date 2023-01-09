using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Bırakmayınız");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Bırakmayınız");
            RuleFor(x => x.BlogContent).MinimumLength(3).WithMessage("Yazdıklarınız 3 Karakterden az");
            RuleFor(x => x.BlogContent).MaximumLength(150).WithMessage("Yazdıklarınız 150 Karakterden fazla");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Resmini Boş Bırakmayınız");
            RuleFor(x => x.BlogTitle).MaximumLength(100).WithMessage("Yazdıklarınız 150 Karakterden fazla");
            RuleFor(x => x.BlogTitle).MinimumLength(0).WithMessage("Yazdıklarınız 3 Karakterden az");
        }
    }
}
