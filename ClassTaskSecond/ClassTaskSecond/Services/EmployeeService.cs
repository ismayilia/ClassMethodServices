using ClassTaskSecond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskSecond.Services
{
    internal class EmployeeService
    {

        public void CheckSalaryOfEmployee()
        {
            Employee[] employees = GetEmployees();

            foreach (var item in employees)
            {
                if (item.Salary < 2000 && item.Salary > 1000)
                {
                    Console.WriteLine($"Id: {item.Id} , Name: {item.Name} , Surname: {item.Surname} , Age: {item.Age}, Salary: {item.Salary}");
                }



            }

        }






        public Employee[] GetEmployees()
        {
            Employee emp1 = new()
            {
                Id=1,
                Name="Xeyyam",
                Surname="Isgenderov",
                Age = 30,
                Salary = 1500

            };

            Employee emp2 = new()
            {
                Id = 2,
                Name = "Ismayil",
                Surname = "Afandizada",
                Age = 29,
                Salary = 1750

            };


            Employee emp3 = new()
            {
                Id = 3,
                Name = "Ramil",
                Surname = "Umudli",
                Age = 30,
                Salary = 2200

            };

            Employee[] employees = { emp1, emp2, emp3 };

            return employees;
                
                
            }



        }










    }

