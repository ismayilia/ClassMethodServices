using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson.Controllers
{
    internal class PersonController
    {
        public void CheckUserIsMarried()
        {
            Console.WriteLine("Add age: ");
        Age: string age = Console.ReadLine();


            int personAge;

            bool isCorrectAgeFormat = int.TryParse(age, out personAge);

            if (isCorrectAgeFormat)
            {
                Console.WriteLine("Add fulname");
                string fullName = Console.ReadLine();

                Console.WriteLine("Are you married ? Yes/No");            //Bunlari elave yazdig
                Married: string married=Console.ReadLine();

                bool personIsMarried = false;

                if (married=="Yes")
                {
                    personIsMarried = true;
                }
                else if(married=="No")
                {
                    personIsMarried = false;
                }
                else
                {
                    Console.WriteLine("Please add your married answer again");
                    goto Married;
                }

                Person person = new()
                {
                    Id = 1,
                    FullName = fullName,
                    Age = personAge,
                    IsMarried = personIsMarried

                };

                //Console.WriteLine(person.Id+ "-" + person.FullName + "-" + person.Age + "-" + person.IsMarried);

                //PersonServices service = new PersonServices();
                //bool isMarried = service.CheckIsMarried(person);
                ////Console.WriteLine(isMarried );
                //string result = isMarried == true ? " Evlidir" : "Subaydir";
                //Console.WriteLine(result);

                string result = GetPersonMarried(person);
                Console.WriteLine(result);


            }
            else
            {
                Console.WriteLine("Please add correct age format again : ");
                goto Age;
            }
        }
        private string GetPersonMarried(Person person)
        {
            PersonServices service = new PersonServices();
            bool isMarried = service.CheckIsMarried(person);
            //Console.WriteLine(isMarried );
            string result = isMarried == true ? " Evlidir" : "Subaydir";
            return result;
        }

    }
}
