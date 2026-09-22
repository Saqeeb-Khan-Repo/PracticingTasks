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
                EmployeeID = Guid.Parse("7370A33A-A4EB-4A16-B0FC-43C3E0B7B8A2"),
                Salary = 20000,
                DateOfBirth = new DateTime(2004,11,03),
                Adress = "Bk road Magadi",
                Gender = GenderOptions.Male
            },
            new Employees
            {
                EmployeeName = "Saqeeb",
                EmployeeID = Guid.Parse("7300A33A-A4EB-4A16-B0FC-43C3E0B7B8A1"),
                Salary = 20000,
                DateOfBirth = new DateTime(2004,12,31),
                Adress = "Bk road Magadi",
                Gender = GenderOptions.Male
            }
        };

      var condition =  ListOfEmployees.Where(e => e.EmployeeName == "Saqeeb");
        
        foreach (var item in condition)
        {
            if (item.EmployeeName == null)
            {
                Console.WriteLine("Error: Employee name is null");
            }

            Console.WriteLine(item.EmployeeName);
        }
    }

    public static void Main1()
    {
        //Dictionary<int, string> Students = new Dictionary<int, string>();

        //Students.Add(01,"Siraj");
        //Students.Add(02, "Saqeeb");
        //Students.Add(03, "Kaif");
        //Students.Add(04, "Mueez");
        //Students.Add(05, "Ahmad");
        //Students.Add(06, "Junaid");

        //foreach (var item in Students)
        //{
        //    Console.WriteLine(item.Value[0]);
        //}

        //LINQ =======>

        List<int> numbers = new List<int>()
        {
            20,10,30,40,50,60,0,1,2,3,4,5,6,7,8,9
        };

        //foreach(var number in numbers)
        //    {
        //        if(number > 20)
        //    {
        //        Console.WriteLine(number);
        //    }
        //    }


        var result =  numbers.Where(n => n > 20);

        var Multiplied = numbers.Select(n => n * n);

        foreach (var item in Multiplied)
        {
            Console.WriteLine(item); 
        }

    }
}

