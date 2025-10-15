namespace Basic.MyLinq.Set;

public class MyExcept
{
    private readonly List<int> _first = [1, 2, 3, 4, 5, 6];
    private readonly List<int> _second = [4, 5, 6, 7, 8, 9];
    
    public void FuncExcept()
    {
        Console.WriteLine("获取第一个集合中存在但第二个集合中不存在的元素：");
        var except = _first.Except(_second).ToList();
        except.ForEach(Console.WriteLine);
    }
}