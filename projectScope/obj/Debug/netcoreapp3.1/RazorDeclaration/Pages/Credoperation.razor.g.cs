#pragma checksum "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Credoperation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "774044326b92fd6024615b14fb490ffe7e3aa593"
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
#line 2 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Credoperation.razor"
using projectScope.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Credoperation.razor"
using projectScope.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Credoperation")]
    public partial class Credoperation : OwningComponentBase<EmpService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\ghada\source\repos\projectScope\projectScope\Pages\Credoperation.razor"
           
        List<Employeeinfo> Displaydata;
        Employeeinfo objinsert = new Employeeinfo();
        bool popup = false;
        void showpopup() { popup = true; }
        void closepopup() { popup = false; }

        protected override void OnInitialized()
        {
            Displaydata = Service.GetEmployees();
        }
        void insertrec()
        {
            var objupdate = false;

            if (objinsert.EmpId > 0)
            {
                objupdate = Service.UpdateEmp(objinsert);
                popup = false;
            }
            else
            {
                objinsert.EmpId = 0;
                Service.AddEmployee(objinsert);
            }

            Displaydata = Service.GetEmployees();

        }
        void editRec(Employeeinfo ecopj)
        {
            objinsert = ecopj;
            popup = true;
        }
        void DeletEmp(Employeeinfo ecopj)
        {
            Service.DeletEmp(ecopj);
            Displaydata.Clear();
            Displaydata = Service.GetEmployees();

        }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
