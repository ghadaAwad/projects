#pragma checksum "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f59d6596235744c633f7e255ebe3f27bf7b3eeb"
// <auto-generated/>
#pragma warning disable 1591
namespace projectScope.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using projectScope;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using projectScope.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Microsoft.EntityFrameworkCore.SqlServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ghada\source\repos\projectScope\projectScope\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
using projectScope.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
using projectScope.Validator;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmpComponent))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Studets")]
    public partial class Studets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Studets</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                  Students

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                                              SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<projectScope.Validator.FluentValidationValideator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    \r\n\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(8, "<lable>Name:</lable>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                             Students.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Students.Name = __value, Students.Name))));
                __builder2.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Students.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __Blazor.projectScope.Pages.Studets.TypeInference.CreateValidationMessage_0(__builder2, 14, 15, 
#nullable restore
#line 13 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                              ()=>Students.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(16, "\r\n\r\n\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(17, "<lable>Age:</lable>\r\n    ");
                __Blazor.projectScope.Pages.Studets.TypeInference.CreateInputNumber_1(__builder2, 18, 19, 
#nullable restore
#line 18 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                               Students.Age

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Students.Age = __value, Students.Age)), 21, () => Students.Age);
                __builder2.AddMarkupContent(22, "\r\n    ");
                __Blazor.projectScope.Pages.Studets.TypeInference.CreateValidationMessage_2(__builder2, 23, 24, 
#nullable restore
#line 19 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                              ()=>Students.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(25, "\r\n\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(26, "<lable>Email:</lable>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                             Students.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Students.Email = __value, Students.Email))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Students.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __Blazor.projectScope.Pages.Studets.TypeInference.CreateValidationMessage_3(__builder2, 32, 33, 
#nullable restore
#line 24 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                              ()=>Students.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(34, "\r\n\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(35, "<lable>Address:</lable>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                             Students.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Students.Address = __value, Students.Address))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Students.Address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __Blazor.projectScope.Pages.Studets.TypeInference.CreateValidationMessage_4(__builder2, 41, 42, 
#nullable restore
#line 29 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
                              ()=>Students.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(43, "\r\n\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(44, "<button class=\"btn btn-primary\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Studets.razor"
       
    Student Students{ get; set; } = new Student();
    void SubmitForm()
    {
        Console.WriteLine("Form Submited");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.projectScope.Pages.Studets
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
