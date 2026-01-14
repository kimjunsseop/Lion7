using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Thing
    {
        protected string name;
        protected double price;
        protected int discount;

        public Thing()
        {
            this.name = "물건";
            this.price = 0;
            this.discount = 0;
        }

        public virtual void Show()
        {
            Console.WriteLine($"{name}입니다.");
            Console.WriteLine($"{discount}% 할인합니다.");
            Console.WriteLine($"할인가 : {price * ((100 - discount) / 100)}");
        }
    }

    class Banana : Thing
    {
        public Banana()
        {
            this.name = "바나나";
            this.price = 2000;
            this.discount = 17;
        }

        public override void Show()
        {
            base.Show();
        }

        public void Info()
        {
            Console.WriteLine("맛있습니다~");
        }
    }
    
    class Apple : Thing
    {
        public Apple()
        {
            this.name = "사과";
            this.price = 1500;
            this.discount = 15;
        }

        public override void Show()
        {
            base.Show();
        }

        public void Info()
        {
            Console.WriteLine("신선합니다~");
        }
    }

    class Meat : Thing
    {
        public Meat()
        {
            this.name = "고기";
            this.price = 5000;
            this.discount = 30;
        }
        public override void Show()
        {
            base.Show();
        }
        
        public void Info()
        {
            Console.WriteLine("저렴합니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Thing[] things = new Thing[10];
            Random rand = new Random();
            for (int i = 0; i < things.Length; i++)
            {
                int rb = rand.Next(1, 4);
                if(rb == 1)
                {
                    things[i] = new Apple();
                }
                else if(rb == 2)
                {
                    things[i] = new Banana();
                }
                else
                {
                    things[i] = new Meat();
                }
            }

            for(int i = 0;i < things.Length;i++)
            {
                switch (things[i])
                {
                    case Apple a:
                        a.Show();
                        a.Info();
                        break;
                    case Banana b:
                        b.Show();
                        b.Info();
                        break;
                    case Meat c:
                        c.Show();
                        c.Info();
                        break;
                }
            }
        }
    }
}
