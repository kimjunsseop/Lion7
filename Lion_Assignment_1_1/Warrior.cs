using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1_1
{
    public class Warrior : Player
    {
        public int attackPower;
        public int defense;
        public Warrior()
        {
            this.strName = "전사";
            this.maxHP = 100;
            this.iHp = 100;
            this.attackPower = 10;
            this.defense = 10;
            this.inventory = new Inventory();

        }
        public override void SetDamage(int iAttack)
        {
            if(this.defense <= iAttack)
            {
                iHp -= (iAttack - this.defense);
            }
        }
        public override int attack()
        {
            return this.attackPower;
        }
        public override void Render()
        {
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("▶ " + strName + " ◀");
            Console.WriteLine("❤️ : " + iHp + "\t🗡️ : " + attackPower);
            Console.WriteLine("🛡️ : " + defense);
            inventory.ShowInventory();
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine();
        }

        public override void useHealItem()
        {
            if (inventory != null)
            {
                if (inventory.healItem <= 0)
                {
                    Console.WriteLine("물약이 없습니다");
                }
                else
                {
                    inventory.healItem--;
                    iHp += 30;
                    if (iHp >= maxHP)
                    {
                        iHp = maxHP;
                    }
                }
            }
        }
        public override void ShowDetail()
        {
            while (true)
            {
                Console.Clear();
                int iInput;
                Console.WriteLine("=================");
                Console.WriteLine($"직업 : {strName}");
                Console.WriteLine($"현재 체력 : {iHp}");
                Console.WriteLine($"공격력 : {attackPower}");
                Console.WriteLine($"방어력 : {defense}");
                Console.WriteLine("=================");
                Console.WriteLine("1. 나가기");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1) break;
            }
        }
    }
}

