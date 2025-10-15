namespace Basic.MyLinq.Projection;

public class MySelect
{
    private readonly List<dynamic> _data = [];
    
    public MySelect()
    {
        for (var i = 1; i < 5; i++)
            _data.Add(new
            {
                Id = i,
                Name = $"Name {i}",
                Age = i
            });
    }
    
    public void FuncSelect()
    {
        Console.WriteLine("选择数据对象：");
        var dataSelect = _data.Select(x => x).ToList();
        dataSelect.ForEach(x => Console.WriteLine(x));
    }
}