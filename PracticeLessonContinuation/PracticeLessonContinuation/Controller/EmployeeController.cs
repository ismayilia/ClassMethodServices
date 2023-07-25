using PracticeLessonContinuation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLessonContinuation.Controller
{
    internal class EmployeeController
    {
        public void GetAverageAgeEmployees()
        {
           EmployeeService employeeService = new();
            int averAge = employeeService.GetAverageAgeEmployees();
            Console.WriteLine(averAge);

        }
    }
}
