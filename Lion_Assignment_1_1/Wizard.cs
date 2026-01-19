using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1_1
{
    public class Wizard : Player
    {
        public int mp;
        public int maxMP;
        public int mpPower;
        public Wizard()
        {
            this.strName = "마법사";
            this.maxHP = 70;
            this.iHp = maxHP;
            this.maxMP = 50;
            this.mpPower = 40;
            this.mp = maxMP;
            this.defense = 0;
            this.inventory = new Inventory();
        }

        public override int attack()
        {
            if (this.mp > 0)
            {
                mp -= 15;
                return mpPower;
            }
            return 0;
        }

        public override void Render()
        {
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("▶ " + strName + " ◀");
            Console.WriteLine("❤️(체력) : " + iHp + "\t\U0001f9f9(마력) : " + mpPower);
            Console.WriteLine($"🩹(mp) : {mp}/{maxMP}");
            if(inventory.isGapot == true)
            {
                Console.WriteLine("🛡️(방어력) : " + defense);
            }
            if (inventory.holdItem != null)
            {
                Console.WriteLine($"장착 아이템 : {inventory.holdItem.Name}  추가 데미지 : {inventory.holdItem.AddAtk}");
            }
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
                Console.WriteLine($"마력 : {mpPower}");
                Console.WriteLine($"남은 마나 : {mp}");
                Console.WriteLine("=================");
                Console.WriteLine("1. 나가기");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1) break;
            }
        }
    }
}
