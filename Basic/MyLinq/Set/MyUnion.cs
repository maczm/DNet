namespace Basic.MyLinq.Set;

public class MyUnion
{
    private readonly string[] _words1 = ["the", "quick", "brown", "fox"];
    private readonly string[] _words2 = ["jumped", "over", "the", "lazy", "dog"];
    
    public void FuncUnion()
    {
        Console.WriteLine("获取两个集合的并集：");
        var union = _words1.Union(_words2).ToList();
        union.ForEach(Console.WriteLine);
    }
}