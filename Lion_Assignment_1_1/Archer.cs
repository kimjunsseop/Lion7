using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1_1
{
    public class Archer : Player
    {
        public int bowPower;
        public int bowNum;
        public int maxBowNum;

        public Archer()
        {
            this.strName = "궁수";
            this.maxHP = 70;
            this.iHp = maxHP;
            this.bowPower = 30;
            this.bowNum = 5;
            this.maxBowNum = bowNum;
            this.inventory = new Inventory();
        }

        public override void SetDamage(int iAttack)
        {
            iHp -= iAttack;
        }

        public override int attack()
        {
            if(this.bowNum > 0)
            {
                bowNum -= 1;
            }
            return this.bowPower;
        }

        public override void Render()
        {
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("▶ " + strName + " ◀");
            Console.WriteLine("❤️ : " + iHp + "\t💘 : " + bowPower);
            Console.WriteLine($"🏹 : {bowNum} / {maxBowNum}" );
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
                Console.WriteLine($"화살 공격 : {bowPower}");
                Console.WriteLine($"남은 화살 : {bowNum}");
                Console.WriteLine("=================");
                Console.WriteLine("1. 나가기");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1) break;
            }
        }
    }
}
