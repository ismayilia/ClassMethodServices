using ClassTaskThird.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskThird.Controller
{
    internal class DoctorController
    {
        public void DateInterval()
        {
            DoctorService doctorService = new();
            DateTime date = new(1993, 05, 25); 
            DateTime date1 = new(2002, 12, 15);
            doctorService.GetDoctorsFulInformationl(date, date1);
        }
    }
}
