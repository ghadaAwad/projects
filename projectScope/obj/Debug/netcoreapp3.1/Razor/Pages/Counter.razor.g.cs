#pragma checksum "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "326686902682e453472ea95ea7a1202a7165d5ee"
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
#line 2 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
using projectScope.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add/Edit Employee</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                  employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row content");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<div class=\"col-md-2\"><label for=\"Name\">Name</label></div>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", "name");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                                                                employee.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employee.Name = __value, employee.Name))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => employee.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-5");
                __Blazor.projectScope.Pages.Counter.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 10 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                                                        () => employee.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(24, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "row content");
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.AddMarkupContent(30, "<div class=\"col-md-2\"><label for=\"EmailAddress\">Email</label></div>\r\n        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-md-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "id", "EmailAddress");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                                                                        employee.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employee.EmailAddress = __value, employee.EmailAddress))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => employee.EmailAddress));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-md-5");
                __Blazor.projectScope.Pages.Counter.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 15 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                                                        () => employee.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(43, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "row content");
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.AddMarkupContent(49, "<div class=\"col-md-2\"><label for=\"PhoneNumer\">Phone</label></div>\r\n        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-md-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "id", "PhoneNumer");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                                                                      employee.PhoneNumer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employee.PhoneNumer = __value, employee.PhoneNumer))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => employee.PhoneNumer));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "col-md-5");
                __Blazor.projectScope.Pages.Counter.TypeInference.CreateValidationMessage_2(__builder2, 60, 61, 
#nullable restore
#line 20 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                                                        () => employee.PhoneNumer

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(62, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "row content");
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.AddMarkupContent(68, "<div class=\"col-md-2\"><label for=\"CreditCardNumer\">Credit Card Numer</label></div>\r\n        ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-md-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "id", "CreditCardNumer");
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                                                                           employee.CreditCardNumer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employee.CreditCardNumer = __value, employee.CreditCardNumer))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => employee.CreditCardNumer));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-md-5");
                __Blazor.projectScope.Pages.Counter.TypeInference.CreateValidationMessage_3(__builder2, 79, 80, 
#nullable restore
#line 25 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
                                                        () => employee.CreditCardNumer

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(81, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n    ");
                __builder2.AddMarkupContent(84, "<div class=\"row content\">\r\n        <button class=\"btn btn-primary\">Submit</button>\r\n    </div>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Counter.razor"
       
    Person employee = new Person();
    private void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.projectScope.Pages.Counter
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
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
    }
}
#pragma warning restore 1591
