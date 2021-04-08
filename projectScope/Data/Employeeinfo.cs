using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projectScope.Data
{
    public class Employeeinfo
    {
        [Key]
        public int EmpId { get; set; } 
        [Required]
        public String EmpName { get; set; } 
        [Required]
        public String Department { get; set; } 
        [Required]
        public int Salary { get; set; } 

            }
}
