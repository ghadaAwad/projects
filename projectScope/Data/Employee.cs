using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace projectScope.Data
{
    public class Employee
    {
        public String AuthorId { set; get; }

        [Required(ErrorMessage = "Enter  First Name")]
        public String FirstName { set; get; } = "";

        [Required(ErrorMessage = "Enter Last  Name")]
        public String LastName { set; get; } = "";
        [Required(ErrorMessage = "Enter  City")]
        public String City { set; get; } = "";
        [Required(ErrorMessage = "Enter  Address")]
        public String Adress { set; get; } = "";
        [Required(ErrorMessage = "Enter  Salary")]
        public String Salary { set; get; } = "";
     
        public int NumEmp { set; get; }

      

        public Employee() { }
        public Employee(string AuthorId, String FirstName, string LastName, string City, string Adress, string Salary) { }

    }
}
