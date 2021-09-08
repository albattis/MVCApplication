using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BussinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstname, string lastname, string emailaddress)
        {
            EmployeeModel data = new EmployeeModel()
            {
                EmployeeId=employeeId,
                FirstName=firstname,
                LastName=lastname,
                EmailAddress=emailaddress
            };
            string sql = @"insert into dbo.Employee(EmployeeId,FirstName,LastName,EmailAddress)
                            values(@EmployeeId,@FirstName,@LastName,@EmailAddress); ";
            return SQLDataAccess.SaveData(sql, data);
        }
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = "select Id,EmployeeId,FirstName,Lastname,EmailAddress from dbo.Employee;";

            return SQLDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
