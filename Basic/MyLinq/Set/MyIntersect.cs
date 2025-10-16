namespace Basic.MyLinq.Set;

public class MyIntersect
{
    private readonly string[] _words1 = ["the", "quick", "brown", "fox"];
    private readonly string[] _words2 = ["jumped", "over", "the", "lazy", "dog"];
    
    public void FuncIntersect()
    {
        Console.WriteLine("获取两个集合的交集：");
        var intersect = _words1.Intersect(_words2).ToList();
        intersect.ForEach(Console.WriteLine);
    }
}