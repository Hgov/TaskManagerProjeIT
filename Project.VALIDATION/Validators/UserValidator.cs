using FluentValidation;
using Project.ENTITIES.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VALIDATION.Validators
{
    class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.first_name).NotEmpty().WithMessage("Lütfen adınızı boş geçmeyiniz.");
            RuleFor(c => c.last_name).NotEmpty().When(c => c.user_id != 1).WithMessage("Lütfen soyadı boş geçmeyiniz.");
        }
    }
}
