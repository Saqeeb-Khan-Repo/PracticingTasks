

namespace PracticingTasks;

public class LinqPractice
{
  public virtual void ErrorMessage()
    {
        Console.WriteLine("Error in your code");
    }
}

public class Program1 : LinqPractice
{
    public override void ErrorMessage()
    {
        Console.WriteLine("Error from program Class");
    }
}











//    List<Employee> employees = new()
//{
//new Employee
//{
//    Id = 1,
//    Name = "Saqeeb",
//    Salary = 50000,
//    Department = "IT"
//},

//new Employee
//{
//    Id = 2,
//    Name = "Ahmed",
//    Salary = 40000,
//    Department = "HR"
//},

//new Employee
//{
//    Id = 3,
//    Name = "Ali",
//    Salary = 60000,
//    Department = "IT"
//},

//new Employee
//{
//    Id = 4,
//    Name = "Rahman",
//    Salary = 45000,
//    Department = "Finance"
//}
//}
//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; } = string.Empty;
//    public decimal Salary { get; set; }
//    public string Department { get; set; } = string.Empty;
//}


