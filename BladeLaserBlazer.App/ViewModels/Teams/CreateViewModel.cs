using BladeLaserBlazer.Core.Data.Models;
using FluentValidation;
using System.Linq;

namespace BladeLaserBlazer.App.ViewModels.Teams
{
    public class CreateViewModel : IValidatable
    {
        public string Location { get; set; }
        public string Name { get; set; }

        public bool IsValid => new CreateViewModelValidator().Validate(this).IsValid;
        public string ValidationErrors
        {
            get
            {
                var errors = new CreateViewModelValidator().Validate(this).Errors.Select(e => e.ErrorMessage);
                return string.Join(',', errors);
            }
        }
        
        public Team ToModel()
        {
            return new Team
            {
                Location = Location,
                NickName = Name
            };
        }

    }

    public class CreateViewModelValidator : AbstractValidator<CreateViewModel>
    {
        public CreateViewModelValidator()
        {   
            RuleFor(c => c.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(c => c.Location).NotEmpty().WithMessage("Location is required");
        }
    }
}
