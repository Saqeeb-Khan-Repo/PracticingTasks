using PracticingTasks.Enum;
using System.ComponentModel.DataAnnotations;

namespace PracticingTasks.Models;

public class Employees
{
    public string? EmployeeName { get; set; }
    public string? Adress { get; set; }
    public Decimal? Salary { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public Guid? EmployeeID { get; set; }
    public GenderOptions? Gender { get; set; }

}
