using System.Collections.Generic;
public class Department{
    public int Id { get; set; }

    public int Code { get; set; }

    public string Sector { get; set; }

    public string Branch { get; set; }



public static List<Department> GetDepartments()
{
      List<Department> Departments = new List<Department>();
        Department dep1 = new Department() { Id =1, Code=101 , Sector="Town" , Branch="Kathmandu"};
        Department dep2 = new Department() { Id =2, Code=202 , Sector ="Village", Branch = "lalitpur" };
        Department dep3 = new Department() { Id =3, Code=303 , Sector ="housing", Branch = "Bhaktpur" };
        Department dep4 = new Department() { Id =4, Code=404 , Sector ="School Area", Branch = "Chitwan" };
        List<Department> moreDepartments =new List<Department>() { dep1, dep2, dep3, dep4 };
        return moreDepartments;
    }

}