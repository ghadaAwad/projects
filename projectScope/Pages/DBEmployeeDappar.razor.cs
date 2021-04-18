using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projectScope.Data;
using projectScope.Validator;
using System.ComponentModel.DataAnnotations;
using projectScope.Shared;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace projectScope.Pages
{
    public partial class DBEmployeeDappar
    {

        IEnumerable<Employeeinfo> ObjEmp;
        Employeeinfo objinsert = new Employeeinfo();
        IEnumerable<Employeeinfo> Emps;

        protected override async Task OnInitializedAsync()
        {
            // ObjEmp =await ObjEmpService.GetEmployee();

            pageSize = 5;
            await PopulateEmps();
            TotalSize = (int)Math.Ceiling(count() / (decimal)pageSize);

        }

        int count()
        {
            int i;
            for (i = 0; i < Emps.Count(); i++)
            {
                i = i + 1;

            }
            return i;
        }


        bool popup = false;
        public void Showpopup()
        {
            popup = true;
            objinsert.EmpId = 0;
            objinsert.EmpName = "";
            objinsert.Department = "";
            objinsert.Salary = 0;
        }
        public void closepopup() { popup = false; }

        void Insert()
        {

            if (objinsert.EmpId > 0)
            {
                Http.PutJsonAsync("http://localhost:56001/api/Employee", objinsert);
                popup = false;
                Snackbar.Add("The recorod is Edit", Severity.Success);


            }
            else
            {

                Http.PostJsonAsync("http://localhost:56001/api/Employee", objinsert);
                Snackbar.Add("The recorod is Add", Severity.Success);
                Http.GetAsync("http://localhost:56001/api/Employee");
                popup = false;
            }




        }
        void EditEmp(Employeeinfo EmID)
        {
            objinsert = EmID;
            popup = true;
        }

        bool popupDelete = false;
        public void ShowpopupDelete() { popupDelete = true; }
        public void closepopupDelete() { popupDelete = false; }


        void DeleteEmp(Employeeinfo EmID)
        {
            objinsert = EmID;
            popupDelete = true;
        }
        void DeleteEmployee()
        {
            if (objinsert.EmpId > 0)
            {
                Http.DeleteAsync("http://localhost:56001/api/Employee/DeleteById/" + objinsert.EmpId);
                popupDelete = false;
                Snackbar.Add("The recorod is Delete", Severity.Success);
                //Http.GetAsync("http://localhost:56001/api/Employee");



            }
            else { popupDelete = false; }
        }
        bool popupDetils = false;
        void DetilsEmp(Employeeinfo EmID)
        {
            objinsert = EmID;
            popupDetils = true;
        }
        void closepopupDitils() { popupDetils = false; }

        [Parameter]
        public RenderFragment Gridcolumns { get; set; }
        [Parameter]
        public RenderFragment<Employeeinfo> GridRow { get; set; }



        List<Employeeinfo> Items { get; set; }
        public int pageSize { get; set; }
        public int TotalSize { get; set; }
        public int CurrentPage { get; set; }

        [Parameter]
        public bool ReloadList { get; set; }
        private void UpdateList(int pagenumper)
        {
            ObjEmp = Emps.Skip(pagenumper * pageSize).Take(pageSize).ToList();
            CurrentPage = pagenumper;

        }

        private void NavigateTo(String direction)
        {
            if (direction == "Prev" && CurrentPage != 0)
                CurrentPage -= 1;
            if (direction == "Next" && CurrentPage != TotalSize - 1)
                CurrentPage += 1;
            if (direction == "First")
                CurrentPage = 0;
            if (direction == "Last")
                CurrentPage = TotalSize - 1;
            UpdateList(CurrentPage);
        }

        public Employeeinfo employeeinfo { set; get; }
        public List<Employeeinfo> employeeinfoList { set; get; }
        public List<Employeeinfo> FilteredEmployeeinfoList { set; get; }


        private void OnEmployeeinfoSearchTextChanged(ChangeEventArgs ChangeEventArgs,string columnTitle)
        {
            String SearchText = ChangeEventArgs.Value.ToString();
            if (columnTitle== "EmpName")
            ObjEmp = Emps.Where(PopulateEmps => PopulateEmps.EmpName.Contains(SearchText)).ToList();
            if (columnTitle == "Department")
                ObjEmp = Emps.Where(PopulateEmps => PopulateEmps.Department.Contains(SearchText)).ToList();
          
        }
    }
}
