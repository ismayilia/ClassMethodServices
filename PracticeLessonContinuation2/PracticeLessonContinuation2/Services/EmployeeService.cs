using PracticeLessonContinuation2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLessonContinuation2.Services
{
    internal class EmployeeService
    {
        public int GetAverageAgeEmployees()
        {
            Employee[] employees = GetEmployees();

            int sumAge = 0;
            int employeeCount = employees.Length;

            foreach (Employee employee in employees)
            {
                sumAge += employee.Age;
            }
            int result = sumAge / employees.Length;
            return result;
        }


        public void SearchByPosition(string position)
        {
            var employees = GetEmployees();

            foreach (var item in employees) 
            {
                if (item.Position.Trim().ToLower().Contains(position.Trim().ToLower()))
                {
                    Console.WriteLine($"FullName: {item.FullName} , Age: {item.Age} , Position: {item.Position} ");
                }
            }
            
            
                        
        }





        //      Employee-ni geri qaytarir
        private Employee[] GetEmployees()
        {
            Employee emp1 = new()
            {
                Id = 1,
                FullName = "Sheref Tenzilli",
                Age = 26,
                Position = "Full stack developer"
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

            Employee[] employees = { emp1, emp2, emp3 };

            return employees;




        }



    }
}
