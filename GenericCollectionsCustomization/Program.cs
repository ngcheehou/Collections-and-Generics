// See https://aka.ms/new-console-template for more information
using System.Collections;





ArrayList employees = new ArrayList();

// Adding different types of objects
employees.Add(new Employee { Name = "Alice" });
employees.Add("Invalid Entry"); // No type safety


EmployeeList employeesGeneric = new EmployeeList();

// Type-safe addition
employeesGeneric.Add(new Employee { Name = "Alice" });
employeesGeneric.Add(new Employee { Name = "Bob" });

//employeesGeneric.Add("Invalid Entry");//Invalid, compile error

// Custom behavior
employeesGeneric.DisplayAll();


foreach (var item in employees)
{
    // Type casting required
    if (item is Employee emp)
    {
        Console.WriteLine(emp.Name);
    }
}
Console.ReadLine();

public class Employee
{
    public string Name { get; set; }
}

class EmployeeList : List<Employee>
{
    // Add custom behavior or constraints if needed
    public void DisplayAll()
    {
        foreach (var emp in this)
        {
            Console.WriteLine(emp.Name);
        }
    }
}