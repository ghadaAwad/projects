using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projectScope.Data;
namespace projectScope.Service
{
    public class EmpService
    {
        protected readonly ApplicationDBContext _dbContext;
        public EmpService(ApplicationDBContext _db)
        {
            _dbContext = _db;
        }
        public List<Employeeinfo>GetEmployees()
        {
            return _dbContext.Emptable.ToList();
        }
        public Employeeinfo GetEmpdetails(int EmpId)
        {
            Employeeinfo editobj = new Employeeinfo();
            return _dbContext.Emptable.FirstOrDefault(u => u.EmpId == EmpId);
        }
        public bool UpdateEmp(Employeeinfo Updatetails)
        {
            var GetEmp= _dbContext.Emptable.FirstOrDefault(u => u.EmpId == Updatetails.EmpId);
            if (GetEmp!=null)
            {
                GetEmp.EmpName = Updatetails.EmpName;
                GetEmp.Department = Updatetails.Department;
                GetEmp.Salary = Updatetails.Salary;
                _dbContext.SaveChanges();
            }
            else { return false; }
            return true;
        }

        public bool DeletEmp(Employeeinfo DeletEmp)
        {
            var GetEmp = _dbContext.Emptable.FirstOrDefault(u => u.EmpId == DeletEmp.EmpId);
            if (GetEmp != null)
            {
                _dbContext.Remove(GetEmp);
                _dbContext.SaveChanges();
            }
            else { return false; }
            return true;
        }
        public bool AddEmployee(Employeeinfo ecAdd)
        {
            _dbContext.Emptable.Add(ecAdd);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
