namespace Basic.MyLinq;

internal static class MyWhere
{
    public static void FuncWhere()
    {
        Console.WriteLine("Linq Where ==================================================================================== END");
        List<int> numbers = [1, 2, 3];
        var where = numbers.Where(n => n > 1).ToList();
        where.ForEach(Console.WriteLine);
    }
}