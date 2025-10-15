namespace Basic.MyLinq;

internal static class MySelect
{
    public static void FuncSelect()
    {
        Console.WriteLine("选择数据对象：");
        var data = new List<dynamic>();
        for (var i = 1; i < 5; i++)
            data.Add(new
            {
                Id = i,
                Name = $"Name {i}",
                Age = i
            });
        var dataSelect = data.Select(x => x).ToList();
        dataSelect.ForEach(x => Console.WriteLine(x));
    }
}