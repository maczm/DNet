namespace Basic.MyLinq.Sort;

public class MyOrderByDescending
{
    private readonly int[] _numbers = [5, 1, 3, 2, 4];
    
    public void FuncOrderByDescending()
    {
        Console.WriteLine("倒序: ");
        var result = _numbers.OrderByDescending(x => x).ToList();
        result.ForEach(Console.WriteLine);
    }
}