using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    public string Address { get; set; }
    public byte Age { get; set; }
    public char Gender { get; set; }
    public float Salary { get; set; }
    public string Shifts { get; set; }

    public static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();
        Employee emp1 = new Employee() { Id = 1, FirstName = "Mohan1", LastName = "Lal", Address = "Nepal", Age = 12, Gender = 'M', Salary = 1234.12f, Shifts = "Day", };
        Employee emp2 = new Employee() { Id = 2, FirstName = "Mohan2", LastName = "Lal", Address = "Nepal", Age = 12, Gender = 'M', Salary = 1234.12f, Shifts = "Day", };
        Employee emp3 = new Employee() { Id = 3, FirstName = "Mohan3", LastName = "Lal", Address = "Nepal", Age = 12, Gender = 'M', Salary = 1234.12f, Shifts = "Day", };
        Employee emp4 = new Employee() { Id = 4, FirstName = "Mohan4", LastName = "Lal", Address = "Nepal", Age = 12, Gender = 'M', Salary = 1234.12f, Shifts = "Day", };
        List<Employee> moreemployees = new List<Employee>() { emp1, emp2, emp3, emp4 };
        return moreemployees;
    }
}


