using Hometask1;
using Hometask1.Enums;
using Hometask2.Interfaces;
using Hometask3.Classes;

namespace Hometask7.Implementations;

public class Problem1Solver : IProblemSolver
{
    private void Output(List<Product> data) => data.ForEach(t => Console.WriteLine(t.ToString())); 
    
    public void Solve()
    {
        Console.WriteLine("Problem 1");
        
        var products = new List<Product>
        {
            new("Milka", "NashSvit", 20, Currency.UAH, 1000, WeightUnit.Gram),
            new("Artek", "NashSvit", 24, Currency.UAH, 500, WeightUnit.Gram),
            new("Cola", "NashSvit", 12, Currency.UAH, 1000, WeightUnit.Gram),
            new("Pepsi", "NashSvit", 15, Currency.UAH, 500, WeightUnit.Gram),
            new("Lays", "NashSvit", 15, Currency.UAH, 1000, WeightUnit.Gram),
            new("Fanta", "NashSvit", 16, Currency.UAH, 750, WeightUnit.Gram),
            new("Pepsi", "NashSvit", 12, Currency.UAH, 450, WeightUnit.Gram),
            new("Milka", "NashSvit", 20, Currency.UAH, 1000, WeightUnit.Gram),
            new("Bonaqua", "NashSvit", 51, Currency.UAH, 300, WeightUnit.Gram),
            new("Pepsi", "NashSvit", 15, Currency.UAH, 500, WeightUnit.Gram)
        };
        
        var storage1 = new Storage(products.Take(5).ToArray());
        var storage2 = new Storage(products.Skip(5).Take(5).ToArray());
        
        //Task 1.1
        var result1 = storage1.Products.Where(t1 => !storage2.Products.Any(t2 => t2.Equals(t1)))
                                       .ToList();
        //Task 1.2
        var result2 = storage1.Products.Intersect(storage2.Products)
                                       .ToList();
        //Task 1.3
        var result3 = storage1.Products.Intersect(storage2.Products)
                                       .Distinct()
                                       .ToList();
        
        Console.WriteLine("Task 1.1");
        Output(result1);
        Console.WriteLine("Task 1.2");
        Output(result2);
        Console.WriteLine("Task 1.3");
        Output(result3);
    }
}