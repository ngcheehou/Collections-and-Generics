// See https://aka.ms/new-console-template for more information



Employee employee1 = new Employee()
{ Name = "Alice" };

Employee employee2 = new Employee()
{ Name = "Bob" };


var managers = new List<Manager>
        {
            new Manager { Name = "Alice", Department = "HR" },
            new Manager { Name = "Bob", Department = "IT" }
        };

Manager m = new Manager { Name = "Charlie", Department = "HR" };

CovariancePrinter(managers);
PrintInfo(m);
Console.ReadLine();

 void PrintInfo<T>(T obj) where T : Employee
{
    if (obj is Manager manager)
    {
        Console.WriteLine($"Manager: {manager.Name}, Department: {manager.Department}");
    }
    else
    {
        Console.WriteLine($"Employee: {obj.Name}");
    }
}


void CovariancePrinter(IEnumerable<Employee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine(employee.Name);
    }

}
    void EmployeePrinter(List<Employee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine(employee.Name);
    }
}


void ManagerPrinter(List<Employee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine(employee.Name);
    }
}

public class Employee
{
    public string Name { get; set; }
}

public class Manager : Employee
{
    public string Department { get; set; }
}


