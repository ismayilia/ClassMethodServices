using ClassTaskSecond.Models;
using ClassTaskSecond.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskSecond.Controller
{
    internal class EmployeController
    {
        public void ResultFullInformatin()
        {
            EmployeeService employeeService = new();
            employeeService.CheckSalaryOfEmployee();
        }
        
    }
}
