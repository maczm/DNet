using Basic.MyLinq.Filter;
using Basic.MyLinq.Projection;
using Basic.MyLinq.Set;
using Basic.MyLinq.Sort;

namespace Basic;

public class ConsoleMenu
{
    private readonly Dictionary<string, Action> _menuItems;
    private int _selectedIndex;
    private readonly string[] _menuKeys;

    public ConsoleMenu()
    {
        _menuItems = new Dictionary<string, Action>
        {
            ["MyWhere"] = () => new MyWhere().FuncWhere(),
            ["MyZip"] = () => new MyZip().FuncZip(),
            ["MySelectMany"] = () => new MySelectMany().FuncSelectMany(),
            ["MySelect"] = () => new MySelect().FuncSelect(),
            ["MyDistinct"] = () => new MyDistinct().FuncDistinct(),
            ["MyDistinctBy"] = () => new MyDistinctBy().FuncDistinctBy(),
            ["MyExcept"] = () => new MyExcept().FuncExcept(),
            ["MyExceptBy"] = () => new MyExceptBy().FuncExceptBy(),
            ["MyIntersect"] = () => new MyIntersect().FuncIntersect(),
            ["MyIntersectBy"] = () => new MyIntersectBy().FuncIntersectBy(),
            ["MyUnion"] = () => new MyUnion().FuncUnion(),
            ["MyUnionBy"] = () => new MyUnionBy().FuncUnionBy(),
            ["MyOrderBy"] = () => new MyOrderBy().FuncOrderBy(),
            ["MyOrderByDescending"] = () => new MyOrderByDescending().FuncOrderByDescending(),
        };
        
        _menuKeys = _menuItems.Keys.ToArray();
    }

    public void FuncConsoleMenu()
    {
        while (true)
        {
            DisplayMenu();
            
            var key = Console.ReadKey(true);
            if (!HandleInput(key))
                break;
        }
    }
    
    private void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("请选择要运行的函数（方向键选择，回车执行，按 Q/Esc 退出）：\n");
        
        for (var i = 0; i < _menuKeys.Length; i++)
        {
            if (i == _selectedIndex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"> {_menuKeys[i]}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"  {_menuKeys[i]}");
            }
        }
    }
    
    private bool HandleInput(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                _selectedIndex = (_selectedIndex - 1 + _menuKeys.Length) % _menuKeys.Length;
                return true;
                
            case ConsoleKey.DownArrow:
                _selectedIndex = (_selectedIndex + 1) % _menuKeys.Length;
                return true;
                
            case ConsoleKey.Enter:
                ExecuteSelectedAction();
                return true;
                
            case ConsoleKey.Q:
            case ConsoleKey.Escape:
                Console.Clear();
                Console.WriteLine("程序已退出，再见！");
                Thread.Sleep(1000);
                return false;
                
            default:
                return true;
        }
    }
    
    private void ExecuteSelectedAction()
    {
        Console.Clear();
        _menuItems[_menuKeys[_selectedIndex]]();
        Console.WriteLine("\n按任意键返回菜单...");
        Console.ReadKey(true);
    }
}