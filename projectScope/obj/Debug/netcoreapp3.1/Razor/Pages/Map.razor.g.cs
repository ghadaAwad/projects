#pragma checksum "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25a3d003fe57dc91b5ca5634091ab50669dac953"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Map")]
    public partial class Map : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Map</h3>\r\n<?xml version=\"1.0\" ?>\r\n");
            __builder.AddMarkupContent(1, "<svg id=\"maps\" baseProfile=\"tiny\" fill=\"#7c7c7c\" height=\"177\" stroke=\"#ffffff\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" version=\"1.2\" viewBox=\"0 0 1000 1127\" width=\"900\" xmlns=\"http://www.w3.org/2000/svg\">\r\n\r\n    <path d=\"M115.6 749.9l-1.3 16.7-4.7 21.1-10.2 32.5 0.4 29.9-1.8 7.8-13.5 26.6-2.6 13.2-0.5 7 1 5 1.3 2.6 1.7 3 2.1 2.8 2.9 2.6 3.1 1.9 3.8 1.2 3.6 0.2 3.5-0.4 2.9-1.1 3-0.6 5.9-0.2 6.9 1.3 4.2 1.6 4.5 2.5 4.5 4 4.1 4.4 3.4 5.3 12.1 27.5 14.9 60.8 11.4 83.6 0.6 2.3-27.2-4.7-34.1-5.9-32-5.6-35.7-6.2-27.3-4.7-25.5-4.5 3-2.1 1.5-24.1 1.6-6.9 5-10.8-0.2-4.2-4.8-4.8-3.1 0-0.2-1.6-1.4-0.2 1-7.2 1.6-5.8 3.1-5 2.2-6.6 1.2-14.9 1.7-6.6 10.7-28.9 1-5.4 0.2-16.1 1.7-9 0.9-2.3 1.1-2 0.9-2.4 0.1-3.2 2.7-10.4 9.8-14.8 3.7-9 0-8.4-4.7-16.2 0.1-7.6 1.6-4.6 2.2-13.9 1.4-3.3 1.5-2.7 1.3-2.9 0.5-3.7-0.7-3.8-3.3-5.4-1.1-2.7 0-6.4 4-10.9 1.1-6.3 9.9-32.7 13.5-27.5 3.4 2.7 15.7 11.3 3.6 1.8 3 2.7 2.7 4.8 2.8 3.7 3.3 1.6 2.6 1 5.2 0.2z\" id=\"JOR849\" name=\"Aqaba\">\r\n    </path>\r\n    <path d=\"M647.2 457.8l-0.4-0.2-285.3-99.2-8.1-4.7-7.3-6.9-4-2.2-12.5-1.3-4.2 0.4-3 1.4-2.4 1.8-2.9 1.4-3.5 0.1-3.5-1.1-4.1-2.9-9.2-4.6-9.3-0.9-2.9 0.4-2.4 0.5-4.8 2-3.1 0.3-3.6-1-5.6-4.3-2.9-1.8-2.2-0.3-3.2 3.2-2.3 1.2-2.7 0.6-2.5-0.4-2.3-1.7-1.2-1.8-0.1-2.6 0.6-2 1.1-1.6 0.3-1.8-0.8-1.9-2-2.1-4.6-1.6-2.4-5.5-3-5.1-1.6-1.4-1.9-1.3-1.1-1.9 0.2-2.6 2.2-4.3 10.5-11.8 3.2-6.6 1.8-2.4 0.3-2.1-0.7-4-1.2-2.7-1.2-2.2-0.3-2.3 0.8-2.2 3.3-2.7 2.8-0.5 2.6 0.9 4.2 3.3 2.1 0.5 1.6-0.6 1.6-7.1-2.8-22.3 3.3 0.1 8.5-1.2 1.4 0.2 2.4 0.9 1.4 0.3 1.1-0.6 2.6-2.4 1.2-0.3 2.5 1.3 7.5 7.6 14.8 10.2 20.2 19.2 3.4 2 4.5 1.4 13 1.3 3.7 2.3 39.8 4.9 8.3 6.3 4-2.4 5 0.2 14.7 3.9 3.2 0.1 3-1 36.9-25.4 35.2-23 25.5-16.3 39.3-25.3 39.4-25.3 39.4-25.4 39.4-25.4 29.2-18.9 40-25.2 68.7-43.4 56.3-35 10.7 39.2 9.5 35.3 8 29.1 10.4 38.9 26.3 97.1-18 5.7 0.3 1 11.2 39.1 1.7 4.1 2.3 1.3 43.6-12 4.7 2.7 3.4 8.4 4.8 18.3-5.9 8.6-27.6 23.7 0 2-2.3 0.8-4.5 3.4-27.3 26-7.9 3.4-26.1 7.6-51.7 15-51.7 15.1-51.6 15-51.7 14.9-43.5 13.1z\" id=\"JOR850\" name=\"Mafraq\">\r\n    </path>\r\n    <path d=\"M471.8 510.5l-8.8 2.7 29.9 32.5 30.3 33.1-245.9-0.4-69.5-1.7-2.3-2-0.8-3.3 0.6-5.2 0.8-3.8 1.9-5.4 0.4-2.4-0.6-3.5-1.6-5.2-5.6-9.8 2.5-2.4 1.4-1.1 1.8-1.8 0.9-1.8 4-12.2 1.5-2.9 3.2-4.6 0.7-1.7-0.4-1.7-1.9-1.8-1.3-1.6-0.2-2.2 0.8-1.9 0.1-2.6-1.3-3.4-10-10.8-1.7-4.3-1.8-6.9-0.4-2.6 0.3-2.4 1.2-2 3.9-4.8 1.4-2.5 0.5-2.5-0.5-19.6-1.7-1.5-1.5-0.3-2.9 1.2-3.5 0.9-11.7 0-8.6 2.3 0.4-4.8 0.6-2.9 2.9-8.3-0.4-2.3-1.3-1.4-5.3-0.9-3-0.9-2.5-1.3-1.6-1.9-0.5-2.4 1.6-3 3.5-3.1 13.3-6.9 5.8-4.2 10.3-12.3 3.5-2.8 8.7-2.7 3.6-2.1 7.2-7 6.7-2.2 5.3 6.9 5.5 5.1 7.8 9.5 4.4 3.2 3.1 1 4.5-2.6 2.8-0.6 3.7-0.3 11.3-3.6 14.8 0.1 4.7-0.9 3-1.9 4.3-5.3 2.8-2.4 4.9-1.1 24.3 2.2 4.8 2.1 4.8 4.1 13 14.3 6.6 8.6 0.4 4.3-2.1 3.3-6.5 4.1-5.1 4.2-1.8 2.4-0.3 2.6 1.4 2.9 6.2 7.1 10.3 9.7 10 6.8 5.4 2 4.3-0.1 10.9-6.7 3.9-1.1 4.3 1 64.4 66 0.8 0.4z\" id=\"JOR851\" name=\"Amman\">\r\n    </path>\r\n    <path d=\"M247.9 707.5l-17.5 29.6-8.4 3.1-6.1-2.4-2.4-0.2-2.5 0.5-2.9 2-2.2 2.3-3.3 2-16.3 4-21.4 2.9-7.9-0.7-22.8 0.7-9.4-1.4-9.2 0-5.2-0.2-2.6-1-3.3-1.6-2.8-3.7-2.7-4.8-3-2.7-3.6-1.8-15.7-11.3-3.4-2.7 1.7-6.3 1.1-6.8 0.8-3 1.5-3.2 1.8-2.1 3.9-3.5 1.3-2.6 0.8-5.9-0.1-6 0.6-6.1 2.9-6 2.8-2.7 13.3 9.3 3.2 0.8 4.1 0.3 2.5-1.5 1.5-2.7 1.5-10.9 2.3-6.9 1-5.5 1.4-2.1 2.2-0.7 2.9 0.2 4.1-0.6 2.9 0.2 2.6 0.7 2.6 2.3 3.2 2.1 3.3 1.3 19.6 1 36.8 14.8 1.6 1.3 1.6 3.6 2.1 2 2.9 2.1 8.3 3.9 2.4 1.4 1.8 2 2.4 4 1.8 2 9.8 7.3 9.8 9.9z\" id=\"JOR852\" name=\"Tafilah\">\r\n    </path>\r\n    <path d=\"M523.2 578.8l59.4 64.4 28.1 33.2 25.2 29.8 25.3 29.7 36.5 43.1-1.8 1.3-16.8 9.5-52.7 29.7-5.3 4.4-3 4.9-6.8 16.5-15.8 38.6-10.2 25-5 4.4-57.8 12.1-65.9 13.7-40.4 8.5-6.3 3.1-5.5 6-12.7 21.6-24.9 42.3-14.7 25.1-68.8 57-24.9 20.6-5.9 2.5-6.3 0.2-50.4-8.7-13-2.3-0.6-2.3-11.4-83.6-14.9-60.8-12.1-27.5-3.4-5.3-4.1-4.4-4.5-4-4.5-2.5-4.2-1.6-6.9-1.3-5.9 0.2-3 0.6-2.9 1.1-3.5 0.4-3.6-0.2-3.8-1.2-3.1-1.9-2.9-2.6-2.1-2.8-1.7-3-1.3-2.6-1-5 0.5-7 2.6-13.2 13.5-26.6 1.8-7.8-0.4-29.9 10.2-32.5 4.7-21.1 1.3-16.7 9.2 0 9.4 1.4 22.8-0.7 7.9 0.7 21.4-2.9 16.3-4 3.3-2 2.2-2.3 2.9-2 2.5-0.5 2.4 0.2 6.1 2.4 8.4-3.1 17.5-29.6 26.9-50.3 11.8-37.5-5.4-14.9-3.9-26.4 245.9 0.4z\" id=\"JOR853\" name=\"Ma`an\">\r\n    </path>\r\n    <path d=\"M261.3 235.3l2.8 22.3-1.6 7.1-1.6 0.6-2.1-0.5-4.2-3.3-2.6-0.9-2.8 0.5-3.3 2.7-0.8 2.2 0.3 2.3 1.2 2.2 1.2 2.7 0.7 4-0.3 2.1-1.8 2.4-7.6-0.4-7.2-2-3 0.9-7.9 3.4-5-7-4.5-3.7-1.1-2.2-1-3.6-1.6-0.7-1.6 1.1-1.6 2.3-2.8 1.6-3.7 0.6-6.7-0.4-3.8 0.7-7 3.9-5.5 1.6-5.8-0.4-4 0.3-3.2 1.4-2.3 2.9-1.6 4.2-3.5 17 0.4 4.1 1.3 4.4 3.2 7.4 0.6 2.3-0.2 1.6-1 2.7-16-1.9-1.5 0.1 3-12.8-3 0 1-2.5 2-1.4-1.8-3.2-0.9-5.1 0.1-5.2 1-3.2-2.1-4 0.2-8.2-1.2-2.6 0-1.9 1.7 0 0 1.9 1.4 0-0.4-2.5-0.7-2.1-0.9-1.7-1.7-2.1-1-3 2.2-0.4 1-0.8-0.2-1.1-1.4-1.4 0-1.7 1.7 0-0.4-1.2-1.3-0.6 3.1-2.1-1.4-1.8 3-1.7 0-2-1-0.2-2-1.5 0.4-1.8 0.9-1.9 1.4-1.5 2-0.6 0-1.7-2.1-2.2-0.5-1.2-1.7-2.4-2.1 0.1 0-1.9 3.1 0-0.6-1.7-0.8-5.7 1.4 1.8 1.1-2.9 1.3 0.5 0.9-1.5-1.3-3.3-0.7-7.1-1.3-2.4 0-2.1 1.6 0 0-1.7-1.9-1.1-1-2 0.2-2.2 0.5-0.9 1.6-0.7 2-1.8 3.5-4.7 4.2-3 5.5 0.6 3.7-1.9 7.6-6.8 12.6-8 4-1.1 2.8-1 1.2 0.2 1 0.8 2.1 2.7 24.7 5.8 2.2 1.3 3.9 4 1.2 0.4 2.9 0 0.9 0.5 0.4 1.8-0.3 1.8-0.8 1.1 1.3 2.5 2 1.9 2.4 0.8 3.3-0.6 5.4 0.4 1 3.1-0.6 4.7 0.1 5.1 2.2 4.6 10.3 15.7 1.3 3.2 0.1 1.2 3.6 0.3z\" id=\"JOR854\" name=\"Irbid\">\r\n    </path>\r\n    <path d=\"M220.7 283.6l-4.9 2.7-2.5 1.1-3.6 2.3-3.6 3.7-3.9 6.1-1.6 4.5-0.6 3.8 0.2 2.6-0.6 2.4-2 2.3-15.7 7.2-9.6 10.9-6-1.2-3.9-1.6-3.7-4.7 1-2.7 0.2-1.6-0.6-2.3-3.2-7.4-1.3-4.4-0.4-4.1 3.5-17 1.6-4.2 2.3-2.9 3.2-1.4 4-0.3 5.8 0.4 5.5-1.6 7-3.9 3.8-0.7 6.7 0.4 3.7-0.6 2.8-1.6 1.6-2.3 1.6-1.1 1.6 0.7 1 3.6 1.1 2.2 4.5 3.7 5 7z\" id=\"JOR855\" name=\"Ajlun\">\r\n    </path>\r\n    <path d=\"M246.4 281.7l-3.2 6.6-10.5 11.8-2.2 4.3-0.2 2.6 1.1 1.9 1.9 1.3 1.6 1.4 3 5.1 2.4 5.5-0.8 5.7-1.1 2.4-2 2.1-3 1.4-3.6 2.1-2.7 2.2-8.6 11.5-8.4-6.3-1.7-2.3-2.6-2.6-3.3-1.4-4.5-0.8-20 0.5-3-0.3-2.4-0.9-0.3-2.3 9.6-10.9 15.7-7.2 2-2.3 0.6-2.4-0.2-2.6 0.6-3.8 1.6-4.5 3.9-6.1 3.6-3.7 3.6-2.3 2.5-1.1 4.9-2.7 7.9-3.4 3-0.9 7.2 2 7.6 0.4z\" id=\"JOR856\" name=\"Jarash\">\r\n    </path>\r\n    <path d=\"M158.7 325.7l3.7 4.7 3.9 1.6 6 1.2 0.3 2.3 2.4 0.9 3 0.3 20-0.5 4.5 0.8 3.3 1.4 2.6 2.6 1.7 2.3 8.4 6.3 1.3 7 3.1 3.2 1.5 0.7 4.5 2.7-6.7 2.2-7.2 7-3.6 2.1-8.7 2.7-3.5 2.8-10.3 12.3-5.8 4.2-13.3 6.9-3.5 3.1-1.6 3 0.5 2.4 1.6 1.9 2.5 1.3 3 0.9 5.3 0.9 1.3 1.4 0.4 2.3-2.9 8.3-0.6 2.9-0.4 4.8-2.9 1.8-6.2 0.5-2.8 0.9-2.8 1.8-1.4 1.9-2.7 7.2-3.8 6.9-2.9 2.8-3.2 1.5-1.8-0.1 0.7-5.4 2.2-7.9-0.4-6-6.2-3.4-4.9-14.6 0-2 2.5-3.4-5.6-21.6 0.7-2.2 3-1.3 1-1.2 0.2-2.2-1.4-3-0.4-2.2-0.1-3.7-0.5-2.9-2.5-6.4-0.4-12.5 1.2-4.7 3.9-3.2-2.4-3.3 0.1-3.2 3.9-6.6-1.2-1.7 0-1.5 1-1.2 1.9-1 0-2-1-3.2 1-4.4 1.5-0.1 16 1.9z\" id=\"JOR857\" name=\"Balqa\">\r\n    </path>\r\n    <path d=\"M200.6 536.1l-10.3-2.4-4.8-0.1-7.8 0.8-7.1 2.2-3.2 0-4.4-0.9-20.8-7 1.9-9.4-0.8-7.7-3.2-11.2 4.8-38.6 1.8 0.1 3.2-1.5 2.9-2.8 3.8-6.9 2.7-7.2 1.4-1.9 2.8-1.8 2.8-0.9 6.2-0.5 2.9-1.8 8.6-2.3 11.7 0 3.5-0.9 2.9-1.2 1.5 0.3 1.7 1.5 0.5 19.6-0.5 2.5-1.4 2.5-3.9 4.8-1.2 2-0.3 2.4 0.4 2.6 1.8 6.9 1.7 4.3 10 10.8 1.3 3.4-0.1 2.6-0.8 1.9 0.2 2.2 1.3 1.6 1.9 1.8 0.4 1.7-0.7 1.7-3.2 4.6-1.5 2.9-4 12.2-0.9 1.8-1.8 1.8-1.4 1.1-2.5 2.4z\" id=\"JOR858\" name=\"Madaba\">\r\n    </path>\r\n    <path d=\"M200.6 536.1l5.6 9.8 1.6 5.2 0.6 3.5-0.4 2.4-1.9 5.4-0.8 3.8-0.6 5.2 0.8 3.3 2.3 2 69.5 1.7 3.9 26.4 5.4 14.9-11.8 37.5-26.9 50.3-9.8-9.9-9.8-7.3-1.8-2-2.4-4-1.8-2-2.4-1.4-8.3-3.9-2.9-2.1-2.1-2-1.6-3.6-1.6-1.3-36.8-14.8-19.6-1-3.3-1.3-3.2-2.1-2.6-2.3-2.6-0.7-2.9-0.2-4.1 0.6-2.9-0.2-2.2 0.7-1.4 2.1-1 5.5-2.3 6.9-1.5 10.9-1.5 2.7-2.5 1.5-4.1-0.3-3.2-0.8-13.3-9.3 6.2-6.1 2.6-4.8-0.1-8.4 1.5-7.9 9.2-18.1 6.4 1.1 3.9 0.3 2.1-0.6 5.7-4.1 1.7-1.7-0.2-1.7-1-1.7-0.7-2.4-1.3-2 0.8-1.5 4.7-5 0.8-1.7-1.1-5.1-3.5-2.9-8.1-3-3.4-2.3-9.2-8.7-3.7 4.2-0.9 1.4-1.2-7.2 2.8-6.6 3.3-5.6 0.4-5.8 4.2 0.6 11.2-12 4.4-0.2 0.5 3.6-2.6 9.7 0.6 3.2 2.1 0.4 2.5-1.5 3.8-3.5 1.7-2.3 0-1.8-0.6-1.9-0.1-2.3 4.4-21.3 20.8 7 4.4 0.9 3.2 0 7.1-2.2 7.8-0.8 4.8 0.1 10.3 2.4z\" id=\"JOR859\" name=\"Karak\">\r\n    </path>\r\n    <path d=\"M647.2 457.8l-70.4 21.2-105 31.5-0.8-0.4-64.4-66-4.3-1-3.9 1.1-10.9 6.7-4.3 0.1-5.4-2-10-6.8-10.3-9.7-6.2-7.1-1.4-2.9 0.3-2.6 1.8-2.4 5.1-4.2 6.5-4.1 2.1-3.3-0.4-4.3-6.6-8.6-13-14.3-4.8-4.1-4.8-2.1-24.3-2.2-4.9 1.1-2.8 2.4-4.3 5.3-3 1.9-4.7 0.9-14.8-0.1-11.3 3.6-3.7 0.3-2.8 0.6-4.5 2.6-3.1-1-4.4-3.2-7.8-9.5-5.5-5.1-5.3-6.9-4.5-2.7-1.5-0.7-3.1-3.2-1.3-7 8.6-11.5 2.7-2.2 3.6-2.1 3-1.4 2-2.1 1.1-2.4 0.8-5.7 4.6 1.6 2 2.1 0.8 1.9-0.3 1.8-1.1 1.6-0.6 2 0.1 2.6 1.2 1.8 2.3 1.7 2.5 0.4 2.7-0.6 2.3-1.2 3.2-3.2 2.2 0.3 2.9 1.8 5.6 4.3 3.6 1 3.1-0.3 4.8-2 2.4-0.5 2.9-0.4 9.3 0.9 9.2 4.6 4.1 2.9 3.5 1.1 3.5-0.1 2.9-1.4 2.4-1.8 3-1.4 4.2-0.4 12.5 1.3 4 2.2 7.3 6.9 8.1 4.7 285.3 99.2 0.4 0.2z\" id=\"JOR860\" name=\"Zarqa\">\r\n    </path>\r\n    <circle cx=\"150.9\" cy=\"286.2\" id=\"0\" r>\r\n    </circle>\r\n    <circle cx=\"258.7\" cy=\"339.7\" id=\"1\" r>\r\n    </circle>\r\n    <circle cx=\"268.7\" cy=\"548\" id=\"2\" r>\r\n    </circle>\r\n    <g id=\"DC\">\r\n        <path id=\"path58\" fill=\"#D3D3D3\" d=\"M975.8,353.8l-1.1-1.6l-1-0.8l1.1-1.6l2.2,1.5L975.8,353.8z\"></path>\r\n        <circle id=\"circle60\" data-info=\"Washington DC\" fill=\"#D3D3D3\" stroke=\"#FFFFFF\" stroke-width=\"1.5\" cx=\"975.3\" cy=\"351.8\" r=\"5\"></circle>\r\n    </g>\r\n\r\n</svg>\r\n<p class=\"info_panel\"></p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
