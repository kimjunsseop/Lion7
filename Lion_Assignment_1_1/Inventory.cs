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
        public Item holdItem;
        public Item[] ItemList = new Item[3];
        public bool isGapot = false;

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
            Console.WriteLine($"💊 : {healItem}");
            Console.WriteLine($"🪙  : {money}G");
        }

        public void Progress(Player player)
        {
            while (true)
            {
                Console.Clear();
                Render(player);
                if(holdItem != null)
                {
                    Console.WriteLine($"[ 현재 장착 중 : {holdItem.Name} ]");
                }
                else
                {
                    Console.WriteLine("[ 현재 장착 아이템 없음]");
                }
                Console.WriteLine("1. 물약 사용 | 2. 나가기");
                Console.WriteLine("=== 아이템 목록 (번호 입력 시 장착) ===");
                for (int i = 0; i < ItemList.Length; i++)
                {
                    if (ItemList[i] != null)
                    {
                        if (ItemList[i].Name == "갑옷")
                        {
                            Console.WriteLine($"{i + 3} : {ItemList[i].Name} 추가 방어력 : {ItemList[i].AddDef}");
                        }
                        Console.WriteLine($"{i + 3} : {ItemList[i].Name}, 추가 데미지 : {ItemList[i].AddAtk}");
                    }
                }
                if (!int.TryParse(Console.ReadLine(), out int iInput)) continue;

                if (iInput == 1)
                {
                    if (healItem > 0)
                    {
                        player.useHealItem();
                        Console.WriteLine($"물약을 사용했습니다! 현재 체력 : {player.iHp}");
                    }
                }
                else if (iInput == 2)
                {
                    break;
                }
                else if (iInput >= 3 && iInput < 3 + ItemList.Length)
                {
                    int index = iInput - 3;
                    if (ItemList[index] != null)
                    {
                        holdItem = ItemList[index];
                        Console.WriteLine($"{holdItem}을(를) 장착했습니다!");
                    }
                }
            }
        }

        public void Render(Player p)
        {
            Console.WriteLine("======================");
            Console.WriteLine($"\U0001fa99 : {p.inventory.money}");
            Console.WriteLine($"💊 : {p.inventory.healItem}");
            Console.WriteLine("======================");
        }
        public void AddItem(Item item) // 매개변수 변경
        {
            for (int i = 0; i < ItemList.Length; i++)
            {
                if (ItemList[i] == null)
                {
                    ItemList[i] = item;
                    return;
                }
            }
        }
        public Inventory()  
        {
            healItem = 0;
            money = 0;
        }

    }
}
