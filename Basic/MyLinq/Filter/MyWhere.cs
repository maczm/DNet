namespace Basic.MyLinq.Filter;

public class MyWhere
{
    private readonly List<int> _numbers = [1, 2, 3];

    public void FuncWhere()
    {
        Console.WriteLine("筛选大于1的数字：");
        var where = _numbers.Where(n => n > 1).ToList();
        where.ForEach(Console.WriteLine);
    }
}