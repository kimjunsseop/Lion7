using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp6
{
    //class Character
    //{
    //    protected string name;
    //    protected int level;
    //    protected int hp;
    //    protected int maxHP;
    //    protected int attack;
    //    protected int defense;

    //    public Character()
    //    {
    //        this.name = "default";
    //        this.level = 1;
    //        this.maxHP = 100;
    //        this.hp = maxHP;
    //        this.attack = 30;
    //        this.defense = 20;
    //        Console.WriteLine($"캐릭터 {this.name} 생성!");
    //    }

    //    public Character(string characterName)
    //    {
    //        this.name = characterName;
    //        this.level = 1;
    //        this.maxHP = 100;
    //        this.hp = maxHP;
    //        this.attack = 30;
    //        this.defense = 20;
    //        Console.WriteLine($"캐릭터 {this.name} 생성!");
    //    }

    //    public virtual void ShowInfo()
    //    {
    //        Console.WriteLine($"이름: {this.name}");
    //        Console.WriteLine($"레벨: {this.level}");
    //        Console.WriteLine($"HP: {this.hp} / {this.maxHP}");
    //        Console.WriteLine($"공격력: {this.attack}");
    //        Console.WriteLine($"방어력: {this.defense}");
    //    }
    //}

    //class Warrior : Character
    //{
    //    private int rage;
    //    public Warrior(string characterName) : base(characterName)
    //    {
    //        this.attack = 60;
    //        this.defense = 60;
    //        this.maxHP = 150;
    //        this.hp = maxHP;
    //        this.rage = 0;
    //        Console.WriteLine("직업은 전사");
    //    }

    //    public override void ShowInfo()
    //    {
    //        base.ShowInfo();
    //        Console.WriteLine($"분노 : {this.rage}");
    //    }
    //}

    public class Character
    {
        public virtual void Render()
        {
            Console.WriteLine("캐릭터");
        }
    }

    public class Warrior : Character 
    {
        public override void Render()
        {
            Console.WriteLine("워리어");
        }

        public void Hi()
        {
            Console.WriteLine("hi");
        }
    }

    public class Mage : Warrior
    {
        public override void Render()
        {
            Console.WriteLine("마법사");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Warrior warrior = new Warrior("kim");
            //warrior.ShowInfo();
            //Character c = new Character("lee");
            //c.ShowInfo();
            //c = warrior;
            //warrior.ShowInfo();

            Character c = new Character();
            Character b = new Warrior();
            Character a = new Mage();

            Warrior w = new Warrior();
            Warrior k = new Mage();

            Mage m = new Mage();
            c.Render();
            b.Render();
            a.Render();
            w.Render();
            k.Render();
            m.Render();
            c = w;
            c.Render();
            c = m;
            c.Render();

            //이건 안됨
            //Warrior wa = new Character();

            //이런식으로 미리 Warrior 객체였다면 다운캐스팅은 됨
            Character character = new Warrior();
            Warrior warrior = (Warrior)character;

            // as 연산자를 통한 다운 캐스팅
            Character z = new Warrior();
            Warrior w1 = z as Warrior;

            w1.Render();
            
            // is 연산자 문법
            //if(character is Warrior)
            //{
            //    warrior.Render();
            //}
        }
    }
}
