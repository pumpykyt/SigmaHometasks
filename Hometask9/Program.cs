using Hometask1;
using Hometask1.Enums;
using Hometask9.Implementations;
using Hometask9.Interfaces;

var products = new List<Product>
{
    new ("Crisps", "Lays", 140, Currency.UAH, 300, WeightUnit.Gram),
    new ("Fanta", "Cola", 120, Currency.UAH, 250, WeightUnit.Gram),
    new ("Mirinda", "Pepsi", 160, Currency.UAH, 750, WeightUnit.Gram),
    new ("Mirinda", "Pepsi", 150, Currency.UAH, 750, WeightUnit.Gram),
    new ("Carrot", "NashSvit", 145, Currency.UAH, 2, WeightUnit.Kilo)
};

var problems = new List<IProblemSolver> { new Problem1Solver("data.txt"), new Problem2Solver(products) };
problems.ForEach(t => t.Solve());
