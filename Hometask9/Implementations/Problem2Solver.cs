using System.Diagnostics;
using Hometask1;
using Hometask9.Interfaces;

namespace Hometask9.Implementations;

public class Problem2Solver : IProblemSolver
{
    private readonly List<Product> _data;

    public Problem2Solver(List<Product> data) => _data = data;
    
    private void QuickSort(int left, int right)
    {
        if (left >= right) return;
        var pivot = Partition(left, right);
        if (pivot > 1) QuickSort(left, pivot - 1);
        if (pivot + 1 < right) QuickSort(pivot + 1, right);
    }

    private int Partition(int left, int right)
    {
        var pivot = _data[left].Price.Value;
        
        while (true)
        {
            while (_data[left].Price.Value < pivot) left++;
            while (_data[right].Price.Value > pivot) right--;

            if (left < right)
            {
                if (_data[left].Price.Value == _data[right].Price.Value) return right;
                (_data[left], _data[right]) = (_data[right], _data[left]);
            }
            else 
            {
                return right;
            }
        }
    }
    
    public void Solve()
    {
        Console.WriteLine("After sort: ");
        var watch = Stopwatch.StartNew();
        QuickSort(0, _data.Count - 1);
        watch.Stop();
        var elapsed = watch.ElapsedTicks;
        Console.WriteLine($"Task 2 benchmark(elapsed ticks): {elapsed}");
        _data.ForEach(t => Console.WriteLine(t.ToString()));
    }
}