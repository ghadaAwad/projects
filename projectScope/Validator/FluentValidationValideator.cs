using FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectScope.Validator
{
    public class FluentValidationValideator:ComponentBase
    {
        [Inject]
        IServiceProvider ServiceProvider { set; get; }
        [CascadingParameter]
        EditContext CurrentEditContext { set; get; }
        [Parameter]
        public IValidator validator { set; get; }
        protected override void OnInitialized()
        {
           if (CurrentEditContext == null)
            {
                throw new InvalidOperationException($"Invalid Edit Context");
            }
            CurrentEditContext.AddFluentValidation(ServiceProvider, validator);
        }
    }
}
