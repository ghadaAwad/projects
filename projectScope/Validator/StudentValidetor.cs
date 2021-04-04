using FluentValidation;
using projectScope.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectScope.Validator
{
    public class StudentValidetor :AbstractValidator<Student>
    {
        public StudentValidetor()
        {
            RuleFor(x => x.Name).NotEmpty()
                                .WithMessage("Gev Name")
                                .MaximumLength(20)
                                .WithMessage("Name Max Length 20")
                                .Matches("^[A-Z]{1}[a-z]{1}")
                                .WithMessage("Must start UpperCase letter");

            RuleFor(x => x.Age).NotEmpty()
                                 .WithMessage("Gev Age")
                                 .LessThan(100)
                                 .WithMessage("Max Age 100");
                                   

            RuleFor(x => x.Email).NotEmpty()
                              .WithMessage("Gev Email")
                              .EmailAddress()
                              .WithMessage("Invalid Email");
                             
            RuleFor(x => x.Address).NotEmpty()
                              .WithMessage("Gev Address")
                              .MaximumLength(10)
                              .WithMessage("Miinimum Address Length 10");
        }
    }
}
