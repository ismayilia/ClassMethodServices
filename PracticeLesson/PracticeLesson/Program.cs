using PracticeLesson;
using PracticeLesson.Controllers;

//Employee employee = new Employee();

//employee.Getname();


//Console.WriteLine("Add age: ");
//Age:  string age = Console.ReadLine();

//int personAge;

//bool isCorrectAgeFormat = int.TryParse(age, out personAge);

//if (isCorrectAgeFormat)
//{
//    Console.WriteLine("Add fulname");
//    string fullName = Console.ReadLine();

//    Person person = new()
//    {
//        Id = 1,
//        FullName = fullName,
//        Age = personAge,
//        IsMarried = true

//    };

//    //Console.WriteLine(person.Id+ "-" + person.FullName + "-" + person.Age + "-" + person.IsMarried);

//    PersonServices service = new PersonServices();
//    bool isMarried = service.CheckIsMarried(person);
//    //Console.WriteLine(isMarried );
//    string result = isMarried == true ? " Evlidir" : "Subaydir";
//    Console.WriteLine(result);




//}
//else
//{
//    Console.WriteLine("Please add correct age format again : ");
//    goto Age;
//}

PersonController personController = new PersonController();

personController.CheckUserIsMarried(); 