using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 10;
            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            while(true)
            {
                Console.Clear();

                Console.SetCursorPosition(x, y);

                Console.Write("●");
                keyInfo = Console.ReadKey(true); // 키 입력받기

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 0) y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if(y < Console.WindowHeight - 1) y++;
                        break ;
                    case ConsoleKey.LeftArrow:
                        if(x > 0) x--;
                        break;
                    case ConsoleKey.RightArrow:
                        if(x < Console.WindowWidth - 1) x++;
                        break ;
                    case ConsoleKey.Spacebar:
                        Console.Write("미사일키");
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        break;
                }

            }

        }
    }
}
