using Hometask3.Classes;

namespace Hometask8.Interfaces;

public interface IProductOrder
{
    bool ProcessOrder(Storage storage);
    Task InitFromFileAsync(string filePath);
}