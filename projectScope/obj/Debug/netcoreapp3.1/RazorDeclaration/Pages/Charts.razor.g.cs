#pragma checksum "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Charts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc33175484881d769783e705e85f9be19ff95d1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Charts.razor"
using projectScope.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Charts")]
    public partial class Charts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Charts.razor"
       
    Chart chart = new Chart();
    List<Chart> Chartss = new List<Chart>();
    private async Task GetChartC()
    {
        Chartss=  chart.GetCharts();
        await jsRunTime.InvokeVoidAsync("GeneratPieChart", Chartss);


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
    }
}
#pragma warning restore 1591
