using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {

        //abstract class Character
        //{
        //    protected string name;
        //    protected int hp;
        //    protected int speed;

        //    public Character(string name, int hp, int speed)
        //    {
        //        this.name = name;
        //        this.hp = hp;
        //        this.speed = speed;
        //    }

        //    public abstract void ShowInfo();
        //}

        //class Warrior : Character
        //{
        //    public int attack;
        //    public int defense;
        //    public Warrior(string name, int hp, int speed) : base(name, hp, speed)
        //    {
        //        this.attack = 80;
        //        this.defense = 50;
        //    }
        //    public override void ShowInfo()
        //    {
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        //        Console.WriteLine($"[전사] {name}");
        //        Console.WriteLine($"HP: {hp}/{hp}");
        //        Console.WriteLine($"공격력: {attack}");
        //        Console.WriteLine($"방어력: {defense}");
        //        Console.WriteLine($"이동속도: {speed}");
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        //    }

        //}
        //class Mage : Character
        //{
        //    public int m;
        //    public int mp;
        //    public Mage(string name, int hp, int speed) : base(name, hp, speed)
        //    {
        //        this.m = 150;
        //        this.mp = 100;
        //    }
        //    public override void ShowInfo()
        //    {
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        //        Console.WriteLine($"[마법사] {name}");
        //        Console.WriteLine($"HP: {hp}/{hp}");
        //        Console.WriteLine($"마력: {m}");
        //        Console.WriteLine($"마나: {mp}");
        //        Console.WriteLine($"이동속도: {speed}");
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        //    }
        //}
        //class Archer : Character
        //{
        //    public int bow;
        //    public Archer(string name, int hp, int speed) : base(name, hp, speed)
        //    {
        //        this.bow = 50;
        //    }
        //    public override void ShowInfo()
        //    {
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        //        Console.WriteLine($"[궁수] {name}");
        //        Console.WriteLine($"HP: {hp}/{hp}");
        //        Console.WriteLine($"화살: {bow}");
        //        Console.WriteLine($"이동속도: {speed}");
        //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        //    }
        //}

        interface IAttackable
        {
            void Attack(string target);
            int GetAttackPower();
        }
        interface IDefenderble
        {
            void Defend();
            int GetDefensePower();
        }

        class Knight : IAttackable, IDefenderble
        {
            private string name;
            private int attackPower;
            private int defensePower;

            public Knight()
            {
                this.name = "검사";
                this.attackPower = 10;
                this.defensePower = 10;
            }
            public void Attack(string target)
            {
                Console.WriteLine($"{target} 공격");
            }
            public int GetAttackPower()
            {
                return attackPower;
            }
            public void Defend()
            {
                Console.WriteLine("방어중");
            }
            public int GetDefensePower()
            {
                return defensePower;
            }
        }

        class Mage : IAttackable  //알트 + 엔터
        {

            public string name;
            public int attackPower;

            public Mage()
            {
                name = "검사";
                attackPower = 10;
            }

            public void Attack(string target)
            {
                Console.WriteLine($"검으로 {target}를 공격 했습니다.");

            }

            public int GetAttackPower()
            {
                return attackPower;
            }
        }
        static void Main(string[] args)
        {
            //Character[] characters = new Character[3];
            //characters[0] = new Warrior("kim", 200, 5);
            //characters[1] = new Mage("lee", 120, 4);
            //characters[2] = new Archer("park", 150, 6);

            //for(int i = 0; i < 3; i++)
            //{
            //    characters[i].ShowInfo();
            //}


            // 인터페이스 타입에 해당 인터페이스와 여러 인터페이스를 다중상속 받은
            // 객체가 해당 타입에 들어갈 수 있다.
            IAttackable attackable = new Knight();

            //인터페이스로 배열을 만들 수 있으며,
            //해당 타입의 인터페이스를 상속받은 객체들은 그 안에 들어갈 수 있다
            IAttackable[] attacker = new IAttackable[2];
            attacker[0] = new Knight();
            attacker[1] = new Mage();

        }
    }
}
