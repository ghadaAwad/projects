#pragma checksum "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d307b8b75fa744b9e77491e0bd882c454f68e0ec"
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
#line 3 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor"
using projectScope.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employees")]
    public partial class Employe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h5>Enter your info</h5>\r\n<hr>\r\n<!--\r\n<div class=\"container\">\r\n    ");
            __builder.AddMarkupContent(1, "<div class=\"row \">\r\n    </div>\r\n   \r\n        ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-sm-12 col-lg-12 col-md-12 my-3");
            __builder.AddMarkupContent(4, "\r\n            ");
            __builder.OpenComponent<MudBlazor.MudButton>(5);
            __builder.AddAttribute(6, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 15 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, "Default");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenComponent<MudBlazor.MudButton>(10);
            __builder.AddAttribute(11, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 16 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor"
                                                       Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(14, "Primary");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenComponent<MudBlazor.MudButton>(16);
            __builder.AddAttribute(17, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 17 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor"
                                                       Color.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(20, "Secondary");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenComponent<MudBlazor.MudButton>(22);
            __builder.AddAttribute(23, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 18 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor"
                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(26, "Disabled");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Employe.razor"
       

    /*  MudTextField<string> pwField1;
      MudForm form;*/




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService EmployeeService { get; set; }
    }
}
#pragma warning restore 1591
