using ClassTaskThird.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskThird.Services
{
    internal class DoctorService
    {

        public void GetDoctorsFulInformationl(DateTime date, DateTime date1)
        {
            Doctor[] doctors = GetDoctors();
            
            
            foreach (var item in doctors)
            {
                if (item.Birthday>date && item.Birthday<date1)
                {
                    Console.WriteLine($"Id: {item.Id} , Name: {item.Name} , Surname: {item.Surname} , Address: {item.Address}, Birthday: {item.Birthday}");
                }
                
            }
           
        }






        public Doctor[] GetDoctors()
        {
            Doctor doc1 = new()
            {
                Id = 1,
                Name = "Xeyyam",
                Surname = "Isgenderov",
                Address = "Yasamal",
                Birthday = new DateTime(1992,06,01)
            };

            Doctor doc2 = new()
            {
                Id = 2,
                Name = "Ismayil",
                Surname = "Afandizada",
                Address = "Xetai",
                Birthday = new DateTime(1994,05,07)

            };


            Doctor doc3 = new()
            {
                Id = 3,
                Name = "Ramil",
                Surname = "Umudli",
                Address = "Nerimanov",
                Birthday = new DateTime(2000,05,05)

            };

            Doctor[] doctors = { doc1, doc2, doc3 };

            return doctors;


        }
    }
}
