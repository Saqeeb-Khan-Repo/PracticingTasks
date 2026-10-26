using PracticingTasks.Models;
using PracticingTasks.Enum;


namespace PracticingTasks;

public class Collections
{
    public static void Main()
    {

        List<Employees> ListOfEmployees = new()
        {
            new Employees
            {
                EmployeeName = " siraj",
                EmployeeID = Guid.Parse("93b34870-2b17-4f57-84b2-fb7c10fd0c7a"),
                Salary = 20000,
                DateOfBirth = new DateTime(2004,11,03),
                Adress = "Bk road Magadi",
                Gender = GenderOptions.Male,
                Department = "IT"
            },
            new Employees
            {
                EmployeeName = "Saqeeb",
               EmployeeID = Guid.NewGuid(),
                Salary = 20000,
                DateOfBirth = new DateTime(2004,12,31),
                Adress = "Bk road Magadi",
                Gender = GenderOptions.Male,
                Department = "IT"
            },
                new Employees
            {
                EmployeeName = "Mr khan",
                EmployeeID = Guid.NewGuid(),
                Salary = 20000,
                DateOfBirth = new DateTime(2004,12,31),
                Adress = "Bk road Magadi",
                Gender = GenderOptions.Male,
                Department = "HR"
            },
            new Employees
            {
                EmployeeName = "Kaif",
                EmployeeID = Guid.NewGuid(),
                Salary = 20000,
                DateOfBirth = new DateTime(2004,12,31),
                Adress = "Bk road Magadi",
                Gender = GenderOptions.Male,
                Department = "Assistant Manager"
            }
        };

        //filter
        var condition = ListOfEmployees.Where(e => e.Salary >= 30000);

        //transform
        var UpdatedSalaray = ListOfEmployees.Select(e => new Employees { EmployeeName = e.EmployeeName, Salary = e.Salary += 5000 });

        //GroupBy
        var GroupByDepartment = ListOfEmployees.GroupBy(e => e.Department);

        foreach (var item in GroupByDepartment)
        {
            Console.WriteLine($"Department Key : {item.Key}");

            foreach (var i in item)
            { 
                if(i.Department == "IT")
                {
                    Console.WriteLine(i.EmployeeName);
                }
               
            }
        }
    }
}

    //    foreach (var employee in ListOfEmployees)
    //    {
    //        if (employee.EmployeeName == null)
    //        {
    //            Console.WriteLine("Error: Employee name is null");
    //            continue;
    //        }

    //        Console.WriteLine($"Employee Name : {employee.EmployeeName}");
    //        Console.WriteLine($"Employee ID   : {employee.EmployeeID}");
    //        Console.WriteLine($"Salary        : {employee.Salary}");
    //        Console.WriteLine($"Date of Birth : {employee.DateOfBirth:dd-MM-yyyy}");
    //        Console.WriteLine($"Address       : {employee.Adress}");
    //        Console.WriteLine($"Gender        : {employee.Gender}");
    //        Console.WriteLine($"Department    : {employee.Department}");
    //        Console.WriteLine("----------------------------------------");
    //    }
    //}


//    public static void Main1()
//    {
//        //Dictionary<int, string> Students = new Dictionary<int, string>();

//        //Students.Add(01,"Siraj");
//        //Students.Add(02, "Saqeeb");
//        //Students.Add(03, "Kaif");
//        //Students.Add(04, "Mueez");
//        //Students.Add(05, "Ahmad");
//        //Students.Add(06, "Junaid");

//        //foreach (var item in Students)
//        //{
//        //    Console.WriteLine(item.Value[0]);
//        //}

//        //LINQ =======>

//        List<int> numbers = new List<int>()
//        {
//            20,10,30,40,50,60,0,1,2,3,4,5,6,7,8,9
//        };

//        //foreach(var number in numbers)
//        //    {
//        //        if(number > 20)
//        //    {
//        //        Console.WriteLine(number);
//        //    }
//        //    }


//        var result =  numbers.Where(n => n > 20);

//        var Multiplied = numbers.Select(n => n * n);
//        var s = numbers.Average();
//        Console.WriteLine(s);

//        foreach (var item in Multiplied)
//        {
//            Console.WriteLine(item); 
//        }

//    }
//}

