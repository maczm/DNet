namespace Basic.MyLinq.Set;

public class MyUnionBy
{
    private readonly string[] _words1 = ["the", "quick", "brown", "fox"];
    private readonly string[] _words2 = ["jumped", "over", "the", "lazy", "dog"];
    
    public void FuncUnionBy()
    {
        Console.WriteLine("Union扩展");
        var union = _words1.UnionBy(_words2, w1 => w1).ToList();
        union.ForEach(Console.WriteLine);
    }
}