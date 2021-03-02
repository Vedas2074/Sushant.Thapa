using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    
    public int Id { get; set; }
    [Required(ErrorMessage="Hold on!you missed your first name")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required(ErrorMessage="Hold on!you missed your last name")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
  
    public static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();
        Employee emp1 = new Employee() { Id = 1, FirstName = "Mohan1", LastName = "Lal", Address = "Nepal", Age = 12 };
        Employee emp2 = new Employee() { Id = 2, FirstName = "Mohan2", LastName = "Lal", Address = "Nepal", Age = 12 };
        Employee emp3 = new Employee() { Id = 3, FirstName = "Mohan3", LastName = "Lal", Address = "Nepal", Age = 12 };
        Employee emp4 = new Employee() { Id = 4, FirstName = "Mohan4", LastName = "Lal", Address = "Nepal", Age = 12 };
        List<Employee> moreemployees = new List<Employee>() { emp1, emp2, emp3, emp4 };
        return moreemployees;
    }
}


