using Hometask8.Models;

namespace Hometask8.Extensions;

public static class StringExtensions
{
    public static OrderedProduct ParseFromString(this string input)
    {
        var temp = input.Split(' ');
        return new OrderedProduct(temp[0], temp[1], Convert.ToUInt32(temp[2]));
    }
}