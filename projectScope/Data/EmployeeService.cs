using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace projectScope.Data
{
   
    public class EmployeeService 
    { 
        public List<Employee> Infos { get; set; }
    public EmployeeService() 
    {
        /* CreatIonDate = DateTime.Now;*/
        Infos = new List<Employee>();
        Infos.Add(new Employee()
        {
            AuthorId = "155-N",
            FirstName = "Noor",
            LastName = "Awad",
            City = "Amman",
            Adress = "Amman-HA",
            Salary = "200$"
        });
        Infos.Add(new Employee()
        {
            AuthorId = "12-g",
            FirstName = "Ghada",
            LastName = "Awad",
            City = "Amman",
            Adress = "Amman-HA",
            Salary = "700$"
        });
        Infos.Add(new Employee()
        {
            AuthorId = "446-r",
            FirstName = "Dalia",
            LastName = "Ayman",
            City = "mafraq",
            Adress = "Mafraq-Al",
            Salary = "1000$"
        });
        Infos.Add(new Employee()
        {
            AuthorId = "R-123",
            FirstName = "Rawand",
            LastName = "Abd",
            City = "Karak",
            Adress = "Karak-HA",
            Salary = "900$"
        });
        Infos.Add(new Employee()
        {
            AuthorId = "e-113",
            FirstName = "Reham",
            LastName = "Ayman",
            City = "Salt",
            Adress = "Salt-HA",
            Salary = "800$"
        });
        Infos.Add(new Employee()
        {
            AuthorId = "12-jh",
            FirstName = "Haneen",
            LastName = "Noor",
            City = "Amman",
            Adress = "Amman-sa",
            Salary = "600$"
        });



    }

    public List<Employee> GetAuthors()
    {

        return Infos;

    }
    
        public List<Employee> SaveAuthor(Employee author)
    {


        return Infos;
    }
        public List<Employee> Num(Employee author)
        {


            return Infos;
        }
        /*  public DateTime GetCreatDate()
          {
              return CreatIonDate;
          }
          public String GetVirsion()
          {
              return "v1";
          }*/
    }
}

