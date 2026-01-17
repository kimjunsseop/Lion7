using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            MainGame mg = new MainGame();
            mg.Initialize();
            mg.Progress();
        }
    }
}
