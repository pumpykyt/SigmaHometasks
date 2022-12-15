﻿using Hometask1;
using Hometask1.Enums;
using Hometask3.Enums;
using Type = System.Type;

namespace Hometask3.Classes;

public class DairyProduct : Product
{
    private uint _expirationDate;

    public DairyProduct(string name, string brand, decimal price, Currency currency, 
                        double weight, WeightUnit weightUnit, uint expirationDate) 
        : base(name, brand, price, currency, weight, weightUnit) 
        => _expirationDate = expirationDate;

    public override void ChangePrice(decimal percents)
    {
        base.ChangePrice(percents);
        if (_expirationDate <= 180)
        {
            Price = (Price.Value + Price.Value * 100 / Constraints.HalfYearExpiration, Price.Currency);
            return;
        }
        Price = (Price.Value + Price.Value * 100 / Constraints.YearExpiration, Price.Currency);
    }
    
    public override void ConsoleInput()
    {   
        Console.WriteLine("Dairy product: ");
        base.ConsoleInput();
        Console.Write("Input expiration date: ");
        _expirationDate = Convert.ToUInt32(Console.ReadLine());
    }
    
    public override string ToString() => base.ToString() + $"\texpiration date(in days): {_expirationDate}";

    public override bool Equals(object? obj) => base.Equals(obj) && 
                                                _expirationDate == ((DairyProduct)obj)._expirationDate;


    public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), (int)_expirationDate);
    
    public DairyProduct() { }
}