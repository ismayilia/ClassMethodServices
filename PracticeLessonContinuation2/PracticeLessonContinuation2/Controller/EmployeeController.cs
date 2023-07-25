using PracticeLessonContinuation2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PracticeLessonContinuation2.Controller
{
    internal class EmployeeController
    {

        private EmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }



        public void GetAverageAgeEmployees()
        {
            //EmployeeService employeeService = new();
            int averageAge = _employeeService.GetAverageAgeEmployees();
            Console.WriteLine(averageAge);

                       
        }   

        public void SearchByPosition()
        {
            //EmployeeService employeeService = new();
            

            Console.WriteLine("Add search text: ");
            string position = Console.ReadLine();

            _employeeService.SearchByPosition(position);
        }

    }
}
