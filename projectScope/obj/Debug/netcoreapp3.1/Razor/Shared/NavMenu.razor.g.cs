#pragma checksum "C:\Users\ghada\source\repos\projectScope\projectScope\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "266b39e0df11e67209b0772f62c10232deb3b14b"
// <auto-generated/>
#pragma warning disable 1591
namespace projectScope.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>projectScope</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\ghada\source\repos\projectScope\projectScope\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\ghada\source\repos\projectScope\projectScope\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\ghada\source\repos\projectScope\projectScope\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddContent(19, 
#nullable restore
#line 11 "C:\Users\ghada\source\repos\projectScope\projectScope\Shared\NavMenu.razor"
             a

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, ";\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item px-3");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "class", "nav-link");
            __builder.AddAttribute(27, "href", "");
            __builder.AddAttribute(28, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\Users\ghada\source\repos\projectScope\projectScope\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "li");
            __builder.AddAttribute(34, "class", "nav-item px-3");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "class", "nav-link");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\ghada\source\repos\projectScope\projectScope\Shared\NavMenu.razor"
                                                 ghada

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(40, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "li");
            __builder.AddAttribute(44, "class", "nav-item px-3");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
            __builder.AddAttribute(47, "class", "nav-link");
            __builder.AddAttribute(48, "href", "Credoperation");
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(50, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Emp\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "li");
            __builder.AddAttribute(54, "class", "nav-item px-3");
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(56);
            __builder.AddAttribute(57, "class", "nav-link");
            __builder.AddAttribute(58, "href", "Charts");
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Chart\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "li");
            __builder.AddAttribute(64, "class", "nav-item px-3");
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(66);
            __builder.AddAttribute(67, "class", "nav-link");
            __builder.AddAttribute(68, "href", "Employe");
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Employee\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.OpenElement(73, "li");
            __builder.AddAttribute(74, "class", "nav-item px-3");
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(76);
            __builder.AddAttribute(77, "class", "nav-link");
            __builder.AddAttribute(78, "href", "Map");
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(80, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Map\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.OpenElement(83, "li");
            __builder.AddAttribute(84, "class", "nav-item px-3");
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(86);
            __builder.AddAttribute(87, "class", "nav-link");
            __builder.AddAttribute(88, "href", "Studets");
            __builder.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(90, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Students\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.OpenElement(93, "li");
            __builder.AddAttribute(94, "class", "nav-item px-3");
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(96);
            __builder.AddAttribute(97, "class", "nav-link");
            __builder.AddAttribute(98, "href", "DBEmployeeDappar");
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(100, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> DB Employee\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\ghada\source\repos\projectScope\projectScope\Shared\NavMenu.razor"
       
    string a = "";
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    void ghada()
    {
        a = "ghada";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
