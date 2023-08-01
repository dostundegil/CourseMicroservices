using FluentValidation;
using FreeCourse.Web.Models.Discounts;

namespace FreeCourse.Web.Validator
{
    public class DiscountApplyInputValidator:AbstractValidator<DiscountApplyInput>
    {
        public DiscountApplyInputValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("indirim kuponu alanı boş olamaz");
        }
    }
}
