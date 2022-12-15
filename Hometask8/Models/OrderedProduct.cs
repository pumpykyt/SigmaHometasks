namespace Hometask8.Models;

public class OrderedProduct
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public uint Quantity { get; set; }

    public OrderedProduct(string name, string brand, uint quantity)
    {
        Name = name;
        Brand = brand;
        Quantity = quantity;
    }

    public override string ToString() => $"Name: {Name}\tBrand: {Brand}\tQuantity: {Quantity}";
}