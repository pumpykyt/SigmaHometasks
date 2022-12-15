using System.Diagnostics;
using Hometask9.Interfaces;

namespace Hometask9.Implementations;

public class Problem1Solver : IProblemSolver
{
    private string _filePath;

    public Problem1Solver(string filePath) => _filePath = filePath;

    private void Merge(int[] arr, int l, int m, int r)
    {
        var n1 = m - l + 1;
        var n2 = r - m;

        var L = new int[n1];
        var R = new int[n2];
        int i, j;
        
        for (i = 0; i < n1; ++i) L[i] = arr[l + i];
        for (j = 0; j < n2; ++j) R[j] = arr[m + 1 + j];
        
        i = 0;
        j = 0;

        var k = l;
        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
        
        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }
        
        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    private void Sort(int[] arr, int l, int r)
    {
        if (l >= r) return;
        var m = l + (r - l) / 2;
        Sort(arr, l, m);
        Sort(arr, m + 1, r);
        Merge(arr, l, m, r);
    }

    private void SaveResultToFile(object data, string filePath = "result.txt") 
        => File.WriteAllText("result.txt", string.Join(' ', data));
    
    private int[] LoadDataFromFile() => File.ReadAllText(_filePath)
                                            .Split(' ')
                                            .Select(t => Convert.ToInt32(t))
                                            .ToArray();

    public void Solve()
    {
        var data = LoadDataFromFile();
        var watch = Stopwatch.StartNew();
        Sort(data, 0, data.Length - 1);
        watch.Stop();
        var elapsed = watch.ElapsedTicks;
        Console.WriteLine($"Task 1 benchmark(elapsed ticks): {elapsed}");
        SaveResultToFile(string.Join(" ", data));
    }
}