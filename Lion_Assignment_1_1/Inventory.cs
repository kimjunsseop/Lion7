using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion_Assignment_1_1
{
    public class Inventory
    {
        public int healItem;
        public int money;

        public int getHealItem()
        {
            return healItem;
        }

        public void setHealItem(int heal)
        {
            healItem = heal;
        }
        public void addHealItem(int heal)
        {
            healItem += heal;
        }

        public void ShowInventory()
        {
            Console.WriteLine($"인벤토리 물약 보유량 : {healItem}");
            Console.WriteLine($"보유 골드 : {money}G");
        }

        public void Progress(Player player)
        {
            Console.Clear();
            while (true)
            {
                int iInput;
                Render(player);
                Console.WriteLine("1. 물약 사용 : 2. 나가기 : ");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1)
                {
                    if (player.inventory.healItem > 0)
                    {
                        player.useHealItem();
                        Console.WriteLine($"현재 체력 : {player.iHp}");
                    }
                }
                if(iInput == 2)
                {
                    break;
                }
            }
        }
        public void Render(Player p)
        {
            Console.WriteLine("======================");
            Console.WriteLine($"보유 골드 : {p.inventory.money}");
            Console.WriteLine($"물약 수량 : {p.inventory.healItem}");
            Console.WriteLine("======================");
        }
        public Inventory()
        {
            healItem = 0;
            money = 0;
        }

    }
}
