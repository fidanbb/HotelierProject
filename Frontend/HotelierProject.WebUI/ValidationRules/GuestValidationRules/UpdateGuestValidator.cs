using FluentValidation;
using HotelierProject.WebUI.Dtos.GuestDtos;

namespace HotelierProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator:AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname field cannot be empty");
            RuleFor(x => x.City).NotEmpty().WithMessage("City field cannot be empty");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Please enter at least 3 characters of data.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Please enter at least 2 characters of data.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Please enter at least 3 characters of data.");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Please enter data up to 20 characters.");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Please enter data up to 30 characters.");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Please enter data up to 20 characters.");
        }
    }
}
