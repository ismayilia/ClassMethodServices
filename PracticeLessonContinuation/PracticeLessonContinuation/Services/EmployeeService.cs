using PracticeLessonContinuation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLessonContinuation.Services
{
    internal class EmployeeService
    {
        public int GetAverageAgeEmployees()
        {
            Employee[] employees = GetEmployees();

            int sumAge = 0;
            int employeeCount=employees.Length;

            foreach (Employee employee in employees)
            {
                sumAge+= employee.Age;
            }
            int result=sumAge/employees.Length;
            return result;
        }
            //      Employee-ni geri qaytarir
        private Employee[] GetEmployees()
        {
            Employee emp1 = new()
            {
                Id = 1,
                FullName= "Sheref Tenzilli",
                Age= 26,
                Position= "Full stack developer"
            };


            Employee emp2 = new()
            {
                Id = 2,
                FullName = "Cahangir Axundov",
                Age = 20,
                Position = "Jumper"
            };
            
            
            
            Employee emp3 = new()
            {
                Id = 3,
                FullName = "Pervin Mirzeyev",
                Age = 30,
                Position = "Backend developer"
            };

            Employee[] employees = {emp1, emp2, emp3 };

            return employees;




        }
    }
}
