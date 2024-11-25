
IRepository<Product> productRepository = new GenericProductRepository();

// Add products
productRepository.Add(new Product { Id = 1, Name = "Laptop", Price = 1500.00m });
productRepository.Add(new Product { Id = 2, Name = "Phone", Price = 800.00m });

// Retrieve and display all products
foreach (var product in productRepository.GetAll())
{
    Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
}


Console.ReadLine(  );


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}


public interface IRepository<T>//Generic Interface
{
    void Add(T item);
    T GetById(int id);
    IEnumerable<T> GetAll();
    void Update(T item);
    void Delete(int id);
}


public interface IProductRepository//conventional Interface
{
    void Add(Product product);
    Product GetById(int id);
    IEnumerable<Product> GetAll();
    void Update(Product product);
    void Delete(int id);
}

public interface ICustomerRepository
{
    void Add(Customer customer);
    Customer GetById(int id);
    IEnumerable<Customer> GetAll();
    void Update(Customer customer);
    void Delete(int id);
}//conventional Interface


//implementation of conventional Interface
public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new();

    public void Add(Product product) => _products.Add(product);
    public Product GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
    public IEnumerable<Product> GetAll() => _products;
    public void Update(Product product)
    {
        var existing = GetById(product.Id);
        if (existing != null)
        {
            existing.Name = product.Name;
            existing.Price = product.Price;
        }
    }
    public void Delete(int id) => _products.RemoveAll(p => p.Id == id);
}

//Implementation of generic Interface
public class GenericProductRepository : IRepository<Product>
{
    private readonly List<Product> _products = new();

    public void Add(Product item) => _products.Add(item);

    public Product GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

    public IEnumerable<Product> GetAll() => _products;

    public void Update(Product item)
    {
        var existing = GetById(item.Id);
        if (existing != null)
        {
            existing.Name = item.Name;
            existing.Price = item.Price;
        }
    }

    public void Delete(int id) => _products.RemoveAll(p => p.Id == id);
}