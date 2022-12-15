using Hometask1;
using Hometask3.Classes;
using Hometask8.Extensions;
using Hometask8.Interfaces;
using Hometask8.Models;

namespace Hometask8;

public class ProductOrder
{
    public delegate void NotEnoughProductsDelegate();
    public event NotEnoughProductsDelegate NotEnoughProductsEvent;

    public List<OrderedProduct> OrderedProducts { get; set; }

    public ProductOrder(string filePath) => InitFromFile(filePath);

    public bool ProcessOrder(Storage storage)
    {
        foreach (var item in OrderedProducts)
        {
            Func<Product, bool> func = t => t.Brand == item.Brand && 
                                            t.Name == item.Name;

            if (storage.Products.Count(func) < item.Quantity)
            {
                NotEnoughProductsEvent();
                return false;
            }
        }
        return true;
    }

    private void InitFromFile(string filePath)
    {
        var data = File.ReadAllText(filePath);
        OrderedProducts = data.Split('\n')
                              .Select(t => t.Trim().ParseFromString())
                              .ToList();
    }
}