using DotNetCore.Validation;
using DotNetCoreArchitecture.Model.Models;
using FluentValidation;

namespace DotNetCoreArchitecture.Model.Validators
{
    public sealed class UpdateUserModelValidator : Validator<UpdateUserModel>
    {
        public UpdateUserModelValidator() : base(string.Empty)
        {
            RuleFor(x => x).NotNull();
            RuleFor(x => x.UserId).GreaterThan(0);
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Surname).NotNull().NotEmpty();
            RuleFor(x => x.Email).NotNull().NotEmpty();
        }
    }
}
