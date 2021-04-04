using FluentValidation;
using FluentValidation.Internal;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectScope.Validator
{
    public static class FluentValidationExtensions
    {
        private readonly static Char[] Separetors = new[] { '.', '[' };
        public static EditContext AddFluentValidation(this EditContext editContext ,IServiceProvider serviceProvider,IValidator validator)
        {
            if (editContext == null)
            {
                throw new ArgumentException(nameof(editContext));
            }
            var messages = new ValidationMessageStore(editContext);
            editContext.OnValidationRequested += (sender, eventArgs) => ValidatModel((EditContext)sender, messages, serviceProvider, validator);
            editContext.OnFieldChanged += (sender, eventArgs) => ValidatField(editContext, messages, eventArgs.FieldIdentifier, serviceProvider, validator);
            return editContext;
        }
        private static async void ValidatModel(EditContext editContext,ValidationMessageStore Messages,IServiceProvider serviceProvider,IValidator validator=null)
        {
            if (validator == null)
            {
                validator = GetValidatorForModel(serviceProvider, editContext.Model);
            }
            var ValidationResults = await validator.ValidateAsync(editContext.Model);
            Messages.Clear();
            foreach(var ValidationResult in ValidationResults.Errors)
            {
                var FieldIdentifier = ToFieldIdentifier(editContext, ValidationResult. PropertyName);
                Messages.Add(FieldIdentifier, ValidationResult.ErrorMessage);
            }
            editContext.NotifyValidationStateChanged();
        }
       private static async void ValidatField(EditContext editContext,ValidationMessageStore message,FieldIdentifier fieldIdentifier, IServiceProvider serviceProvider, IValidator validator = null)
        {
            var Proparties = new[] { fieldIdentifier.FieldName };
            var Context = new ValidationContext(fieldIdentifier.Model, new PropertyChain(), new MemberNameValidatorSelector(Proparties));
            validator = validator ?? GetValidatorForModel(serviceProvider, fieldIdentifier.Model);
            if (validator!=null)
            {
                var ValidationResults = await validator.ValidateAsync(Context);
                message.Clear(fieldIdentifier);
                message.Add(fieldIdentifier, ValidationResults.Errors.Select(e => e.ErrorMessage));
                editContext.NotifyValidationStateChanged();
            }
        }
        private static IValidator GetValidatorForModel (IServiceProvider serviceProvider,object Model)
        {
            var validatorType = typeof(IValidator<>).MakeGenericType(Model.GetType());
            if (serviceProvider != null)
            {
                if (serviceProvider.GetService(validatorType) is IValidator validator)
                {
                    return validator;
                }
            }
            var abstractValidatorType = typeof(AbstractValidator<>).MakeGenericType(Model.GetType());
            Type modelValidatorType = null;
            foreach(var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                modelValidatorType = assembly.GetTypes().FirstOrDefault(x => x.IsSubclassOf(abstractValidatorType));
                if (modelValidatorType != null) break;
            }
            if (modelValidatorType == null) return null;
            return (IValidator)ActivatorUtilities.CreateInstance(serviceProvider, modelValidatorType);
        }
        private static FieldIdentifier ToFieldIdentifier(EditContext editContext,string propertyPath)
        {
            var obj = editContext.Model;
            while (true)
            {
                var nextTokenEnd = propertyPath.IndexOfAny(Separetors);
                if (nextTokenEnd < 0) return new FieldIdentifier(obj, propertyPath);
                var nextToken = propertyPath.Substring(0,nextTokenEnd);
                propertyPath = propertyPath.Substring(nextTokenEnd + 1);
                object newobj;
                if (nextToken.EndsWith("["))
                    {
                    nextToken = nextToken.Substring(0, nextToken.Length - 1);
                    var Prop = obj.GetType().GetProperty("item");
                    var indexerType = Prop.GetIndexParameters()[0].ParameterType;
                    var indexerValue = Convert.ChangeType(nextToken, indexerType);
                    newobj = Prop.GetValue(obj, new object[] { indexerValue });
                }
                else
                {
                    var Prop = obj.GetType().GetProperty(nextToken);
                    if (Prop == null) throw new InvalidOperationException($"Invalid Property Name");
                    newobj = Prop.GetValue(obj);
                }
                if (newobj==null)
                {
                    return new FieldIdentifier(obj, nextToken);
                }
                obj = newobj;
            }
        }
    }   

    }

