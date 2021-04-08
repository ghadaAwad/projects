using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace projectScope.Data
{
    public class EmployeeServiceDapper
    {
        private string connectionString = "";
        public EmployeeServiceDapper()
        {
            connectionString = @"Data Source=Ghada-PC;Initial Catalog=Exam001;Integrated Security=True";
        }
        public IDbConnection connection
        {
            get { return new SqlConnection(connectionString); }
        }
        public void AddEmployee(Employeeinfo ecAdd)
        {
            using (IDbConnection dbConnection = connection)
            {
                string sQuery = @"INSERT INTO EMPTABLE(EmpName,Department,Salary)VALUES(@EmpName,@Department,@Salary)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, ecAdd);

            }
        }
        public async Task<IEnumerable<Employeeinfo>> GetEmployee()
        {
            try
            {
                using (IDbConnection dbConnection = connection)
                {
                    dbConnection.Open();
                    return await dbConnection.QueryAsync<Employeeinfo>("SELECT * FROM Emptable");
                }
            }
            catch(Exception)
            {
                throw;
            }
          
        }
        public Employeeinfo GetEmployeeByID(int id)
        {
            using (IDbConnection dbConnection = connection)
            {
                string sQuery = @"SELECT * FROM Emptable EmpId=@EmpId";
                dbConnection.Open();
                return dbConnection.Query<Employeeinfo>(sQuery, new { Id = id }).FirstOrDefault();
            }
            }
        public void UbdateEmp(Employeeinfo Emp)
        {
            using (IDbConnection dbConnection = connection)
            {
                string sQuery = @"UBDATE Emptable SET EmpName=@EmpName,Department=@Department,Salary=@Salary WHERE EmpId=@EmpId";
                dbConnection.Open();
                 dbConnection.Query(sQuery, Emp) ;
            }
        }
        public void DeletEmp(int id)
        {
            using (IDbConnection dbConnection = connection)
            {
                string sQuery = @"DELETE FROM Emptable WHERE EmpId=@EmpId";
                dbConnection.Open();
                dbConnection.Query(sQuery, new { Id = id });
            }
        }
    }
   


            
}
