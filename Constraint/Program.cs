

EmployeeIT emp = new EmployeeIT
{
    Id = 101,
    Name = "Alice",
    Description = "IT Department"
};

EmployeeFinance emp2 = new EmployeeFinance
{
    Id = 102,
    Name = "Bob",
    Description = "Finance Department"
};

Product product = new Product
{
    Id = 2001,
    Name = "T-Shirt",
    Description = "Green Colour",
    Price = 30.0
};

PrintEmployeeInformation<EmployeeIT> printer1 = new PrintEmployeeInformation<EmployeeIT>();
printer1.DisplayIdAndName(emp);

PrintEmployeeInformation<EmployeeFinance> printer2 = new PrintEmployeeInformation<EmployeeFinance>();
printer2.DisplayIdAndName(emp2);


PrintProductInformation<Product> printer3 = new PrintProductInformation<Product>();
printer3.DisplayIdAndName(product);



Console.ReadLine();

public class PrintEmployeeInformation<T> where T : class, IEmployee
{
    public void DisplayIdAndName(T Entity)
    {
        Console.WriteLine($"Employee ID: {Entity.Id} , Employee Name: {Entity.Name}, Description: {Entity.Description}");
    }

}


public class PrintProductInformation<T> where T : class, IProduct
{
    public void DisplayIdAndName(T Entity)
    {
        Console.WriteLine($"Product ID: {Entity.Id} , Product Name: {Entity.Name}, Description: {Entity.Description}");
    }

}




public interface IEmployee
{
    int Id { get; set; }
    string Name { get; set; }
    string Description { get; set; }
}


public interface IProduct
{
    int Id { get; set; }
    string Name { get; set; }
    string Description { get; set; }
}
public class EmployeeIT : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public void Programming()
    {
        Console.WriteLine("I can do programming");
    }
}


public class EmployeeFinance : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public void FInanceReport()
    {
        Console.WriteLine("I can do finance report");
    }
}

public class Product : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }


}


