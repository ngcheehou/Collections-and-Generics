
var org = new Organization<Manager, CodingTask>
{
    Leader = new Manager { Name = "Alice", TeamSize = 5 },
    Task = new CodingTask()
};

//var org2 = new Organization<InternStaff, AccountingTask>
//{
//    Leader = new InternStaff { Name = "Alice", TeamSize = 5 },
//    Task = new AccountingTask()
//};



org.AssignTask();
Console.ReadLine();

 


public class Employee
{
    public string Name { get; set; }
}

public class Manager : Employee
{
    public int TeamSize { get; set; }
}

public class InternStaff 
{
    public int TeamSize { get; set; }
}


public interface IWork
{
    void PerformWork();
}

public class CodingTask : IWork
{
    public void PerformWork()
    {
        Console.WriteLine("Writing code...");
    }
}

public class AccountingTask  
{
    public void PerformWork()
    {
        Console.WriteLine("Do some accounting report...");
    }
}



public class Organization<TEmployee, TWork>
    where TEmployee : Employee, new()      

    where TWork : IWork                     

{
    public TEmployee Leader { get; set; }
    public TWork Task { get; set; }


    public Organization()
    {
        Leader = new TEmployee(); // Using parameterless constructor constraint
    }

    public void AssignTask()
    {
        Console.WriteLine($"{Leader.Name} is assigning the task.");
        Task.PerformWork(); // Calling method from IWork constraint
    }

}

