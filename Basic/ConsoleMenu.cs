using Basic.MyLinq.Filter;
using Basic.MyLinq.Projection;
using Basic.MyLinq.Set;

namespace Basic;

public class ConsoleMenu
{
    private readonly string[] _menuItems =
    [
        "1：MyWhere",
        "2：MyZip",
        "3：MySelectMany",
        "4：MySelect",
        "5：MyDistinct",
        "6：MyDistinctBy",
        "7：MyExcept",
        "8：MyExceptBy"
    ];

    private int _selectedIndex;

    public void FuncConsoleMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("请选择要运行的函数（方向键选择，回车执行，按 Q/Esc 退出）：\n");
            for (var i = 0; i < _menuItems.Length; i++)
                if (i == _selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"> {_menuItems[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  {_menuItems[i]}");
                }

            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.UpArrow)
            {
                _selectedIndex = (_selectedIndex - 1 + _menuItems.Length) % _menuItems.Length;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                _selectedIndex = (_selectedIndex + 1) % _menuItems.Length;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                switch (_selectedIndex)
                {
                    case 0:
                        new MyWhere().FuncWhere();
                        break;
                    case 1:
                        new MyZip().FuncZip();
                        break;
                    case 2:
                        new MySelectMany().FuncSelectMany();
                        break;
                    case 3:
                        new MySelect().FuncSelect();
                        break;
                    case 4:
                        new MyDistinct().FuncDistinct();
                        break;
                    case 5:
                        new MyDistinctBy().FuncDistinctBy();
                        break;
                    case 6:
                        new MyExcept().FuncExcept();
                        break;
                    case 7:
                        new MyExceptBy().FuncExceptBy();
                        break;
                }

                Console.WriteLine("\n按任意键返回菜单...");
                Console.ReadKey(true);
            }
            else if (key.KeyChar is 'q' or 'Q' || key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("程序已退出，再见！");
                Thread.Sleep(1000); // 等待1秒后退出，让用户看到退出消息
                break;
            }
        }
    }
}