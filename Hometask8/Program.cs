using System.Text.RegularExpressions;
using Hometask1;
using Hometask1.Enums;
using Hometask3.Classes;
using Hometask8;
using Hometask8.Handlers;

var array1 = new Product[]
{
    new ("Crisps", "Lays", 100, Currency.UAH, 300, WeightUnit.Gram),
    new ("Fanta", "Cola", 100, Currency.UAH, 250, WeightUnit.Gram),
    new ("Mirinda", "Pepsi", 100, Currency.UAH, 750, WeightUnit.Gram),
    new ("Mirinda", "Pepsi", 100, Currency.UAH, 750, WeightUnit.Gram),
    new ("Carrot", "NashSvit", 100, Currency.UAH, 2, WeightUnit.Kilo)
};

var array2 = new Product[]
{
    new ("Chocolate", "Milka", 100, Currency.UAH, 500, WeightUnit.Gram),
    new ("Pepsi", "Pepsi", 50, Currency.UAH, 1, WeightUnit.Kilo),
    new ("Pepsi", "Pepsi", 50, Currency.UAH, 1, WeightUnit.Kilo),
    new ("Pepsi", "Pepsi", 50, Currency.UAH, 1, WeightUnit.Kilo),
    new ("Crisps", "Lays", 100, Currency.UAH, 300, WeightUnit.Gram),
    new ("Fanta", "Cola", 100, Currency.UAH, 250, WeightUnit.Gram),
    new ("Fanta", "Cola", 100, Currency.UAH, 250, WeightUnit.Gram),
    new ("Fanta", "Cola", 100, Currency.UAH, 250, WeightUnit.Gram),
    new ("Mirinda", "Pepsi", 100, Currency.UAH, 750, WeightUnit.Gram),
    new ("Mirinda", "Pepsi", 100, Currency.UAH, 750, WeightUnit.Gram),
    new ("Mirinda", "Pepsi", 100, Currency.UAH, 750, WeightUnit.Gram),
    new ("Mirinda", "Pepsi", 100, Currency.UAH, 750, WeightUnit.Gram),
    new ("Carrot", "NashSvit", 100, Currency.UAH, 2, WeightUnit.Kilo)
};

var storage1 = new Storage(array1);
var storage2 = new Storage(array2);
var productOrder = new ProductOrder("test.txt");
var productOrderHandlers = new ProductOrderHandlers();
productOrder.NotEnoughProductsEvent += productOrderHandlers.onNotEnoughProductsEvent;

var canBeProcessed1 = productOrder.ProcessOrder(storage1);
var canBeProcessed2 = productOrder.ProcessOrder(storage2);
Console.WriteLine($"Example 1: {canBeProcessed1}\tExample 2: {canBeProcessed2}");