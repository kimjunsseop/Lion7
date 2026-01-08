using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            A c = new B();
            a.shoot();
            b.shoot();
            c.shoot();
            c.hello();

        }
    }
    class A
    {
        public virtual void shoot()
        {
            Console.WriteLine("parent shoot");
        }
        public virtual void hello()
        {
            Console.WriteLine("parent hello");
        }
    }

    class B : A
    {
        public override void shoot()
        {
            Console.WriteLine("child shoot");
        }
        public void hello()
        {
            Console.WriteLine("child hello");
        }
    }
}
