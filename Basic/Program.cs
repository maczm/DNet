using Basic.MyLinq;

namespace Basic;

public class Program
{
    public static void Main(string[] args)
    {
        string[] menuItems =
        {
            "1：MyWhere",
            "2：MyZip",
            "3：MySelectMany",
            "4：MySelect"
        };
        var selectedIndex = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("请选择要运行的函数（方向键选择，回车执行）：\n");
            for (var i = 0; i < menuItems.Length; i++)
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"> {menuItems[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  {menuItems[i]}");
                }

            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.UpArrow)
            {
                selectedIndex = (selectedIndex - 1 + menuItems.Length) % menuItems.Length;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                selectedIndex = (selectedIndex + 1) % menuItems.Length;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                switch (selectedIndex)
                {
                    case 0:
                        MyWhere.FuncWhere();
                        break;
                    case 1:
                        MyZip.FuncZip();
                        break;
                    case 2:
                        MySelectMany.FuncSelectMany();
                        break;
                    case 3:
                        MySelect.FuncSelect();
                        break;
                }

                Console.WriteLine("\n按任意键返回菜单...");
                Console.ReadKey(true);
            }
        }
    }
}