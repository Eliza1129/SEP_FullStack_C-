// See https://aka.ms/new-console-template for more information

using System;
using Generic_Repository_Pattern;
using Generic_Repository_Pattern.Repository;
class Program
{
    static void Main()
    {
        IRepository<Product> productRepository = new GenericRepository<Product>();

        
        Product p1 = new Product { Id = 1, Name = "Laptop", Price = 999.99 };
        Product p2 = new Product { Id = 2, Name = "Smartphone", Price = 1599.99 };

        productRepository.Add(p1);
        productRepository.Add(p2);
        
        productRepository.Save();

       
        Console.WriteLine("All Products:");
        foreach (var product in productRepository.GetAll())
        {
            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }

        
        Console.WriteLine("\nFetching product with ID 1:");
        var retrievedProduct = productRepository.GetById(1);
        if (retrievedProduct != null)
        {
            Console.WriteLine($"ID: {retrievedProduct.Id}, Name: {retrievedProduct.Name}, Price: {retrievedProduct.Price}");
        }

        
        productRepository.Remove(p1);
        Console.WriteLine("\nProduct with ID 1 removed.");

        
        Console.WriteLine("\nUpdated Product List:");
        foreach (var product in productRepository.GetAll())
        {
            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }
    }
}
