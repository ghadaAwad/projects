using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using projectScope.Data;

namespace projectScope.Validator
{
    public class EmployeeDeppar : AbstractValidator<Employeeinfo>
    {
        public EmployeeDeppar()
        {

            RuleFor(x => x.EmpName).NotEmpty()
                                .WithMessage("The Name is Empty")
                                .MaximumLength(20)
                                .WithMessage("Name Max Length 20")
                                .Matches("^[A-Z][a-z]*$")
                                .WithMessage("Must name Characters and start capital letter");
                               



            RuleFor(x => x.Department).NotEmpty()
                    .WithMessage("The Department is Empty");

                      RuleFor(x => x.Salary).NotEmpty()
                                     .WithMessage("Thae Salary is Empty");



        }   
}
}
