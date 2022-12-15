namespace Hometask8.Handlers;

public class ProductOrderHandlers
{
    public void onNotEnoughProductsEvent()
    {
        var temp = new ProductOrder("reserve.txt");
        Console.WriteLine("Your order cannot be processed. Not enough product in the storage!");
        Console.WriteLine("Suggested products:");
        temp.OrderedProducts.ForEach(t => Console.WriteLine(t.ToString()));
    }
}