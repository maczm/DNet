namespace Basic.MyLinq.Sort;

public class MyOrderBy
{
    private readonly int[] _numbers = [5, 1, 3, 2, 4];
    
    public void FuncOrderBy()
    {
        Console.WriteLine("正序：");
        var orderBy = _numbers.OrderBy(n => n).ToList();
        orderBy.ForEach(Console.WriteLine);
    }
}